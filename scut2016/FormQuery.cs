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
    public partial class FormQuery : Form
    {
        public FormQuery()
        {
            InitializeComponent();
            string sql = "SELECT dname FROM departments";
            DBUtil.fillComboBox(comboBox1, sql);
            sql = "SELECT cspec FROM classes";
            DBUtil.fillComboBox(comboBox2, sql);
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            string sql = "SELECT dname 系名称, cspec 专业名称, sname 学生名字" +
                         " FROM students s, classes c, departments d" +
                         " WHERE s.cno = c.cno AND c.dno = d.dno";
            if (checkBox1.Checked)
            {
                string dname = comboBox1.SelectedItem.ToString();
                sql += " AND dname = '" + dname + "'";
            }
            if (checkBox2.Checked)
            {
                string cspec = comboBox2.SelectedItem.ToString();
                sql += " AND cspec = '" + cspec + "'";
                //string.Format("'{0}' ", comboBox2.SelectedItem.ToString());
            }
            if (checkBox3.Checked)
            {
                string sname = textBox1.Text.Trim();
                sql += " AND sname LIKE '%" + sname + "%'";
            }
            sql += " ORDER BY d.dno desc, c.cno, s.sno desc";
            //MessageBox.Show(sql);
            //Console.WriteLine(sql);
            DBUtil.fillListView(lvShow, sql);
        }
    }
}
