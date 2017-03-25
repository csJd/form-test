namespace scut2016
{
    partial class FormStu
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbSno = new System.Windows.Forms.TextBox();
            this.tbSname = new System.Windows.Forms.TextBox();
            this.dtSdate = new System.Windows.Forms.DateTimePicker();
            this.cbCno = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShow
            // 
            this.lvShow.Location = new System.Drawing.Point(13, 13);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(411, 275);
            this.lvShow.TabIndex = 0;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "出生日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "班号：";
            // 
            // tbSno
            // 
            this.tbSno.Location = new System.Drawing.Point(58, 315);
            this.tbSno.Name = "tbSno";
            this.tbSno.Size = new System.Drawing.Size(126, 21);
            this.tbSno.TabIndex = 5;
            // 
            // tbSname
            // 
            this.tbSname.Location = new System.Drawing.Point(58, 355);
            this.tbSname.Name = "tbSname";
            this.tbSname.Size = new System.Drawing.Size(126, 21);
            this.tbSname.TabIndex = 6;
            // 
            // dtSdate
            // 
            this.dtSdate.Location = new System.Drawing.Point(279, 315);
            this.dtSdate.Name = "dtSdate";
            this.dtSdate.Size = new System.Drawing.Size(136, 21);
            this.dtSdate.TabIndex = 7;
            // 
            // cbCno
            // 
            this.cbCno.FormattingEnabled = true;
            this.cbCno.Location = new System.Drawing.Point(279, 355);
            this.cbCno.Name = "cbCno";
            this.cbCno.Size = new System.Drawing.Size(136, 20);
            this.cbCno.TabIndex = 8;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(152, 400);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(245, 400);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "添加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(339, 400);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 11;
            this.btDel.Text = "删除";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // FormStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 446);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.cbCno);
            this.Controls.Add(this.dtSdate);
            this.Controls.Add(this.tbSname);
            this.Controls.Add(this.tbSno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvShow);
            this.Name = "FormStu";
            this.Text = "FormStu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSno;
        private System.Windows.Forms.TextBox tbSname;
        private System.Windows.Forms.DateTimePicker dtSdate;
        private System.Windows.Forms.ComboBox cbCno;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
    }
}