using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace SS.DataAccess
{
    public static class DatabaseHelper
    {
        private static String ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\SalesSystem.mdb;";//Jet OLEDB:Database"; Password=kssisnocnam";

        public static int ExecuteNonQuery(String sql, OleDbParameter[] param)
        {
            int retval = 0;

            OleDbConnection Connection = new OleDbConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                OleDbCommand Command = new OleDbCommand(sql, Connection);

                for (int i = 0; i < param.Length; i++)
                    Command.Parameters.Add(param[i]);

                Connection.Open();
                retval = Command.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                retval = 0;
            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }

        public static int ExecuteNonQuery(String sql)
        {
            int retval = 0;

            OleDbConnection Connection = new OleDbConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                OleDbCommand Command = new OleDbCommand(sql, Connection);

                Connection.Open();
                retval = Command.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                retval = 0;
            }
            finally
            {
                Connection.Close();
            }

            return retval;
        }

        public static DataSet ExecuteDataSet(String sql)
        {
            DataSet ds = new DataSet();

            OleDbConnection Connection = new OleDbConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                OleDbDataAdapter DataAdapter = new OleDbDataAdapter(sql, Connection);

                Connection.Open();
                DataAdapter.Fill(ds);
            }
            catch (OleDbException ex)
            {
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }

        public static DataSet ExecuteDataSet(String sql, OleDbParameter[] param1)
        {
            DataSet ds = new DataSet();

            OleDbConnection Connection = new OleDbConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                OleDbDataAdapter DataAdapter = new OleDbDataAdapter(sql, Connection);

                for (int i = 0; i < param1.Length; i++)
                    DataAdapter.SelectCommand.Parameters.Add(param1[i]);

                Connection.Open();
                DataAdapter.Fill(ds);
            }
            catch (OleDbException ex)
            {
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }

        public static DataSet ExecuteTypedDataSet(string sql, OleDbParameter[] param1, DataSet ds, string TableName)
        {
            OleDbConnection Connection = new OleDbConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                OleDbDataAdapter DataAdapter = new OleDbDataAdapter(sql, Connection);

                for (int i = 0; i < param1.Length; i++)
                    DataAdapter.SelectCommand.Parameters.Add(param1[i]);

                DataAdapter.SelectCommand.CommandTimeout = 300;
                Connection.Open();
                DataAdapter.Fill(ds, TableName);
            }
            catch (OleDbException ex)
            {
                File.AppendAllText("" + System.Windows.Forms.Application.StartupPath + "\\ErrorLog.txt", "@ " + DateTime.Now.ToString() + " - " + ex.Message + " : " + sql + System.Environment.NewLine + System.Environment.NewLine);
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }

        public static object ExecuteScaller(String sql, OleDbParameter[] param)
        {
            object obj = null;

            OleDbConnection Connection = new OleDbConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                OleDbCommand Command = new OleDbCommand(sql, Connection);

                for (int i = 0; i < param.Length; i++)
                    Command.Parameters.Add(param[i]);

                Connection.Open();
                OleDbDataReader DataReader = Command.ExecuteReader();

                if (DataReader.Read())
                {
                    obj = (object)DataReader[0];
                }
            }
            catch (OleDbException ex)
            {
                throw (ex);
            }
            finally
            {
                Connection.Close();
            }

            return obj;
        }

        public static object ExecuteScaller(String sql)
        {
            object obj = null;

            OleDbConnection Connection = new OleDbConnection();

            try
            {
                Connection.ConnectionString = ConnectionString;
                OleDbCommand Command = new OleDbCommand(sql, Connection);

                Connection.Open();
                OleDbDataReader DataReader = Command.ExecuteReader();

                if (DataReader.Read())
                {
                    obj = (object)DataReader[0];
                }
            }
            catch (OleDbException ex)
            {
                throw (ex);
            }
            finally
            {
                Connection.Close();
            }

            return obj;
        }

    }
}
