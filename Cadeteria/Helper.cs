using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria
{
    public class Helper
    {
        private static readonly string[] Nombres = { "Juan", "Pedro", "Maria", "Carlos", "Araceli", "Claudio" };
        public static Cliente CrearClienteAleatorio()
        {
            Random rnd = new Random();
            Cliente rndCliente = new Cliente(Nombres[rnd.Next()], "Una direccion cualquiera", 3816123456);
            return rndCliente;
        }
    }
}
