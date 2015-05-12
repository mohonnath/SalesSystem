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
    public partial class FrmUserList : Form
    {
        public FrmUserList()
        {
            InitializeComponent();
            LoadUsers();
        }

        public void LoadUsers()
        {
            List<User> UserList = UserAction.GetAll();
            grdUser.AutoGenerateColumns = false;
            grdUser.DataSource = UserList;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmUserNew")
                {
                    isOpen = true;
                    f.Close();
                    break;
                }
            }

            FrmUserNew frm = new FrmUserNew();
            frm.MdiParent = this.ParentForm;
            frm.Show();
        }
    }
}
