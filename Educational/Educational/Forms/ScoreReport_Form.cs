using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Educational.Class;

namespace Educational.Forms
{

    public partial class ScoreReport_Form : Form
    {
        public ScoreReport_Form()
        {
            InitializeComponent();
            CurRecordClass = new ScoreRecord_Class(1);
        }
        public ScoreReport_Form(int p_id)
        {
            InitializeComponent();
            CurRecordClass = new ScoreRecord_Class(p_id);
        }
        private void ScoreReport_Form_Load(object sender, EventArgs e)
        {
            //CurRecordClass = new ScoreRecord_Class(1);
            if (CurRecordClass.ID == 0)
                return;
            Student_Class d_student = new Student_Class(CurRecordClass.studentNo);
            ClassStudent_Class d_class = new ClassStudent_Class(d_student.classtudentNo);
            studentinfo_label.Text = "    ";
            studentinfo_label.Text += "编号：" + CurRecordClass.ID.ToString() + "    ";
            studentinfo_label.Text += "班级：" + d_class.classtudentName.ToString() + "    ";
            studentinfo_label.Text += "姓名：" + d_student.studentName.ToString() + "    ";
            studentinfo_label.Text += "学号：" + d_student.studentNo.ToString() + "    ";

            #region 班级荣誉
            Curhonorslist = new List<TextBoxList>();
            Curhonorslist.Add(new TextBoxList(this.honors_Awardname_1, this.honors_Awarddate_1, this.honors_Awarddep_1, "honors", "", CurRecordClass.termNo, CurRecordClass.studentNo));
            Curhonorslist.Add(new TextBoxList(this.honors_Awardname_2, this.honors_Awarddate_2, this.honors_Awarddep_2, "honors", "", CurRecordClass.termNo, CurRecordClass.studentNo));
            Curhonorslist.Add(new TextBoxList(this.honors_Awardname_3, this.honors_Awarddate_3, this.honors_Awarddep_3, "honors", "", CurRecordClass.termNo, CurRecordClass.studentNo));
            Curhonorslist.Add(new TextBoxList(this.honors_Awardname_4, this.honors_Awarddate_4, this.honors_Awarddep_4, "honors", "", CurRecordClass.termNo, CurRecordClass.studentNo));
            Curhonorslist.Add(new TextBoxList(this.honors_Awardname_5, this.honors_Awarddate_5, this.honors_Awarddep_5, "honors", "", CurRecordClass.termNo, CurRecordClass.studentNo));
            Curhonorslist.Add(new TextBoxList(this.honors_Awardname_6, this.honors_Awarddate_6, this.honors_Awarddep_6, "honors", "", CurRecordClass.termNo, CurRecordClass.studentNo));
            Curhonorslist.Add(new TextBoxList(this.honors_Awardname_7, this.honors_Awarddate_7, this.honors_Awarddep_7, "honors", "", CurRecordClass.termNo, CurRecordClass.studentNo));
            Curhonorslist.Add(new TextBoxList(this.honors_Awardname_8, this.honors_Awarddate_8, this.honors_Awarddep_8, "honors", "", CurRecordClass.termNo, CurRecordClass.studentNo));
            #endregion

            #region 课程
            DataTable dt = new DataTable();
            dt = Course_Class.GetALL();
            Dictionary<string, string> d_Course = new Dictionary<string, string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d_Course.Add(dt.Rows[i]["Coursename"].ToString().Trim(), dt.Rows[i]["Courseno"].ToString().Trim());
            }



            CurScorelist = new List<TextBoxScorelist>();
            string d_coursename = "社会";
            TextBoxScore[] pScore = new TextBoxScore[3];
            pScore[0] = new TextBoxScore(this.ScoreGrade_scoregrade_sh_0, this.ScoreGrade_attitudegrade_sh_0, 0, d_Course[d_coursename]);
            pScore[1] = new TextBoxScore(this.ScoreGrade_scoregrade_sh_1, this.ScoreGrade_attitudegrade_sh_1, 1, d_Course[d_coursename]);
            pScore[2] = new TextBoxScore(this.ScoreGrade_scoregrade_sh_2, this.ScoreGrade_attitudegrade_sh_2, 2, d_Course[d_coursename]);
            CurScorelist.Add(new TextBoxScorelist(pScore, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            pScore = new TextBoxScore[3];
            d_coursename = "语文";
            pScore[0] = new TextBoxScore(0, d_Course[d_coursename], this.ScoreGrade_scoregrade_yw_0, this.ScoreGrade_attitudegrade_yw_0, this.ScoreGrade_Writegrade_yw_0, this.ScoreGrade_compositiongrade_yw_0, this.ScoreGrade_practicegrade_yw_0, this.ScoreGrade_readinggrade_yw_0);
            pScore[1] = new TextBoxScore(1, d_Course[d_coursename], this.ScoreGrade_scoregrade_yw_1, this.ScoreGrade_attitudegrade_yw_1, this.ScoreGrade_Writegrade_yw_1, this.ScoreGrade_compositiongrade_yw_1, this.ScoreGrade_practicegrade_yw_1, this.ScoreGrade_readinggrade_yw_1);
            pScore[2] = new TextBoxScore(2, d_Course[d_coursename], this.ScoreGrade_scoregrade_yw_2, this.ScoreGrade_attitudegrade_yw_2, this.ScoreGrade_Writegrade_yw_2, this.ScoreGrade_compositiongrade_yw_2, this.ScoreGrade_practicegrade_yw_2, this.ScoreGrade_readinggrade_yw_2);
            CurScorelist.Add(new TextBoxScorelist(pScore, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            pScore = new TextBoxScore[3];
            d_coursename = "数学";
            pScore[0] = new TextBoxScore(0, d_Course[d_coursename], this.ScoreGrade_scoregrade_sx_0, this.ScoreGrade_attitudegrade_sx_0, null, null, this.ScoreGrade_practicegrade_sx_0, null);
            pScore[1] = new TextBoxScore(1, d_Course[d_coursename], this.ScoreGrade_scoregrade_sx_1, this.ScoreGrade_attitudegrade_sx_1, null, null, this.ScoreGrade_practicegrade_sx_1, null);
            pScore[2] = new TextBoxScore(2, d_Course[d_coursename], this.ScoreGrade_scoregrade_sx_2, this.ScoreGrade_attitudegrade_sx_2, null, null, this.ScoreGrade_practicegrade_sx_2, null);
            CurScorelist.Add(new TextBoxScorelist(pScore, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            pScore = new TextBoxScore[3];
            d_coursename = "英语";
            pScore[0] = new TextBoxScore(0, d_Course[d_coursename], this.ScoreGrade_scoregrade_yy_0, this.ScoreGrade_attitudegrade_yy_0, this.ScoreGrade_Writegrade_yy_0, this.ScoreGrade_compositiongrade_yy_0, this.ScoreGrade_practicegrade_yy_0, null);
            pScore[1] = new TextBoxScore(1, d_Course[d_coursename], this.ScoreGrade_scoregrade_yy_1, this.ScoreGrade_attitudegrade_yy_1, this.ScoreGrade_Writegrade_yy_1, this.ScoreGrade_compositiongrade_yy_1, this.ScoreGrade_practicegrade_yy_1, null);
            pScore[2] = new TextBoxScore(2, d_Course[d_coursename], this.ScoreGrade_scoregrade_yy_2, this.ScoreGrade_attitudegrade_yy_2, this.ScoreGrade_Writegrade_yy_2, this.ScoreGrade_compositiongrade_yy_2, this.ScoreGrade_practicegrade_yy_2, null);
            CurScorelist.Add(new TextBoxScorelist(pScore, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            pScore = new TextBoxScore[3];
            d_coursename = "科学";
            pScore[0] = new TextBoxScore(0, d_Course[d_coursename], this.ScoreGrade_scoregrade_kx_0, this.ScoreGrade_attitudegrade_kx_0, this.ScoreGrade_Writegrade_kx_0, null, this.ScoreGrade_practicegrade_kx_0, null);
            pScore[1] = new TextBoxScore(1, d_Course[d_coursename], this.ScoreGrade_scoregrade_kx_1, this.ScoreGrade_attitudegrade_kx_1, this.ScoreGrade_Writegrade_kx_1, null, this.ScoreGrade_practicegrade_kx_1, null);
            pScore[2] = new TextBoxScore(2, d_Course[d_coursename], this.ScoreGrade_scoregrade_kx_2, this.ScoreGrade_attitudegrade_kx_2, this.ScoreGrade_Writegrade_kx_2, null, this.ScoreGrade_practicegrade_kx_2, null);
            CurScorelist.Add(new TextBoxScorelist(pScore, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            TextBoxScore pScoreTotal;

            d_coursename = "音乐";
            pScoreTotal = new TextBoxScore(this.ScoreGrade_scoregrade_music_0, this.ScoreGrade_attitudegrade_music_0, 0, d_Course[d_coursename]);
            CurScorelist.Add(new TextBoxScorelist(pScoreTotal, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));

            d_coursename = "体育";
            pScoreTotal = new TextBoxScore(this.ScoreGrade_scoregrade_ty_0, this.ScoreGrade_attitudegrade_ty_0, 0, d_Course[d_coursename]);
            CurScorelist.Add(new TextBoxScorelist(pScoreTotal, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            //pScoreTotal = new TextBoxScore();
            d_coursename = "美术";
            pScoreTotal = new TextBoxScore(this.ScoreGrade_scoregrade_ms_0, this.ScoreGrade_attitudegrade_ms_0, 0, d_Course[d_coursename]);
            CurScorelist.Add(new TextBoxScorelist(pScoreTotal, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            //pScoreTotal = new TextBoxScore[1];
            d_coursename = "信息技术";
            pScoreTotal = new TextBoxScore(this.ScoreGrade_scoregrade_it_0, null, 0, d_Course[d_coursename]);
            CurScorelist.Add(new TextBoxScorelist(pScoreTotal, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            //pScoreTotal = new TextBoxScore[1];
            d_coursename = "社区服务与社会实践";
            pScoreTotal = new TextBoxScore(this.ScoreGrade_scoregrade_sq_0, null, 0, d_Course[d_coursename]);
            CurScorelist.Add(new TextBoxScorelist(pScoreTotal, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            //pScoreTotal = new TextBoxScore[1];
            d_coursename = "研究性学习";
            pScoreTotal = new TextBoxScore(this.ScoreGrade_scoregrade_yj_0, null, 0, d_Course[d_coursename]);
            CurScorelist.Add(new TextBoxScorelist(pScoreTotal, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            //pScoreTotal = new TextBoxScore[1];
            d_coursename = "劳动与技术";
            pScoreTotal = new TextBoxScore(this.ScoreGrade_scoregrade_ld_0, null, 0, d_Course[d_coursename]);
            CurScorelist.Add(new TextBoxScorelist(pScoreTotal, d_coursename, d_Course[d_coursename], CurRecordClass.studentNo, CurRecordClass.termNo));
            #endregion

            #region 教育教学活动记录
            CurEvaluationlist = new List<TextBoxList>();
            CurEvaluationlist.Add(new TextBoxList("社会调查", this.Evaluation_Quantity_shehui, this.Evaluation_results_shehui, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList("阅读书籍", this.Evaluation_Quantity_yuedu, this.Evaluation_results_yuedu, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList("社团活动", this.Evaluation_Quantity_shetuan, this.Evaluation_results_shetuan, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList("社区活动", this.Evaluation_Quantity_shequ, this.Evaluation_results_shequ, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_1, this.Evaluation_Quantity_1, this.Evaluation_results_1, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_2, this.Evaluation_Quantity_2, this.Evaluation_results_2, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_3, this.Evaluation_Quantity_3, this.Evaluation_results_3, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_4, this.Evaluation_Quantity_4, this.Evaluation_results_4, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_5, this.Evaluation_Quantity_5, this.Evaluation_results_5, "Evaluation", "课外活动", CurRecordClass.termNo, CurRecordClass.studentNo));

            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_6, this.Evaluation_createdate_6, this.Evaluation_results_6, "Evaluation", "研究课题", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_7, this.Evaluation_createdate_7, this.Evaluation_results_7, "Evaluation", "研究课题", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_8, this.Evaluation_createdate_8, this.Evaluation_results_8, "Evaluation", "研究课题", CurRecordClass.termNo, CurRecordClass.studentNo));
            CurEvaluationlist.Add(new TextBoxList(this.Evaluation_item_9, this.Evaluation_createdate_9, this.Evaluation_results_9, "Evaluation", "研究课题", CurRecordClass.termNo, CurRecordClass.studentNo));


            #endregion


            FillInputByClass();
        }
        private ScoreRecord_Class CurRecordClass = new ScoreRecord_Class();
        private List<TextBoxList> Curhonorslist;
        private List<TextBoxList> CurEvaluationlist;
        private List<TextBoxScorelist> CurScorelist;
        private void FillInputByClass()
        {

            this.ScoreRecord_specialtyelectivegrade.Text = CurRecordClass.SpecialtyElectiveGrade;
            this.ScoreRecord_specialtyelective.Text = CurRecordClass.SpecialtyElective;
            this.ScoreRecord_schoolcoursenametwo.Text = CurRecordClass.SchoolCourseNameTwo;
            this.ScoreRecord_schoolcoursename.Text = CurRecordClass.SchoolCourseName;
            this.ScoreRecord_schoolcoursegradetwo.Text = CurRecordClass.SchoolCourseGradeTwo;
            this.ScoreRecord_schoolcoursegrade.Text = CurRecordClass.SchoolCourseGrade;
            this.ScoreRecord_productlevel.Text = CurRecordClass.Productlevel;
            this.ScoreRecord_parenthope.Text = CurRecordClass.Parenthope;
            this.ScoreRecord_myevaluate.Text = CurRecordClass.MyEvaluate;
            this.ScoreRecord_leave.Text = CurRecordClass.leave;
            this.ScoreRecord_classjob.Text = CurRecordClass.classjob;
            this.ScoreRecord_attendance.Text = CurRecordClass.Attendance;
            this.ScoreRecord_absenteeism.Text = CurRecordClass.Absenteeism;


            DataTable dt = new DataTable();

            #region 课程
            try
            {
                dt = ScoreGrade_Class.GetDataByStudentAndTerm(CurRecordClass.studentNo, CurRecordClass.termNo);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int p_id = Convert.ToInt32(dt.Rows[i]["id"]);
                    string p_courseNo = dt.Rows[i]["courseNo"].ToString().Trim();
                    foreach (TextBoxScorelist item in CurScorelist)
                    {
                        if (item.pcourseno == p_courseNo)
                        {
                            item.FillInputByClass(dt.Rows[i]);
                            break;
                        }
                    }
                    // CurScorelist[i].FillInputByClass(p_id, p_name, p_date, p_results, "");
                }
            }
            catch (Exception ex)
            { }
            #endregion

            #region 班级荣誉
            dt = Honors_Class.GetDataByStudentAndTerm(CurRecordClass.studentNo, CurRecordClass.termNo);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    int p_id = Convert.ToInt32(dt.Rows[i]["id"]);

                    string p_name = dt.Rows[i]["Awardname"].ToString().Trim();
                    string p_date = dt.Rows[i]["Awarddate"].ToString().Trim();
                    string p_results = dt.Rows[i]["Awarddep"].ToString().Trim();
                    Curhonorslist[i].FillInputByClass(p_id, p_name, p_date, p_results);
                    if (i >= 7)
                        break;
                }
                catch (Exception ex)
                { }
            }
            #endregion

            #region 教育教学活动记录
            dt = Evaluation_Class.GetDataByStudentAndTerm(CurRecordClass.studentNo, CurRecordClass.termNo, "课外活动");
            int d_count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    int p_id = Convert.ToInt32(dt.Rows[i]["id"]);
                    string p_name = dt.Rows[i]["item"].ToString().Trim();
                    string p_date = dt.Rows[i]["Quantity"].ToString().Trim();
                    string p_results = dt.Rows[i]["results"].ToString().Trim();
                    bool inputflag = false;
                    foreach (TextBoxList item in CurEvaluationlist)
                    {
                        if (item.p_labelname == "")
                            break;
                        else if (item.p_labelname == p_name)
                        {
                            item.FillInputByClass(p_id, p_name, p_date, p_results);
                            inputflag = true;
                            break;
                        }
                    }
                    if ((inputflag == false) && (d_count < 5))
                    {
                        CurEvaluationlist[d_count + 4].FillInputByClass(p_id, p_name, p_date, p_results);
                        d_count++;
                        //if (d_count >= 5)
                        //    break;
                    }
                }
                catch (Exception ex)
                { }

            }
            dt = Evaluation_Class.GetDataByStudentAndTerm(CurRecordClass.studentNo, CurRecordClass.termNo, "研究课题");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int p_id = Convert.ToInt32(dt.Rows[i]["id"]);
                string p_name = dt.Rows[i]["item"].ToString().Trim();
                string p_date = dt.Rows[i]["createdate"].ToString().Trim();
                string p_results = dt.Rows[i]["results"].ToString().Trim();
                CurEvaluationlist[i + 9].FillInputByClass(p_id, p_name, p_date, p_results);
                if (i >= 4)
                    break;
            }
            #endregion

        }
        private void FillClassByInput()
        {
            CurRecordClass.SpecialtyElectiveGrade = this.ScoreRecord_specialtyelectivegrade.Text;
            CurRecordClass.SpecialtyElective = this.ScoreRecord_specialtyelective.Text;
            CurRecordClass.SchoolCourseNameTwo = this.ScoreRecord_schoolcoursenametwo.Text;
            CurRecordClass.SchoolCourseName = this.ScoreRecord_schoolcoursename.Text;
            CurRecordClass.SchoolCourseGradeTwo = this.ScoreRecord_schoolcoursegradetwo.Text;
            CurRecordClass.SchoolCourseGrade = this.ScoreRecord_schoolcoursegrade.Text;
            CurRecordClass.Productlevel = this.ScoreRecord_productlevel.Text;
            CurRecordClass.Parenthope = this.ScoreRecord_parenthope.Text;
            CurRecordClass.MyEvaluate = this.ScoreRecord_myevaluate.Text;
            CurRecordClass.leave = this.ScoreRecord_leave.Text;
            CurRecordClass.classjob = this.ScoreRecord_classjob.Text;
            CurRecordClass.Attendance = this.ScoreRecord_attendance.Text;
            CurRecordClass.Absenteeism = this.ScoreRecord_absenteeism.Text;
            CurRecordClass.Update();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            FillClassByInput();
            #region 课程
            foreach (TextBoxScorelist item in CurScorelist)
            {
                item.Save();
            }


            #endregion

            #region 班级荣誉
            foreach (TextBoxList item in Curhonorslist)
            {
                if ((item.pID == 0) && item.textbox_name.Text == "")
                {

                }
                else
                    item.Save();
            }

            #endregion

            #region 教育教学活动记录
            foreach (TextBoxList item in CurEvaluationlist)
            {

                item.Save();
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}