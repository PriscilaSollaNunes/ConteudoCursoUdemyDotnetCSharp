using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseContinuacao {
    internal class cambio {

        public static double Iof = 6.0;
        public static double DolarParaReal(double quant, double dolar) {
            double total = quant * dolar;
            return total + total * Iof / 100.0;
        }

    }
}
