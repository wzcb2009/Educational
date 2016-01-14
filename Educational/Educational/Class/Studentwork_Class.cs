using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    public class Studentwork_Class
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

        private string strleave = "";
        public string leave
        {
            get { return strleave; }
            set { strleave = value; }
        }

        private string strAbsenteeism = "";
        public string Absenteeism
        {
            get { return strAbsenteeism; }
            set { strAbsenteeism = value; }
        }

        private string strAttendance = "";
        public string Attendance
        {
            get { return strAttendance; }
            set { strAttendance = value; }
        }

      

        #endregion

        #region new
        public Studentwork_Class()
        {

        }

        public Studentwork_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from Studentwork where id =@id";
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
            strAttendance = p_dw["Attendance"].ToString().Trim();
            strAbsenteeism = p_dw["Absenteeism"].ToString().Trim();
            strleave = p_dw["leave"].ToString().Trim();


        }
        #endregion

        #region ∑Ω∑®

        #endregion

    }
}
