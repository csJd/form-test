using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scut2013
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTeacher ft = new FormTeacher();
            ft.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormQuery fq = new FormQuery();
            fq.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStat fs = new FormStat();
            fs.Show();
        }
    }
}
