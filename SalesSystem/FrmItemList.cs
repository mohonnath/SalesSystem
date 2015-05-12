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
    public partial class FrmItemList : Form
    {
        public FrmItemList()
        {
            InitializeComponent();
            LoadItems();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmItemNew")
                {
                    isOpen = true;
                    f.Close();
                    break;
                }
            }

            FrmItemNew frm = new FrmItemNew(this);
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }

        public void LoadItems()
        {
            List<Item> ItemList = ItemAction.GetAll(txtItemCode.Text, txtItemName.Text, txtCategory.Text, txtBrand.Text);
            grdItem.DataSource = null;
            grdItem.AutoGenerateColumns = false;
            grdItem.DataSource = ItemList;
            grdItem.Refresh();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void txtItemCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadItems();
            }
        }

        private void grdItem_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Item> ItemList = ItemAction.GetAll(txtItemCode.Text, txtItemName.Text, txtCategory.Text, txtBrand.Text);
            if (e.ColumnIndex == 0)
            {
                ItemList = ItemList.OrderBy(o => o.ItemCode).ToList();
            }
            else if (e.ColumnIndex == 1)
            {
                ItemList = ItemList.OrderBy(o => o.ItemName).ToList();
            }
            else if (e.ColumnIndex == 2)
            {
                ItemList = ItemList.OrderBy(o => o.CategoryName).ToList();
            }
            else if (e.ColumnIndex == 3)
            {
                ItemList = ItemList.OrderBy(o => o.BrandName).ToList();
            }

            grdItem.DataSource = ItemList;
            grdItem.Refresh();
        }

        private void grdItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNumber = e.RowIndex;
            if (RowNumber >= 0)
            {
                List<Item> ItemList = (List<Item>)grdItem.DataSource;

                bool isOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "FrmPurchaseOrderNew")
                    {
                        isOpen = true;
                        f.Close();
                        break;
                    }
                }
                if (ItemList != null)
                {
                    FrmItemNew frm = new FrmItemNew(ItemList[RowNumber].ItemCode,this);
                    frm.MdiParent = this.ParentForm;
                    frm.Show();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow gr = grdItem.SelectedRows[0];
                String DocumentNo = gr.Cells[0].Value.ToString();

                bool isOpen = false;
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "FrmItemNew")
                    {
                        isOpen = true;
                        f.Close();
                        break;
                    }
                }

                FrmItemNew frm = new FrmItemNew(DocumentNo,this);
                frm.MdiParent = this.ParentForm;
                frm.Show();
            }
            catch { }
        }
    }
}
