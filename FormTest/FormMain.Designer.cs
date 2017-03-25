namespace FormTest
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmQuery,
            this.tsmStat,
            this.tsmStu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(238, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmQuery
            // 
            this.tsmQuery.Name = "tsmQuery";
            this.tsmQuery.Size = new System.Drawing.Size(68, 21);
            this.tsmQuery.Text = "查询功能";
            this.tsmQuery.Click += new System.EventHandler(this.tsmQuery_Click);
            // 
            // tsmStat
            // 
            this.tsmStat.Name = "tsmStat";
            this.tsmStat.Size = new System.Drawing.Size(68, 21);
            this.tsmStat.Text = "统计功能";
            this.tsmStat.Click += new System.EventHandler(this.tsmStat_Click);
            // 
            // tsmStu
            // 
            this.tsmStu.Name = "tsmStu";
            this.tsmStu.Size = new System.Drawing.Size(80, 21);
            this.tsmStu.Text = "学生表维护";
            this.tsmStu.Click += new System.EventHandler(this.tsmStu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "欢迎！\r\n\r\n请点击菜单选择功能~";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Hello Form";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmStat;
        private System.Windows.Forms.ToolStripMenuItem tsmStu;
        private System.Windows.Forms.Label label1;
    }
}

