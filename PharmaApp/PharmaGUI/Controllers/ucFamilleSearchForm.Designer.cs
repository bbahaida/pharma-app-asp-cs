namespace PharmaGUI.Controllers
{
    partial class ucFamilleSearchForm
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
            this.familleGrid = new MetroFramework.Controls.MetroGrid();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterComboBox = new MetroFramework.Controls.MetroComboBox();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnGo = new MetroFramework.Controls.MetroButton();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.familleGrid)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.familleGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.familleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.familleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Designation});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.familleGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.familleGrid.EnableHeadersVisualStyles = false;
            this.familleGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.familleGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.familleGrid.Location = new System.Drawing.Point(21, 103);
            this.familleGrid.Name = "familleGrid";
            this.familleGrid.ReadOnly = true;
            this.familleGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.familleGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.familleGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.familleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.familleGrid.Size = new System.Drawing.Size(810, 248);
            this.familleGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.familleGrid.TabIndex = 5;
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
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.ItemHeight = 23;
            this.filterComboBox.Location = new System.Drawing.Point(21, 68);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(142, 29);
            this.filterComboBox.Style = MetroFramework.MetroColorStyle.Green;
            this.filterComboBox.TabIndex = 17;
            this.filterComboBox.UseSelectable = true;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Location = new System.Drawing.Point(586, 68);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 29);
            this.btnBack.Style = MetroFramework.MetroColorStyle.White;
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Retour";
            this.btnBack.UseCustomBackColor = true;
            this.btnBack.UseSelectable = true;
            this.btnBack.UseStyleColors = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Green;
            this.btnGo.Location = new System.Drawing.Point(483, 68);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 29);
            this.btnGo.Style = MetroFramework.MetroColorStyle.White;
            this.btnGo.TabIndex = 15;
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
            this.searchTextBox.Location = new System.Drawing.Point(185, 68);
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
            this.searchTextBox.TabIndex = 14;
            this.searchTextBox.UseSelectable = true;
            this.searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ucFamilleSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.familleGrid);
            this.Name = "ucFamilleSearchForm";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucFamilleSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.familleGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid familleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private MetroFramework.Controls.MetroComboBox filterComboBox;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnGo;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
    }
}
