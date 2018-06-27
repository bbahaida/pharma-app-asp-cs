using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using PharmaDomain;

namespace PharmaGUI.Controllers
{
    public partial class ucFamilleEditForm : MetroFramework.Controls.MetroUserControl
    {
        private static ucFamilleEditForm _instance;
        public static ucFamilleEditForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucFamilleEditForm();
                return _instance;
            }
        }
        
        public void OnEditClick(object source,Famille e)
        {
            codeTextBox.Text = e.CodeFamille.ToString();
            designationTextBox.Text = e.Designation;
        }
        public ucFamilleEditForm()
        {
            ucFamille.Instance.Passed += this.OnEditClick;
            InitializeComponent();
        }

        public void ucFamilleEditForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEditFamille_Click(object sender, EventArgs e)
        {
            if (designationTextBox.Text.Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, "la designation ne doit pas etre vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucFamille.Instance.Famille.Designation = designationTextBox.Text;
            if (frmMain.Instance.Famille.EditFamille(ucFamille.Instance.Famille, frmMain.Instance.Session) != null)
            {
                designationTextBox.Clear();
                ucFamille.Instance.Famille = null;
                MetroFramework.MetroMessageBox.Show(this, "la famille a ete modifier", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucFamille"))
                {
                    ucFamille uc = new ucFamille();
                    uc.Dock = DockStyle.Fill;
                    frmMain.Instance.mainContainer.Controls.Add(uc);
                }
                frmMain.Instance.BtnBack.Visible = true;
                frmMain.Instance.mainContainer.Controls["ucFamille"].BringToFront();
                ucFamille.Instance.Actualiser();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Erreur l'operation a echoue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelFamille_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucFamille"))
            {
                ucFamille uc = new ucFamille();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucFamille"].BringToFront();
        }
       
    }
}
