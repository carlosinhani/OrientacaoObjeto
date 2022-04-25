using Sytem;
namespace AulaClasse
{
    public class Imposto
    {
        private double valor;
        
        public Imposto()
        {
        }
        public double Valor {
            get { return this.valor; }
            set { valor = value; }
        }

        public void valeTransporte()
        {
            double result = this.valor * 1.06;
            Console.WriteLine("Transporte" + result.ToString());
        }
        public void valeAlimentacao()
        {
            Console.WriteLine("Alimentacao")
        }
    }
}