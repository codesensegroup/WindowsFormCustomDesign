using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerFormMaterial.Dialog
{


    public partial class DialogOK : DialogBase
    {
    
        public DialogOK(string title, string msg)
        {
            InitializeComponent();
            base.SetTitle(title);
            base.SetContent(msg);
        }
        public DialogOK SetButtonBackGroundColor(Color color)
        {
            Btn_OK.BackColor = color;
            return this;
        }

        public DialogBase SetButtonText(string text)
        {
            Btn_OK.Text = text;
            return this;
        }
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
     
       
    }
}
