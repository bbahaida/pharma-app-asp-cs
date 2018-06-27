namespace PharmaGUI.Controllers
{
    partial class ucDashboard
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
            System.Windows.Media.SolidColorBrush solidColorBrush3 = new System.Windows.Media.SolidColorBrush();
            this.familleController = new MetroFramework.Controls.MetroTile();
            this.stockController = new MetroFramework.Controls.MetroTile();
            this.userController = new MetroFramework.Controls.MetroTile();
            this.venteController = new MetroFramework.Controls.MetroTile();
            this.medicamentController = new MetroFramework.Controls.MetroTile();
            this.DashboardChart = new LiveCharts.WinForms.CartesianChart();
            this.btnRefrech = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // familleController
            // 
            this.familleController.ActiveControl = null;
            this.familleController.BackColor = System.Drawing.Color.DarkMagenta;
            this.familleController.Location = new System.Drawing.Point(23, 110);
            this.familleController.Name = "familleController";
            this.familleController.Size = new System.Drawing.Size(91, 55);
            this.familleController.Style = MetroFramework.MetroColorStyle.Purple;
            this.familleController.TabIndex = 0;
            this.familleController.Text = "Famille";
            this.familleController.UseCustomBackColor = true;
            this.familleController.UseSelectable = true;
            this.familleController.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // stockController
            // 
            this.stockController.ActiveControl = null;
            this.stockController.BackColor = System.Drawing.Color.DarkMagenta;
            this.stockController.Location = new System.Drawing.Point(136, 110);
            this.stockController.Name = "stockController";
            this.stockController.Size = new System.Drawing.Size(91, 55);
            this.stockController.Style = MetroFramework.MetroColorStyle.Purple;
            this.stockController.TabIndex = 1;
            this.stockController.Text = "Stock";
            this.stockController.UseCustomBackColor = true;
            this.stockController.UseSelectable = true;
            this.stockController.Click += new System.EventHandler(this.stockController_Click);
            // 
            // userController
            // 
            this.userController.ActiveControl = null;
            this.userController.BackColor = System.Drawing.Color.DarkMagenta;
            this.userController.Location = new System.Drawing.Point(136, 190);
            this.userController.Name = "userController";
            this.userController.Size = new System.Drawing.Size(91, 55);
            this.userController.Style = MetroFramework.MetroColorStyle.Green;
            this.userController.TabIndex = 3;
            this.userController.Text = "Utilisateur";
            this.userController.UseCustomBackColor = true;
            this.userController.UseSelectable = true;
            this.userController.Click += new System.EventHandler(this.userController_Click);
            // 
            // venteController
            // 
            this.venteController.ActiveControl = null;
            this.venteController.BackColor = System.Drawing.Color.DarkMagenta;
            this.venteController.Location = new System.Drawing.Point(23, 190);
            this.venteController.Name = "venteController";
            this.venteController.Size = new System.Drawing.Size(91, 55);
            this.venteController.Style = MetroFramework.MetroColorStyle.Green;
            this.venteController.TabIndex = 2;
            this.venteController.Text = "Vente";
            this.venteController.UseCustomBackColor = true;
            this.venteController.UseSelectable = true;
            this.venteController.Click += new System.EventHandler(this.venteController_Click);
            // 
            // medicamentController
            // 
            this.medicamentController.ActiveControl = null;
            this.medicamentController.BackColor = System.Drawing.Color.DarkMagenta;
            this.medicamentController.Location = new System.Drawing.Point(23, 269);
            this.medicamentController.Name = "medicamentController";
            this.medicamentController.Size = new System.Drawing.Size(204, 55);
            this.medicamentController.TabIndex = 4;
            this.medicamentController.Text = "Medicament";
            this.medicamentController.UseCustomBackColor = true;
            this.medicamentController.UseSelectable = true;
            this.medicamentController.Click += new System.EventHandler(this.medicamentController_Click);
            // 
            // DashboardChart
            // 
            this.DashboardChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashboardChart.Hoverable = true;
            this.DashboardChart.Location = new System.Drawing.Point(269, 110);
            this.DashboardChart.Name = "DashboardChart";
            solidColorBrush3.Color = System.Windows.Media.Color.FromArgb(((byte)(30)), ((byte)(30)), ((byte)(30)), ((byte)(30)));
            this.DashboardChart.ScrollBarFill = solidColorBrush3;
            this.DashboardChart.ScrollHorizontalFrom = 0D;
            this.DashboardChart.ScrollHorizontalTo = 0D;
            this.DashboardChart.ScrollMode = LiveCharts.ScrollMode.None;
            this.DashboardChart.ScrollVerticalFrom = 0D;
            this.DashboardChart.ScrollVerticalTo = 0D;
            this.DashboardChart.Size = new System.Drawing.Size(543, 214);
            this.DashboardChart.TabIndex = 5;
            // 
            // btnRefrech
            // 
            this.btnRefrech.ActiveControl = null;
            this.btnRefrech.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnRefrech.Location = new System.Drawing.Point(712, 344);
            this.btnRefrech.Name = "btnRefrech";
            this.btnRefrech.Size = new System.Drawing.Size(100, 38);
            this.btnRefrech.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnRefrech.TabIndex = 6;
            this.btnRefrech.Text = "Actualiser";
            this.btnRefrech.UseCustomBackColor = true;
            this.btnRefrech.UseSelectable = true;
            this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefrech);
            this.Controls.Add(this.DashboardChart);
            this.Controls.Add(this.medicamentController);
            this.Controls.Add(this.userController);
            this.Controls.Add(this.venteController);
            this.Controls.Add(this.stockController);
            this.Controls.Add(this.familleController);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(851, 455);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile familleController;
        private MetroFramework.Controls.MetroTile stockController;
        private MetroFramework.Controls.MetroTile userController;
        private MetroFramework.Controls.MetroTile venteController;
        private MetroFramework.Controls.MetroTile medicamentController;
        private LiveCharts.WinForms.CartesianChart DashboardChart;
        private MetroFramework.Controls.MetroTile btnRefrech;
    }
}
