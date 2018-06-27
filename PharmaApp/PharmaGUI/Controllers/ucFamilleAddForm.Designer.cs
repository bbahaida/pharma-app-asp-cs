namespace PharmaGUI.Controllers
{
    partial class ucFamilleAddForm
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
            this.codeLabel = new MetroFramework.Controls.MetroLabel();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.designationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.designationLabel = new MetroFramework.Controls.MetroLabel();
            this.btnAddFamille = new MetroFramework.Controls.MetroButton();
            this.btnCancelFamille = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(267, 127);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(41, 19);
            this.codeLabel.TabIndex = 0;
            this.codeLabel.Text = "Code";
            // 
            // codeTextBox
            // 
            // 
            // 
            // 
            this.codeTextBox.CustomButton.Image = null;
            this.codeTextBox.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.codeTextBox.CustomButton.Name = "";
            this.codeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTextBox.CustomButton.TabIndex = 1;
            this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTextBox.CustomButton.UseSelectable = true;
            this.codeTextBox.CustomButton.Visible = false;
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Lines = new string[0];
            this.codeTextBox.Location = new System.Drawing.Point(401, 122);
            this.codeTextBox.MaxLength = 32767;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.SelectionLength = 0;
            this.codeTextBox.SelectionStart = 0;
            this.codeTextBox.ShortcutsEnabled = true;
            this.codeTextBox.Size = new System.Drawing.Size(173, 23);
            this.codeTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.codeTextBox.TabIndex = 1;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // designationTextBox
            // 
            // 
            // 
            // 
            this.designationTextBox.CustomButton.Image = null;
            this.designationTextBox.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.designationTextBox.CustomButton.Name = "";
            this.designationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.designationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.designationTextBox.CustomButton.TabIndex = 1;
            this.designationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.designationTextBox.CustomButton.UseSelectable = true;
            this.designationTextBox.CustomButton.Visible = false;
            this.designationTextBox.Lines = new string[0];
            this.designationTextBox.Location = new System.Drawing.Point(401, 173);
            this.designationTextBox.MaxLength = 32767;
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.PasswordChar = '\0';
            this.designationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.designationTextBox.SelectedText = "";
            this.designationTextBox.SelectionLength = 0;
            this.designationTextBox.SelectionStart = 0;
            this.designationTextBox.ShortcutsEnabled = true;
            this.designationTextBox.Size = new System.Drawing.Size(173, 23);
            this.designationTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.designationTextBox.TabIndex = 3;
            this.designationTextBox.UseSelectable = true;
            this.designationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.designationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // designationLabel
            // 
            this.designationLabel.AutoSize = true;
            this.designationLabel.Location = new System.Drawing.Point(267, 178);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(77, 19);
            this.designationLabel.TabIndex = 2;
            this.designationLabel.Text = "Designation";
            // 
            // btnAddFamille
            // 
            this.btnAddFamille.BackColor = System.Drawing.Color.Green;
            this.btnAddFamille.Location = new System.Drawing.Point(401, 234);
            this.btnAddFamille.Name = "btnAddFamille";
            this.btnAddFamille.Size = new System.Drawing.Size(72, 35);
            this.btnAddFamille.Style = MetroFramework.MetroColorStyle.White;
            this.btnAddFamille.TabIndex = 4;
            this.btnAddFamille.Text = "Ajouter";
            this.btnAddFamille.UseCustomBackColor = true;
            this.btnAddFamille.UseSelectable = true;
            this.btnAddFamille.UseStyleColors = true;
            this.btnAddFamille.Click += new System.EventHandler(this.btnAddFamille_Click);
            // 
            // btnCancelFamille
            // 
            this.btnCancelFamille.BackColor = System.Drawing.Color.Green;
            this.btnCancelFamille.Location = new System.Drawing.Point(496, 234);
            this.btnCancelFamille.Name = "btnCancelFamille";
            this.btnCancelFamille.Size = new System.Drawing.Size(78, 35);
            this.btnCancelFamille.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancelFamille.TabIndex = 5;
            this.btnCancelFamille.Text = "Annuler";
            this.btnCancelFamille.UseCustomBackColor = true;
            this.btnCancelFamille.UseSelectable = true;
            this.btnCancelFamille.UseStyleColors = true;
            this.btnCancelFamille.Click += new System.EventHandler(this.btnCancelFamille_Click);
            // 
            // ucFamilleAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelFamille);
            this.Controls.Add(this.btnAddFamille);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.designationLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.codeLabel);
            this.Name = "ucFamilleAddForm";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucFamilleAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel codeLabel;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private MetroFramework.Controls.MetroTextBox designationTextBox;
        private MetroFramework.Controls.MetroLabel designationLabel;
        private MetroFramework.Controls.MetroButton btnAddFamille;
        private MetroFramework.Controls.MetroButton btnCancelFamille;
    }
}
