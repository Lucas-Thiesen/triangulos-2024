namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                BaseTriangulo triangulo = new BaseTriangulo();
                Console.WriteLine("Informe o lado X: ");
                triangulo.x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o lado Y: ");
                triangulo.y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o lado Z: ");
                triangulo.z = Convert.ToDouble(Console.ReadLine());

                triangulo.CalcularTriangulo();
                Console.ReadKey();
            }

        }

    }

    public class BaseTriangulo
    {
        public double x, y, z;


        public void CalcularTriangulo()
        {
            if ((x < y + z) && (y < x + z) && (z < x + y))
            {
                Console.WriteLine("É um triângulo!");
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }
            if ((x == y) && (y == z))
            {
                Console.WriteLine(" ");
                Console.Write("Triângulo Equilátero");
            }
            else if ((x == y) || (y == z) || (x == z))
            {
                Console.WriteLine(" ");
                Console.Write("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine(" ");
                Console.Write("Triângulo Escaleno");
            }
        }
    }
}
    
