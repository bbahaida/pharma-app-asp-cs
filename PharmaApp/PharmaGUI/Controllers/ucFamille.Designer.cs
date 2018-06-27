namespace PharmaGUI.Controllers
{
    partial class ucFamille
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
            this.mAdd = new MetroFramework.Controls.MetroTile();
            this.mEdit = new MetroFramework.Controls.MetroTile();
            this.mDelete = new MetroFramework.Controls.MetroTile();
            this.mChercher = new MetroFramework.Controls.MetroTile();
            this.familleGrid = new MetroFramework.Controls.MetroGrid();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.familleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mAdd
            // 
            this.mAdd.ActiveControl = null;
            this.mAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mAdd.Location = new System.Drawing.Point(748, 103);
            this.mAdd.Name = "mAdd";
            this.mAdd.Size = new System.Drawing.Size(83, 51);
            this.mAdd.Style = MetroFramework.MetroColorStyle.Green;
            this.mAdd.TabIndex = 0;
            this.mAdd.Text = "Ajouter";
            this.mAdd.UseSelectable = true;
            this.mAdd.Click += new System.EventHandler(this.mAdd_Click);
            // 
            // mEdit
            // 
            this.mEdit.ActiveControl = null;
            this.mEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mEdit.Location = new System.Drawing.Point(748, 170);
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(83, 52);
            this.mEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.mEdit.TabIndex = 1;
            this.mEdit.Text = "Modifier";
            this.mEdit.UseSelectable = true;
            this.mEdit.Click += new System.EventHandler(this.mEdit_Click);
            // 
            // mDelete
            // 
            this.mDelete.ActiveControl = null;
            this.mDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mDelete.Location = new System.Drawing.Point(748, 238);
            this.mDelete.Name = "mDelete";
            this.mDelete.Size = new System.Drawing.Size(83, 50);
            this.mDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.mDelete.TabIndex = 2;
            this.mDelete.Text = "Supprimer";
            this.mDelete.UseSelectable = true;
            this.mDelete.Click += new System.EventHandler(this.mDelete_Click);
            // 
            // mChercher
            // 
            this.mChercher.ActiveControl = null;
            this.mChercher.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mChercher.Location = new System.Drawing.Point(748, 304);
            this.mChercher.Name = "mChercher";
            this.mChercher.Size = new System.Drawing.Size(83, 47);
            this.mChercher.Style = MetroFramework.MetroColorStyle.Green;
            this.mChercher.TabIndex = 3;
            this.mChercher.Text = "Chercher";
            this.mChercher.UseSelectable = true;
            this.mChercher.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // familleGrid
            // 
            this.familleGrid.AllowUserToAddRows = false;
            this.familleGrid.AllowUserToDeleteRows = false;
            this.familleGrid.AllowUserToResizeRows = false;
            this.familleGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.familleGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.familleGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.familleGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.familleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.familleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.familleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Designation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.familleGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.familleGrid.EnableHeadersVisualStyles = false;
            this.familleGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.familleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.familleGrid.Location = new System.Drawing.Point(27, 103);
            this.familleGrid.Name = "familleGrid";
            this.familleGrid.ReadOnly = true;
            this.familleGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.familleGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.familleGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.familleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.familleGrid.Size = new System.Drawing.Size(694, 248);
            this.familleGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.familleGrid.TabIndex = 4;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Designation
            // 
            this.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // ucFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.familleGrid);
            this.Controls.Add(this.mChercher);
            this.Controls.Add(this.mDelete);
            this.Controls.Add(this.mEdit);
            this.Controls.Add(this.mAdd);
            this.Name = "ucFamille";
            this.Size = new System.Drawing.Size(851, 455);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.UseStyleColors = true;
            this.Load += new System.EventHandler(this.ucFamille_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familleGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mAdd;
        private MetroFramework.Controls.MetroTile mEdit;
        private MetroFramework.Controls.MetroTile mDelete;
        private MetroFramework.Controls.MetroTile mChercher;
        private MetroFramework.Controls.MetroGrid familleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
    }
}
