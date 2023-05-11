using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_franco_libertini
{
    internal class ProductoVendido
    {
        #region Propiedades

        private int id = 0;
        private int idProducto = 0;
        private int stock = 0;
        private int idVenta = 0;

        #endregion

        #region Setters and Getters

        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public int IdVenta { get; set; }

        #endregion

        #region Constructores

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;
        }

        #endregion

    }
}
