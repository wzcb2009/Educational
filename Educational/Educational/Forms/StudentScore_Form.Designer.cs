namespace Educational.Forms
{
    partial class StudentScore_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_studentname = new System.Windows.Forms.TextBox();
            this.textBox_studentno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_printstatus = new System.Windows.Forms.ComboBox();
            this.comboBox_Recordstatus = new System.Windows.Forms.ComboBox();
            this.comboBox_classname = new System.Windows.Forms.ComboBox();
            this.comboBox_yeargrade = new System.Windows.Forms.ComboBox();
            this.comboBox_term = new System.Windows.Forms.ComboBox();
            this.comboBox_years = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl_RecordList = new DevExpress.XtraGrid.GridControl();
            this.gridView_RecordList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_RecordList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_RecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_studentname);
            this.groupBox1.Controls.Add(this.textBox_studentno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_printstatus);
            this.groupBox1.Controls.Add(this.comboBox_Recordstatus);
            this.groupBox1.Controls.Add(this.comboBox_classname);
            this.groupBox1.Controls.Add(this.comboBox_yeargrade);
            this.groupBox1.Controls.Add(this.comboBox_term);
            this.groupBox1.Controls.Add(this.comboBox_years);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // textBox_studentname
            // 
            this.textBox_studentname.Location = new System.Drawing.Point(471, 68);
            this.textBox_studentname.Name = "textBox_studentname";
            this.textBox_studentname.Size = new System.Drawing.Size(128, 21);
            this.textBox_studentname.TabIndex = 10;
            // 
            // textBox_studentno
            // 
            this.textBox_studentno.Location = new System.Drawing.Point(471, 30);
            this.textBox_studentno.Name = "textBox_studentno";
            this.textBox_studentno.Size = new System.Drawing.Size(128, 21);
            this.textBox_studentno.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "年份：";
            // 
            // comboBox_printstatus
            // 
            this.comboBox_printstatus.FormattingEnabled = true;
            this.comboBox_printstatus.Items.AddRange(new object[] {
            "",
            "未打印",
            "已打印"});
            this.comboBox_printstatus.Location = new System.Drawing.Point(686, 68);
            this.comboBox_printstatus.Name = "comboBox_printstatus";
            this.comboBox_printstatus.Size = new System.Drawing.Size(121, 20);
            this.comboBox_printstatus.TabIndex = 8;
            // 
            // comboBox_Recordstatus
            // 
            this.comboBox_Recordstatus.FormattingEnabled = true;
            this.comboBox_Recordstatus.Items.AddRange(new object[] {
            "新增",
            "编辑",
            "完成"});
            this.comboBox_Recordstatus.Location = new System.Drawing.Point(686, 30);
            this.comboBox_Recordstatus.Name = "comboBox_Recordstatus";
            this.comboBox_Recordstatus.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Recordstatus.TabIndex = 8;
            this.comboBox_Recordstatus.Visible = false;
            // 
            // comboBox_classname
            // 
            this.comboBox_classname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_classname.FormattingEnabled = true;
            this.comboBox_classname.Items.AddRange(new object[] {
            "",
            "1班",
            "2班",
            "3班",
            "4班",
            "5班",
            "6班",
            "7班",
            "8班",
            "9班",
            "10班",
            "11班",
            "11班"});
            this.comboBox_classname.Location = new System.Drawing.Point(282, 68);
            this.comboBox_classname.Name = "comboBox_classname";
            this.comboBox_classname.Size = new System.Drawing.Size(121, 20);
            this.comboBox_classname.TabIndex = 8;
            // 
            // comboBox_yeargrade
            // 
            this.comboBox_yeargrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_yeargrade.FormattingEnabled = true;
            this.comboBox_yeargrade.Items.AddRange(new object[] {
            "",
            "七年级",
            "八年级",
            "九年级"});
            this.comboBox_yeargrade.Location = new System.Drawing.Point(282, 30);
            this.comboBox_yeargrade.Name = "comboBox_yeargrade";
            this.comboBox_yeargrade.Size = new System.Drawing.Size(121, 20);
            this.comboBox_yeargrade.TabIndex = 8;
            this.comboBox_yeargrade.SelectedIndexChanged += new System.EventHandler(this.comboBox_yeargrade_SelectedIndexChanged);
            // 
            // comboBox_term
            // 
            this.comboBox_term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_term.FormattingEnabled = true;
            this.comboBox_term.Location = new System.Drawing.Point(82, 68);
            this.comboBox_term.Name = "comboBox_term";
            this.comboBox_term.Size = new System.Drawing.Size(121, 20);
            this.comboBox_term.TabIndex = 8;
            // 
            // comboBox_years
            // 
            this.comboBox_years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_years.FormattingEnabled = true;
            this.comboBox_years.Items.AddRange(new object[] {
            "2015"});
            this.comboBox_years.Location = new System.Drawing.Point(82, 30);
            this.comboBox_years.Name = "comboBox_years";
            this.comboBox_years.Size = new System.Drawing.Size(121, 20);
            this.comboBox_years.TabIndex = 8;
            this.comboBox_years.SelectedIndexChanged += new System.EventHandler(this.comboBox_years_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "打印状态";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "状态";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "学期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "年级：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "班级：";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(836, 47);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl_RecordList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 353);
            this.panel1.TabIndex = 1;
            // 
            // gridControl_RecordList
            // 
            this.gridControl_RecordList.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridControl_RecordList.EmbeddedNavigator.Name = "";
            this.gridControl_RecordList.Location = new System.Drawing.Point(0, 0);
            this.gridControl_RecordList.MainView = this.gridView_RecordList;
            this.gridControl_RecordList.Name = "gridControl_RecordList";
            this.gridControl_RecordList.Size = new System.Drawing.Size(1004, 353);
            this.gridControl_RecordList.TabIndex = 0;
            this.gridControl_RecordList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_RecordList});
            this.gridControl_RecordList.DoubleClick += new System.EventHandler(this.gridControl_RecordList_DoubleClick);
            // 
            // gridView_RecordList
            // 
            this.gridView_RecordList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn10,
            this.gridColumn9});
            this.gridView_RecordList.GridControl = this.gridControl_RecordList;
            this.gridView_RecordList.Name = "gridView_RecordList";
            this.gridView_RecordList.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 76;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "班级";
            this.gridColumn3.FieldName = "classtudentname";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "学号";
            this.gridColumn4.FieldName = "studentno";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 112;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "姓名";
            this.gridColumn5.FieldName = "studentname";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 112;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "学期";
            this.gridColumn6.FieldName = "termname";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 112;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "状态";
            this.gridColumn7.FieldName = "recordstatus";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 112;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "打印状态";
            this.gridColumn8.FieldName = "printstatus";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 112;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "打印时间";
            this.gridColumn10.FieldName = "printdate";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 7;
            this.gridColumn10.Width = 186;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "选择";
            this.gridColumn9.FieldName = "xuanze";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Width = 49;
            // 
            // StudentScore_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentScore_Form";
            this.Text = "StudentScore_Form";
            this.Load += new System.EventHandler(this.StudentScore_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_RecordList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_RecordList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl_RecordList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_RecordList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_classname;
        private System.Windows.Forms.ComboBox comboBox_yeargrade;
        private System.Windows.Forms.ComboBox comboBox_term;
        private System.Windows.Forms.ComboBox comboBox_years;
        private System.Windows.Forms.ComboBox comboBox_printstatus;
        private System.Windows.Forms.ComboBox comboBox_Recordstatus;
        private System.Windows.Forms.TextBox textBox_studentname;
        private System.Windows.Forms.TextBox textBox_studentno;

    }
}