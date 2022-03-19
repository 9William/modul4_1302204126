using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204126
{
    public class Penjumlahan<T>
    {
        T data;
        public static int JumlahTigaAngka(T a1, T a2, T a3)
        {
            //Mengconvert dari T ke int untuk masuk kedalam penjumlahan
            int A1 = Convert.ToInt16(a1);
            int A2 = Convert.ToInt16(a2);
            int A3 = Convert.ToInt16(a3);
            //Membuat variable hasil untuk menampilkan hasil dari penjumlahan
            int hasil = A1 + A2 + A3;

            return hasil;
        }
    }
}
