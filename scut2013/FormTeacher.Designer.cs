namespace scut2013
{
    partial class FormTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tbTno = new System.Windows.Forms.TextBox();
            this.tbTname = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpt = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShow
            // 
            this.lvShow.Location = new System.Drawing.Point(13, 13);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(369, 280);
            this.lvShow.TabIndex = 0;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "教师号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "教师姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "教师性别：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(120, 394);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(178, 394);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tbTno
            // 
            this.tbTno.Location = new System.Drawing.Point(120, 329);
            this.tbTno.Name = "tbTno";
            this.tbTno.Size = new System.Drawing.Size(100, 21);
            this.tbTno.TabIndex = 6;
            // 
            // tbTname
            // 
            this.tbTname.Location = new System.Drawing.Point(120, 362);
            this.tbTname.Name = "tbTname";
            this.tbTname.Size = new System.Drawing.Size(100, 21);
            this.tbTname.TabIndex = 7;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(25, 443);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpt
            // 
            this.btUpt.Location = new System.Drawing.Point(120, 443);
            this.btUpt.Name = "btUpt";
            this.btUpt.Size = new System.Drawing.Size(75, 23);
            this.btUpt.TabIndex = 10;
            this.btUpt.Text = "修改";
            this.btUpt.UseVisualStyleBackColor = true;
            this.btUpt.Click += new System.EventHandler(this.btUpt_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(214, 443);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 11;
            this.btDel.Text = "删除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 490);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btUpt);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbTname);
            this.Controls.Add(this.tbTno);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvShow);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox tbTno;
        private System.Windows.Forms.TextBox tbTname;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpt;
        private System.Windows.Forms.Button btDel;
    }
}