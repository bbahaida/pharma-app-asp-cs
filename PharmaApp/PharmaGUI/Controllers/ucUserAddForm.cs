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
    public partial class ucUserAddForm : MetroFramework.Controls.MetroUserControl
    {
        public ucUserAddForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Equals("") || loginTextBox.Text.Equals("") || pwTextBox.Text.Equals("") || confirmTextBox.Text.Equals(""))
                return;
            if (pwTextBox.Text.Equals(confirmTextBox.Text))
            {
                User u = frmMain.Instance.User.AddUser(
                   new User
                   {
                       Name = nameTextBox.Text,
                       Login = loginTextBox.Text,
                       Password = pwTextBox.Text
                   }, frmMain.Instance.Session);
                if (u != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "L'utilisateur a ete ajouter avec succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucUser"))
                    {
                        ucUser uc = new ucUser();
                        uc.Dock = DockStyle.Fill;
                        frmMain.Instance.mainContainer.Controls.Add(uc);
                    }
                    frmMain.Instance.BtnBack.Visible = true;
                    frmMain.Instance.mainContainer.Controls["ucUser"].BringToFront();
                    loginTextBox.Clear();
                    nameTextBox.Clear();
                    pwTextBox.Clear();
                    confirmTextBox.Clear();
                    ucUser.Instance.Actualiser();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "L'utilisateur n'a pas ete ajouter", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
