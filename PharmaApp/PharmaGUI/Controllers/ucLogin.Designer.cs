namespace PharmaGUI.Controllers
{
    partial class ucLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.unLabel = new MetroFramework.Controls.MetroLabel();
            this.unTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pwTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pwLabel = new MetroFramework.Controls.MetroLabel();
            this.btnConnection = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.Location = new System.Drawing.Point(255, 154);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(66, 19);
            this.unLabel.TabIndex = 0;
            this.unLabel.Text = "Utilisateur";
            // 
            // unTextBox
            // 
            // 
            // 
            // 
            this.unTextBox.CustomButton.Image = null;
            this.unTextBox.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.unTextBox.CustomButton.Name = "";
            this.unTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.unTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.unTextBox.CustomButton.TabIndex = 1;
            this.unTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.unTextBox.CustomButton.UseSelectable = true;
            this.unTextBox.CustomButton.Visible = false;
            this.unTextBox.Lines = new string[0];
            this.unTextBox.Location = new System.Drawing.Point(419, 150);
            this.unTextBox.MaxLength = 32767;
            this.unTextBox.Name = "unTextBox";
            this.unTextBox.PasswordChar = '\0';
            this.unTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.unTextBox.SelectedText = "";
            this.unTextBox.SelectionLength = 0;
            this.unTextBox.SelectionStart = 0;
            this.unTextBox.ShortcutsEnabled = true;
            this.unTextBox.Size = new System.Drawing.Size(148, 23);
            this.unTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.unTextBox.TabIndex = 1;
            this.unTextBox.UseSelectable = true;
            this.unTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.unTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pwTextBox
            // 
            // 
            // 
            // 
            this.pwTextBox.CustomButton.Image = null;
            this.pwTextBox.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.pwTextBox.CustomButton.Name = "";
            this.pwTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pwTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pwTextBox.CustomButton.TabIndex = 1;
            this.pwTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pwTextBox.CustomButton.UseSelectable = true;
            this.pwTextBox.CustomButton.Visible = false;
            this.pwTextBox.Lines = new string[0];
            this.pwTextBox.Location = new System.Drawing.Point(419, 194);
            this.pwTextBox.MaxLength = 32767;
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.PasswordChar = '●';
            this.pwTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwTextBox.SelectedText = "";
            this.pwTextBox.SelectionLength = 0;
            this.pwTextBox.SelectionStart = 0;
            this.pwTextBox.ShortcutsEnabled = true;
            this.pwTextBox.Size = new System.Drawing.Size(148, 23);
            this.pwTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.pwTextBox.TabIndex = 4;
            this.pwTextBox.UseSelectable = true;
            this.pwTextBox.UseSystemPasswordChar = true;
            this.pwTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pwTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(255, 198);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(88, 19);
            this.pwLabel.TabIndex = 3;
            this.pwLabel.Text = "Mot de passe";
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.Color.Green;
            this.btnConnection.Location = new System.Drawing.Point(487, 255);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(80, 34);
            this.btnConnection.Style = MetroFramework.MetroColorStyle.White;
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "Connecter";
            this.btnConnection.UseCustomBackColor = true;
            this.btnConnection.UseSelectable = true;
            this.btnConnection.UseStyleColors = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.unTextBox);
            this.Controls.Add(this.unLabel);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(851, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel unLabel;
        private MetroFramework.Controls.MetroTextBox unTextBox;
        private MetroFramework.Controls.MetroTextBox pwTextBox;
        private MetroFramework.Controls.MetroLabel pwLabel;
        private MetroFramework.Controls.MetroButton btnConnection;
    }
}
