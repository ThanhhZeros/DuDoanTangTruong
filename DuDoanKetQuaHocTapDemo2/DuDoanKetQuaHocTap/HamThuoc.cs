using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuDoanKetQuaHocTap
{
    class HamThuoc
    {
        Int32 x1, x2, x3;
        Int32 y1, y2, y3;
        public HamThuoc(){}

        public Double LayGiaTriHamThuoc(Int32 input, Int32 a1, Int32 b1, Int32 a2, Int32 b2, Int32 a3, Int32 b3) {
            x1 = a1;
            y1 = b1;
            x2 = a2;
            y2 = b2;
            x3 = a3;
            y3 = b3;
            if (input <= x1)
                return y1;
            else if (input > x1 && input <= x2)
                return ((y2 - y1) * (input*1.0 - x1) / (x2 - x1) + y1);
            else if (input > x2 && input <= x3)
                return ((y3 - y2) * (input*1.0 - x2) / (x3 - x2) + y2);
            else
                return y3;
        }
    }
}
