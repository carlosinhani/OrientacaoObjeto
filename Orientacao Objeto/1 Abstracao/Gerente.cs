using System; 
namespace AulaPolimorfismo
{
    public class Gerente : Imposto
    {
       public Gerente()
       {
       }
       public override void valeAlimentacao() {
           Console.WriteLine("Vale Alimentacao");
       }
       public override void valeTransporte()
       {
           Console.WriteLine("Vale Transporte");
       }
    }
}