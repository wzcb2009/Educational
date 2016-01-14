using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Educational.Class
{
    public class Public_Class
    {
    }
    #region TextBoxList
    public class TextBoxList
    {
        public int pID;
        public string pstudentno;
        public string ptermNo;
        public string ptype;
        public TextBox textbox_name;
        public TextBox textbox_date;
        public TextBox textbox_results;
        public string p_tablename;
        public string p_labelname;
        public TextBoxList(string p_name, TextBox p_date, TextBox p_result, string p_table, string p_type, string p_termNo, string p_studentno)
        {
            pID = 0;
            p_labelname = p_name;
            textbox_name = null;
            textbox_date = p_date;
            textbox_results = p_result;
            p_tablename = p_table;
            ptype = p_type;
            pstudentno = p_studentno;
            ptermNo = p_termNo;
        }

        public TextBoxList(TextBox p_name, TextBox p_date, TextBox p_result, string p_table, string p_type, string p_termNo, string p_studentno)
        {
            pID = 0;
            p_labelname = "";
            textbox_name = p_name;
            textbox_date = p_date;
            textbox_results = p_result;
            p_tablename = p_table;
            ptype = p_type;
            pstudentno = p_studentno;
            ptermNo = p_termNo;
        }
        public bool Save()
        {
            if (pID > 0)
                return Update();
            else
                return Insert();
        }
        public bool Insert()
        {

            if (p_tablename == "honors")
            {
                Honors_Class d_class = new Honors_Class();
                d_class.Awarddep = textbox_results.Text.Trim();
                d_class.Awardname = textbox_name.Text.Trim();
                try
                {
                    d_class.Awarddate = Convert.ToDateTime(textbox_date.Text.Trim());
                }
                catch { d_class.Awarddate = DateTime.Now; }
                d_class.termNo = ptermNo;
                d_class.studentNo = pstudentno;
                return d_class.Insert();
            }
            else if (p_tablename == "Evaluation")
            {
                Evaluation_Class d_class = new Evaluation_Class();
                d_class.termNo = ptermNo;
                d_class.studentNo = pstudentno;
                d_class.itemtype = ptype;
                d_class.results = textbox_results.Text.Trim();
                if (p_labelname != "")
                {
                    d_class.item = p_labelname;
                    if (textbox_date.Text.Trim() == "")
                        return true;
                }
                else
                {
                    d_class.item = textbox_name.Text.Trim();
                    if (d_class.item == "")
                        return true;
                }
                d_class.Quantity = textbox_date.Text.Trim();
                try
                {
                    d_class.createdate = Convert.ToDateTime(textbox_date.Text.Trim());
                }
                catch
                {
                    d_class.createdate = DateTime.Now;
                }
                return d_class.Insert();
            }
            return true;

        }
        public bool Update()
        {

            if (p_tablename == "honors")
            {
                return Honors_Class.UpdateAward(pID.ToString(), textbox_results.Text.Trim(), textbox_name.Text.Trim(), textbox_date.Text.Trim());
            }
            else if (p_tablename == "Evaluation")
            {
                string p_tempname = "";
                if (p_labelname != "")
                    p_tempname = p_labelname;
                else
                    p_tempname = textbox_name.Text.Trim();

                return Evaluation_Class.UpdateByID(pID.ToString(), textbox_results.Text.Trim(), p_tempname, textbox_date.Text.Trim(), ptype);
            }
            return true;

        }
        public void FillInputByClass(int p_id, string p_name, string p_date, string p_result)
        {
            pID = p_id;
            if (p_labelname == "")
                textbox_name.Text = p_name;
            textbox_date.Text = p_date;
            textbox_results.Text = p_result;

        }
    };
    #endregion


    #region TextBoxScorelist
    public class TextBoxScorelist
    {
        public string pstudentno = "";
        public string ptermNo = "";
        public string pcourseno;
        public string pcoursename;
        public TextBoxScore[] pScore;
        public TextBoxScorelist(TextBoxScore[] p_Score, string p_coursename, string p_courseno, string p_studentno, string p_termNo)
        {
            pScore = p_Score;
            pcoursename = p_coursename;
            pcourseno = p_courseno;
            ptermNo = p_termNo;
            pstudentno = p_studentno;
        }
        public TextBoxScorelist(TextBoxScore p_Score, string p_coursename, string p_courseno, string p_studentno, string p_termNo)
        {
            pScore = new TextBoxScore[1];
            pScore[0] = p_Score;
            pcoursename = p_coursename;
            pcourseno = p_courseno;
            ptermNo = p_termNo;
            pstudentno = p_studentno;
        }
        public void FillInputByClass(DataRow dw)
        {
            pScore[Convert.ToInt32(dw["teamtimes"])].FillInputByClass(dw);
        }
        public bool Save()
        {
            foreach (TextBoxScore item in pScore)
            {
                item.Save(pstudentno, ptermNo, pcourseno);
            }
            return true;
        }
    }
    public class TextBoxScore
    {
        public int pID;
        /// <summary>
        /// 1、期中，2、期末、3总评
        /// </summary>
        public int teamtimes;
        //  public string[] pname="";
        //public string pvalues = "";
        public string pcourseno;
        public string pcoursename;
        /// <summary>
        /// 检测
        /// </summary>
        public ComboBox textbox_scoregrade;
        /// <summary>
        /// 态度与行为/习惯与态度/体育技能
        /// </summary>
        public ComboBox textbox_attitudegrade;
        /// <summary>
        /// 书写/制作
        /// </summary>
        public ComboBox textbox_Writegrade;
        /// <summary>
        /// 写作
        /// </summary>
        public ComboBox textbox_compositiongrade;
        /// <summary>
        /// 朗读与表达 /实践运用能力/口语/实践
        /// </summary>
        public ComboBox textbox_practicegrade;
        /// <summary>
        /// 课外阅读积累
        /// </summary>
        public ComboBox textbox_readinggrade;

        //  public string p_tablename;
        public TextBoxScore(ComboBox p_scoregrade, ComboBox p_attitudegrade, int p_teamtimes, string p_courseno)
        {
            pID = 0;
            teamtimes = p_teamtimes;
            pcourseno = p_courseno;
            pcoursename = "";
            textbox_scoregrade = p_scoregrade;
            textbox_attitudegrade = p_attitudegrade;
            textbox_Writegrade = null;
            textbox_compositiongrade = null;
            textbox_practicegrade = null;
            textbox_readinggrade = null;
        }
        public TextBoxScore(int p_teamtimes, string p_courseno, ComboBox p_scoregrade, ComboBox p_attitudegrade, ComboBox p_Writegrade, ComboBox p_compositiongrade, ComboBox p_practicegrade, ComboBox p_readinggrade)
        {
            pID = 0;
            teamtimes = p_teamtimes;
            pcourseno = p_courseno;
            pcoursename = "";
            textbox_scoregrade = p_scoregrade;
            textbox_attitudegrade = p_attitudegrade;
            textbox_Writegrade = p_Writegrade;
            textbox_compositiongrade = p_compositiongrade;
            textbox_practicegrade = p_practicegrade;
            textbox_readinggrade = p_readinggrade;
        }
        public bool Save(string p_studentno, string p_termNo, string p_courseNo)
        {
            ScoreGrade_Class d_class = new ScoreGrade_Class(pID);
            d_class.termNo = p_termNo;
            d_class.teamtimes = teamtimes;
            d_class.studentNo = p_studentno;
            //d_class.Remarks = "";
            //d_class.othergrade = "";
            //d_class.info = "";
            d_class.courseNo = p_courseNo;
            if (textbox_attitudegrade != null)
                d_class.attitudegrade = textbox_attitudegrade.Text.Trim();
            if (textbox_compositiongrade != null)
                d_class.compositiongrade = textbox_compositiongrade.Text.Trim();
            if (textbox_practicegrade != null)
                d_class.practicegrade = textbox_practicegrade.Text.Trim();
            if (textbox_readinggrade != null)
                d_class.readinggrade = textbox_readinggrade.Text.Trim();
            if (textbox_scoregrade != null)
                d_class.scoregrade = textbox_scoregrade.Text.Trim();
            if (textbox_Writegrade != null)
                d_class.Writegrade = textbox_Writegrade.Text.Trim();
            if (d_class.ID > 0)
                return d_class.Update();
            else
                return d_class.Insert();

        }


        public void FillInputByClass(DataRow dw)
        {

            pID = Convert.ToInt32(dw["id"]);
            teamtimes = Convert.ToInt32(dw["teamtimes"]);
            pcourseno = dw["courseno"].ToString().Trim();
            if (textbox_scoregrade != null)
                textbox_scoregrade.Text = dw["scoregrade"].ToString().Trim();
            if (textbox_attitudegrade != null)
                textbox_attitudegrade.Text = dw["attitudegrade"].ToString().Trim();
            if (textbox_Writegrade != null)
                textbox_Writegrade.Text = dw["Writegrade"].ToString().Trim();
            if (textbox_compositiongrade != null)
                textbox_compositiongrade.Text = dw["compositiongrade"].ToString().Trim();
            if (textbox_practicegrade != null)
                textbox_practicegrade.Text = dw["practicegrade"].ToString().Trim();
            if (textbox_readinggrade != null)
                textbox_readinggrade.Text = dw["readinggrade"].ToString().Trim();
        }
    };
    #endregion

}
