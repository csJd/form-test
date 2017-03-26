using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scut2014
{
    public partial class FormStat : Form
    {
        public FormStat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT tname 教师姓名, cname 课程名, ctime 课程时间" +
                         " FROM teachers t, courses c" +
                         " WHERE t.tno = c.tno AND(SELECT COUNT(*) FROM courses c1" +
                         "                          WHERE c1.tno = t.tno) < 2";
            DBUtil.fillListView(lvShow, sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT tname 教师姓名, SUM(rwage * ctime) 总薪酬" +
                         " FROM teachers t, courses c, remunerations r" +
                         " WHERE t.rno = r.rno AND c.tno = t.tno" +
                         " GROUP BY tname" +
                         " ORDER BY SUM(rwage * ctime) DESC";
            DBUtil.fillListView(lvShow, sql);
        }
    }
}
