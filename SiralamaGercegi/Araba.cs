using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiralamaGercegi
{
    public class Araba : IComparable
    {
        public Araba()
        {
            
        }

        public Araba(string ad, int yil)
        {
            Ad = ad;
            Yil = yil;
        }

        public string Ad { get; set; }

        public int Yil { get; set; }

        public int CompareTo(object? obj)
        {
            Araba diger = (Araba)obj;

            #region Yöntem 1: Ada Göre
            // adına göre kıyaslayalım
            //if (Ad.CompareTo(diger.Ad) < 0)
            //    return -1;
            //else if (Ad.CompareTo(diger.Ad) > 0)
            //    return 1;
            //else
            //    return 0; 
            #endregion

            #region Yöntem 2: Ada Göre
            // başına - koyunca tersine sıraladığını gözlemleyin
            // return Ad.CompareTo(diger.Ad); 
            #endregion

            #region Yöntem 1: Yılına Göre Sırala
            // return Yil - diger.Yil;
            #endregion

            #region Yöntem 2: Yılına Göre Sırala
            // return Yil.CompareTo(diger.Yil);
            #endregion

            #region Ada Göre Sırala, Ad aynı ise Yıla Baksın
            int adSira = Ad.CompareTo(diger.Ad);
            int yilSira = Yil.CompareTo(diger.Yil);
            return adSira == 0 ? yilSira : adSira;
            #endregion
        }

        public override string ToString()
        {
            return $"{Ad}/{Yil}";
        }
    }
}
