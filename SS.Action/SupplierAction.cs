using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SS.Collection;
using SS.DataAccess;

namespace SS.Action
{
    public static class SupplierAction
    {
        public static bool Insert(Supplier ob)
        {
            bool IsDone = false;
            String sql = "INSERT INTO supplier(supplier_code,supplier_name,contact_person,supplier_address,supplier_phone,entry_user_id,entry_time,update_user_id,update_time) " +
                        +" VALUES (@supplier_code,@supplier_name,@contact_person,@supplier_address,@supplier_phone,@entry_user_id,@entry_time,@update_user_id,@update_time)";

            OleDbParameter[] param = new OleDbParameter[9];
            param[0] = new OleDbParameter("@supplier_code", ob.SupplierCode);
            param[1] = new OleDbParameter("@supplier_name", ob.SupplierName);
            param[2] = new OleDbParameter("@contact_person", ob.ContactPerson);
            param[3] = new OleDbParameter("@supplier_address", ob.SupplierAddress);
            param[4] = new OleDbParameter("@supplier_phone", ob.SupplierPhone);
            param[5] = new OleDbParameter("@entry_user_id", ob.EntryUser.UserID);
            param[6] = new OleDbParameter("@entry_time", ob.EntryTime);
            param[7] = new OleDbParameter("@update_user_id", ob.UpdateUser.UserID);
            param[8] = new OleDbParameter("@update_time", ob.UpdateTime);

            IsDone = (DatabaseHelper.ExecuteNonQuery(sql, param) > 0) ? true : false;

            return IsDone;
        }

        public static List<Supplier> GetAll(String SupplierCode, String SupplierName)
        {
            SupplierCode = "%" + SupplierCode + "%";
            SupplierName = "%" + SupplierName + "%";
            List<Supplier> SupplierList = new List<Supplier>();

            String sql = "SELECT * FROM supplier WHERE supplier_code LIKE @supplier_code AND supplier_name LIKE @supplier_name order by supplier_code";
            OleDbParameter[] param = new OleDbParameter[2];
            param[0] = new OleDbParameter("@supplier_code", SupplierCode);
            param[1] = new OleDbParameter("@supplier_name", SupplierName);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Supplier ob = new Supplier();
                ob.SupplierCode = dr["supplier_code"].ToString();
                ob.SupplierName = dr["supplier_name"].ToString();
                ob.ContactPerson = dr["contact_person"].ToString();
                ob.SupplierAddress = dr["supplier_address"].ToString();
                ob.SupplierPhone = dr["supplier_phone"].ToString();

                SupplierList.Add(ob);
            }
            return SupplierList;
        }

    }
}
