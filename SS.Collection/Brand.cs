using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SS.Collection
{
    public class Brand
    {
        public int BrandID { get; set; }
        public String BrandName { get; set; }
        public String BrandDescription { get; set; }
        public int BrandStatus { get; set; }

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
