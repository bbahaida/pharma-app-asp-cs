namespace PharmaGUI
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.mBack = new MetroFramework.Controls.MetroLink();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(23, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(851, 455);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // mBack
            // 
            this.mBack.Image = global::PharmaGUI.Properties.Resources._1488582396_circle_back_arrow_glyph;
            this.mBack.ImageSize = 32;
            this.mBack.Location = new System.Drawing.Point(23, 21);
            this.mBack.Name = "mBack";
            this.mBack.Size = new System.Drawing.Size(62, 36);
            this.mBack.TabIndex = 1;
            this.mBack.UseSelectable = true;
            this.mBack.Click += new System.EventHandler(this.mBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Green;
            this.btnLogout.Location = new System.Drawing.Point(785, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 27);
            this.btnLogout.Style = MetroFramework.MetroColorStyle.White;
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Deconnection";
            this.btnLogout.UseCustomBackColor = true;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.UseStyleColors = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 541);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.mBack);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "          Pharma App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroLink mBack;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}

