using System;
namespace Aula Polimorfismo
{
    public class Imposto 
    {
        public Imposto()
        {
        }
        public virtual void valeAlimentacao()
        {
            Console.WriteLine("Calculo GERAL do vale alimetação.");
        }
        public void valeTransporte()
        {
            Console.WriteLine("Calculo GERAL do vale Transporte.");
        }
    }
}