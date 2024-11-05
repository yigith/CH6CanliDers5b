using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerDegistirme
{
    public static class Yardimci
    {
        public static void YerDegistir<Tip>(ref Tip a, ref Tip b)
        {
            Tip yedek = a;
            a = b;
            b = yedek;
        }
    }
}
