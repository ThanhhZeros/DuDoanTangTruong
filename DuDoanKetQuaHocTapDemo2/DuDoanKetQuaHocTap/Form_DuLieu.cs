using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuDoanKetQuaHocTap
{
    public partial class Form_DuLieu : Form
    {
        public Form_DuLieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLuat frm_Luat = new FormLuat();
            frm_Luat.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_DoThi frm_Do_Thi = new Form_DoThi();
            frm_Do_Thi.Show();
        }

        private void Form_DuLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.frmMain.Show();
        }
    }
}
