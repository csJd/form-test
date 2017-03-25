namespace scut2013
{
    partial class FormQuery
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
            this.cbTno = new System.Windows.Forms.ComboBox();
            this.rbTno = new System.Windows.Forms.RadioButton();
            this.rbTname = new System.Windows.Forms.RadioButton();
            this.cbTname = new System.Windows.Forms.ComboBox();
            this.btQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvShow
            // 
            this.lvShow.Location = new System.Drawing.Point(12, 12);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(392, 303);
            this.lvShow.TabIndex = 0;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            // 
            // cbTno
            // 
            this.cbTno.FormattingEnabled = true;
            this.cbTno.Location = new System.Drawing.Point(425, 74);
            this.cbTno.Name = "cbTno";
            this.cbTno.Size = new System.Drawing.Size(121, 20);
            this.cbTno.TabIndex = 1;
            // 
            // rbTno
            // 
            this.rbTno.AutoSize = true;
            this.rbTno.Checked = true;
            this.rbTno.Location = new System.Drawing.Point(411, 46);
            this.rbTno.Name = "rbTno";
            this.rbTno.Size = new System.Drawing.Size(83, 16);
            this.rbTno.TabIndex = 2;
            this.rbTno.TabStop = true;
            this.rbTno.Text = "根据教师号";
            this.rbTno.UseVisualStyleBackColor = true;
            // 
            // rbTname
            // 
            this.rbTname.AutoSize = true;
            this.rbTname.Location = new System.Drawing.Point(411, 118);
            this.rbTname.Name = "rbTname";
            this.rbTname.Size = new System.Drawing.Size(95, 16);
            this.rbTname.TabIndex = 3;
            this.rbTname.Text = "根据教师姓名";
            this.rbTname.UseVisualStyleBackColor = true;
            // 
            // cbTname
            // 
            this.cbTname.FormattingEnabled = true;
            this.cbTname.Location = new System.Drawing.Point(425, 149);
            this.cbTname.Name = "cbTname";
            this.cbTname.Size = new System.Drawing.Size(121, 20);
            this.cbTname.TabIndex = 4;
            // 
            // btQuery
            // 
            this.btQuery.Location = new System.Drawing.Point(471, 223);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(75, 23);
            this.btQuery.TabIndex = 5;
            this.btQuery.Text = "查询";
            this.btQuery.UseVisualStyleBackColor = true;
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // FormQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 323);
            this.Controls.Add(this.btQuery);
            this.Controls.Add(this.cbTname);
            this.Controls.Add(this.rbTname);
            this.Controls.Add(this.rbTno);
            this.Controls.Add(this.cbTno);
            this.Controls.Add(this.lvShow);
            this.Name = "FormQuery";
            this.Text = "FormQuery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ComboBox cbTno;
        private System.Windows.Forms.RadioButton rbTno;
        private System.Windows.Forms.RadioButton rbTname;
        private System.Windows.Forms.ComboBox cbTname;
        private System.Windows.Forms.Button btQuery;
    }
}