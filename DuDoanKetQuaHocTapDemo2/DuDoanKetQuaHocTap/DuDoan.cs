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
    public partial class DuDoan : Form
    {
        public static DuDoan frmDuDoan = new DuDoan();
        public DuDoan()
        {
            InitializeComponent();
        }

        private void frmDuDoan_Load(object sender, EventArgs e)
        {
            Object[] items = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            cbbChamChi.Items.AddRange(items);
            cbbChamChi.Text = "Chọn giá trị";
            cbbKienThuc.Items.AddRange(items);
            cbbKienThuc.Text = "Chọn giá trị";
            cbbDoKho.Items.AddRange(items);
            cbbDoKho.Text = "Chọn giá trị";
            frmDuDoan = this;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            FormKetQua frmKQ = new FormKetQua();
            this.Hide();
            frmKQ.Show();


        }

        private void DuDoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.frmMain.Show();
        }

        public Double TinhKQ() {
            try
            {
                Main m = new Main();
                Int32 chamChi = Int32.Parse(cbbChamChi.Text);
                Int32 ktn = Int32.Parse(cbbKienThuc.Text);
                Int32 doKho = Int32.Parse(cbbDoKho.Text);

                Double kq = m.DuDoan(chamChi, ktn, doKho);

                return kq;

            }
            catch (Exception er)
            {
                MessageBox.Show("Kiểm tra các trường nhập!", "ERROR");
                return -1;
            }
        }

        private void cbbChamChi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbDoKho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
