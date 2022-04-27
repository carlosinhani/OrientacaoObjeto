using System;
namespace AulaPolimorfismo;

   public class Atendente : Imposto
    {
        public Atendente()
        {
        }
        public override void valeAlimentacao()
        {
            Console.WriteLine("Calculo do ATENDENTE do vale alimetação.");
        }
    }
