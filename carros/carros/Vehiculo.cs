using System;
using System.Collections.Generic;
using System.Text;

namespace carros
{
    class Vehiculo
    {
        private int id;
        private String marca;
        private String modelo;
        private int km;
        private double precio;

        public Vehiculo(int id, string marca, string modelo, int km, double precio)
        {
            this.Id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
        }

        public int id { get => id; set => id = value; }
    }
}
