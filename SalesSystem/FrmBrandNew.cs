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
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace SalesSystem
{
    public partial class FrmBrandNew : Form
    {
        bool IsUpdate = false;
        int BrandId = 0;
        FrmBrandList Lst;

        public FrmBrandNew(FrmBrandList lstFrm)
        {
            InitializeComponent();
            Lst = lstFrm;
            label2.Text = GetMACAddress();
            label3.Text = GetMD5Hash("a");
            
        }

        public FrmBrandNew(int passID, FrmBrandList lstFrm)
        {
            InitializeComponent();
            Lst = lstFrm;
            BrandId = passID;
            IsUpdate = true;

            LoadBrand(BrandId);
        }


        private void LoadBrand(int BrandID)
        {
            Brand ob = BrandAction.Get(BrandID);
            txtBrandName.Text = ob.BrandName;
        }

        public static String GetMD5Hash(String TextToHash)
        {
            //Check wether data was passed
            if ((TextToHash == null) || (TextToHash.Length == 0))
            {
                return String.Empty;
            }

            //Calculate MD5 hash. This requires that the string is splitted into a byte[].
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);

            //Convert result back to string.
            return System.BitConverter.ToString(result);
        }

        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            } return sMacAddress;
        }

           

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBrandName.Text.Trim() != "")
            {
                bool IsDone = false;
                Brand ob = new Brand();
                ob.BrandName = txtBrandName.Text.Trim();
                ob.BrandID = BrandId;

                ob.EntryUser = FrmLogin.LoginUser;
                ob.EntryTime = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);
                ob.UpdateUser = FrmLogin.LoginUser;
                ob.UpdateTime = DateTime.Today.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);

                if (IsUpdate)
                {
                    IsDone = BrandAction.Update(ob);
                }
                else
                {
                    IsDone = BrandAction.Insert(ob);
                }
                if (IsDone)
                {
                    MessageBox.Show("Successful");
                    Lst.LoadBrands();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operation Failed", "Warning!!!");
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = GetMD5Hash(textBox1.Text);
        }
    }
}
