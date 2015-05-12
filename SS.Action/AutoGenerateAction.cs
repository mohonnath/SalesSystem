using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SS.Action;
using SS.DataAccess;

namespace SS.Action
{
    public static class AutoGenerateAction
    {
        public static void IncreaseAutoNumber(String ReqType)
        {
            String sql = "UPDATE sys_codes SET current_code = current_code +1 WHERE req_type = '" + ReqType + "'";
            DatabaseHelper.ExecuteNonQuery(sql);
        }

        public static String GenerateAutoNumber(String ReqType)
        {
            String AutoNumber = "";
            String sql = "SELECT * FROM sys_codes WHERE req_type = '" + ReqType + "'";
            DataSet ds = DatabaseHelper.ExecuteDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                AutoNumber = ds.Tables[0].Rows[0]["ticket_format"].ToString();

                String Digit = ds.Tables[0].Rows[0]["current_code"].ToString();
                for (int i = Digit.Length; i < 5; i++)
                {
                    Digit = "0" + Digit;
                }
                AutoNumber = AutoNumber + Digit;
            }

            return AutoNumber;

        }
    }
}
