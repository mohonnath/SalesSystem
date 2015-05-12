using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SS.Collection;
using SS.DataAccess;

namespace SS.Action
{
    public static class ItemAction
    {
        public static bool Insert(Item ob)
        {
            bool IsDone = false;
            ob.ItemCode = AutoGenerateAction.GenerateAutoNumber("Item");
            String sql = "INSERT INTO item(item_code,item_name,cat_id,brand_id,item_desc,purchase_price,sales_price,minimum_stock_qty,entry_user_id,entry_time,update_user_id,update_time) " +
                        " VALUES (@item_code,@item_name,@cat_id,@brand_id,@item_desc,@purchase_price,@sales_price,@minimum_stock_qty,@entry_user_id,@entry_time,@update_user_id,@update_time)";

            OleDbParameter[] param = new OleDbParameter[12];
            param[0] = new OleDbParameter("@item_code", ob.ItemCode);
            param[1] = new OleDbParameter("@item_name", ob.ItemName);
            param[2] = new OleDbParameter("@cat_id", ob.ItemCategory.CategoryID);
            param[3] = new OleDbParameter("@brand_id", ob.ItemBrand.BrandID);
            param[4] = new OleDbParameter("@item_desc", ob.ItemDescription);
            param[5] = new OleDbParameter("@purchase_price", ob.PurchasePrice);
            param[6] = new OleDbParameter("@sales_price", ob.SalesPrice);
            param[7] = new OleDbParameter("@minimum_stock_qty", ob.MinimumStockQty);
            param[8] = new OleDbParameter("@entry_user_id", ob.EntryUser.UserID);
            param[9] = new OleDbParameter("@entry_time", ob.EntryTime);
            param[10] = new OleDbParameter("@update_user_id", ob.UpdateUser.UserID);
            param[11] = new OleDbParameter("@update_time", ob.UpdateTime);

            IsDone = (DatabaseHelper.ExecuteNonQuery(sql, param) > 0) ? true : false;
            return IsDone;
        }

        public static List<Item> GetAll(String ItemCode, String ItemName, String CategoryName, String BrandName)
        {
            ItemCode = "%" + ItemCode + "%";
            ItemName = "%" + ItemName + "%";
            CategoryName = "%" + CategoryName + "%";
            BrandName = "%" + BrandName + "%";
            List<Item> ItemList = new List<Item>();

            String sql = "SELECT item.id, item.item_code, item.item_name, item.cat_id, category.cat_name, item.brand_id, brand.brand_name, item.item_desc, item.purchase_price, item.sales_price, item.minimum_stock_qty " +
                        " FROM (item INNER JOIN category ON item.cat_id = category.cat_id) INNER JOIN brand ON item.brand_id = brand.brand_id " +
                        " WHERE item.item_code LIKE @item_code AND item.item_name LIKE @item_name AND category.cat_name LIKE @cat_name AND brand.brand_name LIKE @brand_name ORDER BY item.item_name";
            OleDbParameter[] param = new OleDbParameter[4];
            param[0] = new OleDbParameter("@item_code", ItemCode);
            param[1] = new OleDbParameter("@item_name", ItemName);
            param[2] = new OleDbParameter("@cat_name", CategoryName);
            param[3] = new OleDbParameter("@brand_name", BrandName);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Item ob = new Item();
                ob.ItemCode = dr["item_code"].ToString();
                ob.ItemName = dr["item_name"].ToString();
                ob.PurchasePrice = Convert.ToDouble(dr["purchase_price"]);
                ob.SalesPrice = Convert.ToDouble(dr["sales_price"]);
                ob.MinimumStockQty = Convert.ToDouble(dr["minimum_stock_qty"]);

                Category cat = new Category();
                cat.CategoryID = Convert.ToInt32(dr["cat_id"]);
                cat.CategoryName = dr["cat_name"].ToString();
                ob.ItemCategory = cat;

                Brand brd = new Brand();
                brd.BrandID = Convert.ToInt32(dr["brand_id"]);
                brd.BrandName = dr["brand_name"].ToString();
                ob.ItemBrand = brd;

                ItemList.Add(ob);

            }

            return ItemList;
        }

        public static Item Get(string ItemCode)
        {
            Item ob = new Item();
            String sql = "SELECT item.id, item.item_code, item.item_name, item.cat_id, category.cat_name, item.brand_id, brand.brand_name, item.item_desc, item.purchase_price, item.sales_price, item.minimum_stock_qty " +
                        " FROM (item INNER JOIN category ON item.cat_id = category.cat_id) INNER JOIN brand ON item.brand_id = brand.brand_id " +
                        " WHERE item.item_code = @item_code";
            OleDbParameter[] param = new OleDbParameter[1];
            param[0] = new OleDbParameter("@item_code", ItemCode);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql,param);
            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                ob.ItemCode = dr["item_code"].ToString();
                ob.ItemName = dr["item_name"].ToString();
                ob.PurchasePrice = Convert.ToDouble(dr["purchase_price"]);
                ob.SalesPrice = Convert.ToDouble(dr["sales_price"]);
                ob.MinimumStockQty = Convert.ToDouble(dr["minimum_stock_qty"]);

                Category cat = new Category();
                cat.CategoryID = Convert.ToInt32(dr["cat_id"]);
                cat.CategoryName = dr["cat_name"].ToString();
                ob.ItemCategory = cat;

                Brand brd = new Brand();
                brd.BrandID = Convert.ToInt32(dr["brand_id"]);
                brd.BrandName = dr["brand_name"].ToString();
                ob.ItemBrand = brd;
            }

            return ob;
        }

        public static bool Update(Item ob)
        {
            bool IsDone = false;
            String sql = "UPDATE Item SET item_name = @item_name, cat_id=@cat_id, brand_id=@brand_id,purchase_price=@purchase_price, sales_price=@sales_price,minimum_stock_qty=@minimum_stock_qty,update_user_id=@update_user_id,update_time=@update_time WHERE item_code=@item_code";
            OleDbParameter[] param = new OleDbParameter[9];
            param[0] = new OleDbParameter("@item_name", ob.ItemName);
            param[1] = new OleDbParameter("@cat_id", ob.ItemCategory.CategoryID);
            param[2] = new OleDbParameter("@brand_id", ob.ItemBrand.BrandID);
            param[3] = new OleDbParameter("@purchase_price", ob.PurchasePrice);
            param[4] = new OleDbParameter("@sales_price", ob.SalesPrice);
            param[5] = new OleDbParameter("@minimum_stock_qty", ob.MinimumStockQty);
            param[6] = new OleDbParameter("@update_user_id", ob.UpdateUser.UserID);
            param[7] = new OleDbParameter("@update_time", ob.UpdateTime);
            param[8] = new OleDbParameter("@item_code", ob.ItemCode);

            IsDone = (DatabaseHelper.ExecuteNonQuery(sql, param) > 0) ? true : false;

            return IsDone;
        }
    }
}
