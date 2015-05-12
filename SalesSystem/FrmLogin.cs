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
    public partial class FrmLogin : Form
    {
        public static User LoginUser = null;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void UserAuthentication()
        {
            if (!String.IsNullOrEmpty(TextID.Text.Trim()) && !String.IsNullOrEmpty(TextPassword.Text.Trim()))
            {
                LoginUser = UserAction.GetLoginManager(TextID.Text.Trim(), TextPassword.Text.Trim());
                if (LoginUser != null)
                {
                    LabelError.Visible = false;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    LabelError.Visible = true;
                    TextID.Text = "";
                    TextPassword.Text = "";
                    TextID.Focus();
                }
            }
            else
            {
                LabelError.Visible = true;
                TextID.Text = "";
                TextPassword.Text = "";
                TextID.Focus();
            }
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            UserAuthentication();
        }
    }
}
