using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_franco_libertini
{
    internal class Producto
    {
        #region Propiedades

        private int id = 0;
        private string descripcion = string.Empty;
        private double costo = 0;
        private double precioVenta = 0;
        private int stock = 0;
        private int idUsuario = 0;

        #endregion

        #region Setters and Getters

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        #endregion

        #region Constructores

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }

        #endregion
    }
}
