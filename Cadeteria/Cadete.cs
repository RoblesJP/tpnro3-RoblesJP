﻿using System;
using System.Collections.Generic;

namespace Cadeteria
{
    public class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private long telefono;
        List<Pedido> listaDePedidos;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public List<Pedido> ListaDePedidos { get => listaDePedidos; set => listaDePedidos = value; }

        public Cadete(int id, string nombre, string direccion, long telefono)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }
    }
}
