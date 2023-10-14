namespace Adapter
{
    internal class PagoConServicio : IPago
    {
        private readonly string _servicio;
        public PagoConServicio(string servicio)
        {
            _servicio = servicio;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pagando prestando servicios de {_servicio}");
        }
    }
}
}
