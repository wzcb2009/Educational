using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    class ClassStudent_Class
    {
        
        #region  Ù–‘
        private int intid = 0;
        public int ID
        {
            get { return intid; }
            set { intid = value; }
        }

        private string strclasstudentNo = "";
        public string classtudentNo
        {
            get { return strclasstudentNo; }
            set { strclasstudentNo = value; }
        }

        private string strclasstudentName = "";
        public string classtudentName
        {
            get { return strclasstudentName; }
            set { strclasstudentName = value; }
        }

        private string strinstitute = "";
        public string institute
        {
            get { return strinstitute; }
            set { strinstitute = value; }
        }

        private string stryeargrade = "";
        public string yeargrade
        {
            get { return stryeargrade; }
            set { stryeargrade = value; }
        }

        private string strclassNum = "";
        public string classNum
        {
            get { return strclassNum; }
            set { strclassNum = value; }
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
        public ClassStudent_Class()
        {

        }

        public ClassStudent_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from ClassStudent where id =@id";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("id", p_id.ToString()));
            dt = Sql_Class.GetDataTable(str, d_list);
            SetPropertyByDt(dt);
        }
        public ClassStudent_Class(string p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from ClassStudent where classtudentNo =@classtudentNo";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("classtudentNo", p_id.ToString()));
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
            //strinfo = p_dw["info"].ToString().Trim();
            //strRemarks = p_dw["Remarks"].ToString().Trim();
            strclasstudentNo = p_dw["classtudentNo"].ToString().Trim();
            strclasstudentName = p_dw["classtudentName"].ToString().Trim();
            strinstitute = p_dw["institute"].ToString().Trim();
            stryeargrade = p_dw["yeargrade"].ToString().Trim();
            strclassNum = p_dw["classNum"].ToString().Trim();           

        }
        #endregion

        #region ∑Ω∑®
        public bool Insert()
        {
            string str ="INSERT INTO  ClassStudent (classtudentNo, classtudentName, institute, yeargrade, classNum)";
            str += "VALUES (@classtudentno, @classtudentname, @institute, @yeargrade, @classnum)";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("classtudentno", strclasstudentNo.ToString()));
            d_list.Add(new Parameter("classtudentname", strclasstudentName.ToString()));
            d_list.Add(new Parameter("institute", strinstitute.ToString()));
            d_list.Add(new Parameter("yeargrade", stryeargrade.ToString()));
            d_list.Add(new Parameter("classnum", strclassNum.ToString()));
            return Sql_Class.ExecuteSQL(str, d_list);
        }

        public static   DataTable GetALL()
        {
            string str = "select * from ClassStudent order by classtudentNo ";
            return Sql_Class.GetDataTable(str, str);
        }
        public static DataTable GetDataYeargrade()
        {
            string SqlStr = "";
            SqlStr = "SELECT DISTINCT  yeargrade FROM  ClassStudent ";
            return Sql_Class.GetDataTable(SqlStr, SqlStr);
        }
        public static DataTable GetDataByYeargrade(string p_yeargrade)
        {
            string SqlStr = "";
            List<Parameter> d_list = new List<Parameter>();
            SqlStr = "select * from ClassStudent where yeargrade=@years ";
            d_list.Add(new Parameter("@years", p_yeargrade));
            return Sql_Class.GetDataTable(SqlStr, d_list);
        }
        #endregion
    }
}
