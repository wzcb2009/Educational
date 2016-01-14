using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    public class Honors_Class
    {

        #region  Ù–‘
        private int intid = 0;
        public int ID
        {
            get { return intid; }
            set { intid = value; }
        }

        private string strstudentNo = "";
        public string studentNo
        {
            get { return strstudentNo; }
            set { strstudentNo = value; }
        }

        private string strtermNo = "";
        public string termNo
        {
            get { return strtermNo; }
            set { strtermNo = value; }
        }

        private string strAwardSubject = "";
        public string AwardSubject
        {
            get { return strAwardSubject; }
            set { strAwardSubject = value; }
        }

        private string strAwardaddress = "";
        public string Awardaddress
        {
            get { return strAwardaddress; }
            set { strAwardaddress = value; }
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

        private string strAwardname = "";
        public string Awardname
        {
            get { return strAwardname; }
            set { strAwardname = value; }
        }

        private string strAwarddep = "";
        public string Awarddep
        {
            get { return strAwarddep; }
            set { strAwarddep = value; }
        }

        private DateTime dateAwarddate = DateTime.Now;
        public DateTime Awarddate
        {
            get { return dateAwarddate; }
            set { dateAwarddate = value; }
        }


        #endregion

        #region new
        public Honors_Class()
        {

        }

        public Honors_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from Honors where id =@id";
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
            strstudentNo = p_dw["studentNo"].ToString().Trim();
            strtermNo = p_dw["termNo"].ToString().Trim();
            strAwardSubject = p_dw["AwardSubject"].ToString().Trim();
            strAwardaddress = p_dw["Awardaddress"].ToString().Trim();
            strAwardname = p_dw["Awardname"].ToString().Trim();
            strinfo = p_dw["info"].ToString().Trim();
            strRemarks = p_dw["Remarks"].ToString().Trim();
            strAwarddep = p_dw["Awarddep"].ToString().Trim();
            try
            {
                dateAwarddate = Convert.ToDateTime(p_dw["Awarddate"]);
            }
            catch { }

        }
        #endregion

        #region ∑Ω∑®
        public bool Insert()
        {
            string SqlStr = "";
            SqlStr += "INSERT INTO  honors (studentNo, termno, Awardname, Awarddep, Awarddate, Awardaddress, AwardSubject, Remarks, info)";
            SqlStr += "VALUES (@studentno, @termno, @awardname, @awarddep, @awarddate, @awardaddress, @awardsubject, @remarks, @info)";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("@studentno", strstudentNo));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@awardaddress", strAwardaddress));
            d_list.Add(new Parameter("@Awarddep", strAwarddep));
            d_list.Add(new Parameter("@Awardname", strAwardname));
            d_list.Add(new Parameter("@Awarddate", dateAwarddate.ToString()));
            d_list.Add(new Parameter("@awardsubject", strAwardSubject));
            d_list.Add(new Parameter("@remarks", strRemarks));
            d_list.Add(new Parameter("@info", strinfo.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }
        public bool Update()
        {
            string SqlStr = "";
            SqlStr += "UPDATE  honors ";
            SqlStr += "SET  studentNo = @studentno, ";
            SqlStr += "termno = @termno, ";
            SqlStr += "Awardname = @awardname, ";
            SqlStr += "Awarddep = @awarddep, ";
            SqlStr += "Awarddate = @awarddate, ";
            SqlStr += "Awardaddress = @awardaddress, ";
            SqlStr += "AwardSubject = @awardsubject, ";
            SqlStr += "Remarks = @remarks, ";
            SqlStr += "info = @info ";
            SqlStr += " where ID = @id";

            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("@studentno", strstudentNo));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@awardaddress", strAwardaddress));
            d_list.Add(new Parameter("@Awarddep", strAwarddep));
            d_list.Add(new Parameter("@Awardname", strAwardname));
            d_list.Add(new Parameter("@Awarddate", dateAwarddate.ToString()));
            d_list.Add(new Parameter("@awardsubject", strAwardSubject));
            d_list.Add(new Parameter("@remarks", strRemarks));
            d_list.Add(new Parameter("@info", strinfo.ToString()));
            d_list.Add(new Parameter("@id", intid.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }

        public static bool UpdateAward(string p_id, string p_results, string p_name, string p_date)
        {
            string SqlStr = "update honors set ";
            List<Parameter> d_list = new List<Parameter>();
            SqlStr += "Awardname = @awardname,";
            SqlStr += "Awarddep = @awarddep,";
            SqlStr += "Awarddate = @awarddate";
            d_list.Add(new Parameter("@Awarddep", p_results));
            d_list.Add(new Parameter("@Awardname", p_name));
            d_list.Add(new Parameter("@Awarddate", p_date));

            SqlStr += " WHERE  ID = @id ";
            d_list.Add(new Parameter("@id", p_id.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }

        public static DataTable GetDataByStudentAndTerm(string p_studentNo, string p_termNo)
        {
            string SqlStr = "";
            List<Parameter> d_list = new List<Parameter>();
            SqlStr = "select * from honors where studentNo=@studentNo and  termno=@termno ";
            d_list.Add(new Parameter("@studentNo", p_studentNo));
            d_list.Add(new Parameter("@termno", p_termNo));
            return Sql_Class.GetDataTable(SqlStr, d_list);
        }

        #endregion
    }
}
