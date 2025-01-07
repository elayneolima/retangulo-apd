
using System.Globalization; 
namespace RetanguloAPD
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro() 
        {
            return 2 * (Largura + Altura); 
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
        public override string ToString()
        {
            return "ÁREA: "
                   + Area().ToString("F2", CultureInfo.InvariantCulture)
                   + ", PERIMETRO: "
                   + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                   + ", DIAGONAL: "
                   + Diagonal().ToString("F2", CultureInfo.InvariantCulture); 
        }

       
    }
}
