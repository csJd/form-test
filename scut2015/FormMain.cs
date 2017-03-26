using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scut2015
{
    public partial class FormMain : Form
    {
        private string preEno;

        public FormMain()
        {
            InitializeComponent();
            tcMain.SelectedTab = tpEmp;
            loadTpEmp();
        }

        void loadTpEmp()
        {
            string sql = "SELECT eno 职工号, ename 姓名, esex 性别, eage 年龄 FROM employees";
            DBUtil.fillListView(lvShow, sql);
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tcMain.SelectedTab == tpEmp)
            {
                loadTpEmp();
            }

            if(tcMain.SelectedTab == tpQuery)
            {
                string sql = "SELECT eno FROM employees";
                DBUtil.fillComboBox(comboBox1, sql);
                sql = "SELECT ename FROM employees";
                DBUtil.fillComboBox(comboBox2, sql);
            }
        }

        private void lvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShow.SelectedItems.Count == 0) return;
            var row = lvShow.SelectedItems[0].SubItems;
            preEno = tbEno.Text = row[0].Text;
            tbEname.Text = row[1].Text;
            radioButton1.Checked = row[2].Text.Equals("男");
            radioButton2.Checked = row[2].Text.Equals("女");
            tbEage.Text = row[3].Text;
        }

        private void btUpt_Click(object sender, EventArgs e)
        {
            string eno = tbEno.Text;
            string sql = "SELECT eno FROM employees WHERE eno = '" + eno + "'";
            if ((!eno.Equals(preEno)) && DBUtil.exists(sql))
            {
                MessageBox.Show("员工号已经存在！");
                return;
            }

            sql = string.Format("UPDATE employees SET eno = '{0}', ename = '{1}', esex = '{2}', eage = {3} WHERE eno = '{4}'",
                eno, tbEname.Text.Trim(), radioButton1.Checked ? "男" : "女", tbEage.Text, preEno);

            if (DBUtil.update(sql))
            {
                MessageBox.Show("更新成功！");
                loadTpEmp();
            }
            else
            {
                MessageBox.Show("更新失败！请检查输入是否有误！");
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string eno = tbEno.Text;
            string sql = "SELECT eno FROM employees WHERE eno = '" + eno + "'";
            if ((!eno.Equals(preEno)) && DBUtil.exists(sql))
            {
                MessageBox.Show("员工号已经存在！");
                return;
            }

            sql = string.Format("INSERT INTO employees VALUES ('{0}', '{1}', '{2}', {3})",
               eno, tbEname.Text.Trim(), radioButton1.Checked ? "男" : "女", tbEage.Text );

            if (DBUtil.update(sql))
            {
                MessageBox.Show("添加成功！");
                loadTpEmp();
            }
            else
            {
                MessageBox.Show("添加失败！请检查输入是否有误！");
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo);
            if (r.Equals(DialogResult.No))
            {
                return;
            }

            string sql = "DELETE FROM employees WHERE eno = '" + tbEno.Text + "'";
            if (DBUtil.update(sql))
            {
                MessageBox.Show("删除成功！");
                loadTpEmp();
            }
            else
            {
                MessageBox.Show("删除失败，请先选择一行");
            }
       }

        private void btQuery_Click(object sender, EventArgs e)
        {
            string sql = "SELECT e.eno 员工号, ename 姓名, cname 公司名, salary 工资 " +
                " FROM employees e LEFT JOIN works w ON w.eno = e.eno LEFT JOIN companies c ON c.cno = w.cno";
            if (checkBox1.Checked)
            {
                sql += string.Format(" WHERE e.eno = '{0}'", comboBox1.Text);
            }

            if (checkBox2.Checked)
            {
                sql += checkBox1.Checked ? " AND" : " WHERE"; 
                sql += string.Format(" e.ename = '{0}'", comboBox2.Text);
            }

            DBUtil.fillListView(lvQshow, sql);
        }

        private void btStat_Click(object sender, EventArgs e)
        {
            string sql;
            if (radioButton3.Checked)
            {
                sql = "SELECT ename 员工姓名, eage 年龄, SUM(salary) 总工资" +
                    " FROM employees e, works w" +
                    " WHERE e.eno = w.eno AND eage > 39" +
                    " GROUP BY ename, eage";
            }
            else
            {
                sql = "SELECT ename 员工姓名, cname 公司名" +
                    " FROM employees e, works w, companies c" +
                    " WHERE w.eno = e.eno AND c.cno = w.cno" +
                    " AND (SELECT COUNT(*) FROM works w1 WHERE w1.eno = e.eno) > 1";
            }

            DBUtil.fillListView(lvSshow, sql);
        }
    }
}
