using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL.Entities
{
    public  class proveedores
    {
        //Atributos
        int _IdProveedores;

        public string NombreEmpresa { get; set; }
        public string NombreContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Gmail { get; set; }
        public bool Estado { get; set; }

        public int IdProveedores
        {
            get
            {
                return _IdProveedores;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: El id del proveedor no puede ser negativo");
                }

                _IdProveedores = value;
            }
        }
    }
}
