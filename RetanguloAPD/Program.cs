using System.Globalization;
using RetanguloAPD;

Retangulo retangulo = new Retangulo();

Console.WriteLine("Entre com a Largura e Altura do Retangulo: "); 

retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA: " + retangulo);