using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaDomain;
using PharmaDomain.Service;
using PharmaDomain.Dao;

namespace PharmaGUI.Controllers
{
    public partial class ucLogin : MetroFramework.Controls.MetroUserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (unTextBox.Text.Equals("") || pwTextBox.Text.Equals(""))
                return;
            User user = frmMain.Instance.User.GetUserByAuth(unTextBox.Text,pwTextBox.Text);
            if (user == null)
            {
                pwTextBox.Text = "";
                pwTextBox.Style = MetroFramework.MetroColorStyle.Red;
                pwTextBox.Focus();
                return;
            }
            frmMain.Instance.Session = user;
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucDashboard"))
            {
                
                ucDashboard uc = new ucDashboard();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc); 
            }
            unTextBox.Clear();
            pwTextBox.Clear();
            pwTextBox.Style = MetroFramework.MetroColorStyle.Green;
            frmMain.Instance.Logout.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucDashboard"].BringToFront();
        }
    }
}
