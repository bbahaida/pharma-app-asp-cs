namespace PharmaGUI.Controllers
{
    partial class ucVenteSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnGo = new MetroFramework.Controls.MetroButton();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.venteGrid = new MetroFramework.Controls.MetroGrid();
            this.NumVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.venteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.ItemHeight = 23;
            this.filterComboBox.Location = new System.Drawing.Point(28, 91);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(142, 29);
            this.filterComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.filterComboBox.TabIndex = 18;
            this.filterComboBox.UseSelectable = true;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Location = new System.Drawing.Point(592, 91);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.Style = MetroFramework.MetroColorStyle.White;
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Retour";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseStyleColors = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Green;
            this.btnGo.Location = new System.Drawing.Point(489, 91);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 29);
            this.btnGo.Style = MetroFramework.MetroColorStyle.White;
            this.btnGo.TabIndex = 16;
            this.btnGo.Text = "Aller";
            this.btnGo.UseCustomBackColor = true;
            this.btnGo.UseSelectable = true;
            this.btnGo.UseStyleColors = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // searchTextBox
            // 
            // 
            // 
            // 
            this.searchTextBox.CustomButton.Image = null;
            this.searchTextBox.CustomButton.Location = new System.Drawing.Point(246, 1);
            this.searchTextBox.CustomButton.Name = "";
            this.searchTextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchTextBox.CustomButton.TabIndex = 1;
            this.searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchTextBox.CustomButton.UseSelectable = true;
            this.searchTextBox.CustomButton.Visible = false;
            this.searchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(186, 91);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.SelectionLength = 0;
            this.searchTextBox.SelectionStart = 0;
            this.searchTextBox.ShortcutsEnabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(274, 29);
            this.searchTextBox.Style = MetroFramework.MetroColorStyle.Green;
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // venteGrid
            // 
            this.venteGrid.AllowUserToAddRows = false;
            this.venteGrid.AllowUserToDeleteRows = false;
            this.venteGrid.AllowUserToResizeRows = false;
            this.venteGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.venteGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.venteGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.venteGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venteGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.venteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumVente,
            this.Medicament,
            this.PrixUnitaire,
            this.Quantite,
            this.PrixTotal});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venteGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.venteGrid.EnableHeadersVisualStyles = false;
            this.venteGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.venteGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.venteGrid.Location = new System.Drawing.Point(28, 135);
            this.venteGrid.Name = "venteGrid";
            this.venteGrid.ReadOnly = true;
            this.venteGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venteGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.venteGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.venteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venteGrid.Size = new System.Drawing.Size(800, 248);
            this.venteGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.venteGrid.TabIndex = 19;
            // 
            // NumVente
            // 
            this.NumVente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumVente.HeaderText = "Code";
            this.NumVente.Name = "NumVente";
            this.NumVente.ReadOnly = true;
            // 
            // Medicament
            // 
            this.Medicament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medicament.HeaderText = "Medicament";
            this.Medicament.Name = "Medicament";
            this.Medicament.ReadOnly = true;
            // 
            // PrixUnitaire
            // 
            this.PrixUnitaire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrixUnitaire.HeaderText = "Prix Unitaire";
            this.PrixUnitaire.Name = "PrixUnitaire";
            this.PrixUnitaire.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // PrixTotal
            // 
            this.PrixTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrixTotal.HeaderText = "Prix Total";
            this.PrixTotal.Name = "PrixTotal";
            this.PrixTotal.ReadOnly = true;
            // 
            // ucVenteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.venteGrid);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.searchTextBox);
            this.Name = "ucVenteSearch";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucVenteSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venteGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox filterComboBox;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnGo;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroGrid venteGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixTotal;
    }
}
