using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    class Student_Class
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
         

        private string strstudentName = "";
        public string studentName
        {
            get { return strstudentName; }
            set { strstudentName = value; }
        }

        private DateTime datebirthday = DateTime.Now ;
        public DateTime  birthday
        {
            get { return datebirthday; }
            set { datebirthday = value; }
        }

        private string strsex = "";
        public string sex
        {
            get { return strsex; }
            set { strsex = value; }
        }

        private string strnative = "";
        public string native
        {
            get { return strnative; }
            set { strnative = value; }
        }

        private string strclasstudentNo = "";
        public string classtudentNo
        {
            get { return strclasstudentNo; }
            set { strclasstudentNo = value; }
        }
        #endregion

        #region new
        public Student_Class()
        {

        }

        public Student_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from student where id =@id";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("id", p_id.ToString()));
            dt = Sql_Class.GetDataTable(str, d_list);
            SetPropertyByDt(dt);
        }
        public Student_Class(string  p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from student where studentNo =@studentNo";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("studentNo", p_id.ToString()));
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
            //strinfo = p_dw["info"].ToString().Trim();
            //strRemarks = p_dw["Remarks"].ToString().Trim();
            
            strstudentName = p_dw["studentName"].ToString().Trim();
            strsex = p_dw["sex"].ToString().Trim();
            strnative = p_dw["native"].ToString().Trim();
            strclasstudentNo = p_dw["classtudentNo"].ToString().Trim();  
            try {datebirthday =Convert .ToDateTime ( p_dw["birthday"]);}
            catch {}

        }
        #endregion

        #region ∑Ω∑®

        #endregion
    }
}
