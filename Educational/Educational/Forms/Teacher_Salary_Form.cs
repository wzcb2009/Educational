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
            dw["teachermane"] = "合计";
            dt.Rows.Add(dw);
            this.gridControl1.DataSource = dt;
            this.gridView1.RefreshData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d_OldPath = "";
            d_OldPath = Application.StartupPath;

            SaveFileDialog d_Dialog = new SaveFileDialog();
            d_Dialog.Title = "导出数据";
            d_Dialog.Filter = "Excel 文件(*.xls)|*.xls|XML 文件(*.xml)|*.xml|TXT文件(*.txt)|*.txt|HTML 文件(*.html)|*.html|MHT 文件(*.mht)|*.mht|PDF 文件(*.pdf)|*.pdf|RFT 文件(*.rtf)|*.rtf";
            //'d_Dialog.Filter = "Excel 文件(*.xls)|*.xls|XML 文件(*.xml)|*.xml|TXT文件(*.txt)|*.txt"
            string d_PathName = "";
            try
            {
                if (d_Dialog.ShowDialog() == DialogResult.OK)
                {
                    d_PathName = d_Dialog.FileName;
                    if (d_PathName.Substring(d_PathName.Length - 3) == "xls")
                    { //'把数据导到Excel中
                        gridView1.ExportToExcelOld(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "xml")
                    { //'把数据导到xml中
                        DataTable d_table = new DataTable();
                        d_table = (DataTable)this.gridControl1.DataSource;
                        //'把FlexGrid里的内容写到DataSet里
                        d_table.WriteXml(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "txt")
                    { //'把数据导到txt中
                        gridView1.ExportToText(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "tml")
                    { //'把数据导到HTML中
                        gridView1.ExportToHtml(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "mht")
                    { //'把数据导到mht中
                        gridView1.ExportToMht(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "pdf")
                    { //'把数据导到PDF中
                        gridView1.ExportToPdf(d_PathName);
                    }
                    else if (d_PathName.Substring(d_PathName.Length - 3) == "rtf")
                    { //'把数据导到PDF中
                        gridView1.ExportToRtf(d_PathName);
                    }
                }

            }
            catch { }
        }
    }
}