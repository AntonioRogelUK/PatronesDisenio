namespace Adapter
{
    internal class PagoTrueque : IPago
    {
        private readonly string _tipoCambio;
        public PagoTrueque(string tipoCambio)
        {
            _tipoCambio = tipoCambio;
        }
        public void Cobrar()
        {
            Console.WriteLine($"Acuerdo de cambio de bienes para cobro, cobrando con {_tipoCambio}");
        }
    }
}
