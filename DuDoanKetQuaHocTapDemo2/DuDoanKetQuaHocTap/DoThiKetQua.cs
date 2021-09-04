using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuDoanKetQuaHocTap
{
    class DoThiKetQua
    {
        Double A, B, C, D, a, b, m1, m2;
        public DoThiKetQua() { }
        public DoThiKetQua(Double a, Double b, Double c, Double d) {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Double getTuSo(Double H) {
            a = H * (B - A);
            b = H * (D - C);
            m1 = A + a;
            m2 = D - b;
            return ((H / 6) * (3 * m2 * m2 - 3 * m1 * m1 + b * b - a * a + 3 * m2 * b + 3 * m1 * a));

        }

        public Double getMauSo(Double H) {
            return ((H / 2) * (2 * m2 - 2 * m1 + a + b));
        }
    }
}
