using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmueblesLinq
{
    public partial class Catalogo
    {
        private List<string> tipos;
        public List<string> Tipos
        {
            get
            {
                if (tipos==null)
                {
                    tipos= (from i in Inmuebles
                            select i.Tipo
                        ).Distinct().ToList();
                }
                return tipos;
            }
        }
        private List<string> provincias;
        public List<string> Provincias
        {
            get
            {
                if (provincias==null)
                {
                    provincias = Inmuebles
                        .Select(i => i.Provincia)
                        .Distinct().ToList();
                }
                return provincias;
            }
        }


        public List<Inmueble> FiltrarPorTipo(string tipo)
        {
            return Inmuebles
                    .Where(i => i.Tipo == tipo)
                    .ToList();
        }
    }
}
