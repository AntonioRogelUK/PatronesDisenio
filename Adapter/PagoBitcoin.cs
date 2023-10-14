namespace Adapter
{
    internal class PagoBitcoin : IPago
    {
        private readonly string _billeteraBitcoin;
        public PagoBitcoin(string billeteraBitcoin)
        {
            _billeteraBitcoin = billeteraBitcoin;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pagando con Bitcoins de billetera: {_billeteraBitcoin}");
        }
    }
}
