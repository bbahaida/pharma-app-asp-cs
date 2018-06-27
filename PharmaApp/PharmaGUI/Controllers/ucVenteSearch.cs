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
    public partial class ucVenteSearch : MetroFramework.Controls.MetroUserControl
    {
        public ucVenteSearch()
        {
            InitializeComponent();
        }

        public void Actualiser()
        {
            List<VenteMedi> data = frmMain.Instance.VenteMedi.GetAll().ToList();
            
            venteGrid.Rows.Clear();
            foreach (VenteMedi f in data)
            {
                venteGrid.Rows.Add(f.NumVente, frmMain.Instance.Medicament.GetOneMedicamentById(f.CodeMedicament).LibelleMedicament, frmMain.Instance.Medicament.GetOneMedicamentById(f.CodeMedicament).Prix, f.QuantiteMedicament, frmMain.Instance.Vente.GetOneVenteById(f.NumVente).MontantVente);
            }
        }
        private void ucVenteSearch_Load(object sender, EventArgs e)
        {
            filterComboBox.Items.Add("Code");
            filterComboBox.Items.Add("Medicament");
            filterComboBox.Items.Add("Prix Unitaire");
            filterComboBox.Items.Add("Quantite");
            filterComboBox.Items.Add("Prix Total");
            btnGo.Enabled = false;
            searchTextBox.Visible = false;
            Actualiser();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterComboBox.Text.Equals(""))
            {
                btnGo.Enabled = false;
                searchTextBox.Visible = false;
            }
            else
            {
                btnGo.Enabled = true;
                searchTextBox.Visible = true;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Equals(""))
            {
                Actualiser();
                return;
            }
            if (filterComboBox.Text.Equals("Code"))
            {
                
            }
            else if (filterComboBox.Text.Equals("libelle"))
            {
                
            }
            else if (filterComboBox.Text.Equals("prix"))
            {
                
            }
            else if (filterComboBox.Text.Equals("famille"))
            {
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucVente"))
            {
                ucVente uc = new ucVente();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucVente"].BringToFront();
        }
    }
}
