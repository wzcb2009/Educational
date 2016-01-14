using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Educational.Class
{
    public class Mysql_Class
    {
        #region  建立MySql数据库连接
        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        /// <returns>返回MySqlConnection对象</returns>
        public MySqlConnection getmysqlcon()
        {
            String mysqlStr = "Database=test;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306";
            // String mySqlCon = ConfigurationManager.ConnectionStrings["MySqlCon"].ConnectionString;
            MySqlConnection myCon = new MySqlConnection(mysqlStr);
            return myCon;
        }
        #endregion

        #region  执行MySqlCommand命令
        /// <summary>
        /// 执行MySqlCommand
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
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

        #region  创建MySqlDataReader对象
        /// <summary>
        /// 创建一个MySqlDataReader对象
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        /// <returns>返回MySqlDataReader对象</returns>
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
