using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerFormMaterial.Dialog
{
    public partial class DialogOKCancel : DialogBase
    {
     
        public DialogOKCancel(string title, string msg)
        {
            InitializeComponent();

            base.SetTitle(title);
            base.SetContent(msg);
        }


        public DialogOKCancel SetRightButtonBackGroundColor(Color color)
        {
            Btn_OK.BackColor = color;
            return this;
        }

        public DialogOKCancel SetRightButtonText(string text)
        {
            Btn_OK.Text = text;
            return this;
        }


        public DialogOKCancel SetLeftButtonBackGroundColor(Color color)
        {
            Btn_Cancel.BackColor = color;
            return this;
        }

        public DialogOKCancel SetLeftButtonText(string text)
        {
            Btn_Cancel.Text = text;
            return this;
        }


        private void Btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        



    }
}
