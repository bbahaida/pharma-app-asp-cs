namespace PharmaGUI.Controllers
{
    partial class ucMedicamentEditForm
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
            this.btnCancelMedicament = new MetroFramework.Controls.MetroButton();
            this.btnEditMedicament = new MetroFramework.Controls.MetroButton();
            this.stockComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.quantityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.familleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.prixTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.libelle = new MetroFramework.Controls.MetroLabel();
            this.libelleTextBox = new MetroFramework.Controls.MetroTextBox();
            this.codeLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnCancelMedicament
            // 
            this.btnCancelMedicament.BackColor = System.Drawing.Color.Green;
            this.btnCancelMedicament.Location = new System.Drawing.Point(651, 296);
            this.btnCancelMedicament.Name = "btnCancelMedicament";
            this.btnCancelMedicament.Size = new System.Drawing.Size(78, 35);
            this.btnCancelMedicament.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancelMedicament.TabIndex = 62;
            this.btnCancelMedicament.Text = "Annuler";
            this.btnCancelMedicament.UseCustomBackColor = true;
            this.btnCancelMedicament.UseSelectable = true;
            this.btnCancelMedicament.UseStyleColors = true;
            this.btnCancelMedicament.Click += new System.EventHandler(this.btnCancelMedicament_Click);
            // 
            // btnEditMedicament
            // 
            this.btnEditMedicament.BackColor = System.Drawing.Color.Green;
            this.btnEditMedicament.Location = new System.Drawing.Point(555, 296);
            this.btnEditMedicament.Name = "btnEditMedicament";
            this.btnEditMedicament.Size = new System.Drawing.Size(72, 35);
            this.btnEditMedicament.Style = MetroFramework.MetroColorStyle.White;
            this.btnEditMedicament.TabIndex = 61;
            this.btnEditMedicament.Text = "Modifier";
            this.btnEditMedicament.UseCustomBackColor = true;
            this.btnEditMedicament.UseSelectable = true;
            this.btnEditMedicament.UseStyleColors = true;
            this.btnEditMedicament.Click += new System.EventHandler(this.btnEditMedicament_Click);
            // 
            // stockComboBox
            // 
            this.stockComboBox.FormattingEnabled = true;
            this.stockComboBox.ItemHeight = 23;
            this.stockComboBox.Location = new System.Drawing.Point(555, 243);
            this.stockComboBox.Name = "stockComboBox";
            this.stockComboBox.Size = new System.Drawing.Size(174, 29);
            this.stockComboBox.TabIndex = 60;
            this.stockComboBox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(453, 248);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.TabIndex = 59;
            this.metroLabel3.Text = "Stock";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(122, 243);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 58;
            this.metroLabel4.Text = "Quantite";
            // 
            // quantityTextBox
            // 
            // 
            // 
            // 
            this.quantityTextBox.CustomButton.Image = null;
            this.quantityTextBox.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.quantityTextBox.CustomButton.Name = "";
            this.quantityTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.quantityTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantityTextBox.CustomButton.TabIndex = 1;
            this.quantityTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantityTextBox.CustomButton.UseSelectable = true;
            this.quantityTextBox.CustomButton.Visible = false;
            this.quantityTextBox.Lines = new string[0];
            this.quantityTextBox.Location = new System.Drawing.Point(221, 239);
            this.quantityTextBox.MaxLength = 32767;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantityTextBox.SelectedText = "";
            this.quantityTextBox.SelectionLength = 0;
            this.quantityTextBox.SelectionStart = 0;
            this.quantityTextBox.ShortcutsEnabled = true;
            this.quantityTextBox.Size = new System.Drawing.Size(173, 23);
            this.quantityTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.quantityTextBox.TabIndex = 57;
            this.quantityTextBox.UseSelectable = true;
            this.quantityTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantityTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // familleComboBox
            // 
            this.familleComboBox.FormattingEnabled = true;
            this.familleComboBox.ItemHeight = 23;
            this.familleComboBox.Location = new System.Drawing.Point(555, 181);
            this.familleComboBox.Name = "familleComboBox";
            this.familleComboBox.Size = new System.Drawing.Size(174, 29);
            this.familleComboBox.TabIndex = 56;
            this.familleComboBox.UseSelectable = true;
            // 
            // prixTextBox
            // 
            // 
            // 
            // 
            this.prixTextBox.CustomButton.Image = null;
            this.prixTextBox.CustomButton.Location = new System.Drawing.Point(152, 1);
            this.prixTextBox.CustomButton.Name = "";
            this.prixTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prixTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prixTextBox.CustomButton.TabIndex = 1;
            this.prixTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prixTextBox.CustomButton.UseSelectable = true;
            this.prixTextBox.CustomButton.Visible = false;
            this.prixTextBox.Lines = new string[0];
            this.prixTextBox.Location = new System.Drawing.Point(555, 124);
            this.prixTextBox.MaxLength = 32767;
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.PasswordChar = '\0';
            this.prixTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prixTextBox.SelectedText = "";
            this.prixTextBox.SelectionLength = 0;
            this.prixTextBox.SelectionStart = 0;
            this.prixTextBox.ShortcutsEnabled = true;
            this.prixTextBox.Size = new System.Drawing.Size(174, 23);
            this.prixTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.prixTextBox.TabIndex = 55;
            this.prixTextBox.UseSelectable = true;
            this.prixTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prixTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(453, 186);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Famille";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(453, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 53;
            this.metroLabel2.Text = "Prix";
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
            this.codeTextBox.Lines = new string[0];
            this.codeTextBox.Location = new System.Drawing.Point(221, 124);
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
            this.codeTextBox.TabIndex = 52;
            this.codeTextBox.UseSelectable = true;
            this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // libelle
            // 
            this.libelle.AutoSize = true;
            this.libelle.Location = new System.Drawing.Point(122, 181);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(46, 19);
            this.libelle.TabIndex = 51;
            this.libelle.Text = "Libelle";
            // 
            // libelleTextBox
            // 
            // 
            // 
            // 
            this.libelleTextBox.CustomButton.Image = null;
            this.libelleTextBox.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.libelleTextBox.CustomButton.Name = "";
            this.libelleTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.libelleTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.libelleTextBox.CustomButton.TabIndex = 1;
            this.libelleTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.libelleTextBox.CustomButton.UseSelectable = true;
            this.libelleTextBox.CustomButton.Visible = false;
            this.libelleTextBox.Lines = new string[0];
            this.libelleTextBox.Location = new System.Drawing.Point(221, 177);
            this.libelleTextBox.MaxLength = 32767;
            this.libelleTextBox.Name = "libelleTextBox";
            this.libelleTextBox.PasswordChar = '\0';
            this.libelleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.libelleTextBox.SelectedText = "";
            this.libelleTextBox.SelectionLength = 0;
            this.libelleTextBox.SelectionStart = 0;
            this.libelleTextBox.ShortcutsEnabled = true;
            this.libelleTextBox.Size = new System.Drawing.Size(173, 23);
            this.libelleTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.libelleTextBox.TabIndex = 50;
            this.libelleTextBox.UseSelectable = true;
            this.libelleTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.libelleTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(127, 128);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(41, 19);
            this.codeLabel.TabIndex = 49;
            this.codeLabel.Text = "Code";
            // 
            // ucMedicamentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelMedicament);
            this.Controls.Add(this.btnEditMedicament);
            this.Controls.Add(this.stockComboBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.familleComboBox);
            this.Controls.Add(this.prixTextBox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.libelleTextBox);
            this.Controls.Add(this.codeLabel);
            this.Name = "ucMedicamentEditForm";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucMedicamentEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancelMedicament;
        private MetroFramework.Controls.MetroButton btnEditMedicament;
        private MetroFramework.Controls.MetroComboBox stockComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox quantityTextBox;
        private MetroFramework.Controls.MetroComboBox familleComboBox;
        private MetroFramework.Controls.MetroTextBox prixTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox codeTextBox;
        private MetroFramework.Controls.MetroLabel libelle;
        private MetroFramework.Controls.MetroTextBox libelleTextBox;
        private MetroFramework.Controls.MetroLabel codeLabel;
    }
}
