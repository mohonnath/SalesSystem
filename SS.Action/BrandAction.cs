using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SS.Collection;
using SS.DataAccess;

namespace SS.Action
{
    public static class BrandAction
    {
        public static bool Insert(Brand ob)
        {
            bool IsDone = false;
            String sql = "INSERT INTO brand (brand_name,entry_user_id,entry_time,update_user_id,update_time ) VALUES(@brand_name,@entry_user_id,@entry_time,@update_user_id,@update_time)";

            OleDbParameter[] param = new OleDbParameter[5];

            param[0] = new OleDbParameter("@brand_name", ob.BrandName);
            param[1] = new OleDbParameter("@entry_user_id", ob.EntryUser.UserID);
            param[2] = new OleDbParameter("@entry_time", ob.EntryTime);
            param[3] = new OleDbParameter("@update_user_id", ob.UpdateUser.UserID);
            param[4] = new OleDbParameter("@update_time", ob.UpdateTime);

            IsDone = (DatabaseHelper.ExecuteNonQuery(sql, param) > 0) ? true : false;
            return IsDone;
        }

        public static List<Brand> GetAll(String BrandName)
        {
            BrandName = "%" + BrandName + "%";
            List<Brand> BrandList = new List<Brand>();

            String sql = "SELECT * FROM brand WHERE brand_name like @brand_name";
            OleDbParameter[] param = new OleDbParameter[1];
            param[0] = new OleDbParameter("@brand_name", BrandName);
            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Brand brnd = new Brand();

                    brnd.BrandID = Convert.ToInt32(dr["brand_id"]);
                    brnd.BrandName = dr["brand_name"].ToString();

                    BrandList.Add(brnd);
                }
            }

            return BrandList;
        }


        public static Brand Get(int BrandID)
        {
            Brand ob = new Brand();

            String sql = "SELECT * FROM brand WHERE brand_id = @brand_id";
            OleDbParameter[] param = new OleDbParameter[1];
            param[0] = new OleDbParameter("@brand_id", BrandID);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];

                ob.BrandID = Convert.ToInt32(dr["brand_id"]);
                ob.BrandName = dr["brand_name"].ToString();

            }

            return ob;
        }

        public static bool Update(Brand ob)
        {
            bool IsDone = false;
            String sql = "UPDATE brand SET brand_name = @brand_name,update_user_id=@update_user_id,update_time=@update_time WHERE brand_id=@brand_id";
            OleDbParameter[] param = new OleDbParameter[4];
            param[0] = new OleDbParameter("@brand_name", ob.BrandName);
            param[1] = new OleDbParameter("@update_user_id", ob.UpdateUser.UserID);
            param[2] = new OleDbParameter("@update_time", ob.UpdateTime);
            param[3] = new OleDbParameter("@brand_id", ob.BrandID);

            IsDone = DatabaseHelper.ExecuteNonQuery(sql, param) > 0 ? true : false;

            return IsDone;
        }
    }
}
