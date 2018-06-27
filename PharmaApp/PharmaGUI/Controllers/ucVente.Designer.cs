namespace PharmaGUI.Controllers
{
    partial class ucVente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.venteGrid = new MetroFramework.Controls.MetroGrid();
            this.NumVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mChercher = new MetroFramework.Controls.MetroTile();
            this.mDelete = new MetroFramework.Controls.MetroTile();
            this.mAdd = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.venteGrid)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venteGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.venteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumVente,
            this.Medicament,
            this.PrixUnitaire,
            this.Quantite,
            this.PrixTotal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.venteGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.venteGrid.EnableHeadersVisualStyles = false;
            this.venteGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.venteGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.venteGrid.Location = new System.Drawing.Point(23, 103);
            this.venteGrid.Name = "venteGrid";
            this.venteGrid.ReadOnly = true;
            this.venteGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.venteGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.venteGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.venteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.venteGrid.Size = new System.Drawing.Size(694, 248);
            this.venteGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.venteGrid.TabIndex = 14;
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
            // mChercher
            // 
            this.mChercher.ActiveControl = null;
            this.mChercher.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mChercher.Location = new System.Drawing.Point(744, 271);
            this.mChercher.Name = "mChercher";
            this.mChercher.Size = new System.Drawing.Size(83, 65);
            this.mChercher.Style = MetroFramework.MetroColorStyle.Green;
            this.mChercher.TabIndex = 13;
            this.mChercher.Text = "Chercher";
            this.mChercher.UseSelectable = true;
            this.mChercher.Click += new System.EventHandler(this.mChercher_Click);
            // 
            // mDelete
            // 
            this.mDelete.ActiveControl = null;
            this.mDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mDelete.Location = new System.Drawing.Point(744, 188);
            this.mDelete.Name = "mDelete";
            this.mDelete.Size = new System.Drawing.Size(83, 67);
            this.mDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.mDelete.TabIndex = 12;
            this.mDelete.Text = "Supprimer";
            this.mDelete.UseSelectable = true;
            this.mDelete.Click += new System.EventHandler(this.mDelete_Click);
            // 
            // mAdd
            // 
            this.mAdd.ActiveControl = null;
            this.mAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mAdd.Location = new System.Drawing.Point(744, 103);
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(83, 67);
            this.mAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.mAdd.TabIndex = 10;
            this.mAdd.Text = "Ajouter";
            this.mAdd.UseSelectable = true;
            this.mAdd.Click += new System.EventHandler(this.mAdd_Click);
            // 
            // ucVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.venteGrid);
            this.Controls.Add(this.mChercher);
            this.Controls.Add(this.mDelete);
            this.Controls.Add(this.mAdd);
            this.Name = "ucVente";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucVente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venteGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid venteGrid;
        private MetroFramework.Controls.MetroTile mChercher;
        private MetroFramework.Controls.MetroTile mDelete;
        private MetroFramework.Controls.MetroTile mAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixTotal;
    }
}
