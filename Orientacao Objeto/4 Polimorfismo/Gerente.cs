using System;
namespace AulaPolimorfismo;

    public class Gerente : Imposto
    {
        public Gerente()
        {
        }
        public override void valeAlimentacao()
        {
            Console.WriteLine("Calculo GERENTE do vale alimetação.");
        }
    }
