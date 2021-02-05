namespace WindowsFormMaterialDesign
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DialogOK = new System.Windows.Forms.Button();
            this.DialogOKCancel = new System.Windows.Forms.Button();
            this.DialogSelectOK = new System.Windows.Forms.Button();
            this.customProgressBar = new FormMaterial.ProhressBar.CustomProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogOK
            // 
            this.DialogOK.Location = new System.Drawing.Point(39, 26);
            this.DialogOK.Margin = new System.Windows.Forms.Padding(4);
            this.DialogOK.Name = "DialogOK";
            this.DialogOK.Size = new System.Drawing.Size(202, 34);
            this.DialogOK.TabIndex = 0;
            this.DialogOK.Text = "DialogOK";
            this.DialogOK.UseVisualStyleBackColor = true;
            this.DialogOK.Click += new System.EventHandler(this.DialogOK_Click);
            // 
            // DialogOKCancel
            // 
            this.DialogOKCancel.Location = new System.Drawing.Point(39, 90);
            this.DialogOKCancel.Margin = new System.Windows.Forms.Padding(4);
            this.DialogOKCancel.Name = "DialogOKCancel";
            this.DialogOKCancel.Size = new System.Drawing.Size(202, 34);
            this.DialogOKCancel.TabIndex = 2;
            this.DialogOKCancel.Text = "DialogOKCancel";
            this.DialogOKCancel.UseVisualStyleBackColor = true;
            this.DialogOKCancel.Click += new System.EventHandler(this.DialogOKCancel_Click);
            // 
            // DialogSelectOK
            // 
            this.DialogSelectOK.Location = new System.Drawing.Point(39, 162);
            this.DialogSelectOK.Margin = new System.Windows.Forms.Padding(4);
            this.DialogSelectOK.Name = "DialogSelectOK";
            this.DialogSelectOK.Size = new System.Drawing.Size(202, 34);
            this.DialogSelectOK.TabIndex = 3;
            this.DialogSelectOK.Text = "DialogSelectOK";
            this.DialogSelectOK.UseVisualStyleBackColor = true;
            this.DialogSelectOK.Click += new System.EventHandler(this.DialogSelectOK_Click);
            // 
            // customProgressBar
            // 
            this.customProgressBar.AllowDrag = true;
            this.customProgressBar.FillDegree = 50;
            this.customProgressBar.Font = new System.Drawing.Font("Arial", 10F);
            this.customProgressBar.LeftBarSize = 30;
            this.customProgressBar.LeftText = "0";
            this.customProgressBar.Location = new System.Drawing.Point(35, 37);
            this.customProgressBar.MainText = "Energe";
            this.customProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.customProgressBar.Name = "customProgressBar";
            this.customProgressBar.RightBarSize = 30;
            this.customProgressBar.RightText = "125";
            this.customProgressBar.RoundedCornerAngle = 10;
            this.customProgressBar.Size = new System.Drawing.Size(300, 36);
            this.customProgressBar.StatusBarColor = 99;
            this.customProgressBar.StatusBarSize = 0;
            this.customProgressBar.StatusText = "Not set";
            this.customProgressBar.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1478, 627);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DialogOK);
            this.tabPage1.Controls.Add(this.DialogOKCancel);
            this.tabPage1.Controls.Add(this.DialogSelectOK);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1470, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dialog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customProgressBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1470, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ProgressBar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 709);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DialogOK;
        private System.Windows.Forms.Button DialogOKCancel;
        private System.Windows.Forms.Button DialogSelectOK;
        private FormMaterial.ProhressBar.CustomProgressBar customProgressBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

