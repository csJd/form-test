using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scut2016
{
    public partial class FormStat : Form
    {
        public FormStat()
        {
            InitializeComponent();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            string sql = "SELECT dname 系名称, COUNT(*) 人数" +
                         " FROM departments d, classes c, students s" +
                         " WHERE d.dno = c.dno AND s.cno = c.cno" +
                         " GROUP BY dname";
            if (radioButton2.Checked)
            {
                sql = "SELECT cyear 入学年份, COUNT(*) 人数" +
                      " FROM classes c, students s" +
                      " WHERE s.cno = c.cno" +
                      " GROUP BY cyear";
            }
            DBUtil.fillListView(lvShow, sql);
        }
    }
}
