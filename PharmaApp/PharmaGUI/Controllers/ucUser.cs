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
    public partial class ucUser : MetroFramework.Controls.MetroUserControl
    {
        public EventHandler<User> Passed;
        private static ucUser _instance;
        public User User { get; set; }
        public static ucUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUser();
                return _instance;
            }
        }
        protected virtual void OnEditClick()
        {
            Passed?.Invoke(this, User);
        }
        public ucUser()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            List<User> data = frmMain.Instance.User.GetAll().ToList();
            userGrid.Rows.Clear();
            foreach (User f in data)
            {
                userGrid.Rows.Add(f.Login, f.Name);
            }
        }
        private void mAdd_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.Session.Login.Equals("admin"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Vous avez pas les droits pour ajouter un utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucUserAddForm"))
            {
                ucUserAddForm uc = new ucUserAddForm();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucUserAddForm"].BringToFront();
        }

        private void ucUser_Load(object sender, EventArgs e)
        {
            _instance = this;
            Actualiser();
        }


        private void mEdit_Click(object sender, EventArgs e)
        {
            User = frmMain.Instance.User.GetUserByLogin(userGrid.SelectedRows[0].Cells[0].Value.ToString());
            if(!(frmMain.Instance.Session.UserId == User.UserId || frmMain.Instance.Session.Login.Equals("admin") ))
            {
                MetroFramework.MetroMessageBox.Show(this, "Vous avez pas les droits pour modifier cet utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (User == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "L'utilisateur n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucUserEditForm"))
            {
                ucUserEditForm uc = new ucUserEditForm();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }

            frmMain.Instance.BtnBack.Visible = true;
            OnEditClick();
            frmMain.Instance.mainContainer.Controls["ucUserEditForm"].BringToFront();
        }
    }
}
