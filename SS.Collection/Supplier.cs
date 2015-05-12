using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SS.Collection
{
    public class Supplier
    {
        public String SupplierCode { get; set; }
        public String SupplierName { get; set; }
        public String ContactPerson { get; set; }
        public String SupplierAddress { get; set; }
        public String SupplierPhone { get; set; }

        public User EntryUser { get; set; }
        public DateTime EntryTime { get; set; }
        public User UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }

        public String EntryUserName
        {
            get
            {
                return EntryUser.UserFullName;
            }
        }

        public String UpdateUserName
        {
            get
            {
                return UpdateUser.UserFullName;
            }
        }
    }
}
