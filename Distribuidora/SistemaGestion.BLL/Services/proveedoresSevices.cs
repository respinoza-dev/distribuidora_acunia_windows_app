using SistemaGestion.DAL.Entities;
using SistemaGestion.DAL.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.BLL.Services
{
    public class proveedoresSevices
    {
        private ProveedorRepository _repository;
        public proveedoresSevices()
        {
            // construyendo el objeto de tipo CategoryRepository
            // inyeccion de dependencias
            _repository = new ProveedorRepository();
        }

        public void RegistrarLista(List<proveedores> lista)
        {
            // Validacion
            foreach (var proveedores in lista)
            {
                if (string.IsNullOrEmpty(proveedores.NombreEmpresa))
                {
                    throw new Exception("Error: nombre del proveedor no puede estar vacio");
                }
            }

            // invocamos al metodo para registrar la lista de Proveedores
            _repository.RegistrarLista(lista);
        }

        public List<proveedores> ObtenerLista()
        {
            return _repository.ObtenerLista();
        }

        public List<proveedores> ObtenerProveedoresActivos()
        {
            return _repository.ObtenerProveedoresActivos();
        }

        public void Editar(proveedores proveedores)
        {
            if (string.IsNullOrEmpty(proveedores.NombreEmpresa) || proveedores.Estado == null)
            {
                throw new ArgumentException("Error: No se admiten valores nulos en Nombre Empresa y Estado.");
            }

            // si no hay problema de la excepcion anterior, se invoca el metodo de editar
            _repository.Editar(proveedores);
        }
        public void Eliminar(int IdProveedores)
        {
            if (IdProveedores < 0)
            {
                throw new Exception("Error: El ID proveedor no puede ser negativo");
            }
            _repository.Eliminar(IdProveedores);
        }
    }
}
