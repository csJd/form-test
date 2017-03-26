namespace scut2015
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpEmp = new System.Windows.Forms.TabPage();
            this.tpQuery = new System.Windows.Forms.TabPage();
            this.tpStat = new System.Windows.Forms.TabPage();
            this.lvShow = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbEage = new System.Windows.Forms.TextBox();
            this.tbEname = new System.Windows.Forms.TextBox();
            this.tbEno = new System.Windows.Forms.TextBox();
            this.btUpt = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.lvSshow = new System.Windows.Forms.ListView();
            this.lvQshow = new System.Windows.Forms.ListView();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btStat = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btQuery = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpEmp.SuspendLayout();
            this.tpQuery.SuspendLayout();
            this.tpStat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpEmp);
            this.tcMain.Controls.Add(this.tpQuery);
            this.tcMain.Controls.Add(this.tpStat);
            this.tcMain.Location = new System.Drawing.Point(13, 13);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(639, 353);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpEmp
            // 
            this.tpEmp.Controls.Add(this.btDel);
            this.tpEmp.Controls.Add(this.btAdd);
            this.tpEmp.Controls.Add(this.btUpt);
            this.tpEmp.Controls.Add(this.tbEno);
            this.tpEmp.Controls.Add(this.tbEname);
            this.tpEmp.Controls.Add(this.tbEage);
            this.tpEmp.Controls.Add(this.radioButton2);
            this.tpEmp.Controls.Add(this.radioButton1);
            this.tpEmp.Controls.Add(this.label4);
            this.tpEmp.Controls.Add(this.label3);
            this.tpEmp.Controls.Add(this.label2);
            this.tpEmp.Controls.Add(this.label1);
            this.tpEmp.Controls.Add(this.lvShow);
            this.tpEmp.Location = new System.Drawing.Point(4, 22);
            this.tpEmp.Name = "tpEmp";
            this.tpEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmp.Size = new System.Drawing.Size(631, 327);
            this.tpEmp.TabIndex = 0;
            this.tpEmp.Text = "员工管理";
            this.tpEmp.UseVisualStyleBackColor = true;
            // 
            // tpQuery
            // 
            this.tpQuery.Controls.Add(this.btQuery);
            this.tpQuery.Controls.Add(this.comboBox2);
            this.tpQuery.Controls.Add(this.comboBox1);
            this.tpQuery.Controls.Add(this.checkBox2);
            this.tpQuery.Controls.Add(this.checkBox1);
            this.tpQuery.Controls.Add(this.lvQshow);
            this.tpQuery.Location = new System.Drawing.Point(4, 22);
            this.tpQuery.Name = "tpQuery";
            this.tpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery.Size = new System.Drawing.Size(631, 327);
            this.tpQuery.TabIndex = 1;
            this.tpQuery.Text = "查询";
            this.tpQuery.UseVisualStyleBackColor = true;
            // 
            // tpStat
            // 
            this.tpStat.Controls.Add(this.btStat);
            this.tpStat.Controls.Add(this.radioButton4);
            this.tpStat.Controls.Add(this.radioButton3);
            this.tpStat.Controls.Add(this.lvSshow);
            this.tpStat.Location = new System.Drawing.Point(4, 22);
            this.tpStat.Name = "tpStat";
            this.tpStat.Size = new System.Drawing.Size(631, 327);
            this.tpStat.TabIndex = 2;
            this.tpStat.Text = "统计";
            this.tpStat.UseVisualStyleBackColor = true;
            // 
            // lvShow
            // 
            this.lvShow.Location = new System.Drawing.Point(7, 7);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(429, 314);
            this.lvShow.TabIndex = 0;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "年龄：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(512, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(577, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tbEage
            // 
            this.tbEage.Location = new System.Drawing.Point(512, 113);
            this.tbEage.Name = "tbEage";
            this.tbEage.Size = new System.Drawing.Size(100, 21);
            this.tbEage.TabIndex = 7;
            // 
            // tbEname
            // 
            this.tbEname.Location = new System.Drawing.Point(512, 51);
            this.tbEname.Name = "tbEname";
            this.tbEname.Size = new System.Drawing.Size(100, 21);
            this.tbEname.TabIndex = 8;
            // 
            // tbEno
            // 
            this.tbEno.Location = new System.Drawing.Point(512, 18);
            this.tbEno.Name = "tbEno";
            this.tbEno.Size = new System.Drawing.Size(100, 21);
            this.tbEno.TabIndex = 9;
            // 
            // btUpt
            // 
            this.btUpt.Location = new System.Drawing.Point(458, 174);
            this.btUpt.Name = "btUpt";
            this.btUpt.Size = new System.Drawing.Size(75, 23);
            this.btUpt.TabIndex = 10;
            this.btUpt.Text = "修改";
            this.btUpt.UseVisualStyleBackColor = true;
            this.btUpt.Click += new System.EventHandler(this.btUpt_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(458, 216);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(458, 256);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 12;
            this.btDel.Text = "删除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // lvSshow
            // 
            this.lvSshow.Location = new System.Drawing.Point(4, 4);
            this.lvSshow.Name = "lvSshow";
            this.lvSshow.Size = new System.Drawing.Size(624, 237);
            this.lvSshow.TabIndex = 0;
            this.lvSshow.UseCompatibleStateImageBehavior = false;
            // 
            // lvQshow
            // 
            this.lvQshow.Location = new System.Drawing.Point(7, 7);
            this.lvQshow.Name = "lvQshow";
            this.lvQshow.Size = new System.Drawing.Size(407, 314);
            this.lvQshow.TabIndex = 0;
            this.lvQshow.UseCompatibleStateImageBehavior = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 260);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(371, 16);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "统计年龄至少为 40 岁员工的总工资，工资按从大到小顺序排列。";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(20, 293);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(275, 16);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "查询至少具有两份工作员工的姓名和其公司名。";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btStat
            // 
            this.btStat.Location = new System.Drawing.Point(541, 286);
            this.btStat.Name = "btStat";
            this.btStat.Size = new System.Drawing.Size(75, 23);
            this.btStat.TabIndex = 3;
            this.btStat.Text = "查询";
            this.btStat.UseVisualStyleBackColor = true;
            this.btStat.Click += new System.EventHandler(this.btStat_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(453, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "员工号：";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(453, 94);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "员工名：";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(473, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(473, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(453, 192);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 23);
            this.btQuery.TabIndex = 5;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 378);
            this.Controls.Add(this.tcMain);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tcMain.ResumeLayout(false);
            this.tpEmp.ResumeLayout(false);
            this.tpEmp.PerformLayout();
            this.tpQuery.ResumeLayout(false);
            this.tpQuery.PerformLayout();
            this.tpStat.ResumeLayout(false);
            this.tpStat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.TabPage tpQuery;
        private System.Windows.Forms.TabPage tpStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpt;
        private System.Windows.Forms.TextBox tbEno;
        private System.Windows.Forms.TextBox tbEname;
        private System.Windows.Forms.TextBox tbEage;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListView lvSshow;
        private System.Windows.Forms.ListView lvQshow;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btStat;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btQuery;
    }
}

