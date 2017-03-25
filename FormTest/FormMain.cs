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
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void tsmQuery_Click(object sender, EventArgs e)
        {
            FormQuery fq = new FormQuery();
            fq.Show();
        }

        private void tsmStat_Click(object sender, EventArgs e)
        {
            FormStat fs = new FormStat();
            fs.Show();
        }

        private void tsmStu_Click(object sender, EventArgs e)
        {
            FormStu fs = new FormStu();
            fs.Show();
        }
    }
}
