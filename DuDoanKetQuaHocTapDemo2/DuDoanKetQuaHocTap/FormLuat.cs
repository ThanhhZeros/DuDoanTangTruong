using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DuDoanKetQuaHocTap
{
    public partial class FormLuat : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=localhost;Initial Catalog=DuDoanKetQua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public void intruction_sql(string intruction)
        {
            command = connection.CreateCommand();
            command.CommandText = intruction;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv_display.DataSource = table;
        }

        public FormLuat()
        {
            InitializeComponent();
        }

        //load data ban đầu
        public void load_data()
        {
            intruction_sql("SELECT * FROM TAPLUAT ORDER BY MaLuat");
        }

        private void FormLuat_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            load_data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBox_ChamChi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // click vào dòng
        private void dgv_display_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_display.CurrentCell.RowIndex;
            textBox_MaLuat.Text = dgv_display.Rows[i].Cells[0].Value.ToString();
            comboBox_ChamChi.Text = dgv_display.Rows[i].Cells[1].Value.ToString();
            comboBox_Ktn.Text = dgv_display.Rows[i].Cells[2].Value.ToString();
            comboBox_DoKho.Text = dgv_display.Rows[i].Cells[3].Value.ToString();
            comboBox_KetQua.Text = dgv_display.Rows[i].Cells[4].Value.ToString();
        }

        //click nút thêm
        private void button_Insert_Click(object sender, EventArgs e)
        {
            string intruction = "";
            string MaLuat = textBox_MaLuat.Text;
            string ChamChi = comboBox_ChamChi.Text;
            string Ktn = comboBox_Ktn.Text;
            string DoKho = comboBox_DoKho.Text;
            string KetQua = comboBox_KetQua.Text;
            intruction = "INSERT INTO TAPLUAT "
                            + "VALUES( " + MaLuat  + ", N'" 
                            + ChamChi +"', N'" + Ktn + "', N'" + DoKho + "', N'" + KetQua + "')";
            try
            {
                // Các khối code được giám sát để bắt lỗi nếu có
                // nếu có lỗi sẽ phát sinh ngoại lệ Exception
                // Ngoại lệ này bắt lại được ở khối catch
                intruction_sql(intruction);
            }
            catch (Exception loi)
            {
                // Khối này thực thi khi có lỗi - đối tượng Exception bắt được lưu ở biến loi
                Form_Error frmError = new Form_Error();
                frmError.Show();
            }

            load_data();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string intruction = "";
            string MaLuat = textBox_MaLuat.Text;
            intruction = "DELETE FROM TAPLUAT "
                        + "WHERE MaLuat = " + MaLuat;
            try
            {
                // Các khối code được giám sát để bắt lỗi nếu có
                // nếu có lỗi sẽ phát sinh ngoại lệ Exception
                // Ngoại lệ này bắt lại được ở khối catch
                intruction_sql(intruction);
            }
            catch (Exception loi)
            {
                // Khối này thực thi khi có lỗi - đối tượng Exception bắt được lưu ở biến loi
                Form_Error frmError = new Form_Error();
                frmError.Show();
            }
 
            load_data();
        }
        
    }
}
