namespace Adapter
{
    internal class PagoCuerpomatic : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Cobrando con cuerpomatic");
        }
    }
}
