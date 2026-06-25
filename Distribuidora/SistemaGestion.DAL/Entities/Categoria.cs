using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL.Entities
{
    public class Categoria
    {
        //Atributos
        int _idCategoria;

        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        public int IdCategoria
        {
            get
            {
                return _idCategoria;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: El id de la categoria no puede ser negativo");
                }

                _idCategoria = value;
            }
        }
    }
}
