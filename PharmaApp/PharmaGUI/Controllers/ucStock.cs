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
    public partial class ucStock : MetroFramework.Controls.MetroUserControl
    {
        private static ucStock _instance;
        public EventHandler<IEnumerable<Stock>> StockData;

        public virtual void OnAdd()
        {
            StockData?.Invoke(this,frmMain.Instance.Stock.GetAll());
        }
        public static ucStock Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucStock();
                return _instance;
            }
        }
        public ucStock()
        {
            InitializeComponent();
        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance.Stock.AddStock(new Stock { QuantiteMedicament = 0 },frmMain.Instance.Session) != null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Le stock a ete ajouter", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualiser();
                OnAdd();
                return;
            }
            MetroFramework.MetroMessageBox.Show(this, "Le stock n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeleteStock_Click(object sender, EventArgs e)
        {
            Stock s = frmMain.Instance.Stock.GetOneStockById(int.Parse(stockGrid.SelectedRows[0].Cells[0].Value.ToString()));
            if (s == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Le stock n'est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MetroFramework.MetroMessageBox.Show(this, "Voulez vous vraiment supprimer le stock " + s.NumStock + " ?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                s = frmMain.Instance.Stock.DeleteStock(s, frmMain.Instance.Session);
                if (s == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Le stock a ete supprimmer avec succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnAdd();
                }
                    
                else
                    MetroFramework.MetroMessageBox.Show(this, "Le stock n'a pas ete supprimmer avec succes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Actualiser();
            }
        }
        public void Actualiser()
        {
            List<Stock> data = frmMain.Instance.Stock.GetAll().ToList();
            stockGrid.Rows.Clear();
            foreach (Stock s in data)
            {
                stockGrid.Rows.Add(s.NumStock, s.QuantiteMedicament);
            }
        }
        private void ucStock_Load(object sender, EventArgs e)
        {
            _instance = this;
            Actualiser();
        }
    }
}
