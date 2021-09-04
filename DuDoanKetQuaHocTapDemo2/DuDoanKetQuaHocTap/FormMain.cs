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
    public partial class FormMain : Form
    {
        public static FormMain frmMain = new FormMain();
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DuDoan frmDuDoan = new DuDoan();
            this.Hide();
            frmDuDoan.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmMain = this;
        }

        private void btnTapLuat_Click(object sender, EventArgs e)
        {
            Form_DuLieu frm_Du_Lieu = new Form_DuLieu();
            this.Hide();
            frm_Du_Lieu.Show();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            FormGioiThieu frmGT = new FormGioiThieu();
            this.Hide();
            frmGT.Show();
        }
    }
}
