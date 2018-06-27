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
    public partial class ucMedicamentSearch : MetroFramework.Controls.MetroUserControl
    {

        private static ucMedicamentSearch _instance;

        public static ucMedicamentSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMedicamentSearch();
                return _instance;
            }
        }
        
        public ucMedicamentSearch()
        {
            InitializeComponent();
        }

        
        
        private void ucMedicament_Load(object sender, EventArgs e)
        {
            _instance = this;
            Actualiser();
            btnGo.Enabled = false;
            searchTextBox.Visible = false;
            filterComboBox.Items.Add("code");
            filterComboBox.Items.Add("libelle");
            filterComboBox.Items.Add("prix");
            filterComboBox.Items.Add("famille");
        }
        public void Actualiser()
        {
            List<Medicament> data = frmMain.Instance.Medicament.GetAll().ToList();
            
            medicamentGrid.Rows.Clear();
            foreach (Medicament f in data)
            {
                medicamentGrid.Rows.Add(f.CodeMedicament, f.LibelleMedicament,f.Prix, frmMain.Instance.Famille.GetOneFamilleById(f.CodeFamille).Designation);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Equals(""))
            {
                Actualiser();
                return;
            }
            if (filterComboBox.Text.Equals("code"))
            {
                medicamentGrid.Rows.Clear();
                Medicament f = frmMain.Instance.Medicament.GetOneMedicamentById(int.Parse(searchTextBox.Text));
                if(f == null)
                {
                    return;
                }
                medicamentGrid.Rows.Add(f.CodeMedicament, f.LibelleMedicament, f.Prix, frmMain.Instance.Famille.GetOneFamilleById(f.CodeFamille).Designation);
            }
            else if (filterComboBox.Text.Equals("libelle"))
            {
                List<Medicament> data = frmMain.Instance.Medicament.GetMedicamentByMC(filterComboBox.Text).ToList();

                medicamentGrid.Rows.Clear();
                foreach (Medicament f in data)
                {
                    medicamentGrid.Rows.Add(f.CodeMedicament, f.LibelleMedicament, f.Prix, frmMain.Instance.Famille.GetOneFamilleById(f.CodeFamille).Designation);
                }
            }
            else if (filterComboBox.Text.Equals("prix"))
            {
                List<Medicament> data = frmMain.Instance.Medicament.GetAll().Where(m => m.Prix < decimal.Parse(searchTextBox.Text)).ToList();

                medicamentGrid.Rows.Clear();
                foreach (Medicament f in data)
                {
                    medicamentGrid.Rows.Add(f.CodeMedicament, f.LibelleMedicament, f.Prix, frmMain.Instance.Famille.GetOneFamilleById(f.CodeFamille).Designation);
                }
            }
            else if (filterComboBox.Text.Equals("famille"))
            {
                
                List<Medicament> data = frmMain.Instance.Medicament.GetAll().ToList();

                medicamentGrid.Rows.Clear();
                foreach (Medicament f in data)
                {
                    if (frmMain.Instance.Famille.GetOneFamilleById(f.CodeFamille).Designation.ToUpper().StartsWith(searchTextBox.Text.ToUpper()))
                    {
                        medicamentGrid.Rows.Add(f.CodeMedicament, f.LibelleMedicament, f.Prix, frmMain.Instance.Famille.GetOneFamilleById(f.CodeFamille).Designation);
                    }
                    
                }
            }
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!filterComboBox.Text.Equals(""))
            {
                btnGo.Enabled = true;
                searchTextBox.Visible = true;
            }
            else
            {
                btnGo.Enabled = false;
                searchTextBox.Visible = false;
            }
                
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucMedicament"))
            {
                ucMedicament uc = new ucMedicament();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucMedicament"].BringToFront();
        }
    }
    
}
