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
    public partial class FormGioiThieu : Form
    {
        public FormGioiThieu()
        {
            InitializeComponent();
        }

        private void FormGioiThieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.frmMain.Show();
        }

        private void FormGioiThieu_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
