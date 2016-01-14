using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    class Exam_Class
    {
        
        #region  Ù–‘
        private int intid = 0;
        public int ID
        {
            get { return intid; }
            set { intid = value; }
        }

        private string strExamName = "";
        public string ExamName
        {
            get { return strExamName; }
            set { strExamName = value; }
        }

        private string strExamAdress = "";
        public string ExamAdress
        {
            get { return strExamAdress; }
            set { strExamAdress = value; }
        }

        private string strExamTime = "";
        public string ExamTime
        {
            get { return strExamTime; }
            set { strExamTime = value; }
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
         
        private string strexamNo = "";
        public string examNo
        {
            get { return strexamNo; }
            set { strexamNo = value; }
        }
         
        #endregion

        #region new
        public Exam_Class()
        {

        }

        public Exam_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from Exam where id =@id";
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
            strExamName = p_dw["ExamName"].ToString().Trim();
            strExamAdress = p_dw["ExamAdress"].ToString().Trim();
            strExamTime = p_dw["ExamTime"].ToString().Trim();
            strinfo = p_dw["info"].ToString().Trim();
            strRemarks = p_dw["Remarks"].ToString().Trim();
            strexamNo = p_dw["examNo"].ToString().Trim();           

        }
        #endregion

        #region ∑Ω∑®

        #endregion
    }
}
