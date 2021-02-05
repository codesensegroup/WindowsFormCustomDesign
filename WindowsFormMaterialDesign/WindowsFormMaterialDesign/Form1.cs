using CustomerFormMaterial.Dialog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormMaterialDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // ProgressBar Sample
            customProgressBar.FillDegree = 100;
            customProgressBar.Refresh();
        }

        

        private void DialogOK_Click(object sender, EventArgs e)
        {
            var dialog = new DialogOK("Title", "XXXAAA Content");

            //Self Definition
            dialog.SetBackGroundColor(Color.AliceBlue)
                  .SetSelectImageIcon(2);
            dialog.SetButtonBackGroundColor(Color.Orange)
                 .SetButtonText("Modify");

            //Default Style Demo
            //dialog.SetWarningStyle();

            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void ShowLockMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show Dialog");
        }

        private void DialogOKCancel_Click(object sender, EventArgs e)
        {

            var dialog = new DialogOKCancel("Message", "TitleXXX");


            // Self Definition
            //dialog.SetBackGroundColor(Color.AliceBlue)
            //      .SetSelectImageIcon(2);

            //dialog.SetLeftButtonBackGroundColor(Color.Red)
            //     .SetLeftButtonText("Self DefA");

            //dialog.SetRightButtonBackGroundColor(Color.Red)
            //   .SetRightButtonText("Self DefA");

            //Default Style
            dialog.SetInfoStyle();


            dialog.ShowDialog();
            dialog.Dispose();


            if (dialog.DialogResult == DialogResult.OK)
            {

                MessageBox.Show("Enter");
                return;
            }

            MessageBox.Show("Cancel");

         
        }

        private void DialogSelectOK_Click(object sender, EventArgs e)
        {
            var dialog = new DialogSelectOK("XXXX Message", "XX Title");


            // Self Definition Style
            //dialog.SetBackGroundColor(Color.AliceBlue)
            //      .SetSelectImageIcon(2);

            //dialog.SetLeftButtonBackGroundColor(Color.Red)
            //     .SetLeftButtonText("Modify A");

            //dialog.SetMiddleButtonBackGroundColor(Color.Red)
            //    .SetMiddleButtonText("Modify B");

            //dialog.SetRightButtonBackGroundColor(Color.Red)
            //       .SetRightButtonText("Modify C");

            //Default Style
            dialog.SetInfoStyle();

            dialog.ShowDialog();
            dialog.Dispose();

            if (dialog.DialogResult == DialogResult.Yes)
            {

                MessageBox.Show("Yes");
                return;
            }

            if (dialog.DialogResult == DialogResult.No)
            {

                MessageBox.Show("No");
                return;
            }

            MessageBox.Show("Cancel");

         

        }
    }
}
