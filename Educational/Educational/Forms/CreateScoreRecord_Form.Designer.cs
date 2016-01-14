namespace Educational.Forms
{
    partial class CreateScoreRecord_Form
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
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_term = new System.Windows.Forms.ComboBox();
            this.comboBox_years = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "年份：";
            // 
            // comboBox_term
            // 
            this.comboBox_term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_term.FormattingEnabled = true;
            this.comboBox_term.Location = new System.Drawing.Point(85, 63);
            this.comboBox_term.Name = "comboBox_term";
            this.comboBox_term.Size = new System.Drawing.Size(121, 20);
            this.comboBox_term.TabIndex = 12;
            // 
            // comboBox_years
            // 
            this.comboBox_years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_years.FormattingEnabled = true;
            this.comboBox_years.Items.AddRange(new object[] {
            "2015"});
            this.comboBox_years.Location = new System.Drawing.Point(85, 25);
            this.comboBox_years.Name = "comboBox_years";
            this.comboBox_years.Size = new System.Drawing.Size(121, 20);
            this.comboBox_years.TabIndex = 11;
            this.comboBox_years.SelectedIndexChanged += new System.EventHandler(this.comboBox_years_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "学期：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateScoreRecord_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 148);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_term);
            this.Controls.Add(this.comboBox_years);
            this.Controls.Add(this.label5);
            this.Name = "CreateScoreRecord_Form";
            this.Text = "生成学期记录";
            this.Load += new System.EventHandler(this.CreateScoreRecord_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_term;
        private System.Windows.Forms.ComboBox comboBox_years;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}