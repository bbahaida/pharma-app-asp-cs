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
    public partial class ucMedicamentAddForm : MetroFramework.Controls.MetroUserControl
    {
        public EventHandler<IEnumerable<Medicament>> DataLoad;

        static int code;
        private List<Stock> Stocks;
        private List<Famille> Familles;
        private static ucMedicamentAddForm _instance;
        public static ucMedicamentAddForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucMedicamentAddForm();
                return _instance;
            }
        }
        public virtual void OnAdd()
        {
            DataLoad?.Invoke(this,frmMain.Instance.Medicament.GetAll());
        }
        
        public ucMedicamentAddForm()
        {
            ucFamilleAddForm.Instance.FamilleData += this.OnAddFamille;
            ucStock.Instance.StockData += this.OnAddStock;
            Familles = frmMain.Instance.Famille.GetAll().ToList();
            Stocks = frmMain.Instance.Stock.GetAll().ToList();
            
            InitializeComponent();
            
        }

        public void OnAddFamille(object sender, IEnumerable<Famille> e)
        {
            Familles = e.ToList();
            LoadData();
        }
        public void OnAddStock(object sender, IEnumerable<Stock> e)
        {
            Stocks = e.ToList();
            LoadData();
        }
        private void btnAddMedicament_Click(object sender, EventArgs e)
        {
            if (libelleTextBox.Text.Equals("") || prixTextBox.Text.Equals("") || quantityTextBox.Text.Equals("") || familleComboBox.Text.Equals("") || stockComboBox.Text.Equals(""))
                return;
            Medicament m = frmMain.Instance.Medicament.AddMedicament(
                new Medicament
                {
                    LibelleMedicament = libelleTextBox.Text,
                    Prix = decimal.Parse(prixTextBox.Text),
                    CodeFamille = frmMain.Instance.Famille.GetOneFamilleByDesignation(familleComboBox.Text).CodeFamille
                }
                ,frmMain.Instance.Session);
            if(m != null)
            {
                StockMedi sm = frmMain.Instance.StockMedi.AddStockMedi(
                    new StockMedi
                    {
                    CodeMedicament = m.CodeMedicament,
                    NumStock = int.Parse(stockComboBox.Text),
                    QuantiteMedicament = int.Parse(quantityTextBox.Text)
                    },
                    frmMain.Instance.Session);
                if(sm != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Le medicament a ete ajouter", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnAdd();
                    code++;
                    codeTextBox.Text = code.ToString();
                    libelleTextBox.Clear();
                    prixTextBox.Clear();
                    quantityTextBox.Clear();
                    if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucMedicament"))
                    {
                        ucMedicament uc = new ucMedicament();
                        uc.Dock = DockStyle.Fill;
                        frmMain.Instance.mainContainer.Controls.Add(uc);
                    }
                    frmMain.Instance.BtnBack.Visible = true;
                    frmMain.Instance.mainContainer.Controls["ucMedicament"].BringToFront();
                    ucMedicament.Instance.Actualiser();
                    ucStock.Instance.Actualiser();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Le medicament n'a pas ete ajouter", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
        public void LoadData()
        {
            foreach (Famille f in Familles)
            {
                familleComboBox.Items.Add(f.Designation);
            }
            foreach (Stock s in Stocks)
            {
                stockComboBox.Items.Add(s.NumStock);
            }
            

        }

        private void ucMedicamentAddForm_Load(object sender, EventArgs e)
        {
            code = frmMain.Instance.Medicament.GetAll().Count() == 0 ? 1 : frmMain.Instance.Medicament.GetAll().Last().CodeMedicament + 1;
            codeTextBox.Text = code.ToString();
            LoadData();
        }
    }

}
