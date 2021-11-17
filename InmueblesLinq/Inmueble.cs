using System;
using System.Collections.Generic;

namespace InmueblesLinq
{
    public class Inmueble
    {
        public int Referencia { get; set; }
        public DateTime FechaAlta { get; set; }
        public String Tipo { get; set; }
        public String Operacion { get; set; }
        public String Provincia { get; set; }
        public int Superficie { get; set; }
        public decimal PrecioVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public String Vendedor { get; set; }
    }
}