using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using SS.Collection;
using SS.DataAccess;


namespace SS.Action
{
    public static class UserAction
    {
        public static User GetLoginManager(String UserName, String UserPassword)
        {
            User usr = null;

            String sql = "SELECT * FROM sys_users WHERE user_login=@user_login AND user_password=@user_password";
            OleDbParameter[] param = new OleDbParameter[2];

            param[0] = new OleDbParameter("@user_login", UserName);
            param[1] = new OleDbParameter("@user_password", UserPassword);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);

            if (ds.Tables[0].Rows.Count > 0)
            {
                usr = new User();
                usr.UserID = Convert.ToInt32(ds.Tables[0].Rows[0]["user_id"]);
                usr.UserLogin = ds.Tables[0].Rows[0]["user_login"].ToString();
                usr.UserFullName = ds.Tables[0].Rows[0]["user_name"].ToString();
            }

            return usr;
        }

        public static List<User> GetAll()
        {
            List<User> UserList = new List<User>();
            String sql = "SELECT * FROM sys_users ORDER BY user_name";
            DataSet ds = DatabaseHelper.ExecuteDataSet(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    User user = new User();
                    user.UserID = Convert.ToInt32(dr["user_id"]);
                    user.UserLogin = dr["user_login"].ToString();
                    user.UserFullName = dr["user_name"].ToString();
                    user.UserPassword = dr["user_password"].ToString();

                    UserList.Add(user);
                }
            }
            return UserList;
        }

        public static User Get(int parseUserID)
        {
            User user = new User();
            String sql = "SELECT * FROM sys_users WHERE user_id=@user_id";
            OleDbParameter[] param = new OleDbParameter[1];
            param[0] = new OleDbParameter("@user_id", parseUserID);

            DataSet ds = DatabaseHelper.ExecuteDataSet(sql, param);
            if (ds.Tables[0].Rows.Count == 1)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                user.UserID = Convert.ToInt32(dr["user_id"]);
                user.UserLogin = dr["user_login"].ToString();
                user.UserFullName = dr["user_name"].ToString();
                user.UserPassword = dr["user_password"].ToString();
            }
            return user;
        }

        public static bool Insert(User ob)
        {
            bool IsDone = false;
            String sql = "INSERT INTO sys_users (user_login,user_password,user_name) VALUES (@user_login,@user_password,@user_name)";
            OleDbParameter[] param = new OleDbParameter[3];
            param[0] = new OleDbParameter("@user_login", ob.UserLogin);
            param[1] = new OleDbParameter("@user_password", ob.UserPassword);
            param[2] = new OleDbParameter("@user_name", ob.UserFullName);

            IsDone = DatabaseHelper.ExecuteNonQuery(sql, param) > 0 ? true : false;
            return IsDone;
        }

        public static bool Update(User ob)
        {
            bool IsDone = false;
            String sql = "UPDATE sys_users SET user_name = @user_name, user_password=@user_password WHERE user_id=@user_id";
            OleDbParameter[] param = new OleDbParameter[3];
            param[0] = new OleDbParameter("@user_name", ob.UserFullName);
            param[1] = new OleDbParameter("@user_password", ob.UserPassword);
            param[2] = new OleDbParameter("@user_id", ob.UserID);

            IsDone = DatabaseHelper.ExecuteNonQuery(sql, param) > 0 ? true : false;

            return IsDone;
        }
    }
}
