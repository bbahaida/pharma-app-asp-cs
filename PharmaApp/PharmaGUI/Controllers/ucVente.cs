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
    public partial class ucVente : MetroFramework.Controls.MetroUserControl
    {
        public ucVente()
        {
            InitializeComponent();
            Actualiser(frmMain.Instance.VenteMedi.GetAll().ToList());
        }
        private static ucVente _instance;
        public static ucVente Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucVente();
                return _instance;
            }
        }

        private void mAdd_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucVenteAddForm"))
            {
                ucVenteAddForm uc = new ucVenteAddForm();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucVenteAddForm"].BringToFront();
        }

        public void Actualiser(List<VenteMedi> data)
        {
            venteGrid.Rows.Clear();
            if (data.Count > 0)
            {
                mDelete.Enabled = true;
                mChercher.Enabled = true;
            }
            else
            {
                mDelete.Enabled = false;
                mChercher.Enabled = false;
            }
            
            foreach (VenteMedi v in data)
            {
                venteGrid.Rows.Add(v.NumVente,frmMain.Instance.Medicament.GetOneMedicamentById(v.CodeMedicament).LibelleMedicament, frmMain.Instance.Medicament.GetOneMedicamentById(v.CodeMedicament).Prix,v.QuantiteMedicament, frmMain.Instance.Vente.GetOneVenteById(v.NumVente).MontantVente);
            }
        }

        private void ucVente_Load(object sender, EventArgs e)
        {
            Actualiser(frmMain.Instance.VenteMedi.GetAll().ToList());
        }

        private void mDelete_Click(object sender, EventArgs e)
        {
            Vente v = frmMain.Instance.Vente.GetOneVenteById(int.Parse(venteGrid.SelectedRows[0].Cells[0].Value.ToString()));
            if (v == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "La vente n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous vraiment supprimer la vente " + v.NumVente + " ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                v = frmMain.Instance.Vente.DeleteVente(v, frmMain.Instance.Session);
                if (v == null)
                    MetroFramework.MetroMessageBox.Show(this, "La vente a ete supprimmer avec succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroFramework.MetroMessageBox.Show(this, "La vente n'a pas ete supprimmer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Actualiser(frmMain.Instance.VenteMedi.GetAll().ToList());
            }
        }

        private void mChercher_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucVenteSearch"))
            {
                ucVenteSearch uc = new ucVenteSearch();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucVenteSearch"].BringToFront();
        }
    }
}
