namespace Adapter
{
    internal class PagoConAguacates : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Cobrando con aguacates");
        }
    }
}
