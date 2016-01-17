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
    public partial class Teacher_Salary_Form : Form
    {
        public Teacher_Salary_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            str += " SELECT  r.sort ,r.teachermane,sum(s.totalsalary ) totalsalar,avg (s.totalsalary) avgsalary ,count (s.monthes) monthes, sum(s.monthcount ) mothescount   FROM Teacher r ,teacher_salary s WHERE r.teacherno = s.teacherno";
            str += " AND  r.sort <999";
            str += " GROUP BY  r.sort  ,r.teachermane";
            str += " ORDER BY r.sort ;";
            DataTable dt = Sql_Class.GetDataTable(str, str);
            double totalsalar = 0;
            double salar = 0;
            int monthes = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                salar = Convert.ToDouble(dt.Rows[i]["totalsalar"]);
                totalsalar += salar;
                monthes = Convert.ToInt32(dt.Rows[i]["mothescount"]);
                if (monthes == 4)
                {
                    dt.Rows[i]["avgsalary"] = Convert.ToDouble(salar / 4).ToString("0.00");
                }
                else
                    dt.Rows[i]["avgsalary"] = Convert.ToDouble(salar / 12).ToString("0.00");

            }
            DataRow dw = dt.NewRow();
            dw["totalsalar"] = totalsalar;
            //dw["monthes"] = monthes;
            //dw["avgsalary"] = totalsalar / monthes;
            dw["teachermane"] = "�ϼ�";
            dt.Rows.Add(dw);
            this.gridControl1.DataSource = dt;
            this.gridView1.RefreshData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d_OldPath = "";
            d_OldPath = Application.StartupPath;

            SaveFileDialog d_Dialog = new SaveFileDialog();
            d_Dialog.Title = "��������";
            d_Dialog.Filter = "Excel �ļ�(*.xls)|*.xls|XML �ļ�(*.xml)|*.xml|TXT�ļ�(*.txt)|*.txt|HTML �ļ�(*.html)|*.html|MHT �ļ�(*.mht)|*.mht|PDF �ļ�(*.pdf)|*.pdf|RFT �ļ�(*.rtf)|*.rtf";
            //'d_Dialog.Filter = "Excel �ļ�(*.xls)|*.xls|XML �ļ�(*.xml)|*.xml|TXT�ļ�(*.txt)|*.txt"
            string d_PathName = "";
            try
            {
                if (d_Dialog.ShowDialog() == DialogResult.OK)
                {
                    d_PathName = d_Dialog.FileName;
                    if (d_PathName.Substring(d_PathName.Length - 3) == "xls")
                    { //'�����ݵ���Excel��
                        gridView1.ExportToExcelOld(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "xml")
                    { //'�����ݵ���xml��
                        DataTable d_table = new DataTable();
                        d_table = (DataTable)this.gridControl1.DataSource;
                        //'��FlexGrid�������д��DataSet��
                        d_table.WriteXml(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "txt")
                    { //'�����ݵ���txt��
                        gridView1.ExportToText(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "tml")
                    { //'�����ݵ���HTML��
                        gridView1.ExportToHtml(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "mht")
                    { //'�����ݵ���mht��
                        gridView1.ExportToMht(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "pdf")
                    { //'�����ݵ���PDF��
                        gridView1.ExportToPdf(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "rtf")
                    { //'�����ݵ���PDF��
                        gridView1.ExportToRtf(d_PathName);
                    }
                }

            }
            catch { }
        }
    }
}