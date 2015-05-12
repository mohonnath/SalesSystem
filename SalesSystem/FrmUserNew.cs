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
    public partial class FrmUserNew : Form
    {
        public FrmUserNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckError())
            {
                User ob = new User();
                ob.UserLogin = txtUserLogin.Text.Trim();
                ob.UserPassword = txtPassword.Text.Trim();
                ob.UserFullName = txtFullName.Text.Trim();

                if (UserAction.Insert(ob))
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "FrmUserList")
                        {
                            f.Close();
                            break;
                        }
                    }

                    FrmUserList frm = new FrmUserList();
                    frm.MdiParent = this.ParentForm;
                    frm.Show();

                    MessageBox.Show("Successfull");
                    this.Close();


                }
            }
        }


        private bool CheckError()
        {
            bool HasError = false;
            if (txtFullName.Text.Trim() == "")
            {
                err.SetError(txtFullName, "Cannot be empty");
                HasError = true;
            }
            if (txtUserLogin.Text.Trim() == "")
            {
                err.SetError(txtUserLogin, "Cannot be empty");
                HasError = true;
            }
            if (txtPassword.Text.Trim() == "")
            {
                err.SetError(txtPassword, "Cannot be empty");
                HasError = true;
            }
            return HasError;
        }

    }
}
