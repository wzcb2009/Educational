using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Educational.Forms;
using Educational.Class;

namespace Educational
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Public_Class.dir = Application.StartupPath;
            StudentScore_Form d_form = new StudentScore_Form();
            // d_form.IsMdiChild = true;
            d_form.MdiParent = this;
            d_form.Show();
        }

        private void 导入学期记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateScoreRecord_Form d_form = new CreateScoreRecord_Form();
            d_form.MdiParent = this;
            d_form.Show();

        }

        private void 工资查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_Salary_Form d_form = new Teacher_Salary_Form();
            d_form.MdiParent = this;
            d_form.Show();
        }

        private void 阅卷系统同步ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Score_Sync_Form d_form = new Score_Sync_Form();
            d_form.MdiParent = this;
            d_form.Show();
        }
    }
}