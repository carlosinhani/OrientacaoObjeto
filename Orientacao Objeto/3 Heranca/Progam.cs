using Sytem;

namespace Aula Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerent gg = new Gerente();
            gg.valeAlimentacao();
            gg.valeTransporte();
            Console.WriteLine("FIM");
        }
    }
}