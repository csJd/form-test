using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class FormStu : Form
    {

        void reLoad()
        {
            string sql = "SELECT sno AS 学号, sname AS 姓名, sdate AS 出生日期, cno AS 班号 FROM students";
            DBUtil.fillListView(lvShow, sql);
        }
        public FormStu()
        {
            InitializeComponent();
            string sql = "SELECT cno FROM classes";
            DBUtil.fillComboBox(cbCno, sql);
            reLoad();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string sno = tbSno.Text.Trim();
            string sname = tbSname.Text.Trim();
            string sdate = dtSdate.Text;
            string cno = cbCno.Text;

            string sql = "UPDATE students SET sno = '" + sno + "'" +
                            " SET sname = '" + sname + "'" +
                            " SET sdate = '" + sdate + "'" +
                            " SET cno = '" + cno + "'" +
                            " WHERE sno = '" + sno + "'";

            if (DBUtil.update(sql))
            {
                MessageBox.Show("更新成功！");
            }
            else
            {
                MessageBox.Show("更新失败！请重试");
            }
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvShow.SelectedItems.Count > 0)
            {
                var si = lvShow.SelectedItems[0].SubItems;
                tbSno.Text = si[0].Text;
                tbSname.Text = si[1].Text;
                dtSdate.Text = si[2].Text;
                cbCno.Text = si[3].Text;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string sno = tbSno.Text.Trim();
            string sname = tbSname.Text.Trim();
            string sdate = dtSdate.Text;
            string cno = cbCno.Text;

            string sql = "SELECT sno FROM students WHERE sno = '" + sno + "'";
            if (DBUtil.exists(sql))
            {
                MessageBox.Show("学号已经存在!");
                return;
            } 

            sql = "INSERT INTO students VALUES ("
        }
    }
}
