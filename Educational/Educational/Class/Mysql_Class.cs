using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Educational.Class
{
    public class Mysql_Class
    {
        #region  ����MySql���ݿ�����
        /// <summary>
        /// �������ݿ�����.
        /// </summary>
        /// <returns>����MySqlConnection����</returns>
        public MySqlConnection getmysqlcon()
        {
            String mysqlStr = "Database=test;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306";
            // String mySqlCon = ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString;
            MySqlConnection myCon = new MySqlConnection(mysqlStr);
            return myCon;
        }
        #endregion

        #region  ִ��MySqlCommand����
        /// <summary>
        /// ִ��MySqlCommand
        /// </summary>
        /// <param name="M_str_sqlstr">SQL���</param>
        public void getmysqlcom(string M_str_sqlstr)
        {
            MySqlConnection mysqlcon = this.getmysqlcon();
            mysqlcon.Open();
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            mysqlcom.ExecuteNonQuery();
            mysqlcom.Dispose();
            mysqlcon.Close();
            mysqlcon.Dispose();
        }
        #endregion

        #region  ����MySqlDataReader����
        /// <summary>
        /// ����һ��MySqlDataReader����
        /// </summary>
        /// <param name="M_str_sqlstr">SQL���</param>
        /// <returns>����MySqlDataReader����</returns>
        public MySqlDataReader getmysqlread(string M_str_sqlstr)
        {
            MySqlConnection mysqlcon = this.getmysqlcon();
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, mysqlcon);
            mysqlcon.Open();
            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            return mysqlread;
        }
        #endregion
    }
}
