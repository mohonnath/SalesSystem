using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SS.Collection;
using SS.DataAccess;

namespace SS.Action
{
    public static class CategoryAction
    {
        public static bool Insert(Category ob)
        {
            bool IsDone = false;
            String sql = "INSERT INTO category (cat_name,entry_user_id,entry_time,update_user_id,update_time ) VALUES(@cat_name,@entry_user_id,@entry_time,@update_user_id,@update_time)";

            OleDbParameter[] param = new OleDbParameter[5];

            param[0] = new OleDbParameter("@cat_name", ob.CategoryName);
            param[1] = new OleDbParameter("@entry_user_id", ob.EntryUser.UserID);
            param[2] = new OleDbParameter("@entry_time", ob.EntryTime);
            param[3] = new OleDbParameter("@update_user_id", ob.UpdateUser.UserID);
            param[4] = new OleDbParameter("@update_time", ob.UpdateTime);

            IsDone = (DatabaseHelper.ExecuteNonQuery(sql, param) > 0) ? true : false;
            return IsDone;
        }

        public static List<Category> GetAll(String CategoryName)
        {
            CategoryName = "%" + CategoryName + "%";
            List<Category> CategoryList = new List<Category>();

            String sql = "SELECT * FROM category WHERE cat_name like @cat_name";
            OleDbParameter[] param = new OleDbParameter[1];
            param[0] = new OleDbParameter("@cat_name", CategoryName);
            DataSet ds = DatabaseHelper.ExecuteDataSet(sql,param);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Category cat = new Category();

                    cat.CategoryID = Convert.ToInt32(dr["cat_id"]);
                    cat.CategoryName = dr["cat_name"].ToString();
                    
                    CategoryList.Add(cat);
                }
            }

            return CategoryList;
        }


        public static Category Get(int CatID)
        {
            Category ob = new Category();

            String sql = "SELECT * FROM category WHERE cat_id = @cat_id";
            OleDbParameter[] param = new OleDbParameter[1];
            param[0] = new OleDbParameter("@cat_id", CatID);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                ob.CategoryID = Convert.ToInt32(dr["cat_id"]);
                ob.CategoryName = dr["cat_name"].ToString();
                
            }

            return ob;
        }

        public static bool Update(Category ob)
        {
            bool IsDone = false;
            String sql = "UPDATE category SET cat_name = @cat_name,update_user_id=@update_user_id,update_time=@update_time WHERE cat_id=@cat_id";
            OleDbParameter[] param = new OleDbParameter[4];
            param[0] = new OleDbParameter("@cat_name", ob.CategoryName);
            param[1] = new OleDbParameter("@update_user_id", ob.UpdateUser.UserID);
            param[2] = new OleDbParameter("@update_time", ob.UpdateTime);
            param[3] = new OleDbParameter("@cat_id", ob.CategoryID);

            IsDone = DatabaseHelper.ExecuteNonQuery(sql, param) > 0 ? true : false;

            return IsDone;
        }
    }
}
