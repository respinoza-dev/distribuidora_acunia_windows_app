using SistemaGestion.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL.Entities
{
    public class UnidaDeMedida
    {
        int _IdUnidad;

        public string NombreUnidad { get; set; }
        public string Abreviatura { get; set; }


        public int IdUnidad
        {
            get
            {
                return _IdUnidad;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: El id de la Unidad no puede ser negativo");
                }

                _IdUnidad = value;
            }
        }

        public void Editar(UnidaDeMedida unidaDeMedida)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int idUnidad)
        {
            throw new NotImplementedException();
        }

        public List<UnidaDeMedida> ObtenerLista()
        {
            throw new NotImplementedException();
        }

        public void RegistrarLista(List<UnidaDeMedida> lista)
        {
            throw new NotImplementedException();
        }

        public static implicit operator UnidaDeMedida(UnidaRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
