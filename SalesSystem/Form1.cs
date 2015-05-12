using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (FrmLogin.LoginUser == null)
            {
                FrmLogin frm = new FrmLogin();
                frm.ShowDialog();
                //DisableMenu();
                if (frm.DialogResult == DialogResult.OK)
                {
                    //EnableMenu();
                    lblLogUser.Text = FrmLogin.LoginUser.UserFullName;
                }
            }
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmUserList")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                FrmUserList frm = new FrmUserList();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void userProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmUserProfile")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                FrmUserProfile frm = new FrmUserProfile();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void categoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmCategoryList")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                FrmCategoryList frm = new FrmCategoryList();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void brandListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmBrandList")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                FrmBrandList frm = new FrmBrandList();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmItemList")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (isOpen == false)
            {
                FrmItemList frm = new FrmItemList();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
