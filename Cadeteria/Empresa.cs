using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria
{
    public class Empresa
    {
        private string nombre;
        private List<Cadete> listaDeCadetes;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Cadete> ListadoDeCadetes { get => listaDeCadetes; set => listaDeCadetes = value; }

        public Empresa(string nombre)
        {
            Nombre = nombre;
        }
    }
}
