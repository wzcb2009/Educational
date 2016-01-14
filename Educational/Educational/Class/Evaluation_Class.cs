using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace Educational.Class
{
    public class Evaluation_Class
    {
        #region 属性
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

        private string stritem = "";
        public string item
        {
            get { return stritem; }
            set { stritem = value; }
        }

        private string stritemtype = "";
        public string itemtype
        {
            get { return stritemtype; }
            set { stritemtype = value; }
        }

        private string strQuantity = "";
        public string Quantity
        {
            get { return strQuantity; }
            set { strQuantity = value; }
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

        private string strresults = "";
        public string results
        {
            get { return strresults; }
            set { strresults = value; }
        }



        private DateTime datecreatedate = DateTime.Now;
        public DateTime createdate
        {
            get { return datecreatedate; }
            set { datecreatedate = value; }
        }

        private DateTime dateModifydate = DateTime.Now;
        public DateTime Modifydate
        {
            get { return dateModifydate; }
            set { dateModifydate = value; }
        }
        #endregion

        #region new
        public Evaluation_Class()
        {

        }

        public Evaluation_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from Evaluation where id =@id";
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
            stritem = p_dw["item"].ToString().Trim();
            stritemtype = p_dw["itemtype"].ToString().Trim();
            strQuantity = p_dw["Quantity"].ToString().Trim();
            strinfo = p_dw["info"].ToString().Trim();
            strRemarks = p_dw["Remarks"].ToString().Trim();
            strresults = p_dw["results"].ToString().Trim();

            try
            {
                datecreatedate = Convert.ToDateTime(p_dw["createdate"]);
                dateModifydate = Convert.ToDateTime(p_dw["Modifydate"]);
            }
            catch { }

        }
        #endregion

        #region 方法
        public bool Insert()
        {
            string SqlStr = "";
            SqlStr += " INSERT INTO dbo.Evaluation (studentNo, termno, item, itemtype, createdate, Modifydate, Quantity, results, Remarks, info) ";
            SqlStr += " VALUES (@studentno, @termno, @item, @itemtype, @createdate, @modifydate, @quantity, @results, @remarks, @info)";
            List<Parameter> d_list = new List<Parameter>();
            d_list.Add(new Parameter("@studentno", strstudentNo));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@item", stritem));
            d_list.Add(new Parameter("@itemtype", stritemtype));
            d_list.Add(new Parameter("@createdate", datecreatedate.ToString()));
            d_list.Add(new Parameter("@modifydate", dateModifydate.ToString()));
            d_list.Add(new Parameter("@quantity", strQuantity));
            d_list.Add(new Parameter("@results", strresults));
            d_list.Add(new Parameter("@remarks", strRemarks));
            d_list.Add(new Parameter("@info", strinfo.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }
        public bool Update()
        {
            string SqlStr = "";
            SqlStr += " UPDATE dbo.Evaluation ";
            SqlStr += " SET  studentNo = @studentno, ";
            SqlStr += " termno = @termno, ";
            SqlStr += " item = @item, ";
            SqlStr += " itemtype = @itemtype, ";
            SqlStr += " createdate = @createdate, ";
            SqlStr += " Modifydate = @modifydate, ";
            SqlStr += "Quantity = @quantity, ";
            SqlStr += " results = @results, ";
            SqlStr += " Remarks = @remarks, ";
            SqlStr += " info = @info ";
            SqlStr += " WHERE  ID = @id ";
            List<Parameter> d_list = new List<Parameter>();
            if (stritemtype == "研究课题")
            {
                strQuantity = "";
            }
            else
            {
                createdate = DateTime.Now;
            }
            d_list.Add(new Parameter("@studentno", strstudentNo));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@item", stritem));
            d_list.Add(new Parameter("@itemtype", stritemtype));
            d_list.Add(new Parameter("@createdate", datecreatedate.ToString()));
            d_list.Add(new Parameter("@modifydate", dateModifydate.ToString()));
            d_list.Add(new Parameter("@quantity", strQuantity));
            d_list.Add(new Parameter("@results", strresults));
            d_list.Add(new Parameter("@remarks", strRemarks));
            d_list.Add(new Parameter("@info", strinfo.ToString()));
            d_list.Add(new Parameter("@id", intid.ToString()));

            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }
        public static bool UpdateByID(string p_id, string p_results, string p_name, string p_date, string p_type)
        {
            string SqlStr = "update Evaluation set ";
            List<Parameter> d_list = new List<Parameter>();
            SqlStr += "item = @item,";
            SqlStr += "results = @results,";
            d_list.Add(new Parameter("@results", p_results));
            d_list.Add(new Parameter("@item", p_name));
            if (p_type == "研究课题")
            {
                SqlStr += "createdate = @createdate";
                d_list.Add(new Parameter("@createdate", p_date));
            }
            else
            {
                SqlStr += "Quantity = @quantity";
                d_list.Add(new Parameter("@quantity", p_date));
            }
            SqlStr += " WHERE  ID = @id ";
            d_list.Add(new Parameter("@id", p_id.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }

        public static DataTable GetDataByStudentAndTerm(string p_studentNo, string p_termNo, string pitemtype)
        {
            string SqlStr = "";
            List<Parameter> d_list = new List<Parameter>();
            SqlStr = "select * from Evaluation where studentNo=@studentNo and  termno=@termno and itemtype=@itemtype ";
            d_list.Add(new Parameter("@studentNo", p_studentNo));
            d_list.Add(new Parameter("@termno", p_termNo));
            d_list.Add(new Parameter("@itemtype", pitemtype));
            return Sql_Class.GetDataTable(SqlStr, d_list);
        }

        #endregion
    }
}
