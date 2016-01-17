using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Educational.Class
{
    class ScoreRecord_Class
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

        private string strRecordstatus = "";
        public string Recordstate
        {
            get { return strRecordstatus; }
            set { strRecordstatus = value; }
        }

        private string strPrintstatus = "";
        public string Printstatus
        {
            get { return strPrintstatus; }
            set { strPrintstatus = value; }
        }

        private string strPrintperson = "";
        public string Printperson
        {
            get { return strPrintperson; }
            set { strPrintperson = value; }
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

        private string strcreateperson = "";
        public string createperson
        {
            get { return strcreateperson; }
            set { strcreateperson = value; }
        }

        private string strModifyperson = "";
        public string Modifyperson
        {
            get { return strModifyperson; }
            set { strModifyperson = value; }
        }

        private DateTime datePrintdate = DateTime.Now;
        public DateTime Printdate
        {
            get { return datePrintdate; }
            set { datePrintdate = value; }
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

        private string strclassjob = "";
        public string classjob
        {
            get { return strclassjob; }
            set { strclassjob = value; }
        }

        private string strProductlevel = "";
        public string Productlevel
        {
            get { return strProductlevel; }
            set { strProductlevel = value; }
        }

        private string strSchoolCourseName = "";
        public string SchoolCourseName
        {
            get { return strSchoolCourseName; }
            set { strSchoolCourseName = value; }
        }
        private string strSchoolCourseGrade = "";
        public string SchoolCourseGrade
        {
            get { return strSchoolCourseGrade; }
            set { strSchoolCourseGrade = value; }
        }

        private string strSchoolCourseNameTwo = "";
        public string SchoolCourseNameTwo
        {
            get { return strSchoolCourseNameTwo; }
            set { strSchoolCourseNameTwo = value; }
        }

        private string strSchoolCourseGradeTwo = "";
        public string SchoolCourseGradeTwo
        {
            get { return strSchoolCourseGradeTwo; }
            set { strSchoolCourseGradeTwo = value; }
        }
        private string strMyEvaluate = "";
        public string MyEvaluate
        {
            get { return strMyEvaluate; }
            set { strMyEvaluate = value; }
        }

        private string strParenthope = "";
        public string Parenthope
        {
            get { return strParenthope; }
            set { strParenthope = value; }
        }

        private string strSpecialtyElective = "";
        public string SpecialtyElective
        {
            get { return strSpecialtyElective; }
            set { strSpecialtyElective = value; }
        }
        private string strSpecialtyElectiveGrade = "";
        public string SpecialtyElectiveGrade
        {
            get { return strSpecialtyElectiveGrade; }
            set { strSpecialtyElectiveGrade = value; }
        }

        #endregion

        #region new
        public ScoreRecord_Class()
        {

        }

        public ScoreRecord_Class(int p_id)
        {
            DataTable dt = new DataTable();
            string str = "select * from ScoreRecord where id =@id";
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
            strRecordstatus = p_dw["Recordstatus"].ToString().Trim();
            strPrintstatus = p_dw["Printstatus"].ToString().Trim();
            strPrintperson = p_dw["Printperson"].ToString().Trim();
            strinfo = p_dw["info"].ToString().Trim();
            strRemarks = p_dw["Remarks"].ToString().Trim();
            strcreateperson = p_dw["createperson"].ToString().Trim();
            strModifyperson = p_dw["Modifyperson"].ToString().Trim();
            try
            {
                datecreatedate = Convert.ToDateTime(p_dw["createdate"]);
                dateModifydate = Convert.ToDateTime(p_dw["Modifydate"]);
                datePrintdate = Convert.ToDateTime(p_dw["Printdate"]);
            }
            catch { }

            strAttendance = p_dw["Attendance"].ToString().Trim();
            strAbsenteeism = p_dw["Absenteeism"].ToString().Trim();
            strleave = p_dw["leave"].ToString().Trim();

            strSpecialtyElectiveGrade = p_dw["SpecialtyElectiveGrade"].ToString().Trim();
            strSpecialtyElective = p_dw["SpecialtyElective"].ToString().Trim();
            strParenthope = p_dw["Parenthope"].ToString().Trim();
            strMyEvaluate = p_dw["MyEvaluate"].ToString().Trim();
            strSchoolCourseGradeTwo = p_dw["SchoolCourseGradeTwo"].ToString().Trim();
            strSchoolCourseNameTwo = p_dw["SchoolCourseNameTwo"].ToString().Trim();
            strSchoolCourseGrade = p_dw["SchoolCourseGrade"].ToString().Trim();
            strSchoolCourseName = p_dw["SchoolCourseName"].ToString().Trim();
            strProductlevel = p_dw["Productlevel"].ToString().Trim();
            strclassjob = p_dw["classjob"].ToString().Trim();


        }
        #endregion

        #region 方法
        public bool Insert()
        {
            List<Parameter> d_list = new List<Parameter>();
            string SqlStr = "";
            SqlStr += "INSERT INTO  ScoreRecord (studentNo, termno, createdate, Modifydate, Remarks, info, Recordstate, Printstatus, Printdate, Printperson, createperson, Modifyperson, Attendance, Absenteeism, leave, classjob, Productlevel, SchoolCourseName, SchoolCourseGrade, SchoolCourseNameTwo, SchoolCourseGradeTwo, MyEvaluate, Parenthope, SpecialtyElective, SpecialtyElectiveGrade) ";
            SqlStr += " VALUES (@studentno, @termno, @createdate, @modifydate, @remarks,";
            SqlStr += " @info, @recordstate, @printstatus, @printdate, @printperson,";
            SqlStr += " @createperson, @modifyperson, @attendance, @absenteeism, @leave,";
            SqlStr += " @classjob, @productlevel, @schoolcoursename, @schoolcoursegrade, @schoolcoursenametwo,";
            SqlStr += " @schoolcoursegradetwo, @myevaluate, @parenthope, @specialtyelective, @specialtyelectivegrade)";

            d_list.Add(new Parameter("@studentno", strstudentNo));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@createdate", datecreatedate.ToString()));
            d_list.Add(new Parameter("@Remarks", strRemarks));
            d_list.Add(new Parameter("@modifydate", dateModifydate.ToString()));
            d_list.Add(new Parameter("@printdate", datePrintdate.ToString()));
            d_list.Add(new Parameter("@info", strinfo));
            d_list.Add(new Parameter("@Recordstatus", strRecordstatus));
            d_list.Add(new Parameter("@Printstatus", strPrintstatus));
            d_list.Add(new Parameter("@Printperson", strPrintperson.ToString()));
            d_list.Add(new Parameter("@createperson", strcreateperson.ToString()));
            d_list.Add(new Parameter("@Modifyperson", strModifyperson));
            d_list.Add(new Parameter("@Attendance", strAttendance));
            d_list.Add(new Parameter("@Absenteeism", strAbsenteeism.ToString()));
            d_list.Add(new Parameter("@leave", strleave));
            d_list.Add(new Parameter("@classjob", strclassjob.ToString()));
            d_list.Add(new Parameter("@Productlevel", strProductlevel.ToString()));
            d_list.Add(new Parameter("@SchoolCourseName", strSchoolCourseName));
            d_list.Add(new Parameter("@SchoolCourseGrade", strSchoolCourseGrade));
            d_list.Add(new Parameter("@SchoolCourseNameTwo", strSchoolCourseNameTwo));
            d_list.Add(new Parameter("@SchoolCourseGradeTwo", strSchoolCourseGradeTwo.ToString()));
            d_list.Add(new Parameter("@MyEvaluate", strMyEvaluate.ToString()));
            d_list.Add(new Parameter("@Parenthope", strParenthope));
            d_list.Add(new Parameter("@SpecialtyElective", strSpecialtyElective.ToString()));
            d_list.Add(new Parameter("@SpecialtyElectiveGrade", strSpecialtyElectiveGrade.ToString()));
            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }
        public bool Update()
        {
            List<Parameter> d_list = new List<Parameter>();
            string SqlStr = "";
            SqlStr += "  UPDATE  ScoreRecord ";
            SqlStr += "  SET studentNo = @studentno, ";
            SqlStr += "  termno = @termno, ";
            SqlStr += "  createdate = @createdate, ";
            SqlStr += "  Modifydate = @modifydate, ";
            SqlStr += "  Remarks = @remarks, ";
            SqlStr += "  info = @info, ";
            SqlStr += "  Recordstatus = @Recordstatus, ";
            SqlStr += "  Printstatus = @printstatus, ";
            SqlStr += "  Printdate = @printdate, ";
            SqlStr += "  Printperson = @printperson, ";
            SqlStr += "  createperson = @createperson, ";
            SqlStr += "  Modifyperson = @modifyperson, ";
            SqlStr += "  Attendance = @attendance, ";
            SqlStr += "  Absenteeism = @absenteeism, ";
            SqlStr += "  leave = @leave, ";
            SqlStr += "  classjob = @classjob, ";
            SqlStr += "  Productlevel = @productlevel, ";
            SqlStr += "  SchoolCourseName = @schoolcoursename, ";
            SqlStr += "  SchoolCourseGrade = @schoolcoursegrade, ";
            SqlStr += "  SchoolCourseNameTwo = @schoolcoursenametwo, ";
            SqlStr += "  SchoolCourseGradeTwo = @schoolcoursegradetwo, ";
            SqlStr += "  MyEvaluate = @myevaluate, ";
            SqlStr += "  Parenthope = @parenthope, ";
            SqlStr += "  SpecialtyElective = @specialtyelective, ";
            SqlStr += "  SpecialtyElectiveGrade = @specialtyelectivegrade ";
            SqlStr += " WHERE  ID = @id ";
            d_list.Add(new Parameter("@studentno", strstudentNo));
            d_list.Add(new Parameter("@termno", strtermNo));
            d_list.Add(new Parameter("@createdate", datecreatedate.ToString()));
            d_list.Add(new Parameter("@Remarks", strRemarks));
            d_list.Add(new Parameter("@modifydate", dateModifydate.ToString()));
            d_list.Add(new Parameter("@printdate", datePrintdate.ToString()));
            d_list.Add(new Parameter("@info", strinfo));
            d_list.Add(new Parameter("@Recordstatus", strRecordstatus));
            d_list.Add(new Parameter("@Printstatus", strPrintstatus));
            d_list.Add(new Parameter("@Printperson", strPrintperson.ToString()));
            d_list.Add(new Parameter("@createperson", strcreateperson.ToString()));
            d_list.Add(new Parameter("@Modifyperson", strModifyperson));
            d_list.Add(new Parameter("@Attendance", strAttendance));
            d_list.Add(new Parameter("@Absenteeism", strAbsenteeism.ToString()));
            d_list.Add(new Parameter("@leave", strleave));
            d_list.Add(new Parameter("@classjob", strclassjob.ToString()));
            d_list.Add(new Parameter("@Productlevel", strProductlevel.ToString()));
            d_list.Add(new Parameter("@SchoolCourseName", strSchoolCourseName));
            d_list.Add(new Parameter("@SchoolCourseGrade", strSchoolCourseGrade));
            d_list.Add(new Parameter("@SchoolCourseNameTwo", strSchoolCourseNameTwo));
            d_list.Add(new Parameter("@SchoolCourseGradeTwo", strSchoolCourseGradeTwo.ToString()));
            d_list.Add(new Parameter("@MyEvaluate", strMyEvaluate.ToString()));
            d_list.Add(new Parameter("@Parenthope", strParenthope));
            d_list.Add(new Parameter("@SpecialtyElective", strSpecialtyElective.ToString()));
            d_list.Add(new Parameter("@SpecialtyElectiveGrade", strSpecialtyElectiveGrade.ToString()));
            d_list.Add(new Parameter("@id", intid.ToString()));

            return Sql_Class.ExecuteSQL(SqlStr, d_list);
        }

        public static DataTable GetRecordList(string p_classtudentno, string p_termno, string p_studentName, string p_studentno, string p_Printstatus, string p_Recordstatus, string p_yeargrade)
        {
            List<Parameter> d_list = new List<Parameter>();
            string str = "SELECT r.*,t.termname,t.years,s.studentName,s.sex,c.classtudentName,c.yeargrade FROM ScoreRecord r,Student s ,ClassStudent c,Term t ";
            str += " WHERE r.studentNo= s.studentNo AND s.classtudentNo = c.classtudentNo AND r.termno = t.termNo ";

            if (p_classtudentno != "")
            {
                str += " AND r.termno = @termno  ";
                d_list.Add(new Parameter("@termno", p_termno));
            }
            if (p_classtudentno != "")
            {
                str += " AND s.studentName  like @studentName ";
                d_list.Add(new Parameter("@studentName", "%" + p_studentName + "%"));
            }
            if (p_classtudentno != "")
            {
                str += " AND r.studentNo LIKE @studentno  ";
                d_list.Add(new Parameter("@studentno", "%" + p_studentno + "%"));
            }
            if (p_classtudentno != "")
            {
                str += " AND c.classtudentNo =@classtudentno";
                d_list.Add(new Parameter("@classtudentno", p_classtudentno));
            }
            if (p_classtudentno != "")
            {
                str += " AND r.Printstatus =@Printstatus  ";
                d_list.Add(new Parameter("@Printstatus", p_Printstatus));
            }
            if (p_classtudentno != "")
            {
                str += " AND r.Recordstatus =@Recordstatus";
                d_list.Add(new Parameter("@Recordstatus", p_Recordstatus));
            }
            if (p_yeargrade != "")
            {
                str += " AND c.yeargrade =@yeargrade";
                d_list.Add(new Parameter("@yeargrade", p_yeargrade));
            }
            str += "    ORDER BY t.years , r.termno ,C.yeargrade ,C.classtudentNo ,s.studentNo ";
            return Sql_Class.GetDataTable(str, d_list);
        }

        public static  bool InsertByUpdate(string p_termno, string yeargrade1, string yeargrade2, string yeargrade3)
        {
            List<Parameter> d_list = new List<Parameter>();
            string str = "";
            str += "  INSERT INTO  ScoreRecord (studentNo, termno, createdate,  Recordstatus, Printstatus)";
            str += " SELECT s.studentNo ,'" + p_termno + "',getdate(),'1','未打印'";
            str += " FROM ClassStudent c,Student s WHERE c.classtudentNo=s.classtudentNo and s.studentno is not null";
            str += " and  c.yeargrade IN (@yeargrade1,@yeargrade2,@yeargrade3)";
            str += " AND  NOT exists  ( SELECT studentno FROM ScoreRecord a WHERE  a.studentNo = s.studentNo AND a.termno =@termno )";

            d_list.Add(new Parameter("@yeargrade1", yeargrade1));
            d_list.Add(new Parameter("@yeargrade2", yeargrade2));
            d_list.Add(new Parameter("@yeargrade3", yeargrade3));
            d_list.Add(new Parameter("@termno", p_termno));
            return Sql_Class.ExecuteSQL(str, d_list);

        }


        #endregion
    }
}
