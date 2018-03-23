namespace SeviyeBazliSayiTahmin
{
    partial class Form1
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
            this.lblRobot = new MetroFramework.Controls.MetroLabel();
            this.txtInput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnOnayla = new MetroFramework.Controls.MetroButton();
            this.lblCan = new MetroFramework.Controls.MetroLabel();
            this.lblSeviye = new MetroFramework.Controls.MetroLabel();
            this.btnYeniOyun = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRobot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRobot.Location = new System.Drawing.Point(62, 93);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(75, 25);
            this.lblRobot.TabIndex = 41;
            this.lblRobot.Text = "ROBOT";
            this.lblRobot.UseCustomBackColor = true;
            this.lblRobot.UseCustomForeColor = true;
            // 
            // txtInput
            // 
            // 
            // 
            // 
            this.txtInput.CustomButton.Image = null;
            this.txtInput.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txtInput.CustomButton.Name = "";
            this.txtInput.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInput.CustomButton.TabIndex = 1;
            this.txtInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInput.CustomButton.UseSelectable = true;
            this.txtInput.CustomButton.Visible = false;
            this.txtInput.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtInput.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtInput.Lines = new string[0];
            this.txtInput.Location = new System.Drawing.Point(175, 143);
            this.txtInput.MaxLength = 32767;
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInput.SelectedText = "";
            this.txtInput.SelectionLength = 0;
            this.txtInput.SelectionStart = 0;
            this.txtInput.ShortcutsEnabled = true;
            this.txtInput.ShowClearButton = true;
            this.txtInput.Size = new System.Drawing.Size(164, 30);
            this.txtInput.TabIndex = 42;
            this.txtInput.UseCustomBackColor = true;
            this.txtInput.UseCustomForeColor = true;
            this.txtInput.UseSelectable = true;
            this.txtInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(26, 144);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 43;
            this.metroLabel1.Text = "Tahmininiz:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOnayla.Location = new System.Drawing.Point(344, 211);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(244, 40);
            this.btnOnayla.TabIndex = 44;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseSelectable = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // lblCan
            // 
            this.lblCan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCan.AutoSize = true;
            this.lblCan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCan.Location = new System.Drawing.Point(528, 143);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(98, 25);
            this.lblCan.TabIndex = 45;
            this.lblCan.Text = "Kalan Can: ";
            this.lblCan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCan.UseCustomBackColor = true;
            this.lblCan.UseCustomForeColor = true;
            // 
            // lblSeviye
            // 
            this.lblSeviye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeviye.AutoSize = true;
            this.lblSeviye.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSeviye.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSeviye.Location = new System.Drawing.Point(555, 93);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(71, 25);
            this.lblSeviye.TabIndex = 46;
            this.lblSeviye.Text = "Seviye: ";
            this.lblSeviye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSeviye.UseCustomBackColor = true;
            this.lblSeviye.UseCustomForeColor = true;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnYeniOyun.Location = new System.Drawing.Point(39, 211);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(244, 40);
            this.btnYeniOyun.TabIndex = 47;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseSelectable = true;
            this.btnYeniOyun.Visible = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 274);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblRobot);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Seviye Bazlı Sayı Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblRobot;
        private MetroFramework.Controls.MetroTextBox txtInput;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnOnayla;
        private MetroFramework.Controls.MetroLabel lblCan;
        private MetroFramework.Controls.MetroLabel lblSeviye;
        private MetroFramework.Controls.MetroButton btnYeniOyun;
    }
}

