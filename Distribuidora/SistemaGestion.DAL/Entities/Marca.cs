using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL.Entities
{
    public class Marca
    {
        int _IdMarca;

        public string NombreMarca { get; set; }
        public string Descripcion { get; set; }
        

        public int IdMarca
        {
            get
            {
                return _IdMarca;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: El id de la Marca no puede ser negativo");
                }

                _IdMarca = value;
            }
        }
    }
}
