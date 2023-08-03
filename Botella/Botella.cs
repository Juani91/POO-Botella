using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botella
{
    internal class Botella
    {
        // Creamos una Botella.
        // Al crearla hay que darle las características de Material, Color, Capacidad y CantidadActual.
        // Viene con una Capacidad de 1000ml
        // Viene con una CantidadActual de 0ml
        // Se puede recargar con un precio de $100 cada 1000ml

        // ATRIBUTOS y PROPIEDADES

        public string Material { get; }
        public string Color { get; }
        public int Capacidad { get; }
        public int CantidadActual { get; set; } // Si el método va a cambiarlo debe tener set también. 


        // CONSTRUCTORES

        // Material y Color van a ser variables (se los damos al momento de crearlo)
        // Capacidad y CantidadActual son fijos (siempre se creará una botella vacía de 1000ml)

        public Botella(string Material, string Color)
        {
            this.Material = Material;
            this.Color = Color;
            Capacidad = 1000;
            CantidadActual = 0;
        }


        // METODOS

        // Hacer que se recargue la Botella
        // Luego que se tome 1/4
        // Y se vuelva a recargar (con el precio ajustado)

        public int Recargar(int m)
        {
            int d;
            if (CantidadActual > 0)
            {
                d = Capacidad - CantidadActual;
                CantidadActual += d;
                // 1000ml -> $100
                // dif -> x=monto
                m = (d * m) / 1000;
                return m;
            }
            else
            {
                CantidadActual = 1000;
                //m = m;
                return m;
            }
        }

        public void Beber()
        {
            CantidadActual -= 250;
        }
    }
}
