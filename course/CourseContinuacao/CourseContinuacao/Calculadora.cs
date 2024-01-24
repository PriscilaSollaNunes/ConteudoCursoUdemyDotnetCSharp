using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseContinuacao {
    internal class Calculadora {

        static public double Pi = 3.14;

        static public double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        static public double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

    }
}
