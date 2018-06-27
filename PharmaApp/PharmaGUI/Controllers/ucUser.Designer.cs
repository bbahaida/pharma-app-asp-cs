namespace PharmaGUI.Controllers
{
    partial class ucUser
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
            this.userGrid = new MetroFramework.Controls.MetroGrid();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mChercher = new MetroFramework.Controls.MetroTile();
            this.mDelete = new MetroFramework.Controls.MetroTile();
            this.mEdit = new MetroFramework.Controls.MetroTile();
            this.mAdd = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userGrid
            // 
            this.userGrid.AllowUserToAddRows = false;
            this.userGrid.AllowUserToDeleteRows = false;
            this.userGrid.AllowUserToResizeRows = false;
            this.userGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.nom});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.userGrid.EnableHeadersVisualStyles = false;
            this.userGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userGrid.Location = new System.Drawing.Point(23, 103);
            this.userGrid.Name = "userGrid";
            this.userGrid.ReadOnly = true;
            this.userGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGrid.Size = new System.Drawing.Size(694, 248);
            this.userGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.userGrid.TabIndex = 14;
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // mChercher
            // 
            this.mChercher.ActiveControl = null;
            this.mChercher.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mChercher.Location = new System.Drawing.Point(744, 304);
            this.mChercher.Name = "mChercher";
            this.mChercher.Size = new System.Drawing.Size(83, 47);
            this.mChercher.Style = MetroFramework.MetroColorStyle.Green;
            this.mChercher.TabIndex = 13;
            this.mChercher.Text = "Chercher";
            this.mChercher.UseSelectable = true;
            // 
            // mDelete
            // 
            this.mDelete.ActiveControl = null;
            this.mDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mDelete.Location = new System.Drawing.Point(744, 238);
            this.mDelete.Name = "mDelete";
            this.mDelete.Size = new System.Drawing.Size(83, 50);
            this.mDelete.Style = MetroFramework.MetroColorStyle.Green;
            this.mDelete.TabIndex = 12;
            this.mDelete.Text = "Supprimer";
            this.mDelete.UseSelectable = true;
            // 
            // mEdit
            // 
            this.mEdit.ActiveControl = null;
            this.mEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mEdit.Location = new System.Drawing.Point(744, 170);
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(83, 52);
            this.mEdit.Style = MetroFramework.MetroColorStyle.Green;
            this.mEdit.TabIndex = 11;
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
            this.mAdd.TabIndex = 10;
            this.mAdd.Text = "Ajouter";
            this.mAdd.UseSelectable = true;
            this.mAdd.Click += new System.EventHandler(this.mAdd_Click);
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userGrid);
            this.Controls.Add(this.mChercher);
            this.Controls.Add(this.mDelete);
            this.Controls.Add(this.mEdit);
            this.Controls.Add(this.mAdd);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid userGrid;
        private MetroFramework.Controls.MetroTile mChercher;
        private MetroFramework.Controls.MetroTile mDelete;
        private MetroFramework.Controls.MetroTile mEdit;
        private MetroFramework.Controls.MetroTile mAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
    }
}
