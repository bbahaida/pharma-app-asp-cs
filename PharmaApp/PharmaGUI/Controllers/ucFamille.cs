using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaDomain.Service;
using PharmaDomain.Dao;
using PharmaDomain;

namespace PharmaGUI.Controllers
{
    public partial class ucFamille : MetroFramework.Controls.MetroUserControl
    {
        public EventHandler<Famille> Passed;
        private static ucFamille _instance;
        public Famille Famille { get; set; }
        public static ucFamille Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucFamille();
                return _instance;
            }
        }
        public ucFamille()
        {
            InitializeComponent();
            Actualiser();
        }
        
        protected virtual void OnEditClick()
        {
            Passed?.Invoke(this,Famille);
        }
        private void metroTile4_Click(object sender, EventArgs e)
        {
            
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucFamilleSearchForm"))
            {
                ucFamilleSearchForm uc = new ucFamilleSearchForm();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucFamilleSearchForm"].BringToFront();

        }

        private void mAdd_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucFamilleAddForm"))
            {
                ucFamilleAddForm uc = new ucFamilleAddForm();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucFamilleAddForm"].BringToFront();

        }

        private void mEdit_Click(object sender, EventArgs e)
        {
            Famille = frmMain.Instance.Famille.GetOneFamilleById(int.Parse(familleGrid.SelectedRows[0].Cells[0].Value.ToString()));
            if (Famille == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "La famille n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucFamilleEditForm"))
            {
                ucFamilleEditForm uc = new ucFamilleEditForm();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            OnEditClick();
            frmMain.Instance.mainContainer.Controls["ucFamilleEditForm"].BringToFront();
            
        }

        private void mDelete_Click(object sender, EventArgs e)
        {

            Famille = frmMain.Instance.Famille.GetOneFamilleById(int.Parse(familleGrid.SelectedRows[0].Cells[0].Value.ToString()));
            if (Famille == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "La famille n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous vraiment supprimer la famille " + Famille.Designation + " ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Famille = frmMain.Instance.Famille.DeleteFamille(Famille, frmMain.Instance.Session);
                if (Famille == null)
                    MetroFramework.MetroMessageBox.Show(this, "La famille a ete supprimmer avec succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "La famille n'a pas ete supprimmer avec succes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Actualiser();
            }
        }

        private void ucFamille_Load(object sender, EventArgs e)
        {
            _instance = this;
            mEdit.Enabled = false;
            mDelete.Enabled = false;
            mChercher.Enabled = false;
            Actualiser();
            
        }
        public void Actualiser()
        {
            List<Famille> data = frmMain.Instance.Famille.GetAll().ToList();
            familleGrid.Rows.Clear();
            if (data.Count > 0)
            {
                mEdit.Enabled = true;
                mDelete.Enabled = true;
                mChercher.Enabled = true;
            }
            foreach (Famille f in data)
            {
                familleGrid.Rows.Add(f.CodeFamille,f.Designation);
            }
        }
    }
}
