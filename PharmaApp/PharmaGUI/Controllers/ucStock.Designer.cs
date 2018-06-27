namespace PharmaGUI.Controllers
{
    partial class ucStock
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
            this.stockGrid = new MetroFramework.Controls.MetroGrid();
            this.NumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddStock = new MetroFramework.Controls.MetroTile();
            this.DeleteStock = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stockGrid
            // 
            this.stockGrid.AllowUserToAddRows = false;
            this.stockGrid.AllowUserToDeleteRows = false;
            this.stockGrid.AllowUserToResizeRows = false;
            this.stockGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stockGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.stockGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumStock,
            this.Quantite});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockGrid.EnableHeadersVisualStyles = false;
            this.stockGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stockGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stockGrid.Location = new System.Drawing.Point(22, 168);
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.ReadOnly = true;
            this.stockGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stockGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockGrid.Size = new System.Drawing.Size(812, 248);
            this.stockGrid.Style = MetroFramework.MetroColorStyle.Green;
            this.stockGrid.TabIndex = 9;
            // 
            // NumStock
            // 
            this.NumStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumStock.HeaderText = "NumStock";
            this.NumStock.Name = "NumStock";
            this.NumStock.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // AddStock
            // 
            this.AddStock.ActiveControl = null;
            this.AddStock.Location = new System.Drawing.Point(22, 32);
            this.AddStock.Name = "AddStock";
            this.AddStock.Size = new System.Drawing.Size(98, 49);
            this.AddStock.Style = MetroFramework.MetroColorStyle.Green;
            this.AddStock.TabIndex = 10;
            this.AddStock.Text = "Nouveau";
            this.AddStock.UseSelectable = true;
            this.AddStock.Click += new System.EventHandler(this.AddStock_Click);
            // 
            // DeleteStock
            // 
            this.DeleteStock.ActiveControl = null;
            this.DeleteStock.Location = new System.Drawing.Point(22, 96);
            this.DeleteStock.Name = "DeleteStock";
            this.DeleteStock.Size = new System.Drawing.Size(98, 49);
            this.DeleteStock.Style = MetroFramework.MetroColorStyle.Green;
            this.DeleteStock.TabIndex = 11;
            this.DeleteStock.Text = "Supprimer";
            this.DeleteStock.UseSelectable = true;
            this.DeleteStock.Click += new System.EventHandler(this.DeleteStock_Click);
            // 
            // ucStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteStock);
            this.Controls.Add(this.AddStock);
            this.Controls.Add(this.stockGrid);
            this.Name = "ucStock";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid stockGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private MetroFramework.Controls.MetroTile AddStock;
        private MetroFramework.Controls.MetroTile DeleteStock;
    }
}
