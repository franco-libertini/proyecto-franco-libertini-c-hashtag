using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_franco_libertini
{
    internal class Usuario
    {
        #region Propiedades

        private int id = 0;
        private string nombre = string.Empty;
        private string apellido = string.Empty;
        private string nombreUsuario = string.Empty;
        private string contrasena = string.Empty;
        private string mail = string.Empty;

        #endregion

        #region Setters and Getters

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Mail { get; set; }

        #endregion

        #region Constructores

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasena, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Mail = mail;
        }

        #endregion
    }
}

