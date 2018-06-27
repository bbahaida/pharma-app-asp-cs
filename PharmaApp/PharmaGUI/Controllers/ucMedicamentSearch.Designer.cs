namespace PharmaGUI.Controllers
{
    partial class ucMedicamentSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.medicamentGrid = new MetroFramework.Controls.MetroGrid();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.btnGo = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.filterComboBox = new MetroFramework.Controls.MetroComboBox();
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.medicamentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicamentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Libelle,
            this.Prix,
            this.Famille});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicamentGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.medicamentGrid.EnableHeadersVisualStyles = false;
            this.medicamentGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.medicamentGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.medicamentGrid.Location = new System.Drawing.Point(23, 123);
            this.medicamentGrid.Name = "medicamentGrid";
            this.medicamentGrid.ReadOnly = true;
            this.medicamentGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.medicamentGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.medicamentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicamentGrid.Size = new System.Drawing.Size(794, 228);
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
            this.searchTextBox.Location = new System.Drawing.Point(181, 79);
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
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Green;
            this.btnGo.Location = new System.Drawing.Point(484, 79);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 29);
            this.btnGo.Style = MetroFramework.MetroColorStyle.White;
            this.btnGo.TabIndex = 11;
            this.btnGo.Text = "Aller";
            this.btnGo.UseCustomBackColor = true;
            this.btnGo.UseSelectable = true;
            this.btnGo.UseStyleColors = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Location = new System.Drawing.Point(587, 79);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.Style = MetroFramework.MetroColorStyle.White;
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Retour";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseStyleColors = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.ItemHeight = 23;
            this.filterComboBox.Location = new System.Drawing.Point(23, 79);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(142, 29);
            this.filterComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.filterComboBox.TabIndex = 13;
            this.filterComboBox.UseSelectable = true;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // ucMedicamentSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.medicamentGrid);
            this.Name = "ucMedicamentSearch";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid medicamentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famille;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroButton btnGo;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroComboBox filterComboBox;
    }
}
