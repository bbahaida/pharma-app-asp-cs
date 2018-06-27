using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;

namespace PharmaGUI.Controllers
{
    public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
    {
        private static ucDashboard _instance;
        Dictionary<string, decimal> data;

        public static ucDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDashboard();
                return _instance;
            }
        }
        public ucDashboard()
        {
            ucVenteAddForm.Instance.LoadDash += this.OnAddVente;
            data = frmMain.Instance.Vente.GetMontantPerDate();
            InitializeComponent();
        }
        public void OnAddVente(object source, Dictionary<string,decimal> e)
        {
            data = e;
            Actualiser();
        }
        private void metroTile1_Click(object sender, EventArgs e)
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

        private void stockController_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucStock"))
            {
                ucStock uc = new ucStock();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucStock"].BringToFront();
        }

        private void venteController_Click(object sender, EventArgs e)
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

        private void userController_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.mainContainer.Controls.ContainsKey("ucUser"))
            {
                ucUser uc = new ucUser();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.mainContainer.Controls.Add(uc);
            }
            frmMain.Instance.BtnBack.Visible = true;
            frmMain.Instance.mainContainer.Controls["ucUser"].BringToFront();
        }

        private void medicamentController_Click(object sender, EventArgs e)
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
        public void Actualiser()
        {
            DashboardChart.Series.Clear();
            DashboardChart.AxisX.Clear();
            DashboardChart.AxisY.Clear();
            DashboardChart.BackColor = Color.White;
            LineSeries col = new LineSeries { Stroke = System.Windows.Media.Brushes.Green, DataLabels = true, Values = new ChartValues<int>(), LabelPoint = p => p.Y.ToString() };
            Axis ax = new Axis { Separator = new Separator { Step = 1, IsEnabled = false } };
            ax.Labels = new List<string>();
            foreach (var x in data)
            {
                col.Values.Add((int)Math.Ceiling(x.Value));
                ax.Labels.Add(x.Key);

            }

            DashboardChart.Series.Add(col);
            DashboardChart.AxisX.Add(ax);
            DashboardChart.AxisY.Add(new Axis
            {
                LabelFormatter = v => v.ToString(),
                Separator = new Separator()
            });
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            _instance = this;
            Actualiser();
        }

        private void btnRefrech_Click(object sender, EventArgs e)
        {
            Actualiser();
        }
    }
}
