using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SS.Collection;
using SS.DataAccess;

namespace SS.Action
{
    public static class UserProfileAction
    {
        public static List<UserProfile> GetAllByUser(int UserID)
        {
            List<UserProfile> UserProfileList = new List<UserProfile>();
            String sql = "SELECT * FROM user_profile WHERE user_id = @user_id";
            OleDbParameter[] param = new OleDbParameter[1];
            param[0] = new OleDbParameter("@user_id", UserID);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    UserProfile ob = new UserProfile();
                    ob.UserID = Convert.ToInt32(dr["user_id"]);
                    ob.FormName = dr["form_name"].ToString();
                    UserProfileList.Add(ob);
                }
            }
            return UserProfileList;
        }

        public static bool InsertUserProfile(List<UserProfile> UserProfileList)
        {
            bool IsDone = false;
            
            
            foreach (UserProfile up in UserProfileList)
            {
                String sql = "INSERT INTO user_profile (user_id, form_name) VALUES (@user_id, @form_name)";

                OleDbParameter[] param = new OleDbParameter[2];
                param[0] = new OleDbParameter("@user_id", up.UserID);
                param[1] = new OleDbParameter("@form_name", up.FormName);

                IsDone = DatabaseHelper.ExecuteNonQuery(sql, param) > 0 ? true : false;
                
            }
            
            return IsDone;
        }

        public static bool DeleteUserProfile(int UserID)
        {
            bool IsDone = false;
            String sql = "DELETE FROM user_profile WHERE user_id = @user_id";
            OleDbParameter[] param = new OleDbParameter[1];
            param[0] = new OleDbParameter("@user_id", UserID);

            IsDone = DatabaseHelper.ExecuteNonQuery(sql, param) > 0 ? true : false;
            return IsDone;
        }

        public static bool CheckUserProfice(int UserID, String MenuName)
        {
            bool IsDone = false;
            String sql = "SELECT * FROM user_profile WHERE user_id = @user_id AND form_name=@form_name";

            OleDbParameter[] param = new OleDbParameter[2];
            param[0] = new OleDbParameter("@user_id", UserID);
            param[1] = new OleDbParameter("@form_name", MenuName);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);

            if (ds.Tables[0].Rows.Count == 1)
            {
                IsDone = true;
            }
            return IsDone;
        }
    }
}
