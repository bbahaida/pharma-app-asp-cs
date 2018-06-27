namespace PharmaGUI.Controllers
{
    partial class ucVenteAddForm
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
            this.medicamentComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.quantityTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PrixTextBox = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelVente = new MetroFramework.Controls.MetroButton();
            this.btnAddVente = new MetroFramework.Controls.MetroButton();
            this.quantityCounterLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.stockComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // medicamentComboBox
            // 
            this.medicamentComboBox.FormattingEnabled = true;
            this.medicamentComboBox.ItemHeight = 23;
            this.medicamentComboBox.Location = new System.Drawing.Point(346, 123);
            this.medicamentComboBox.Name = "medicamentComboBox";
            this.medicamentComboBox.Size = new System.Drawing.Size(212, 29);
            this.medicamentComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.medicamentComboBox.TabIndex = 0;
            this.medicamentComboBox.UseSelectable = true;
            this.medicamentComboBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(230, 133);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Medicament";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(230, 230);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Quantite";
            // 
            // quantityTrackBar
            // 
            this.quantityTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.quantityTrackBar.ForeColor = System.Drawing.Color.Green;
            this.quantityTrackBar.Location = new System.Drawing.Point(346, 230);
            this.quantityTrackBar.Minimum = 1;
            this.quantityTrackBar.MouseWheelBarPartitions = 5;
            this.quantityTrackBar.Name = "quantityTrackBar";
            this.quantityTrackBar.Size = new System.Drawing.Size(173, 23);
            this.quantityTrackBar.Style = MetroFramework.MetroColorStyle.Green;
            this.quantityTrackBar.TabIndex = 6;
            this.quantityTrackBar.Value = 12;
            this.quantityTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.quantityTrackBar_Scroll);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(230, 281);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Montant";
            // 
            // PrixTextBox
            // 
            // 
            // 
            // 
            this.PrixTextBox.CustomButton.Image = null;
            this.PrixTextBox.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.PrixTextBox.CustomButton.Name = "";
            this.PrixTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PrixTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PrixTextBox.CustomButton.TabIndex = 1;
            this.PrixTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PrixTextBox.CustomButton.UseSelectable = true;
            this.PrixTextBox.CustomButton.Visible = false;
            this.PrixTextBox.Lines = new string[0];
            this.PrixTextBox.Location = new System.Drawing.Point(346, 276);
            this.PrixTextBox.MaxLength = 32767;
            this.PrixTextBox.Name = "PrixTextBox";
            this.PrixTextBox.PasswordChar = '\0';
            this.PrixTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PrixTextBox.SelectedText = "";
            this.PrixTextBox.SelectionLength = 0;
            this.PrixTextBox.SelectionStart = 0;
            this.PrixTextBox.ShortcutsEnabled = true;
            this.PrixTextBox.Size = new System.Drawing.Size(212, 23);
            this.PrixTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.PrixTextBox.TabIndex = 8;
            this.PrixTextBox.UseSelectable = true;
            this.PrixTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PrixTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancelVente
            // 
            this.btnCancelVente.BackColor = System.Drawing.Color.Green;
            this.btnCancelVente.Location = new System.Drawing.Point(470, 338);
            this.btnCancelVente.Name = "btnCancelVente";
            this.btnCancelVente.Size = new System.Drawing.Size(88, 35);
            this.btnCancelVente.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancelVente.TabIndex = 13;
            this.btnCancelVente.Text = "Annuler";
            this.btnCancelVente.UseCustomBackColor = true;
            this.btnCancelVente.UseSelectable = true;
            this.btnCancelVente.UseStyleColors = true;
            this.btnCancelVente.Click += new System.EventHandler(this.btnCancelVente_Click);
            // 
            // btnAddVente
            // 
            this.btnAddVente.BackColor = System.Drawing.Color.Green;
            this.btnAddVente.Location = new System.Drawing.Point(346, 338);
            this.btnAddVente.Name = "btnAddVente";
            this.btnAddVente.Size = new System.Drawing.Size(88, 35);
            this.btnAddVente.Style = MetroFramework.MetroColorStyle.White;
            this.btnAddVente.TabIndex = 12;
            this.btnAddVente.Text = "Ajouter";
            this.btnAddVente.UseCustomBackColor = true;
            this.btnAddVente.UseSelectable = true;
            this.btnAddVente.UseStyleColors = true;
            this.btnAddVente.Click += new System.EventHandler(this.btnAddVente_Click);
            // 
            // quantityCounterLabel
            // 
            this.quantityCounterLabel.AutoSize = true;
            this.quantityCounterLabel.Location = new System.Drawing.Point(537, 230);
            this.quantityCounterLabel.Name = "quantityCounterLabel";
            this.quantityCounterLabel.Size = new System.Drawing.Size(21, 19);
            this.quantityCounterLabel.TabIndex = 14;
            this.quantityCounterLabel.Text = "12";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(230, 190);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Stock";
            // 
            // stockComboBox
            // 
            this.stockComboBox.FormattingEnabled = true;
            this.stockComboBox.ItemHeight = 23;
            this.stockComboBox.Location = new System.Drawing.Point(346, 180);
            this.stockComboBox.Name = "stockComboBox";
            this.stockComboBox.Size = new System.Drawing.Size(212, 29);
            this.stockComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.stockComboBox.TabIndex = 15;
            this.stockComboBox.UseSelectable = true;
            this.stockComboBox.SelectedIndexChanged += new System.EventHandler(this.stockComboBox_SelectedIndexChanged);
            // 
            // ucVenteAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.stockComboBox);
            this.Controls.Add(this.quantityCounterLabel);
            this.Controls.Add(this.btnCancelVente);
            this.Controls.Add(this.btnAddVente);
            this.Controls.Add(this.PrixTextBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.quantityTrackBar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.medicamentComboBox);
            this.Name = "ucVenteAddForm";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucVenteAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox medicamentComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTrackBar quantityTrackBar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox PrixTextBox;
        private MetroFramework.Controls.MetroButton btnCancelVente;
        private MetroFramework.Controls.MetroButton btnAddVente;
        private MetroFramework.Controls.MetroLabel quantityCounterLabel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox stockComboBox;
    }
}
