namespace scut2014
{
    partial class FormTeachers
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
            this.cbTdept = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btQuery = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpt = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTno = new System.Windows.Forms.TextBox();
            this.cbRno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvShow
            // 
            this.lvShow.Location = new System.Drawing.Point(13, 13);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(385, 304);
            this.lvShow.TabIndex = 0;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
            // 
            // cbTdept
            // 
            this.cbTdept.FormattingEnabled = true;
            this.cbTdept.Location = new System.Drawing.Point(262, 345);
            this.cbTdept.Name = "cbTdept";
            this.cbTdept.Size = new System.Drawing.Size(121, 20);
            this.cbTdept.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // tbTname
            // 
            this.tbTname.Location = new System.Drawing.Point(74, 345);
            this.tbTname.Name = "tbTname";
            this.tbTname.Size = new System.Drawing.Size(100, 21);
            this.tbTname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "系别：";
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(12, 425);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 23);
            this.btQuery.TabIndex = 5;
            this.btQuery.Text = "查找";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(117, 425);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpt
            // 
            this.btUpt.Location = new System.Drawing.Point(221, 425);
            this.btUpt.Name = "btUpt";
            this.btUpt.Size = new System.Drawing.Size(75, 23);
            this.btUpt.TabIndex = 7;
            this.btUpt.Text = "修改";
            this.btUpt.UseVisualStyleBackColor = true;
            this.btUpt.Click += new System.EventHandler(this.btUpt_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(323, 425);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 8;
            this.btDel.Text = "删除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "教师号：";
            // 
            // tbTno
            // 
            this.tbTno.Location = new System.Drawing.Point(74, 378);
            this.tbTno.Name = "tbTno";
            this.tbTno.Size = new System.Drawing.Size(100, 21);
            this.tbTno.TabIndex = 10;
            // 
            // cbRno
            // 
            this.cbRno.FormattingEnabled = true;
            this.cbRno.Location = new System.Drawing.Point(262, 379);
            this.cbRno.Name = "cbRno";
            this.cbRno.Size = new System.Drawing.Size(121, 20);
            this.cbRno.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "职称号：";
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRno);
            this.Controls.Add(this.tbTno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btUpt);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTdept);
            this.Controls.Add(this.lvShow);
            this.Name = "FormTeachers";
            this.Text = "FormTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ComboBox cbTdept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpt;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTno;
        private System.Windows.Forms.ComboBox cbRno;
        private System.Windows.Forms.Label label4;
    }
}