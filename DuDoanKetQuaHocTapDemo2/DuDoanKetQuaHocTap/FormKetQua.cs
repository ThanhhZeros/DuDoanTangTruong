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
    public partial class FormKetQua : Form
    {
        public FormKetQua()
        {
            InitializeComponent();
        }

        private void FormKetQua_FormClosing(object sender, FormClosingEventArgs e)
        {
            DuDoan.frmDuDoan.Show();
        }

        private void FormKetQua_Load(object sender, EventArgs e)
        {
            Double kq = Math.Round(DuDoan.frmDuDoan.TinhKQ(), 2);
            if (kq == -1)
                this.Close();
            lbKetQua.Text = kq.ToString();
            lbDiemChu.Text = ChuyenDoiDiem(kq);
        }


        public String ChuyenDoiDiem(Double kq) {
            if (kq < 4) return "F";
            else if (kq < 5) return "D";
            else if (kq < 5.5) return "D+";
            else if (kq < 6.5) return "C";
            else if (kq < 7) return "C+";
            else if (kq < 8) return "B";
            else if (kq < 8.5) return "B+";
            else return "A";
        }

    }
}
