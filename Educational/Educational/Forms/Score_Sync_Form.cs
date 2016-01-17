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
    public partial class Score_Sync_Form : Form
    {
        public Score_Sync_Form()
        {
            InitializeComponent();
        }
        Dictionary<string, string> d_projectlist;
        private void Score_Sync_Form_Load(object sender, EventArgs e)
        {
            Mysql_Class d_mysql = new Mysql_Class("xepsys");
            DataTable dt = d_mysql.GetDataTable("SELECT * FROM sys_project ORDER BY  CREATETIME ;", null);
            d_projectlist = new Dictionary<string, string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d_projectlist.Add(dt.Rows[i]["PROJECTNAME"].ToString(), dt.Rows[i]["PROJECTID"].ToString());
                comboBox1.Items.Add(dt.Rows[i]["PROJECTNAME"].ToString());
            }

        }
    }
}