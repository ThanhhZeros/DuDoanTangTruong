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

using System.IO;

namespace DuDoanKetQuaHocTap
{
    class Main
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=localhost;Initial Catalog=DuDoanKetQua;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();






        HamThuoc ht = new HamThuoc();
        public Double DuDoan(Int32 chamChi, Int32 ktn, Int32 doKho)
        {

            //Ham Thuoc
            //Cham chi
            Double chamChiCao = ht.LayGiaTriHamThuoc(chamChi, 0, 0, 10, 1, 10, 1);
            Double chamChiTB = ht.LayGiaTriHamThuoc(chamChi, 0, 0, 5, 1, 10, 0);
            Double chamChiThap = ht.LayGiaTriHamThuoc(chamChi, 0, 1, 10, 0, 10, 0);

            //Kien thuc nen
            Double ktnCao = ht.LayGiaTriHamThuoc(ktn, 0, 0, 9, 1, 10, 1);
            Double ktnTB = ht.LayGiaTriHamThuoc(ktn, 0, 0, 5, 1, 10, 0);
            Double ktnThap = ht.LayGiaTriHamThuoc(ktn, 0, 1, 2, 1, 10, 0);

            //Do kho
            Double doKhoCao = ht.LayGiaTriHamThuoc(doKho, 0, 0, 1, 0, 9, 1);
            Double doKhoTB = ht.LayGiaTriHamThuoc(doKho, 0, 0, 5, 1, 10, 0);
            Double doKhoThap = ht.LayGiaTriHamThuoc(doKho, 0, 1, 9, 0, 10, 0);

            //Ket qua
            DoThiKetQua ketQuaCao = new DoThiKetQua(5, 8.5, 10, 10);
            DoThiKetQua ketQuaTB = new DoThiKetQua(4, 5, 5, 6);
            DoThiKetQua ketQuaThap = new DoThiKetQua(0, 0, 4, 8.5);

            List<Double> lTuSo = new List<double>();
            List<Double> lMauSo = new List<double>();



            connection = new SqlConnection(str);
            connection.Open();

            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM TAPLUAT ORDER BY MaLuat";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            connection.Close();

            //StreamWriter sw = new StreamWriter("D:\\window form\\project\\1\\w.txt");

            foreach (DataRow row in table.Rows)
            {

                Double CC = 0, KTN = 0, DK = 0;
                DoThiKetQua KQ = new DoThiKetQua();
                if (row[1].ToString() == "Cao")
                    CC = chamChiCao;
                if (row[1].ToString() == "TB")
                    CC = chamChiTB;
                if (row[1].ToString() == "Thấp")
                    CC = chamChiThap;


                if (row[2].ToString() == "Tốt")
                    KTN = ktnCao;
                if (row[2].ToString() == "TB")
                    KTN = ktnTB;
                if (row[2].ToString() == "Kém")
                    KTN = ktnThap;

                if (row[3].ToString() == "Khó")
                    DK = doKhoCao;
                if (row[3].ToString() == "Vừa")
                    DK = doKhoTB;
                if (row[3].ToString() == "Dễ")
                    DK = doKhoThap;


                if (row[4].ToString() == "Tốt")
                    KQ = ketQuaCao;
                if (row[4].ToString() == "TB")
                    KQ = ketQuaTB;
                if (row[4].ToString() == "Kém")
                    KQ = ketQuaThap;

                lTuSo.Add(KQ.getTuSo(Math.Min(CC, Math.Min(KTN, DK))));
                lMauSo.Add(KQ.getMauSo(Math.Min(CC, Math.Min(KTN, DK))));



            }


            Double tongTu = 0;
            Double tongMau = 0;

            foreach (Double i in lTuSo)
                tongTu += i;
            foreach (Double i in lMauSo)
                tongMau += i;

            return (tongTu / tongMau);

        }
    }
}
