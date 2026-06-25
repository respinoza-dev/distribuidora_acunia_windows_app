using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion.DAL.Entities
{
    public class Producto
    {
        //Atributos
            //Campos
            int _id;
            double _precio;
            int _stockDisponible;

            //Propiedades autoimplementadas
            public string Nombre { get; set; }
            public string Marca { get; set; }
            public string Descripcion { get; set; }
            public double Tamanio { get; set; }
            public string Modelo { get; set; }

        //Propiedades
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error: Id no puede ser negativo");
                }
                _id = value;
            }
        }


        public double Precio {
                get { 
                    return _precio; 
                }
                set {
                    if (value<0)
                    {
                        throw new ArgumentException("Error: Precio no puede ser negativo");
                    }
                    _precio = value;
                } 
            }

            public int StockDisponible {
                get {
                    return _stockDisponible;
                }
                set {
                    if (value<0)
                    {
                        throw new ArgumentException("Error: Stock no debe recibir valores negativos");
                    }
                    _stockDisponible = value;
                }
            }



        //Metodos
        public int VerificarStockDisponible()
        {            
            return _stockDisponible;
        }


        public bool ActualizarStock(int cantidad, bool accion)
        {
            bool banderaActualizacion = false;

            if (cantidad>0)
            {
                if (accion == true)
                {
                    StockDisponible += cantidad;
                    banderaActualizacion = true;
                }
                else
                {
                    StockDisponible -= cantidad;
                    banderaActualizacion = true;
                }
            }           

            return banderaActualizacion;

        }

        public bool ActualizarPrecio(double nuevoPrecio)
        {
            if (nuevoPrecio > _precio)
            {
                _precio = nuevoPrecio;
                return true;
            }
            else
                return false;
        }

        public void Actualizar(string Nombre, string Marca, string Modelo)
        {
            this.Nombre = Nombre;
            this.Marca = Marca;
            this.Modelo = Modelo;
        }
    }
}
