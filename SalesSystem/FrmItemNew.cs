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
    public partial class FrmItemNew : Form
    {
        bool IsUpdate = false;
        String ItemCode = "";
        FrmItemList Lst;
        public FrmItemNew(FrmItemList lstFrm)
        {
            InitializeComponent();
            Lst = lstFrm;

            LoadCategories();
            LoadBrands();
            txtItemCode.Text = AutoGenerateAction.GenerateAutoNumber("Item");
        }

        public FrmItemNew(String passCode, FrmItemList lstFrm)
        {
            InitializeComponent();
            Lst = lstFrm;
            ItemCode = passCode;
            LoadCategories();
            LoadBrands();
            txtItemCode.Text = passCode;
            IsUpdate = true;
            LoadItem();
        }

        private void LoadItem()
        {
            Item ob = ItemAction.Get(ItemCode);
            txtItemName.Text = ob.ItemName;
            txtPurchasePrice.Text = ob.PurchasePrice.ToString();
            txtSalesPrice.Text = ob.SalesPrice.ToString();
            txtMinimumStock.Text = ob.MinimumStockQty.ToString();

            List<Category> Categorylist = (List<Category>)cmbCategory.DataSource;
            for (int i = 0; i < Categorylist.Count; i++)
            {
                if (Categorylist[i].CategoryID == ob.ItemCategory.CategoryID)
                {
                    cmbCategory.SelectedIndex = i;
                    break;
                }
            }

            List<Brand> Brandlist = (List<Brand>)cmbBrand.DataSource;
            for (int i = 0; i < Brandlist.Count; i++)
            {
                if (Brandlist[i].BrandID == ob.ItemBrand.BrandID)
                {
                    cmbBrand.SelectedIndex = i;
                    break;
                }
            }
            
        }

        private void LoadCategories()
        {
            List<Category> CategoryList = CategoryAction.GetAll("");
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = CategoryList;
        }

        private void LoadBrands()
        {
            List<Brand> BrandList = BrandAction.GetAll("");
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandID";
            cmbBrand.DataSource = BrandList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text != "")
            {
                bool IsDone = false;
                Item ob = new Item();
                ob.ItemCode = txtItemCode.Text;
                ob.ItemName = txtItemName.Text;
                ob.ItemDescription = "";

                Category cat = (Category)cmbCategory.SelectedItem;
                ob.ItemCategory = cat;

                Brand brd = (Brand)cmbBrand.SelectedItem;
                ob.ItemBrand = brd;

                try
                {
                    ob.PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
                }
                catch { }

                try
                {
                    ob.SalesPrice = Convert.ToDouble(txtSalesPrice.Text);
                }
                catch { }

                try
                {
                    ob.MinimumStockQty = Convert.ToDouble(txtMinimumStock.Text);
                }
                catch { }

                ob.EntryUser = FrmLogin.LoginUser;
                ob.EntryTime = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);
                ob.UpdateUser = FrmLogin.LoginUser;
                ob.UpdateTime = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);

                if (IsUpdate)
                {
                    IsDone = ItemAction.Update(ob);
                }
                else
                {
                    IsDone = ItemAction.Insert(ob);
                    if (IsDone)
                    {
                        AutoGenerateAction.IncreaseAutoNumber("Item");
                    }
                }
                if (IsDone)
                {                    
                    MessageBox.Show("Successful");

                    int ScrolPosition = Lst.grdItem.FirstDisplayedScrollingRowIndex;

                    Lst.LoadItems();
                    Lst.grdItem.FirstDisplayedScrollingRowIndex = ScrolPosition;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operation Failed", "Warning!!!");
                }

            }
        }


    }
}
