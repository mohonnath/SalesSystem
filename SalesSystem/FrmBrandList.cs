using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SS.Action;
using SS.Collection;

namespace SalesSystem
{
    public partial class FrmBrandList : Form
    {
        public FrmBrandList()
        {
            InitializeComponent();
            LoadBrands();
        }

        public void LoadBrands()
        {
            List<Brand> BrandList = BrandAction.GetAll(txtBrandName.Text);
            grdBrand.DataSource = null;
            grdBrand.AutoGenerateColumns = false;
            grdBrand.DataSource = BrandList;
            grdBrand.Refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmBrandNew")
                {
                    isOpen = true;
                    f.Close();
                    break;
                }
            }

            FrmBrandNew frm = new FrmBrandNew(this);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DataGridViewRow gr = grdBrand.SelectedRows[0];
            //String FabricCode = gr.Cells[0].Value.ToString();

            Brand ob = (Brand)gr.DataBoundItem;

            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmBrandNew")
                {
                    isOpen = true;
                    f.Close();
                    break;
                }
            }

            FrmBrandNew frm = new FrmBrandNew(ob.BrandID, this);
            frm.Show();
        }

        private void grdBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNumber = e.RowIndex;
            List<Brand> BrandList = (List<Brand>)grdBrand.DataSource;

            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmBrandNew")
                {
                    isOpen = true;
                    f.Close();
                    break;
                }
            }

            FrmBrandNew frm = new FrmBrandNew(BrandList[RowNumber].BrandID, this);
            frm.Show();
        }
    }
}
