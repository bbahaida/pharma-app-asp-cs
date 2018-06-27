namespace PharmaGUI.Controllers
{
    partial class ucMedicament
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.medicamentGrid = new MetroFramework.Controls.MetroGrid();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mChercher = new MetroFramework.Controls.MetroTile();
            this.mDelete = new MetroFramework.Controls.MetroTile();
            this.mEdit = new MetroFramework.Controls.MetroTile();
            this.mAdd = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // medicamentGrid
            // 
            this.medicamentGrid.AllowUserToAddRows = false;
            this.medicamentGrid.AllowUserToDeleteRows = false;
            this.medicamentGrid.AllowUserToResizeRows = false;
            this.medicamentGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.medicamentGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicamentGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.medicamentGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.medicamentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Libelle,
            this.Prix,
            this.Famille});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicamentGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.medicamentGrid.EnableHeadersVisualStyles = false;
            this.medicamentGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.medicamentGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.medicamentGrid.Location = new System.Drawing.Point(23, 103);
            this.medicamentGrid.Name = "medicamentGrid";
            this.medicamentGrid.ReadOnly = true;
            this.medicamentGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.medicamentGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.medicamentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicamentGrid.Size = new System.Drawing.Size(694, 248);
            this.medicamentGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.medicamentGrid.TabIndex = 9;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // Famille
            // 
            this.Famille.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Famille.HeaderText = "Famille";
            this.Famille.Name = "Famille";
            this.Famille.ReadOnly = true;
            // 
            // mChercher
            // 
            this.mChercher.ActiveControl = null;
            this.mChercher.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mChercher.Location = new System.Drawing.Point(744, 304);
            this.mChercher.Name = "mChercher";
            this.mChercher.Size = new System.Drawing.Size(83, 47);
            this.mChercher.Style = MetroFramework.MetroColorStyle.Green;
            this.mChercher.TabIndex = 8;
            this.mChercher.Text = "Chercher";
            this.mChercher.UseSelectable = true;
            this.mChercher.Click += new System.EventHandler(this.mChercher_Click);
            // 
            // mDelete
            // 
            this.mDelete.ActiveControl = null;
            this.mDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mDelete.Location = new System.Drawing.Point(744, 238);
            this.mDelete.Name = "mDelete";
            this.mDelete.Size = new System.Drawing.Size(83, 50);
            this.mDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.mDelete.TabIndex = 7;
            this.mDelete.Text = "Supprimer";
            this.mDelete.UseSelectable = true;
            this.mDelete.Click += new System.EventHandler(this.mDelete_Click);
            // 
            // mEdit
            // 
            this.mEdit.ActiveControl = null;
            this.mEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mEdit.Location = new System.Drawing.Point(744, 170);
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(83, 52);
            this.mEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.mEdit.TabIndex = 6;
            this.mEdit.Text = "Modifier";
            this.mEdit.UseSelectable = true;
            this.mEdit.Click += new System.EventHandler(this.mEdit_Click);
            // 
            // mAdd
            // 
            this.mAdd.ActiveControl = null;
            this.mAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mAdd.Location = new System.Drawing.Point(744, 103);
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(83, 51);
            this.mAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.mAdd.TabIndex = 5;
            this.mAdd.Text = "Ajouter";
            this.mAdd.UseSelectable = true;
            this.mAdd.Click += new System.EventHandler(this.mAdd_Click);
            // 
            // ucMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.medicamentGrid);
            this.Controls.Add(this.mChercher);
            this.Controls.Add(this.mDelete);
            this.Controls.Add(this.mEdit);
            this.Controls.Add(this.mAdd);
            this.Name = "ucMedicament";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid medicamentGrid;
        private MetroFramework.Controls.MetroTile mChercher;
        private MetroFramework.Controls.MetroTile mDelete;
        private MetroFramework.Controls.MetroTile mEdit;
        private MetroFramework.Controls.MetroTile mAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famille;
    }
}
