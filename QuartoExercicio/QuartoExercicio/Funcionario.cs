using System;
using System.Globalization;

namespace QuartoExercicio {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double percentualAumento) {
            SalarioBruto = SalarioBruto + (SalarioBruto * percentualAumento / 100.0);
        }

      
             public override string ToString() {
            return
                Nome
                + ", $ "
                + SalarioLiquido(). ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
