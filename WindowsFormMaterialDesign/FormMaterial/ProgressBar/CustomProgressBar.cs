using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static FormMaterial.GraphicsUtil;

namespace FormMaterial.ProhressBar
{
    /// <summary>
    /// 橫條變色Process Bar
    /// </summary>
    public class CustomProgressBar : Panel
    {

        private Color _statusColor1;
        private Color _statusColor2;
        private int _statusBarColorIndex;

        private Color _firstColor;
        private Color _secondColor;
        private int _fillDegree = 50;

        //Check radius for begin drag n drop
        public bool AllowDrag { get; set; }
        private bool _isDragging = false;
        private int _DDradius = 40;
        private int _mX = 0;
        private int _mY = 0;

        //各屬性初始設定!
        public CustomProgressBar()
        {
            Font = new Font("Arial", 10);
            FillDegree = 50;
            RoundedCornerAngle = 10;
            Margin = new Padding(0);
            LeftText = "LT";
            StatusText = "Not set";
            MainText = "MainText";
            RightText = "RT";
            LeftBarSize = 30;
            StatusBarSize = 60;
            RightBarSize = 30;
            StatusBarColor = 99;
            AllowDrag = true;
        }

        public int RoundedCornerAngle { get; set; }
        public int LeftBarSize { get; set; }
        public int RightBarSize { get; set; }
        public int StatusBarSize { get; set; }

        public string MainText { get; set; }
        public string LeftText { get; set; }
        public string RightText { get; set; }
        public string StatusText { get; set; }


        /// <summary>
        /// ColorIndex. 
        /// [0 - Raw active] 
        /// [1 - Raw inactive] 
        /// [2 - Dry active] 
        /// [3 - Dry inactive].
        /// </summary>
        public int StatusBarColor
        {
            get { return _statusBarColorIndex; }

            set
            {
                switch (value)
                {
                    case 0:
                        // Raw active
                        _statusColor1 = Color.OliveDrab;
                        _statusColor2 = Color.DarkOliveGreen;
                        _statusBarColorIndex = 0;
                        break;
                    case 1:
                        // Raw inactive
                        _statusColor1 = Color.OliveDrab;
                        _statusColor2 = Color.Gray;
                        _statusBarColorIndex = 1;
                        break;
                    case 2:
                        // Dry active
                        _statusColor1 = Color.Goldenrod;
                        _statusColor2 = Color.DarkGoldenrod;
                        _statusBarColorIndex = 2;
                        break;
                    case 3:
                        // Dry inactive
                        _statusColor1 = Color.Goldenrod;
                        _statusColor2 = Color.Gray;
                        _statusBarColorIndex = 3;
                        break;
                    default:
                        _statusColor1 = Color.DimGray;
                        _statusColor2 = Color.DimGray;
                        _statusBarColorIndex = 99;
                        break;
                }
            }
        }

        //先告物件時，須設定屬性，代表百分比顯示的顏色區塊，例如:myProgressBarEntry.FillDegree = 0;
        public int FillDegree
        {
            get { return _fillDegree; }
            set
            {
                if (value > 89)
                {
                    _firstColor = Color.Red;
                    _secondColor = Color.DarkRed;
                }
                else if (value > 69)
                {
                    _firstColor = Color.Orange;
                    _secondColor = Color.DarkOrange;
                }
                else if (value > 49)
                {
                    _firstColor = Color.Gold;
                    _secondColor = Color.DarkGoldenrod;
                }
                else
                {
                    _firstColor = Color.Green;
                    _secondColor = Color.DarkGreen;
                }
                _fillDegree = value;
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = Color.SandyBrown;
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.Transparent;
            base.OnLostFocus(e);
        }

        protected override void OnClick(EventArgs e)
        {
            this.Focus();
            base.OnClick(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.Focus();
            base.OnMouseDown(e);
            _mX = e.X;
            _mY = e.Y;
            this._isDragging = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!_isDragging)
            {
                // This is a check to see if the mouse is moving while pressed.
                // Without this, the DragDrop is fired directly when the control is clicked, now you have to drag a few pixels first.
                if (e.Button == MouseButtons.Left && _DDradius > 0 && this.AllowDrag)
                {
                    int num1 = _mX - e.X;
                    int num2 = _mY - e.Y;
                    if (((num1 * num1) + (num2 * num2)) > _DDradius)
                    {
                        DoDragDrop(this, DragDropEffects.All);
                        _isDragging = true;
                        return;
                    }
                }
                base.OnMouseMove(e);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _isDragging = false;
            base.OnMouseUp(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            paintThis(e.Graphics);
        }

        public void paintThis(Graphics _graphics)
        {
            // Textformat
            StringFormat f = new StringFormat();
            f.Alignment = StringAlignment.Center;
            f.LineAlignment = StringAlignment.Center;

            // Misc
            _graphics = this.CreateGraphics();
            LinearGradientBrush _LeftAndRightBrush = new LinearGradientBrush(GetMainArea(), Color.DimGray, Color.Black, LinearGradientMode.Vertical);
            LinearGradientBrush _StatusBrush = new LinearGradientBrush(GetMainArea(), _statusColor1, _statusColor2, LinearGradientMode.Vertical);
            LinearGradientBrush _MainBrush = new LinearGradientBrush(GetMainArea(), _firstColor, _secondColor, LinearGradientMode.Vertical);

            // Draw left
            if (LeftBarSize > 0)
            {
                _graphics.FillRoundedRectangle(_LeftAndRightBrush, this.GetLeftArea(), this.RoundedCornerAngle, RectangleEdgeFilter.TopLeft | RectangleEdgeFilter.BottomLeft);
                _graphics.DrawString(this.LeftText, this.Font, Brushes.White, this.GetLeftArea(), f);
            }

            // Draw status
            if (StatusBarSize > 0)
            {
                _graphics.FillRoundedRectangle(_StatusBrush, this.GetStatusArea(), this.RoundedCornerAngle, RectangleEdgeFilter.None);
                _graphics.DrawString(this.StatusText, this.Font, Brushes.White, this.GetStatusArea(), f);
            }

            // Draw main background
            _graphics.FillRoundedRectangle(Brushes.DimGray, GetMainAreaBackground(), this.RoundedCornerAngle, RectangleEdgeFilter.None);

            // Draw main
            _graphics.FillRoundedRectangle(_MainBrush, this.GetMainArea(), this.RoundedCornerAngle, RectangleEdgeFilter.None);
            _graphics.DrawString(this.MainText, this.Font, Brushes.White, this.GetMainAreaBackground(), f);

            // Draw right
            if (RightBarSize > 0)
            {
                _graphics.FillRoundedRectangle(_LeftAndRightBrush, this.GetRightArea(), this.RoundedCornerAngle, RectangleEdgeFilter.TopRight | RectangleEdgeFilter.BottomRight);
                _graphics.DrawString(this.RightText, this.Font, Brushes.White, this.GetRightArea(), f);
            }

            // Clean up
            _LeftAndRightBrush.Dispose();
            _MainBrush.Dispose();
            _StatusBrush.Dispose();
        }

        private Rectangle GetLeftArea()
        {
            return new Rectangle(
                Padding.Left,
                Padding.Top,
                LeftBarSize,
                this.ClientRectangle.Height - Padding.Bottom - Padding.Top);
        }

        private Rectangle GetStatusArea()
        {
            return new Rectangle(
                Padding.Left + LeftBarSize,
                Padding.Top,
                StatusBarSize,
                this.ClientRectangle.Height - Padding.Bottom - Padding.Top);
        }

        private Rectangle GetMainArea()
        {
            try
            {
                Double width = (FillDegree == 0) ? 0.001 : FillDegree;
                var widthLenth = Convert.ToInt32(((this.ClientRectangle.Width - (Padding.Left + LeftBarSize + StatusBarSize + RightBarSize + Padding.Right)) * width) / 100);
                if (widthLenth == 0)
                {
                    widthLenth = 1;
                }
                return new Rectangle(
                    Padding.Left + LeftBarSize + StatusBarSize,
                    Padding.Top, widthLenth
                   ,
                    this.ClientRectangle.Height - Padding.Bottom - Padding.Top);
            }
            catch (Exception ex)
            {

                return new Rectangle(0, 0, 10, 10);
            }

        }

        private Rectangle GetMainAreaBackground()
        {
            return new Rectangle(
                   Padding.Left + LeftBarSize + StatusBarSize,
                   Padding.Top,
                   this.ClientRectangle.Width - (Padding.Left + LeftBarSize + StatusBarSize + RightBarSize + Padding.Right),
                   this.ClientRectangle.Height - Padding.Bottom - Padding.Top);
        }

        private Rectangle GetRightArea()
        {
            return new Rectangle(
                this.ClientRectangle.Width - (RightBarSize + Padding.Right),
                Padding.Top,
                RightBarSize,
                this.ClientRectangle.Height - Padding.Bottom - Padding.Top);
        }
    }
}
