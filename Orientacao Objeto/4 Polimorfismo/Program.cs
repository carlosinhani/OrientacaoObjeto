using System;

namespace Aula Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente();
            Atendente atendente = new Atendente();
            Estagiario estagiario = new Estagiario();
            gerente.valeAlimentacao();
            atendente.valeAlimentacao();
            estagiario.valeAlimentacao();
            Console.WriteLine("FIM: Polomorfismo");
        }
    }
}