namespace scut2017
{
    partial class FormPatients
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
            this.lvShow = new System.Windows.Forms.ListView();
            this.tbPid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPname = new System.Windows.Forms.TextBox();
            this.btBirth = new System.Windows.Forms.DateTimePicker();
            this.cbGno = new System.Windows.Forms.ComboBox();
            this.btQuery = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpt = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDname = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbGname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvShow
            // 
            this.lvShow.Location = new System.Drawing.Point(13, 13);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(410, 419);
            this.lvShow.TabIndex = 0;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            // 
            // tbPid
            // 
            this.tbPid.Location = new System.Drawing.Point(535, 260);
            this.tbPid.Name = "tbPid";
            this.tbPid.Size = new System.Drawing.Size(127, 21);
            this.tbPid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "身份证号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "生日：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "小科室号：";
            // 
            // tbPname
            // 
            this.tbPname.Location = new System.Drawing.Point(535, 291);
            this.tbPname.Name = "tbPname";
            this.tbPname.Size = new System.Drawing.Size(127, 21);
            this.tbPname.TabIndex = 6;
            // 
            // btBirth
            // 
            this.btBirth.Location = new System.Drawing.Point(535, 327);
            this.btBirth.Name = "btBirth";
            this.btBirth.Size = new System.Drawing.Size(127, 21);
            this.btBirth.TabIndex = 7;
            // 
            // cbGno
            // 
            this.cbGno.FormattingEnabled = true;
            this.cbGno.Location = new System.Drawing.Point(535, 367);
            this.cbGno.Name = "cbGno";
            this.cbGno.Size = new System.Drawing.Size(127, 20);
            this.cbGno.TabIndex = 8;
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(151, 198);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 23);
            this.btQuery.TabIndex = 9;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(429, 409);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btUpt
            // 
            this.btUpt.Location = new System.Drawing.Point(510, 409);
            this.btUpt.Name = "btUpt";
            this.btUpt.Size = new System.Drawing.Size(75, 23);
            this.btUpt.TabIndex = 11;
            this.btUpt.Text = "修改";
            this.btUpt.UseVisualStyleBackColor = true;
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(591, 409);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 12;
            this.btDel.Text = "删除";
            this.btDel.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "大科室名";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbQname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbGname);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.cbDname);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btQuery);
            this.groupBox1.Location = new System.Drawing.Point(436, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 227);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条件混合查询";
            // 
            // cbDname
            // 
            this.cbDname.FormattingEnabled = true;
            this.cbDname.Location = new System.Drawing.Point(31, 43);
            this.cbDname.Name = "cbDname";
            this.cbDname.Size = new System.Drawing.Size(121, 20);
            this.cbDname.TabIndex = 14;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "小科室名";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbGname
            // 
            this.cbGname.FormattingEnabled = true;
            this.cbGname.Location = new System.Drawing.Point(31, 99);
            this.cbGname.Name = "cbGname";
            this.cbGname.Size = new System.Drawing.Size(121, 20);
            this.cbGname.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "姓名（模糊）：";
            // 
            // tbQname
            // 
            this.tbQname.Location = new System.Drawing.Point(31, 160);
            this.tbQname.Name = "tbQname";
            this.tbQname.Size = new System.Drawing.Size(121, 21);
            this.tbQname.TabIndex = 18;
            // 
            // FormPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btUpt);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbGno);
            this.Controls.Add(this.btBirth);
            this.Controls.Add(this.tbPname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPid);
            this.Controls.Add(this.lvShow);
            this.Name = "FormPatients";
            this.Text = "FormPatients";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.TextBox tbPid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPname;
        private System.Windows.Forms.DateTimePicker btBirth;
        private System.Windows.Forms.ComboBox cbGno;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpt;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox cbDname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGname;
        private System.Windows.Forms.TextBox tbQname;
    }
}