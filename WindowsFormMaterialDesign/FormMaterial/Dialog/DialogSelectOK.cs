using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormMaterial.Dialog
{
    public partial class DialogSelectOK : DialogBase
    {
      
        public DialogSelectOK(string title, string msg)
        {
            InitializeComponent();
            base.SetTitle(title);
            base.SetContent(msg);

        }



        public DialogSelectOK SetRightButtonBackGroundColor(Color color)
        {
            Btn_Cancel.BackColor = color;
            return this;
        }

        public DialogSelectOK SetRightButtonText(string text)
        {
            Btn_Cancel.Text = text;
            return this;
        }


        public DialogSelectOK SetLeftButtonBackGroundColor(Color color)
        {
            Btn_Yes.BackColor = color;
            return this;
        }

        public DialogSelectOK SetLeftButtonText(string text)
        {
            Btn_Yes.Text = text;
            return this;
        }

        public DialogSelectOK SetMiddleButtonBackGroundColor(Color color)
        {
            Btn_No.BackColor = color;
            return this;
        }

        public DialogSelectOK SetMiddleButtonText(string text)
        {
            Btn_No.Text = text;
            return this;
        }


        private void Btn_Yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_No_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
       
    }
}
