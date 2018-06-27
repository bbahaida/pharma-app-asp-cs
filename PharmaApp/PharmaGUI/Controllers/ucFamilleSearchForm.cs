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
    public partial class ucFamilleSearchForm : MetroFramework.Controls.MetroUserControl
    {
        public ucFamilleSearchForm()
        {
            InitializeComponent();
        }
          public void Actualiser()
        {
            List<Famille> data = frmMain.Instance.Famille.GetAll().ToList();
            familleGrid.Rows.Clear();
            
            foreach (Famille f in data)
            {
                familleGrid.Rows.Add(f.CodeFamille, f.Designation);
            }
        }
        private void ucFamilleSearchForm_Load(object sender, EventArgs e)
        {
            filterComboBox.Items.Add("Code");
            filterComboBox.Items.Add("Designation");
            btnGo.Enabled = false;
            searchTextBox.Visible = false;
            Actualiser();
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

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Equals(""))
            {
                Actualiser();
                return;
            }
            if (filterComboBox.Text.Equals("Code"))
            {
                familleGrid.Rows.Clear();
                Famille f = frmMain.Instance.Famille.GetOneFamilleById(int.Parse(searchTextBox.Text));
                if (f == null)
                {
                    return;
                }
                familleGrid.Rows.Add(f.CodeFamille, f.Designation);
            }
            else if (filterComboBox.Text.Equals("Designation"))
            {
                List<Famille> data = frmMain.Instance.Famille.GetFamilleByMC(filterComboBox.Text).ToList();

                familleGrid.Rows.Clear();
                foreach (Famille f in data)
                {
                    familleGrid.Rows.Add(f.CodeFamille, f.Designation);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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
    }
}
