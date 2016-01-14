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
    public partial class CreateScoreRecord_Form : Form
    {
        public CreateScoreRecord_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Dictionary<string, string> termlist = new Dictionary<string, string>();
        private void CreateScoreRecord_Form_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string d_year = this.comboBox_years.Text.Trim();
            int d_years = Convert.ToInt32(d_year);
              string termno = "";
            if (this.comboBox_term.Text.Trim() != "")
                termno = termlist[this.comboBox_term.Text.Trim()];
            else
                return ;
         bool d_flag=   ScoreRecord_Class.InsertByUpdate(termno, Convert.ToString(d_years - 2) + "级", Convert.ToString(d_years - 1) + "级", d_year + "级");
         if (d_flag == true)
             MessageBox.Show("生成成功！");
         else
             MessageBox.Show("生成失败！");
        }
    }
}