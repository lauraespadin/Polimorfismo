namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometria geometria = new Geometria();

            double areaQuadrado = geometria.CalcularArea(5);

            double areaRetangulo = geometria.CalcularArea(40, 4);

            double areaCirculo = geometria.CalcularArea(6, true);

            Console.WriteLine($"Área do quadrado: {areaQuadrado:F2}");
            Console.WriteLine($"Área do retângulo: {areaRetangulo:F2}");
            Console.WriteLine($"Área do círculo: {areaCirculo:F2}");
        }
    }
}
