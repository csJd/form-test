namespace scut2013
{
    partial class FormStat
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btQuery = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 211);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 247);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(251, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "查询教授两门以上课程的教师姓名和课程名";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(13, 336);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 23);
            this.btQuery.TabIndex = 3;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 286);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "自己想个查询";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 383);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listView1);
            this.Name = "FormStat";
            this.Text = "FormStat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btQuery;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}