using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Educational.Class
{
    public class Print_Class
    {
        private static DataTable PrintDataSource(int p_id)
        {
            ScoreRecord_Class CurRecordClass = new ScoreRecord_Class(p_id);
            List<string> d_courselist = new List<string>();
            d_courselist.Add("yw");
            d_courselist.Add("sx");
            d_courselist.Add("yy");
            d_courselist.Add("kx");
            d_courselist.Add("sh");
            d_courselist.Add("it");
            d_courselist.Add("music");
            d_courselist.Add("ms");
            d_courselist.Add("ty");
            d_courselist.Add("ld");
            d_courselist.Add("yj");
            d_courselist.Add("sq");
            DataTable dt = new DataTable();
            dt.Columns.Add("termname", typeof(string));
            dt.Columns.Add("classname", typeof(string));
            dt.Columns.Add("studentname", typeof(string));
            dt.Columns.Add("studentno", typeof(string));
            for (int i = 0; i < 12; i++)
            {
                string coursenametemp = d_courselist[i];
                dt.Columns.Add("ScoreGrade_scoregrade_" + coursenametemp + "_0", typeof(string));
                dt.Columns.Add("ScoreGrade_scoregrade_" + coursenametemp + "_2", typeof(string));
                dt.Columns.Add("ScoreGrade_scoregrade_" + coursenametemp + "_1", typeof(string));
                dt.Columns.Add("ScoreGrade_readinggrade_" + coursenametemp + "_0", typeof(string));
                dt.Columns.Add("ScoreGrade_readinggrade_" + coursenametemp + "_2", typeof(string));
                dt.Columns.Add("ScoreGrade_readinggrade_" + coursenametemp + "_1", typeof(string));
                dt.Columns.Add("ScoreGrade_compositiongrade_" + coursenametemp + "_0", typeof(string));
                dt.Columns.Add("ScoreGrade_compositiongrade_" + coursenametemp + "_2", typeof(string));
                dt.Columns.Add("ScoreGrade_compositiongrade_" + coursenametemp + "_1", typeof(string));
                dt.Columns.Add("ScoreGrade_practicegrade_" + coursenametemp + "_0", typeof(string));
                dt.Columns.Add("ScoreGrade_practicegrade_" + coursenametemp + "_2", typeof(string));
                dt.Columns.Add("ScoreGrade_practicegrade_" + coursenametemp + "_1", typeof(string));
                dt.Columns.Add("ScoreGrade_Writegrade_" + coursenametemp + "_0", typeof(string));
                dt.Columns.Add("ScoreGrade_Writegrade_" + coursenametemp + "_2", typeof(string));
                dt.Columns.Add("ScoreGrade_Writegrade_" + coursenametemp + "_1", typeof(string));
                dt.Columns.Add("ScoreGrade_attitudegrade_" + coursenametemp + "_0", typeof(string));
                dt.Columns.Add("ScoreGrade_attitudegrade_" + coursenametemp + "_2", typeof(string));
                dt.Columns.Add("ScoreGrade_attitudegrade_" + coursenametemp + "_1", typeof(string));
            }
            for (int i = 0; i < 9; i++)
            {
                dt.Columns.Add("honors_Awarddep_" + Convert.ToString(i + 1), typeof(string));
                dt.Columns.Add("honors_Awardname_" + Convert.ToString(i + 1), typeof(string));
                dt.Columns.Add("honors_Awarddate_" + Convert.ToString(i + 1), typeof(string));
                dt.Columns.Add("Evaluation_results_" + Convert.ToString(i + 1), typeof(string));
                dt.Columns.Add("Evaluation_item_" + Convert.ToString(i + 1), typeof(string));
                dt.Columns.Add("Evaluation_createdate_" + Convert.ToString(i + 1), typeof(string));
                dt.Columns.Add("Evaluation_Quantity_" + Convert.ToString(i + 1), typeof(string));
            }
            dt.Columns.Add("Evaluation_results_shequ", typeof(string));
            dt.Columns.Add("Evaluation_results_shetuan", typeof(string));
            dt.Columns.Add("Evaluation_results_shehui", typeof(string));
            dt.Columns.Add("Evaluation_results_yuedu", typeof(string));
            dt.Columns.Add("Evaluation_Quantity_shehui", typeof(string));
            dt.Columns.Add("Evaluation_Quantity_shequ", typeof(string));
            dt.Columns.Add("Evaluation_Quantity_shetuan", typeof(string));
            dt.Columns.Add("Evaluation_Quantity_yuedu", typeof(string));

            dt.Columns.Add("ScoreRecord_schoolcoursename", typeof(string));
            dt.Columns.Add("ScoreRecord_schoolcoursenametwo", typeof(string));
            dt.Columns.Add("ScoreRecord_attendance", typeof(string));
            dt.Columns.Add("ScoreRecord_leave", typeof(string));
            dt.Columns.Add("ScoreRecord_absenteeism", typeof(string));
            dt.Columns.Add("ScoreRecord_specialtyelectivegrade", typeof(string));
            dt.Columns.Add("ScoreRecord_schoolcoursegradetwo", typeof(string));
            dt.Columns.Add("ScoreRecord_schoolcoursegrade", typeof(string));
            dt.Columns.Add("ScoreRecord_specialtyelective", typeof(string));
            dt.Columns.Add("ScoreRecord_classjob", typeof(string));
            dt.Columns.Add("ScoreRecord_parenthope", typeof(string));
            dt.Columns.Add("ScoreRecord_myevaluate", typeof(string));
            dt.Columns.Add("ScoreRecord_productlevel", typeof(string));
            DataRow dw = dt.NewRow();

            dw["termname"] = "二〇     学年度第   学期";
            dw["classname"] = "二〇     学年度第   学期";
            dw["studentname"] = "二〇     学年度第   学期";
            dw["studentno"] = "二〇     学年度第   学期";

            for (int i = 0; i < 12; i++)
            {
                string coursenametemp = d_courselist[i];
                dw["ScoreGrade_scoregrade_" + coursenametemp + "_0"] = "";
                dw["ScoreGrade_scoregrade_" + coursenametemp + "_2"] = "";
                dw["ScoreGrade_scoregrade_" + coursenametemp + "_1"] = "";
                dw["ScoreGrade_readinggrade_" + coursenametemp + "_0"] = "";
                dw["ScoreGrade_readinggrade_" + coursenametemp + "_2"] = "";
                dw["ScoreGrade_readinggrade_" + coursenametemp + "_1"] = "";
                dw["ScoreGrade_compositiongrade_" + coursenametemp + "_0"] = "";
                dw["ScoreGrade_compositiongrade_" + coursenametemp + "_2"] = "";
                dw["ScoreGrade_compositiongrade_" + coursenametemp + "_1"] = "";
                dw["ScoreGrade_practicegrade_" + coursenametemp + "_0"] = "";
                dw["ScoreGrade_practicegrade_" + coursenametemp + "_2"] = "";
                dw["ScoreGrade_practicegrade_" + coursenametemp + "_1"] = "";
                dw["ScoreGrade_Writegrade_" + coursenametemp + "_0"] = "";
                dw["ScoreGrade_Writegrade_" + coursenametemp + "_2"] = "";
                dw["ScoreGrade_Writegrade_" + coursenametemp + "_1"] = "";
                dw["ScoreGrade_attitudegrade_" + coursenametemp + "_0"] = "";
                dw["ScoreGrade_attitudegrade_" + coursenametemp + "_2"] = "";
                dw["ScoreGrade_attitudegrade_" + coursenametemp + "_1"] = "";
            }
            for (int i = 0; i < 9; i++)
            {
                dw["honors_Awarddep_" + Convert.ToString(i + 1)] = "";
                dw["honors_Awardname_" + Convert.ToString(i + 1)] = "";
                dw["honors_Awarddate_" + Convert.ToString(i + 1)] = "";
                dw["Evaluation_results_" + Convert.ToString(i + 1)] = "";
                dw["Evaluation_item_" + Convert.ToString(i + 1)] = "";
                dw["Evaluation_createdate_" + Convert.ToString(i + 1)] = "";
                dw["Evaluation_Quantity_" + Convert.ToString(i + 1)] = "";
            }

            dw["Evaluation_results_shequ"] = "";
            dw["Evaluation_results_shetuan"] = "";
            dw["Evaluation_results_shehui"] = "";
            dw["Evaluation_results_yuedu"] = "";
            dw["Evaluation_Quantity_shehui"] = "";
            dw["Evaluation_Quantity_shequ"] = "";
            dw["Evaluation_Quantity_shetuan"] = "";
            dw["Evaluation_Quantity_yuedu"] = "";

            dw["ScoreRecord_specialtyelectivegrade"] = CurRecordClass.SpecialtyElectiveGrade;
            dw["ScoreRecord_schoolcoursename"] = CurRecordClass.SchoolCourseName;
            dw["ScoreRecord_schoolcoursenametwo"] = CurRecordClass.SchoolCourseNameTwo;
            dw["ScoreRecord_schoolcoursegradetwo"] = CurRecordClass.SchoolCourseGradeTwo;
            dw["ScoreRecord_schoolcoursegrade"] = CurRecordClass.SchoolCourseGrade;
            dw["ScoreRecord_attendance"] = CurRecordClass.Attendance;
            dw["ScoreRecord_leave"] = CurRecordClass.leave;
            dw["ScoreRecord_absenteeism"] = CurRecordClass.Absenteeism;
            dw["ScoreRecord_parenthope"] = CurRecordClass.Parenthope;
            dw["ScoreRecord_myevaluate"] = CurRecordClass.MyEvaluate ;
            dw["ScoreRecord_specialtyelective"] = CurRecordClass.SpecialtyElective;
            dw["ScoreRecord_classjob"] = CurRecordClass.classjob;
            dw["ScoreRecord_productlevel"] = CurRecordClass.Productlevel ;

            #region 课程
            DataTable d_table = new DataTable();
            try
            {
                d_table = ScoreGrade_Class.GetDataByStudentAndTerm(CurRecordClass.studentNo, CurRecordClass.termNo);
                for (int i = 0; i < d_table.Rows.Count; i++)
                {
                    try
                    {
                        string p_courseNo = d_table.Rows[i]["courseNo"].ToString().Trim().Replace("2600", "");
                        p_courseNo = d_courselist[Convert.ToInt32(p_courseNo)-1];
                        string timesterm = d_table.Rows[i]["teamtimes"].ToString().Trim();
                        dw["ScoreGrade_scoregrade_" + p_courseNo + "_" + timesterm] = d_table.Rows[i]["scoregrade"].ToString().Trim();
                        dw["ScoreGrade_readinggrade_" + p_courseNo + "_" + timesterm] = d_table.Rows[i]["readinggrade"].ToString().Trim();
                        dw["ScoreGrade_compositiongrade_" + p_courseNo + "_" + timesterm] = d_table.Rows[i]["compositiongrade"].ToString().Trim();
                        dw["ScoreGrade_practicegrade_" + p_courseNo + "_" + timesterm] = d_table.Rows[i]["practicegrade"].ToString().Trim();
                        dw["ScoreGrade_Writegrade_" + p_courseNo + "_" + timesterm] = d_table.Rows[i]["Writegrade"].ToString().Trim();
                        dw["ScoreGrade_attitudegrade_" + p_courseNo + "_" + timesterm] = d_table.Rows[i]["attitudegrade"].ToString().Trim();
                    }
                    catch { }

                    // CurScorelist[i].FillInputByClass(p_id, p_name, p_date, p_results, "");
                }
            }
            catch (Exception ex)
            { }
            #endregion

            #region 班级荣誉
            d_table = Honors_Class.GetDataByStudentAndTerm(CurRecordClass.studentNo, CurRecordClass.termNo);
            for (int i = 0; i < d_table.Rows.Count; i++)
            {
                try
                {


                    string p_name = d_table.Rows[i]["Awardname"].ToString().Trim();
                    string p_date = d_table.Rows[i]["Awarddate"].ToString().Trim();
                    string p_results = d_table.Rows[i]["Awarddep"].ToString().Trim();
                    try
                    {
                        dw["honors_Awarddep_" + Convert.ToString(i + 1)] = p_results;
                        dw["honors_Awarddate_" + Convert.ToString(i + 1)] = p_date;
                        dw["honors_Awardname_" + Convert.ToString(i + 1)] = p_name;
                    }
                    catch { }
                }
                catch (Exception ex)
                { }
            }
            #endregion

            #region 教育教学活动记录

            d_table = Evaluation_Class.GetDataByStudentAndTerm(CurRecordClass.studentNo, CurRecordClass.termNo, "课外活动");
            int d_count = 0;
            for (int i = 0; i < d_table.Rows.Count; i++)
            {
                try
                {
                    string p_name = d_table.Rows[i]["item"].ToString().Trim();
                    string p_date = d_table.Rows[i]["Quantity"].ToString().Trim();
                    string p_results = d_table.Rows[i]["results"].ToString().Trim();
                    switch (p_name)
                    {
                        case "社会调查":
                            dw["Evaluation_results_shehui"] = p_results;
                            dw["Evaluation_Quantity_shehui"] = p_date;
                            break;
                        case "阅读书籍":
                            dw["Evaluation_results_yuedu"] = p_results;
                            dw["Evaluation_Quantity_yuedu"] = p_date;
                            break;
                        case "社团活动":
                            dw["Evaluation_results_shetuan"] = p_results;
                            dw["Evaluation_Quantity_shetuan"] = p_date;
                            break;
                        case "社区活动":
                            dw["Evaluation_results_shequ"] = p_results;
                            dw["Evaluation_Quantity_shequ"] = p_date;
                            break;
                        default:
                            try
                            {
                                dw["Evaluation_results_" + Convert.ToString(i + 1)] = p_results;
                                dw["Evaluation_Quantity_" + Convert.ToString(i + 1)] = p_date;
                                dw["Evaluation_item_" + Convert.ToString(i + 1)] = p_name;
                            }
                            catch { }
                            break;
                    }
                }
                catch (Exception ex)
                { }

            }
            d_table = Evaluation_Class.GetDataByStudentAndTerm(CurRecordClass.studentNo, CurRecordClass.termNo, "研究课题");
            for (int i = 0; i < d_table.Rows.Count; i++)
            {
                string p_name = d_table.Rows[i]["item"].ToString().Trim();
                string p_date = d_table.Rows[i]["createdate"].ToString().Trim();
                string p_results = d_table.Rows[i]["results"].ToString().Trim();
                try
                {
                    dw["Evaluation_results_" + Convert.ToString(i + 6)] = p_results;
                    dw["Evaluation_createdate_" + Convert.ToString(i + 6)] = p_date;
                    dw["Evaluation_item_" + Convert.ToString(i + 6)] = p_name;
                }
                catch { }

            }
            #endregion
            dt.Rows.Add(dw);
            return dt;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_id"></param>
        /// <param name="p_printstatus">0打印，1预览</param>
        public static void PrintReport(int p_id, int p_printstatus)
        {
            C1.Win.C1Report.C1Report d_report = new C1.Win.C1Report.C1Report();
            d_report.Load(Public_Class.dir + @"\report\ScoreReport.xml", "ScoreRecord");
            d_report.DataSource.Recordset = PrintDataSource(p_id);
            //Cursor = Cursors.WaitCursor;
            d_report.Render();
            //Cursor = Cursors.Default;
            if (p_printstatus == 0)
            {
                PrintDialog d_dialog = new PrintDialog();
                d_dialog.Document = d_report.Document;
                d_dialog.Document.Print();
            }
            else
            {
                PrintPreviewDialog d_dialog = new PrintPreviewDialog();
                d_dialog.Document = d_report.Document;
                d_dialog.WindowState = FormWindowState.Maximized;
                d_dialog.PrintPreviewControl.Zoom = 1;
                d_dialog.ShowDialog();
            }
        }
    }
}
