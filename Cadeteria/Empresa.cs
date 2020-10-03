using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

        public void AgregarCadete(string nombre, string direccion, long telefono)
        {
            Cadete nuevoCadete = new Cadete(ListadoDeCadetes.Count + 1, nombre, direccion, telefono);
            ListadoDeCadetes.Add(nuevoCadete);
        }

        public void MarcarPedidoComoEntregado(int idCadete, int nroPedido)
        {
            Cadete miCadete = ListadoDeCadetes.Find(cadete => cadete.Id == idCadete);
            Pedido suPedido = miCadete.ListaDePedidos.Find(pedido => pedido.Nro == nroPedido);
            suPedido.Estado = Estado.Entregado;
        }
    }
}
