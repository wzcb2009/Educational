using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Educational.Class
{
    public struct Parameter
    {
        public string pname;
        public string pvalues;
        public int ptype;
        public Parameter(string p_name ,string p_values )
        {
            pname = p_name;
            pvalues = p_values;
            ptype = 0;
        }
        public Parameter(string p_name, string p_values,int  p_type)
        {
            pname = p_name;
            pvalues = p_values;
            ptype = p_type;
        }
    };
    public class Sql_Class
    {
        private static string sqlconnStr = "Data Source=(local);Initial Catalog=schooldb;Integrated Security=True;";
        private static SqlConnection SqlConn;
        private static void Open()
        {
            //string sqlconnStr = ConfigurationManager.AppSettings["ConnectionString"];
            //sqlconnStr = "";
            try
            {
                if (SqlConn == null)
                {
                    SqlConn = new SqlConnection(sqlconnStr);
                }
                else if (SqlConn.State == System.Data.ConnectionState.Open)
                {
                    return;

                }

                SqlConn.Open();
            }
            catch (Exception ex)
            {
                //string str4 = sqlconnStr + "\r\n" + ex.Message;
                //flog_Class.WriteFlog(str4);
            }
        }
        public static DataTable GetDataTable(string strSQL, List<Parameter> Pars)
        {
            DataTable dt = new DataTable();
            try
            {

                Open();
                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);

                if ((Pars != null) && (Pars.Count > 0))
                {
                    foreach (Parameter par in Pars)
                    {
                        SqlParameter spar = new SqlParameter();
                        spar.Value = par.pvalues;
                        spar.ParameterName = par.pname;                        
                        sqlCand.Parameters.Add(spar);
                    }

                }

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlCand);
                sqlCand.ExecuteNonQuery();
                sqlda.Fill(dt);
                
                sqlCand.Cancel();
            }
            catch (Exception ex)
            {
                //  flog_Class.WriteFlog(strSQL + "\r\n" + ex.Message);
            }
            //   Close();
            try
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dt.Columns[i].ColumnName = dt.Columns[i].ColumnName.ToLower().Trim();
                }
            }
            catch (Exception ex)
            {
                //string str4 = strSQL + "\r\n" + ex.Message;
                //flog_Class.WriteFlog(str4);
            }
            return dt;
        }
        public static DataTable GetDataTable(string strSQL, List<SqlParameter> Pars)
        {
            DataTable dt = new DataTable();
            try
            {

                Open();
                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);

                if ((Pars != null) && (Pars.Count > 0))
                {
                    foreach (SqlParameter par in Pars)
                    {
                        sqlCand.Parameters.Add(par);
                    }

                }

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlCand);
                sqlCand.ExecuteNonQuery();
                sqlda.Fill(dt);
                try
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dt.Columns[i].ColumnName = dt.Columns[i].ColumnName.ToLower().Trim();
                    }
                }
                catch (Exception ex)
                {
                    //string str4 = strSQL + "\r\n" + ex.Message;
                    //flog_Class.WriteFlog(str4);
                }
                sqlCand.Cancel();
            }
            catch (Exception ex)
            {
                //  flog_Class.WriteFlog(strSQL + "\r\n" + ex.Message);
            }
            //   Close();
            return dt;
        }
        public static DataSet GetDataSet(string strSQL, List<SqlParameter> Pars)
        {
            DataSet dt = new DataSet();
            try
            {

                Open();
                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);

                if ((Pars != null) && (Pars.Count > 0))
                {
                    foreach (SqlParameter par in Pars)
                    {
                        sqlCand.Parameters.Add(par);
                    }

                }

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlCand);
                sqlCand.ExecuteNonQuery();
                sqlda.Fill(dt);
                try
                {
                    for (int i = 0; i < dt.Tables[0].Columns.Count; i++)
                    {
                        dt.Tables[0].Columns[i].Caption = dt.Tables[0].Columns[i].Caption.ToLower().Trim();
                    }
                }
                catch (Exception ex)
                {
                    //string str4 = strSQL + "\r\n" + ex.Message;
                    //flog_Class.WriteFlog(str4);
                }
                sqlCand.Cancel();
            }
            catch (Exception ex)
            {
                // flog_Class.WriteFlog(strSQL + "\r\n" + ex.Message);
            }
            Close();
            return dt;
        }

        public static bool ExecuteSQL(string strSQL, string d_strSQL)
        {
            int count = -1;
            try
            {
                Open();

                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);
                // flog_Class.WriteFlog(strSQL + "\r\n");
                count = sqlCand.ExecuteNonQuery();
                sqlCand.Cancel();
                return true;
            }
            catch (Exception ex)
            {
                //string str4 = strSQL + "\r\n" + ex.Message;
                //flog_Class.WriteFlog(str4);
            }
            Close();
            return false;
        }
        public static DataTable GetDataTable(string strSQL, string d_strSQL)
        {
            DataTable dt = new DataTable();
            try
            {

                Open();
                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);

                // flog_Class.WriteFlog(strSQL + "\r\n");

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlCand);
                sqlCand.ExecuteNonQuery();
                sqlda.Fill(dt);
                try
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        dt.Columns[i].Caption = dt.Columns[i].Caption.ToLower().Trim();
                    }
                }
                catch (Exception ex)
                {
                    //string str4 = strSQL + "\r\n" + ex.Message;
                    //flog_Class.WriteFlog(str4);
                }
                sqlCand.Cancel();
            }
            catch (Exception ex)
            {
                //  flog_Class.WriteFlog(strSQL + "\r\n" + ex.Message);
            }
            Close();
            return dt;
        }
        public static DataSet GetDataSet(string strSQL, string d_strSQL)
        {
            DataSet dt = new DataSet();
            try
            {

                // flog_Class.WriteFlog(strSQL);
                Open();
                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlCand);
                sqlCand.ExecuteNonQuery();
                sqlda.Fill(dt);
                try
                {
                    for (int i = 0; i < dt.Tables[0].Columns.Count; i++)
                    {
                        dt.Tables[0].Columns[i].Caption = dt.Tables[0].Columns[i].Caption.ToLower().Trim();
                    }
                }
                catch (Exception ex)
                {
                    //string str4 = strSQL + "\r\n" + ex.Message;
                    //flog_Class.WriteFlog(str4);
                }
                sqlCand.Cancel();
            }
            catch (Exception ex)
            {
                //  flog_Class.WriteFlog(strSQL + "\r\n" + ex.Message);
            }
            Close();
            return dt;
        }


        public static bool  ExecuteSQL(string strSQL, List<Parameter> Pars)
        {
            int count = -1;
            try
            {
                Open();

                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);
                if ((Pars != null) && (Pars.Count > 0))
                {
                    foreach (Parameter par in Pars)
                    {
                        SqlParameter spar = new SqlParameter();
                        spar.Value = par.pvalues;
                        spar.ParameterName = par.pname;
                        sqlCand.Parameters.Add(spar);
                    }
                }
                count = sqlCand.ExecuteNonQuery();
                sqlCand.Cancel();
            }
            catch (Exception ex)
            {
                //string str4 = strSQL + "\r\n" + ex.Message;
                //flog_Class.WriteFlog(str4);
            }
            Close();
            if (count > 0)
                return true;
            else
                return false;
        }
        public static int ExecuteSQLCount(string strSQL, List<Parameter> Pars)
        {
            int count = -1;
            try
            {
                Open();

                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);
                if ((Pars != null) && (Pars.Count > 0))
                {
                    foreach (Parameter par in Pars)
                    {
                        SqlParameter spar = new SqlParameter();
                        spar.Value = par.pvalues;
                        spar.ParameterName = par.pname;
                        sqlCand.Parameters.Add(spar);
                    }
                }
                count = sqlCand.ExecuteNonQuery();
                sqlCand.Cancel();
            }
            catch (Exception ex)
            {
                //string str4 = strSQL + "\r\n" + ex.Message;
                //flog_Class.WriteFlog(str4);
            }
            Close();
            return count;
        }
        public static int SelCount(string strSQL, List<SqlParameter> Pars)
        {
            int num = 0;
            try
            {
                Open();

                SqlCommand sqlCand = new SqlCommand(strSQL, SqlConn);

                if ((Pars != null) && (Pars.Count > 0))
                {
                    foreach (SqlParameter par in Pars)
                    {
                        sqlCand.Parameters.Add(par);
                    }
                }

                num = Convert.ToInt32(sqlCand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                //  flog_Class.WriteFlog(strSQL + "\r\n" + ex.Message);
            }
            finally
            {
                Close();
            }
            return num;
        }
        private static void Close()
        {
            if (SqlConn != null)
            {
                SqlConn.Close();
                SqlConn = null;
            }
        }
    }
}
