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
    public partial class ucVenteAddForm : MetroFramework.Controls.MetroUserControl
    {
        private decimal prix;
        public EventHandler<Dictionary<string, decimal>> LoadDash;
        public Stock Stock { get; set; }
        private static ucVenteAddForm _instance;
        public static ucVenteAddForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucVenteAddForm();
                return _instance;
            }
        }
        
        public ucVenteAddForm()
        {
            Stock = null;
            ucMedicamentAddForm.Instance.DataLoad += this.OnAddMedicament;
            InitializeComponent();
        }
        public virtual void OnAdd()
        {
            LoadDash?.Invoke(this,frmMain.Instance.Vente.GetMontantPerDate());
        }
        private void quantityTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            quantityCounterLabel.Text = quantityTrackBar.Value.ToString();
            decimal montant = prix * quantityTrackBar.Value;
            PrixTextBox.Text = montant.ToString();
        }
        public void OnAddMedicament(object source, IEnumerable<Medicament> e)
        {
            LoadData(e.ToList());
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (medicamentComboBox.Text.Equals(""))
                return;
            LoadStock(frmMain.Instance.Medicament.GetMedicamentByLibelle(medicamentComboBox.Text));
            
        }

        private void ucVenteAddForm_Load(object sender, EventArgs e)
        {
            quantityTrackBar.Value = 1;
            quantityTrackBar.Enabled = false;
            btnAddVente.Enabled = false;
            PrixTextBox.Enabled = false;
            quantityCounterLabel.Text = quantityTrackBar.Value.ToString();
            LoadData(frmMain.Instance.Medicament.GetAll().ToList());
        }
        public void LoadData(List<Medicament> data)
        {
            foreach (Medicament m in data)
            {
                medicamentComboBox.Items.Add(m.LibelleMedicament);
            }

        }

        private void btnAddVente_Click(object sender, EventArgs e)
        {
            if (Stock == null)
                return;
            Vente v = new Vente
            {
                MontantVente = decimal.Parse(PrixTextBox.Text),
                DateVente = DateTime.Now
            };
            
            if ((v = frmMain.Instance.Vente.AddVente(v,frmMain.Instance.Session)) != null)
            {
                Medicament m = frmMain.Instance.Medicament.GetMedicamentByLibelle(medicamentComboBox.Text);
                if (m != null)
                {
                    VenteMedi vm = new VenteMedi
                    {
                        NumVente = v.NumVente,
                        CodeMedicament = m.CodeMedicament,
                        QuantiteMedicament = quantityTrackBar.Value
                    };
                    if ((vm = frmMain.Instance.VenteMedi.AddVenteMedi(vm, Stock, frmMain.Instance.Session)) != null)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "La vente a ete ajouter", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucVente"))
                        {
                            ucVente uc = new ucVente();
                            uc.Dock = DockStyle.Fill;
                            frmMain.Instance.mainContainer.Controls.Add(uc);
                        }
                        
                        medicamentComboBox.Items.Clear();
                        stockComboBox.Items.Clear();
                        quantityTrackBar.Value = 1;
                        quantityTrackBar.Enabled = false;
                        btnAddVente.Enabled = false;
                        PrixTextBox.Enabled = false;
                        frmMain.Instance.BtnBack.Visible = true;
                        frmMain.Instance.mainContainer.Controls["ucVente"].BringToFront();
                        ucVente.Instance.Actualiser(frmMain.Instance.VenteMedi.GetAll().ToList());
                        LoadData(frmMain.Instance.Medicament.GetAll().ToList());
                        OnAdd();
                    }
                }
                
            }else
                MetroFramework.MetroMessageBox.Show(this, "Vente null", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void LoadStock(Medicament m)
        {
            List<StockMedi> data =  frmMain.Instance.StockMedi.GetStockMediByMedicament(m).ToList();
            
            stockComboBox.Items.Clear();
            foreach (StockMedi s in data)
            {
                stockComboBox.Items.Add(s.NumStock);
            }
        }

        private void btnCancelVente_Click(object sender, EventArgs e)
        {

        }

        private void stockComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stockComboBox.Text.Equals(""))
                return;
            Stock = frmMain.Instance.Stock.GetOneStockById(int.Parse(stockComboBox.Text));
            if(frmMain.Instance.StockMedi.GetOneStockMediById(Stock.NumStock,frmMain.Instance.Medicament.GetMedicamentByLibelle(medicamentComboBox.Text).CodeMedicament).QuantiteMedicament <= 0)
            {
                MetroFramework.MetroMessageBox.Show(this,"Pas de medicament dans ce stock","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                medicamentComboBox.Focus();
                return;
            }
            quantityTrackBar.Enabled = true;
            btnAddVente.Enabled = true;
            prix = frmMain.Instance.Medicament.GetMedicamentByLibelle(medicamentComboBox.Text).Prix;
            quantityTrackBar.Maximum = frmMain.Instance.StockMedi.GetQuantityByStock(frmMain.Instance.Medicament.GetMedicamentByLibelle(medicamentComboBox.Text),Stock);
        }
    }
}
