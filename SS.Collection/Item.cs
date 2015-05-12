using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SS.Collection
{
    public class Item
    {
        public String ItemCode { get; set; }
        public String ItemName { get; set; }
        public Category ItemCategory { get; set; }
        public Brand ItemBrand { get; set; }
        public String ItemDescription { get; set; }
        public Double PurchasePrice { get; set; }
        public Double SalesPrice { get; set; }
        public Double MinimumStockQty { get; set; }

        public User EntryUser { get; set; }
        public DateTime EntryTime { get; set; }
        public User UpdateUser { get; set; }
        public DateTime UpdateTime { get; set; }

        public String CategoryName
        {
            get
            {
                return ItemCategory.CategoryName;
            }
        }

        public String BrandName
        {
            get
            {
                return ItemBrand.BrandName;
            }
        }


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
