using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Educational.Forms;

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
            StudentScore_Form d_form = new StudentScore_Form();
           // d_form.IsMdiChild = true;
            d_form.MdiParent = this;
            d_form.Show();
        }

        private void ����ѧ�ڼ�¼ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateScoreRecord_Form d_form = new CreateScoreRecord_Form();
            d_form.MdiParent = this;
            d_form.Show();

        }
    }
}