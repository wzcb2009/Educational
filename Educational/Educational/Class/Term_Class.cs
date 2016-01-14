using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    public class term_Class
    {
        #region  Ù–‘
        private int intid = 0;
        public int ID
        {
            get { return intid; }
            set { intid = value; }
        }

        private string strtermname = "";
        public string termname
        {
            get { return strtermname; }
            set { strtermname = value; }
        }

        private string strtermNo = "";
        public string termNo
        {
            get { return strtermNo; }
            set { strtermNo = value; }
        }

        private string stryears = "";
        public string years
        {
            get { return stryears; }
            set { stryears = value; }
        }

        private string strinfo = "";
        public string info
        {
            get { return strinfo; }
            set { strinfo = value; }
        }

        private string strRemarks = "";
        public string Remarks
        {
            get { return strRemarks; }
            set { strRemarks = value; }
        }

        #endregion

        #region new
        public term_Class()
        {

        }

        public term_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from term where id =@id";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("id", p_id.ToString()));
            dt = Sql_Class.GetDataTable(str, d_list);
            SetPropertyByDt(dt);
        }
        public void SetPropertyByDt(DataTable p_dt)
        {
            if (p_dt.Rows.Count == 0)
                return;
            SetPropertyByDw(p_dt.Rows[0]);
        }
        public void SetPropertyByDw(DataRow p_dw)
        {

            intid = Convert.ToInt32(p_dw["ID"]);
            strtermname = p_dw["termname"].ToString().Trim();
            strtermNo = p_dw["termNo"].ToString().Trim();
            strinfo = p_dw["info"].ToString().Trim();
            strRemarks = p_dw["Remarks"].ToString().Trim();
            stryears = p_dw["years"].ToString().Trim();

        }
        #endregion

        #region ∑Ω∑®
        public bool Insert()
        {
            string SqlStr = "";
            SqlStr += "  INSERT INTO dbo.Term (termNo, termname, Remarks, info, years) ";
            SqlStr += "  VALUES (@termno, @termname, @remarks, @info, @years)";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("@termname", strtermname));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@years", stryears));
            d_list.Add(new Parameter("@remarks", strRemarks));
            d_list.Add(new Parameter("@info", strinfo.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }
        public bool Update()
        {
            string SqlStr = "";
            SqlStr += "UPDATE  Term ";
            SqlStr += " SET  termNo = @termno, ";
            SqlStr += " termname = @termname, ";
            SqlStr += " Remarks = @remarks, ";
            SqlStr += " info = @info, ";
            SqlStr += " years = @years ";
            SqlStr += " where ID = @id";

            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("@termname", strtermname));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@years", stryears));
            d_list.Add(new Parameter("@remarks", strRemarks));
            d_list.Add(new Parameter("@info", strinfo.ToString()));
            d_list.Add(new Parameter("@id", intid.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }
        public static DataTable GetDataYears()
        {
            string SqlStr = "";            
            SqlStr = "SELECT DISTINCT  years FROM  Term ";
            return Sql_Class.GetDataTable(SqlStr, SqlStr);
        }
        public static DataTable GetDataByYears(string p_years )
        {
            string SqlStr = "";
            List<Parameter> d_list = new List<Parameter>();
            SqlStr = "select * from Term where years=@years ";
            d_list.Add(new Parameter("@years", p_years));
            return Sql_Class.GetDataTable(SqlStr, d_list);
        }


        #endregion
    }
}
