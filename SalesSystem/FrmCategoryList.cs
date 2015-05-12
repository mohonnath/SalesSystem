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
    public partial class FrmCategoryList : Form
    {
        public FrmCategoryList()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmCategoryNew")
                {
                    isOpen = true;
                    f.Close();
                    break;
                }
            }

            FrmCategoryNew frm = new FrmCategoryNew(this);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }



        public void LoadCategories()
        {
            List<Category> CategoryList = CategoryAction.GetAll(txtCategoryName.Text);
            grdCategory.DataSource = null;
            grdCategory.AutoGenerateColumns = false;
            grdCategory.DataSource = CategoryList;
            grdCategory.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DataGridViewRow gr = grdCategory.SelectedRows[0];
            //String FabricCode = gr.Cells[0].Value.ToString();

            Category ob = (Category)gr.DataBoundItem;

            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmCategoryNew")
                {
                    isOpen = true;
                    f.Close();
                    break;
                }
            }

            FrmCategoryNew frm = new FrmCategoryNew(ob.CategoryID,this);                       
            frm.Show();
            
        }

        private void grdCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNumber = e.RowIndex;
            List<Category> CategoryList = (List<Category>)grdCategory.DataSource;

            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmCategoryNew")
                {
                    isOpen = true;
                    f.Close();
                    break;
                }
            }

            FrmCategoryNew frm = new FrmCategoryNew(CategoryList[RowNumber].CategoryID, this);
            frm.Show();
        }
    }
}
