using System;
using Cadeteria;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa miCadeteria1 = Helper.GenerarEmpresaAleatoria(5, 5);
            Helper.InformeDeEmpresa(miCadeteria1);
        }
    }
}
