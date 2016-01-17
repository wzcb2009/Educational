using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Educational.Class
{
    public class Mysql_Class
    {
        private string sqlconnStr = "";
        private static MySqlConnection SqlConn;
        public Mysql_Class(string p_database)
        {
            sqlconnStr = "Database=" + p_database + ";Data Source=112.16.5.165;User Id=root;Password=star1022;pooling=false;CharSet=utf8;port=18088";
            Open();
        }
        private void Open()
        {

            try
            {
                if (SqlConn == null)
                {
                    SqlConn = new MySqlConnection(sqlconnStr);
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

        public DataTable GetDataTable(string strSQL, List<Parameter> Pars)
        {
            DataTable dt = new DataTable();
            try
            {

                Open();
                MySqlCommand sqlCand = new MySqlCommand(strSQL, SqlConn);

                if ((Pars != null) && (Pars.Count > 0))
                {
                    foreach (Parameter par in Pars)
                    {
                        MySqlParameter spar = new MySqlParameter();
                        spar.Value = par.pvalues;
                        spar.ParameterName = par.pname;
                        sqlCand.Parameters.Add(spar);
                    }

                }

                MySqlDataAdapter sqlda = new MySqlDataAdapter(sqlCand);
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

        public bool ExecuteSQL(string strSQL, List<Parameter> Pars)
        {
            int count = -1;
            try
            {
                Open();

                MySqlCommand sqlCand = new MySqlCommand(strSQL, SqlConn);
                if ((Pars != null) && (Pars.Count > 0))
                {
                    foreach (Parameter par in Pars)
                    {
                        MySqlParameter spar = new MySqlParameter();
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


        private void Close()
        {
            if (SqlConn != null)
            {
                SqlConn.Close();
                SqlConn = null;
            }
        }


        #region  执行MySqlCommand命令
        /// <summary>
        /// 执行MySqlCommand
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        public void getmysqlcom(string M_str_sqlstr)
        {
            MySqlConnection mysqlcon = SqlConn; 
            mysqlcon.Open();
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            mysqlcom.ExecuteNonQuery();
            mysqlcom.Dispose();
            mysqlcon.Close();
            mysqlcon.Dispose();
        }
        #endregion

        #region  创建MySqlDataReader对象
        /// <summary>
        /// 创建一个MySqlDataReader对象
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        /// <returns>返回MySqlDataReader对象</returns>
        public MySqlDataReader getmysqlread(string M_str_sqlstr)
        {
            MySqlConnection mysqlcon = SqlConn; 
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            mysqlcon.Open();
            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return mysqlread;
        }
        #endregion
    }
}
