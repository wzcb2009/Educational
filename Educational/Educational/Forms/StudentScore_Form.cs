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
    public partial class StudentScore_Form : Form
    {
        public StudentScore_Form()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> termlist = new Dictionary<string, string>();
        private Dictionary<string, string> ClassStudentlist = new Dictionary<string, string>();
        private void StudentScore_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = term_Class.GetDataYears();
            comboBox_years.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBox_years.Items.Add(dt.Rows[i]["years"].ToString().Trim());
            }
            if (DateTime.Now.Month < 8)
                comboBox_years.Text = Convert.ToString(DateTime.Now.Year - 1);
            else
                comboBox_years.Text = Convert.ToString(DateTime.Now.Year);
            if (comboBox_years.Items.Count == 1)
                comboBox_years.SelectedIndex = 0;

            dt = ClassStudent_Class.GetDataYeargrade();
            comboBox_yeargrade.Items.Clear();
            comboBox_yeargrade.Items.Add("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.comboBox_yeargrade.Items.Add(dt.Rows[i]["yeargrade"].ToString().Trim()  );
            }

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string termno = "";
            if (this.comboBox_term.Text.Trim() != "")
                termno = termlist[this.comboBox_term.Text.Trim()];
            string classtudentNo = "";
            if (this.comboBox_classname.Text.Trim() != "")
                classtudentNo = ClassStudentlist[this.comboBox_classname.Text.Trim()];
            DataTable dt = new DataTable();
            dt = ScoreRecord_Class.GetRecordList(classtudentNo, termno, this.textBox_studentname.Text.Trim(), this.textBox_studentno.Text.Trim(), this.comboBox_printstatus.Text.Trim(), comboBox_Recordstatus.Text.Trim(),this.comboBox_yeargrade.Text.Trim ());
            this.gridControl_RecordList.DataSource = dt;
            this.gridView_RecordList.RefreshData();
        }

        private void comboBox_years_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = term_Class.GetDataByYears(this.comboBox_years.Text);
            comboBox_term.Items.Clear();
            termlist.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string temp = dt.Rows[i]["termname"].ToString().Trim().Replace(this.comboBox_years.Text.Trim() + "年", "");
                termlist.Add(temp, dt.Rows[i]["termno"].ToString().Trim());
                this.comboBox_term.Items.Add(temp);
            }
            if (comboBox_term.Items.Count == 1)
                comboBox_term.SelectedIndex = 0;
        }

        private void comboBox_yeargrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_classname.Items.Clear();
            comboBox_classname.Items.Add("");
            ClassStudentlist.Clear();
            if (comboBox_yeargrade.Text.Trim() != "")
            {
                DataTable dt = new DataTable();
                dt = ClassStudent_Class.GetDataByYeargrade(this.comboBox_yeargrade.Text );
                //comboBox_classname.Items.Clear();
                //comboBox_classname.Items.Add("");
                //ClassStudentlist.Clear.Replace(this.comboBox_yeargrade.Text.Trim() , "")
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string temp = dt.Rows[i]["classtudentName"].ToString().Trim().Replace(this.comboBox_yeargrade.Text.Trim(), "");
                    ClassStudentlist.Add(temp, dt.Rows[i]["classtudentNo"].ToString().Trim());
                    this.comboBox_classname.Items.Add(temp);
                }
                if (comboBox_classname.Items.Count == 1)
                    comboBox_classname.SelectedIndex = 0;
            }
        }

        private void gridControl_RecordList_DoubleClick(object sender, EventArgs e)
        {
            DataTable d_DTable = new DataTable();
            d_DTable = (DataTable)gridControl_RecordList.DataSource;
            if (d_DTable == null)
            {

                MessageBox.Show("请先查出要操作的记录", "错误");
                return;
            }

            if (d_DTable.Rows.Count == 0)
            {
                MessageBox.Show("请先查出要操作的记录", "错误");
                return;
            }

            string temp_id = d_DTable.Rows[gridView_RecordList.GetDataSourceRowIndex(gridView_RecordList.FocusedRowHandle)]["ID"].ToString();
            if (temp_id == "")
            {
                MessageBox.Show("请先查出要操作的记录", "错误");
                return;
            }
            int p_id = Convert.ToInt32(temp_id);
            ScoreRecord_Class d_class = new ScoreRecord_Class(p_id);
            if (d_class.ID == 0)
            {
                MessageBox.Show("无效选择，请重新选择", "错误");
                return;
            }
            ScoreReport_Form d_from = new ScoreReport_Form(p_id);
            d_from.MdiParent = this.MdiParent;
            d_from.Show();

        }
    }
}