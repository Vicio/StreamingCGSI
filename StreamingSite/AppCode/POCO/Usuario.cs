using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StreamingSite.AppCode.POCO
{
    /// <summary>
    /// Clase del usuario que mantiene los mensajes de los canales
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// El id del usuario
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// El nombre del usuario
        /// </summary>
        public string nombre { get; set; }

        /// <summary>
        /// El correo del usuario
        /// </summary>
        public string correo { get; set; }

        /// <summary>
        /// La contraseña del usuario
        /// </summary>
        public string hash { get; set; }

        /// <summary>
        /// El departamento o facultad a la que pertenece
        /// </summary>
        public string departamento { get; set; }

        /// <summary>
        /// El mensaje del canal del departamento o facultad
        /// </summary>
        public string mensaje { get; set; }

        /// <summary>
        /// Constructor vacío de la clase Usuario: int = 0, string = ""
        /// </summary>
        public Usuario()
        {
            id = 0;
            nombre = "";
            correo = "";
            hash = "";
            departamento = "";
            mensaje = "";
        }

        /// <summary>
        /// Constructor de la clase Usuario
        /// </summary>
        /// <param name="id">El id del usuario</param>
        /// <param name="nombre">El nombre del usuario</param>
        /// <param name="correo">El correo del usuario</param>
        /// <param name="hash">El hash del usuario que se va a comparar</param>
        /// <param name="departamento">El departamento del usuario</param>
        /// <param name="mensaje">El mensaje del canal del departamento del usuario</param>
        public Usuario(int id, string nombre, string correo, string hash, string departamento, string mensaje)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.hash = hash;
            this.departamento = departamento;
            this.mensaje = mensaje;
        }

    }
}