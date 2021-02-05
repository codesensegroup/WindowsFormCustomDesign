﻿namespace FormMaterial.Dialog
{
    partial class DialogOKCancel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Type)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ShowMessage
            // 
            this.Lbl_ShowMessage.Visible = true;
            // 
            // Pnl_Broder_Top
            // 
            this.Pnl_Broder_Top.BackColor = System.Drawing.Color.Gold;
            // 
            // Pnl_Broder_Left
            // 
            this.Pnl_Broder_Left.BackColor = System.Drawing.Color.Gold;
            // 
            // Pnl_Broder_Right
            // 
            this.Pnl_Broder_Right.BackColor = System.Drawing.Color.Gold;
            // 
            // Pnl_Broder_Bottom
            // 
            this.Pnl_Broder_Bottom.BackColor = System.Drawing.Color.Gold;
            // 
            // Pnl_Border_Two
            // 
            this.Pnl_Border_Two.BackColor = System.Drawing.Color.Gold;
            // 
            // Pnl_Border_One
            // 
            this.Pnl_Border_One.BackColor = System.Drawing.Color.Gold;
            // 
            // Btn_OK
            // 
            this.Btn_OK.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_OK.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_OK.Location = new System.Drawing.Point(93, 248);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(100, 40);
            this.Btn_OK.TabIndex = 5;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = false;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.LightPink;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Cancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Cancel.Location = new System.Drawing.Point(257, 248);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(100, 40);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Frm_DialogOKCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Name = "Frm_DialogOKCancel";
            this.Text = "Frm_DialogOKCancel";
            this.Controls.SetChildIndex(this.Pnl_Broder_Top, 0);
            this.Controls.SetChildIndex(this.Pnl_Broder_Right, 0);
            this.Controls.SetChildIndex(this.Pnl_Broder_Bottom, 0);
            this.Controls.SetChildIndex(this.Pnl_Broder_Left, 0);
            this.Controls.SetChildIndex(this.Pnl_Border_One, 0);
            this.Controls.SetChildIndex(this.Pnl_Border_Two, 0);
            this.Controls.SetChildIndex(this.Lbl_Tile, 0);
            this.Controls.SetChildIndex(this.Pic_Type, 0);
            this.Controls.SetChildIndex(this.Lbl_ShowMessage, 0);
            this.Controls.SetChildIndex(this.Btn_OK, 0);
            this.Controls.SetChildIndex(this.Btn_Cancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Type)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}