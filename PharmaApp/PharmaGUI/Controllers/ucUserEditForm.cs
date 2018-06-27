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

namespace PharmaGUI.Controllers
{
    public partial class ucUserEditForm : MetroFramework.Controls.MetroUserControl
    {
        public User User { get; set; }
        public ucUserEditForm()
        {
            ucUser.Instance.Passed += this.OnEditClick;
            InitializeComponent();
        }
        public void OnEditClick(object source, User e)
        {
            User = e;
            nameTextBox.Text = e.Name;
            loginTextBox.Text = e.Login;
            pwTextBox.Clear();
            confirmTextBox.Clear();
            pwTextBox.Focus();
        }
        private void ucUserEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals("") || loginTextBox.Text.Equals("") || pwTextBox.Text.Equals("") || confirmTextBox.Text.Equals(""))
                return;
            if(!(frmMain.Instance.User.GetUserByLogin(loginTextBox.Text) == null || loginTextBox.Text.Equals(User.Login)) )
            {
                MetroFramework.MetroMessageBox.Show(this, "Login "+loginTextBox.Text+" est deja utilise", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pwTextBox.Text.Equals(confirmTextBox.Text))
            {
                User.Name = nameTextBox.Text;
                User.Login = loginTextBox.Text;
                User.Password = pwTextBox.Text;
                User u = frmMain.Instance.User.EditUser(
                   User, frmMain.Instance.Session);
                if (u != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "L'utilisateur a ete modifier avec succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucUser"))
                    {
                        ucUser uc = new ucUser();
                        uc.Dock = DockStyle.Fill;
                        frmMain.Instance.mainContainer.Controls.Add(uc);
                    }
                    frmMain.Instance.BtnBack.Visible = true;
                    frmMain.Instance.mainContainer.Controls["ucUser"].BringToFront();
                    ucUser.Instance.Actualiser();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "L'utilisateur n'a pas ete modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucUser"))
            {
                ucUser uc = new ucUser();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucUser"].BringToFront();
        }
    }
}
