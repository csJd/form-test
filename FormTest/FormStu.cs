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
        private string preSno;

        public FormStu()
        {
            InitializeComponent();
            string sql = "SELECT cno FROM classes";
            DBUtil.fillComboBox(cbCno, sql);
            reLoad();
        }

        void reLoad()
        {
            string sql = "SELECT sno AS 学号, sname AS 姓名, sdate AS 出生日期, cno AS 班号 FROM students";
            DBUtil.fillListView(lvShow, sql);
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count > 0)
            {
                var si = lvShow.SelectedItems[0].SubItems;
                preSno = tbSno.Text = si[0].Text;
                tbSname.Text = si[1].Text;
                dtSdate.Text = si[2].Text;
                cbCno.Text = si[3].Text;
            }
        }


        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择一行要更新的数据！");
                return;
            }

            string sno = tbSno.Text.Trim();
            string sname = tbSname.Text.Trim();
            string sdate = dtSdate.Value.ToString("yyyy-MM-dd");
            string cno = cbCno.Text;

            string sql = string.Format("UPDATE students SET sno = '{0}', sname = '{1}', sdate ='{2}', cno = '{3}' WHERE sno = '{4}'",
                sno, sname, sdate, cno, preSno);
            MessageBox.Show(sql);

            if (DBUtil.update(sql))
            {
                MessageBox.Show("更新成功！");
                reLoad();
            }
            else
            {
                MessageBox.Show("更新失败！请重试");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string sno = tbSno.Text.Trim();
            string sname = tbSname.Text.Trim();
            string sdate = dtSdate.Value.ToString("yyyy-MM-dd");
            string cno = cbCno.Text;

            string sql = "SELECT sno FROM students WHERE sno = '" + sno + "'";
            if (DBUtil.exists(sql))
            {
                MessageBox.Show("学号已经存在!");
                return;
            }

            sql = String.Format("INSERT INTO students VALUES ('{0}', '{1}', '{2}', '{3}')",
                                    sno, sname, sdate, cno);
            if (DBUtil.update(sql))
            {
                MessageBox.Show("添加成功!");
                reLoad();
            }
            else
            {
                MessageBox.Show("添加失败#");
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count == 0)
            {
                MessageBox.Show("请先选择一行要删除的数据！");
                return;
            }

            string sql = "DELETE FROM students WHERE sno = '" + preSno + "'";
            if (DBUtil.update(sql))
            {
                MessageBox.Show("删除成功!");
                reLoad();
            }
            else
            {
                MessageBox.Show("删除失败#");
            }
            reLoad();
        }
    }
}
