using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    public class Score_Class
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

        private string strcourseNo = "";
        public string courseNo
        {
            get { return strcourseNo; }
            set { strcourseNo = value; }
        }

        private string strexamNo = "";
        public string examNo
        {
            get { return strexamNo; }
            set { strexamNo = value; }
        }

        private float fltsurface = 0;
        public float surface
        {
            get { return fltsurface; }
            set { fltsurface = value; }
        }

        private float fltstandard = 0;
        public float standard
        {
            get { return fltstandard; }
            set { fltstandard = value; }
        }

        private float flttotalscore = 0;
        public float totalscore
        {
            get { return flttotalscore; }
            set { flttotalscore = value; }
        }

        #endregion

        #region new
        public Score_Class()
        {

        }

        public Score_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from Score where id =@id";
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
            strcourseNo = p_dw["courseNo"].ToString().Trim();
            strexamNo = p_dw["examNo"].ToString().Trim();
            fltsurface = Convert.ToSingle(p_dw["surface"]);
            fltstandard = Convert.ToSingle(p_dw["standard"]);
            flttotalscore = Convert.ToSingle(p_dw["totalscore"]);

        }
        #endregion

        #region ∑Ω∑®

        #endregion
    }
}
