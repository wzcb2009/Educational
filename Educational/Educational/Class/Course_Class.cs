using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    class Course_Class
    {
        
        #region  Ù–‘
        private int intid = 0;
        public int ID
        {
            get { return intid; }
            set { intid = value; }
        }

       private string strcourseNo = "";
        public string courseNo
        {
            get { return strcourseNo; }
            set { strcourseNo = value; }
        }

        private string strcourseName = "";
        public string courseName
        {
            get { return strcourseName; }
            set { strcourseName = value; }
        }

        private string strcreditHour = "";
        public string creditHour
        {
            get { return strcreditHour; }
            set { strcreditHour = value; }
        }

        private string strcourseHour = "";
        public string courseHour
        {
            get { return strcourseHour; }
            set { strcourseHour = value; }
        }

        private string strpriorCourse = "";
        public string priorCourse
        {
            get { return strpriorCourse; }
            set { strpriorCourse = value; }
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
        public Course_Class()
        {

        }

        public Course_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from Course where id =@id";
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
            strcourseName = p_dw["courseName"].ToString().Trim();
            strcreditHour = p_dw["creditHour"].ToString().Trim();
            strcourseHour = p_dw["courseHour"].ToString().Trim();
            strpriorCourse = p_dw["priorCourse"].ToString().Trim();
            strcourseNo = p_dw["courseNo"].ToString().Trim();
           // strinfo = p_dw["info"].ToString().Trim();
           // strRemarks = p_dw["Remarks"].ToString().Trim();
                     

        }
        #endregion

        #region ∑Ω∑®
        public static DataTable GetALL()
        {
            string str = "select * from Course order by CourseNo ";
            return Sql_Class.GetDataTable(str, str);
        }

        #endregion
    }
}
