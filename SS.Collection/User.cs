using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SS.Collection
{
    public class User
    {
        public int UserID { get; set; }
        public String UserLogin { get; set; }
        public String UserPassword { get; set; }
        public String UserFullName { get; set; }

        public String UserPasswordView
        {
            get
            {
                String pass = "";
                for (int i = 0; i < UserPassword.Length; i++)
                {
                    pass += "*";
                }
                return pass;
            }
        }
    }
}
