using System;


namespace TerceiroExercicio {
    internal class retangulo {

        public double Largura;
        public double Altura;

        public double CalcularArea() {
            return Largura * Altura;
        }

        public double CalcularPerimetro() {
            return 2 * (Largura + Altura);
        }

        public double CalcularDiagonal() {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    
    }
}
