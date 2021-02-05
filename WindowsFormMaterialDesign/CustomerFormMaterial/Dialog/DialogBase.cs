using CustomerFormMaterial.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace CustomerFormMaterial.Dialog
{
    public partial class DialogBase : Form
    {
        public DialogBase()
        {
            InitializeComponent();
        }

        public DialogBase SetSelectImageIcon(int type)
        {
            Image infoTypeImage;

            switch (type)
            {
                case 1:
                    infoTypeImage = Resources.dialogQuestion;
                    break;
                case 2:
                    infoTypeImage = Resources.dialogWarning;
                    break;
                case 3:
                    infoTypeImage = Resources.dialogCancel;
                    break;
                case 4:
                    infoTypeImage = Resources.dialogCheck;
                    break;

                default:
                    infoTypeImage = Resources.dialogInformation;
                    break;
            }

            Pic_Type.BackgroundImage = infoTypeImage;

            return this;
        }
        public DialogBase SetBackGroundColor(Color color)
        {
            this.BackColor = color;
            return this;
        }
        public DialogBase SetBroderColor(Color color)
        {
            this.Pnl_Broder_Top.BackColor = color;
            this.Pnl_Broder_Left.BackColor = color;
            this.Pnl_Broder_Right.BackColor = color;
            this.Pnl_Broder_Bottom.BackColor = color;

            this.Pnl_Border_One.BackColor = color;
            this.Pnl_Border_Two.BackColor = color;

            return this;

        }

        public DialogBase SetTitle(string title)
        {
            Lbl_Tile.Text = title;
            return this;
        }
        public DialogBase SetContent(string title)
        {
            Lbl_ShowMessage.Text = title;
            return this;
        }
       
        public void SetInfoStyle()
        {
            Pic_Type.BackgroundImage = Resources.dialogInformation;
            SetBackGroundColor(Color.LightCyan);
            SetBroderColor(Color.CornflowerBlue);
            
        }
        public void SetQuestionStyle()
        {
            Pic_Type.BackgroundImage = Resources.dialogQuestion;
            SetBackGroundColor(Color.LemonChiffon);
            SetBroderColor(Color.Gold);

           
        }
        public void SetWarningStyle()
        {
            Pic_Type.BackgroundImage = Resources.dialogWarning;
            SetBackGroundColor(Color.MistyRose);
            SetBroderColor(Color.Tomato);

           
        }
        public void SetCheckStyle()
        {

            Pic_Type.BackgroundImage = Resources.dialogCheck;
            SetBackGroundColor(Color.LightCyan);
            SetBroderColor(Color.CornflowerBlue);      
        }

    }
}
