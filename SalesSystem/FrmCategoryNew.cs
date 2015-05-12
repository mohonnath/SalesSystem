using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SS.Collection;
using SS.Action;

namespace SalesSystem
{
    public partial class FrmCategoryNew : Form
    {
        bool IsUpdate = false;
        int CatId = 0;
        FrmCategoryList Lst;
        public FrmCategoryNew(FrmCategoryList lstFrm)
        {
            InitializeComponent();
            Lst = lstFrm;
        }
        
        public FrmCategoryNew(int PassID, FrmCategoryList lstFrm)
        {
            InitializeComponent();
            CatId = PassID;
            IsUpdate = true;
            Lst = lstFrm;
            LoadCategory(CatId);
        }

        private void LoadCategory(int CatID)
        {
            Category ob = CategoryAction.Get(CatID);
            txtCategoryName.Text = ob.CategoryName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text.Trim() != "")
            {
                bool IsDone = false;
                Category ob = new Category();
                ob.CategoryName = txtCategoryName.Text.Trim();
                ob.CategoryID = CatId;

                ob.EntryUser = FrmLogin.LoginUser;
                ob.EntryTime = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);
                ob.UpdateUser = FrmLogin.LoginUser;
                ob.UpdateTime = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);

                if (IsUpdate)
                {
                    IsDone = CategoryAction.Update(ob);                    
                }
                else
                {
                    IsDone = CategoryAction.Insert(ob);
                }
                if (IsDone)
                {                    
                    MessageBox.Show("Successful");
                    Lst.LoadCategories();
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
