using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SS.Collection
{
    public class Category
    {
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }
        public int CategoryStatus { get; set; }

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
