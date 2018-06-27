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
    public partial class ucFamilleAddForm : MetroFramework.Controls.MetroUserControl
    {
        static int code;
        public EventHandler<IEnumerable<Famille>> FamilleData;

        private static ucFamilleAddForm _instance;
        public static ucFamilleAddForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucFamilleAddForm();
                return _instance;
            }
        }

        public virtual void OnAdd()
        {
            FamilleData?.Invoke(this,frmMain.Instance.Famille.GetAll());
        }
        
        public ucFamilleAddForm()
        {
            InitializeComponent();
        }

        private void btnAddFamille_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance.Famille.AddFamille(new Famille { Designation = designationTextBox.Text},frmMain.Instance.Session) != null)
            {
                MetroFramework.MetroMessageBox.Show(this, "La famille a ete ajouter avec succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                code++;
                codeTextBox.Text = code.ToString();
                designationTextBox.Clear();
                if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucFamille"))
                {
                    ucFamille uc = new ucFamille();
                    uc.Dock = DockStyle.Fill;
                    frmMain.Instance.mainContainer.Controls.Add(uc);
                }
                frmMain.Instance.BtnBack.Visible = true;
                OnAdd();
                frmMain.Instance.mainContainer.Controls["ucFamille"].BringToFront();
                ucFamille.Instance.Actualiser();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "La famille n'a pas ete ajouter avec succes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ucFamilleAddForm_Load(object sender, EventArgs e)
        {
            code = frmMain.Instance.Famille.GetAll().Count() == 0 ? 1 : frmMain.Instance.Famille.GetAll().Last().CodeFamille + 1;
            codeTextBox.Text = code.ToString();
        }
    }
}
