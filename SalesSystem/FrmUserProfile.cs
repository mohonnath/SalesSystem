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
    public partial class FrmUserProfile : Form
    {
        List<UserProfile> UserProfileList;
        public FrmUserProfile()
        {
            InitializeComponent();
            LoadAllUser();
        }

        private void LoadAllUser()
        {
            List<User> UserList = UserAction.GetAll();

            cmbUser.DisplayMember = "UserFullName";
            cmbUser.ValueMember = "UserID";
            cmbUser.DataSource = UserList;
        }

        private void LoadTree()
        {
            treeView1.Nodes.Clear();
            Form1 frm = new Form1();
            foreach (ToolStripMenuItem mainMenu in frm.mnuMain.Items)
            {
                TreeNode tn = new TreeNode();
                String TnText = mainMenu.Text;
                tn.Text = TnText;
                treeView1.Nodes.Add(tn);

                if (mainMenu is ToolStripMenuItem)
                {
                    if (mainMenu.HasDropDownItems)
                    {
                        foreach (ToolStripItem subMenu in mainMenu.DropDownItems)
                        {
                            if (subMenu is ToolStripMenuItem)
                            {
                                TreeNode subTn = new TreeNode();
                                subTn.Text = subMenu.Text;
                                tn.Nodes.Add(subTn);
                                ToolStripMenuItem subMenu1 = (ToolStripMenuItem)subMenu;
                                foreach (ToolStripItem subsubMenu in subMenu1.DropDownItems)
                                {
                                    if (subsubMenu is ToolStripMenuItem)
                                    {
                                        TreeNode subsubTn = new TreeNode();
                                        subsubTn.Text = subsubMenu.Text;
                                        subTn.Nodes.Add(subsubTn);
                                    }
                                }
                            }
                        }

                    }
                }
            }

        }

        private void CheckUserAccess()
        {
            UserProfileList = UserProfileAction.GetAllByUser(Convert.ToInt32(cmbUser.SelectedValue));

            foreach (TreeNode tn in treeView1.Nodes)
            {
                CheckRecursive(tn);
            }
        }

        private void CheckRecursive(TreeNode treeNode)
        {
            foreach (UserProfile up in UserProfileList)
            {
                if (treeNode.Text == up.FormName)
                {
                    treeNode.Checked = true;
                    break;
                }
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                CheckRecursive(tn);
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTree();
            CheckUserAccess();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserProfileAction.DeleteUserProfile(Convert.ToInt32(cmbUser.SelectedValue));
            UserProfileList = new List<UserProfile>();
            foreach (TreeNode tn in treeView1.Nodes)
            {
                PrintRecursive(tn);
            }

            bool IsDone = UserProfileAction.InsertUserProfile(UserProfileList);

            if (IsDone)
            {
                MessageBox.Show("Successful");
            }
        }

        private void PrintRecursive(TreeNode treeNode)
        {
            if (treeNode.Checked)
            {
                UserProfile ob = new UserProfile();
                ob.UserID = Convert.ToInt32(cmbUser.SelectedValue);
                ob.FormName = treeNode.Text;
                UserProfileList.Add(ob);
            }
            // Call each node recursively.
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }
    }
}
