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
    public partial class ucMedicamentEditForm : MetroFramework.Controls.MetroUserControl
    {
        public ucMedicamentEditForm()
        {
            ucMedicament.Instance.Passed += this.OnEditClick;
            InitializeComponent();
        }
        public void OnEditClick(object source, Medicament e)
        {
            LoadData();
            codeTextBox.Text = e.CodeMedicament.ToString();
            libelleTextBox.Text = e.LibelleMedicament;
            prixTextBox.Text = e.Prix.ToString();

        }
        private void btnEditMedicament_Click(object sender, EventArgs e)
        {
            if (libelleTextBox.Text.Equals("") || prixTextBox.Text.Equals("") || quantityTextBox.Text.Equals("") || familleComboBox.Text.Equals("") || stockComboBox.Text.Equals(""))
            {
                MessageBox.Show("champ(s) vide(s)");
                return;
            }
            ucMedicament.Instance.Medicament.LibelleMedicament = libelleTextBox.Text;
            ucMedicament.Instance.Medicament.Prix = decimal.Parse(prixTextBox.Text);
            ucMedicament.Instance.Medicament.CodeFamille = frmMain.Instance.Famille.GetOneFamilleByDesignation(familleComboBox.Text).CodeFamille;
            if (frmMain.Instance.Medicament.EditMedicament(ucMedicament.Instance.Medicament, frmMain.Instance.Session) != null)
            {

                ucMedicament.Instance.Medicament = null;
                MessageBox.Show("Done");
                if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucMedicament"))
                {
                    ucMedicament uc = new ucMedicament();
                    uc.Dock = DockStyle.Fill;
                    frmMain.Instance.mainContainer.Controls.Add(uc);
                }
                frmMain.Instance.BtnBack.Visible = true;
                frmMain.Instance.mainContainer.Controls["ucMedicament"].BringToFront();
                ucMedicament.Instance.Actualiser();
            }
        }

        private void btnCancelMedicament_Click(object sender, EventArgs e)
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

        private void ucMedicamentEditForm_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadData()
        {
            List<Famille> Familles = frmMain.Instance.Famille.GetAll().ToList();
            List<Stock> Stocks = frmMain.Instance.Stock.GetAll().ToList();
            familleComboBox.Items.Clear();
            stockComboBox.Items.Clear();
            familleComboBox.Items.Add("");
            stockComboBox.Items.Add("");
            foreach (Famille f in Familles)
            {
                familleComboBox.Items.Add(f.Designation);
            }
            foreach (Stock s in Stocks)
            {
                stockComboBox.Items.Add(s.NumStock);
            }


        }
    }
}
