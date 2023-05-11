using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_franco_libertini
{
    internal class Venta
    {
        #region Propiedades

        private int id = 0;
        private string comentarios = string.Empty;
        private int idUsuario = 0;

        #endregion

        #region Setters and Getters

        public int Id { get; set; }
        public string Comentarios { get; set; }
        public int IdUsuario { get; set; }

        #endregion

        #region Constructores

        public Venta(int id, string comentarios, int idUsuario)
        {
            Id = id;
            Comentarios = comentarios;
            IdUsuario = idUsuario;
        }

        #endregion

    }
}
