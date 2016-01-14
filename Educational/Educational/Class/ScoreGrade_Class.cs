using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    public class ScoreGrade_Class
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

        private string strWritegrade = "";
        public string Writegrade
        {
            get { return strWritegrade; }
            set { strWritegrade = value; }
        }

        private string strcompositiongrade = "";
        public string compositiongrade
        {
            get { return strcompositiongrade; }
            set { strcompositiongrade = value; }
        }

        private string strpracticegrade = "";
        public string practicegrade
        {
            get { return strpracticegrade; }
            set { strpracticegrade = value; }
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

        private string strreadinggrade = "";
        public string readinggrade
        {
            get { return strreadinggrade; }
            set { strreadinggrade = value; }
        }

        private string strothergrade = "";
        public string othergrade
        {
            get { return strothergrade; }
            set { strothergrade = value; }
        }

        private int intteamtimes = 0;
        public int teamtimes
        {
            get { return intteamtimes; }
            set { intteamtimes = value; }
        }

        private string strscoregrade = "";
        public string scoregrade
        {
            get { return strscoregrade; }
            set { strscoregrade = value; }
        }

        private string strcourseNo = "";
        public string courseNo
        {
            get { return strcourseNo; }
            set { strcourseNo = value; }
        }

        private string strattitudegrade = "";
        public string attitudegrade
        {
            get { return strattitudegrade; }
            set { strattitudegrade = value; }
        }
        #endregion

        #region new
        public ScoreGrade_Class()
        {

        }

        public ScoreGrade_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from ScoreGrade where id =@id";
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
            strothergrade = p_dw["othergrade"].ToString().Trim();
            strreadinggrade = p_dw["readinggrade"].ToString().Trim();
            strpracticegrade = p_dw["practicegrade"].ToString().Trim();
           // strinfo = p_dw["info"].ToString().Trim();
           // strRemarks = p_dw["Remarks"].ToString().Trim();
            strcompositiongrade = p_dw["compositiongrade"].ToString().Trim();
            strWritegrade = p_dw["Writegrade"].ToString().Trim();
            strattitudegrade = p_dw["attitudegrade"].ToString().Trim();
            strcourseNo = p_dw["courseNo"].ToString().Trim();
            strscoregrade = p_dw["scoregrade"].ToString().Trim();
            intteamtimes = Convert.ToInt32(p_dw["teamtimes"]);

        }
        #endregion

        #region ∑Ω∑®
        public bool Insert()
        {
            List<Parameter> d_list = new List<Parameter>();
            string SqlStr = "";
            SqlStr += "INSERT INTO dbo.ScoreGrade (studentNo, termno, scoregrade, teamtimes, courseNo, attitudegrade, Writegrade, compositiongrade, practicegrade, readinggrade, othergrade)";
            SqlStr += " VALUES (@studentno, @termno, @scoregrade, @teamtimes, @courseno,";
            SqlStr += " @attitudegrade, @writegrade, @compositiongrade, @practicegrade, @readinggrade, @othergrade)";
            
            d_list.Add(new Parameter("@studentno", strstudentNo));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@teamtimes", intteamtimes. ToString()));
            d_list.Add(new Parameter("@courseno", strcourseNo));
            d_list.Add(new Parameter("@scoregrade", strscoregrade.ToString()));
            d_list.Add(new Parameter("@attitudegrade", strattitudegrade.ToString()));
            d_list.Add(new Parameter("@writegrade", strWritegrade));
            d_list.Add(new Parameter("@compositiongrade", strcompositiongrade));
            d_list.Add(new Parameter("@practicegrade", strpracticegrade));
            d_list.Add(new Parameter("@readinggrade", strreadinggrade.ToString()));
            d_list.Add(new Parameter("@othergrade", strothergrade.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }
        public bool Update()
        {
            List<Parameter> d_list = new List<Parameter>();
            string SqlStr = "";
            SqlStr += " UPDATE  ScoreGrade ";
            SqlStr += " SET  studentNo = @studentno, ";
            SqlStr += " termno = @termno, ";
            SqlStr += " scoregrade = @scoregrade, ";
            SqlStr += " teamtimes = @teamtimes, ";
            SqlStr += " courseNo = @courseno, ";
            SqlStr += " attitudegrade = @attitudegrade, ";
            SqlStr += " Writegrade = @writegrade, ";
            SqlStr += " compositiongrade = @compositiongrade, ";
            SqlStr += " practicegrade = @practicegrade, ";
            SqlStr += " readinggrade = @readinggrade, ";
            SqlStr += " othergrade = @othergrade";
            SqlStr += " WHERE  ID = @id ";
            d_list.Add(new Parameter("@studentno", strstudentNo));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@teamtimes", intteamtimes. ToString()));
            d_list.Add(new Parameter("@courseno", strcourseNo));
            d_list.Add(new Parameter("@scoregrade", strscoregrade.ToString()));
            d_list.Add(new Parameter("@attitudegrade", strattitudegrade.ToString()));
            d_list.Add(new Parameter("@writegrade", strWritegrade));
            d_list.Add(new Parameter("@compositiongrade", strcompositiongrade));
            d_list.Add(new Parameter("@practicegrade", strpracticegrade));
            d_list.Add(new Parameter("@readinggrade", strreadinggrade.ToString()));
            d_list.Add(new Parameter("@othergrade", strothergrade.ToString()));
            d_list.Add(new Parameter("@id", intid.ToString()));

            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }

        public static DataTable GetDataByStudentAndTerm(string p_studentNo, string p_termNo)
        {
            string SqlStr = "";
            List<Parameter> d_list = new List<Parameter>();
            SqlStr = "select * from ScoreGrade where studentNo=@studentNo and  termno=@termno ";
            d_list.Add(new Parameter("@studentNo", p_studentNo));
            d_list.Add(new Parameter("@termno", p_termNo));
            return Sql_Class.GetDataTable(SqlStr, d_list);
        }

        #endregion
    }
}
