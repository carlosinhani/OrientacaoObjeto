using Sytem;

namespace Aula Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerent gg = new Gerent();
            gg.Valor = 200;
            string valorCalc = gg.Valor.ToString();
           
            gg.valeTransporte();
            Console.WriteLine("Valor" + valorCalc);

            Console,WriteLine("FIM");
        }
    }
}