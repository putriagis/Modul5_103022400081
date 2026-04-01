using System;
using System.Collections.Generic;
using System.Text;

namespace Modul5_103022400081
{
    internal class PemrosesData
    {
       public T DapatkanNilaiTerbesar<T> (T nilai1, T nilai2, T nilai3)
        {
            dynamic tamp1 = nilai1;
            dynamic tamp2 = nilai2;
            dynamic tamp3 = nilai3;
            dynamic max = nilai1;

            if (tamp2 > max)
            {
                max = tamp2;
            }
            if (tamp3 > max)
            {
                max = tamp3;
            }
            return max;
        }
    }
}
