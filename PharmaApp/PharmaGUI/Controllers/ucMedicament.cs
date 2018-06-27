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
    public partial class ucMedicament : MetroFramework.Controls.MetroUserControl
    {

        private static ucMedicament _instance;

        public static ucMedicament Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMedicament();
                return _instance;
            }
        }
        public Medicament Medicament { get; set; }
        public EventHandler<Medicament> Passed;
        protected virtual void OnEditClick()
        {
            Passed?.Invoke(this, Medicament);
        }
        public ucMedicament()
        {
            InitializeComponent();
        }

        private void mAdd_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucMedicamentAddForm"))
            {
                ucMedicamentAddForm uc = new ucMedicamentAddForm();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucMedicamentAddForm"].BringToFront();
        }

        private void mEdit_Click(object sender, EventArgs e)
        {
            Medicament = frmMain.Instance.Medicament.GetOneMedicamentById(int.Parse(medicamentGrid.SelectedRows[0].Cells[0].Value.ToString()));
            if (Medicament == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Le medicament n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucMedicamentEditForm"))
            {
                ucMedicamentEditForm uc = new ucMedicamentEditForm();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            OnEditClick();
            frmMain.Instance.mainContainer.Controls["ucMedicamentEditForm"].BringToFront();
        }

        private void ucMedicament_Load(object sender, EventArgs e)
        {
            _instance = this;
            mEdit.Enabled = false;
            mChercher.Enabled = false;
            mDelete.Enabled = false;
            Actualiser();
        }
        public void Actualiser()
        {
            List<Medicament> data = frmMain.Instance.Medicament.GetAll().ToList();
            if(data.Count() > 0)
            {
                mEdit.Enabled = true;
                mChercher.Enabled = true;
                mDelete.Enabled = true;
            }
            medicamentGrid.Rows.Clear();
            foreach (Medicament f in data)
            {
                medicamentGrid.Rows.Add(f.CodeMedicament, f.LibelleMedicament,f.Prix, frmMain.Instance.Famille.GetOneFamilleById(f.CodeFamille).Designation);
            }
        }

        private void mChercher_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucMedicamentSearch"))
            {
                ucMedicamentSearch uc = new ucMedicamentSearch();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucMedicamentSearch"].BringToFront();
        }

        private void mDelete_Click(object sender, EventArgs e)
        {
            Medicament = frmMain.Instance.Medicament.GetOneMedicamentById(int.Parse(medicamentGrid.SelectedRows[0].Cells[0].Value.ToString()));
            if (Medicament == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Le medicament n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous vraiment supprimer le medicament " + Medicament.LibelleMedicament + " ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Medicament = frmMain.Instance.Medicament.DeleteMedicament(Medicament, frmMain.Instance.Session);
                if (Medicament == null)
                    MetroFramework.MetroMessageBox.Show(this, "Le medicament a ete supprimmer avec succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "Le medicament n'a pas ete supprimmer avec succes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Actualiser();
            }
        }
    }
    
}
