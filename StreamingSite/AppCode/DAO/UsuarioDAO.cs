using System;
using System.Collections.Generic;
using System.Linq;
using StreamingSite.AppCode.POCO;

namespace StreamingSite.AppCode.DAO
{

    /// <summary>
    /// Summary description for UsuarioDAO
    /// </summary>
    public class UsuarioDAO
    {
        /// <summary>
        /// Busqueda de Usuario por su ID
        /// </summary>
        /// <param name="id">El ID del usuario</param>
        /// <returns>Un objeto usuario con todas sus características</returns>
        public Usuario FindById(int id)
        {
            StreamingDSDataContext contexto = new StreamingDSDataContext();

            using (contexto)
            {
                var resultado =
                (
                    from usuario in contexto.usuarios
                    where usuario.id_usuario == id
                    select new Usuario(usuario.id_usuario, usuario.nombre_usuario, usuario.correo_usuario,
                        usuario.hash_usuario, usuario.departamento_usuario, usuario.mensaje_usuario)
                );
                return resultado.FirstOrDefault();
            }

        }

        /// <summary>
        /// Busqueda del usuario por su correo
        /// </summary>
        /// <param name="correo">el correo del usuario</param>
        /// <returns>un objeto que contiene los datos del usuario</returns>
        public Usuario FindByMail(string correo)
        {
            StreamingDSDataContext contexto = new StreamingDSDataContext();

            using (contexto)
            {
                var resultado =
                (
                    from usuario in contexto.usuarios
                    where usuario.correo_usuario == correo
                    select new Usuario(usuario.id_usuario, usuario.nombre_usuario, usuario.correo_usuario,
                        usuario.hash_usuario, usuario.departamento_usuario, usuario.mensaje_usuario)
                );
                return resultado.FirstOrDefault();
            }

        }

        /// <summary>
        /// Busqueda del usuario por el departamento
        /// </summary>
        /// <param name="departamento">El departamento</param>
        /// <returns>un objeto que contiene los datos del usuario</returns>
        public Usuario FindByDepartment(string departamento)
        {
            StreamingDSDataContext contexto = new StreamingDSDataContext();

            using (contexto)
            {
                var resultado =
                (
                    from usuario in contexto.usuarios
                    where usuario.departamento_usuario == departamento
                    select new Usuario(usuario.id_usuario, usuario.nombre_usuario, usuario.correo_usuario,
                        usuario.hash_usuario, usuario.departamento_usuario, usuario.mensaje_usuario)
                );
                return resultado.FirstOrDefault();
            }

        }

        /// <summary>
        /// Busqueda de todos los usuarios
        /// </summary>
        /// <returns>Una lista que contiene los usuarios del sistema</returns>
        public List<Usuario> FindAll()
        {
            StreamingDSDataContext contexto = new StreamingDSDataContext();

            using (contexto)
            {
                var resultado =
                (
                    from usuario in contexto.usuarios
                    select new Usuario(usuario.id_usuario, usuario.nombre_usuario, usuario.correo_usuario,
                        usuario.hash_usuario, usuario.departamento_usuario, usuario.mensaje_usuario)
                );
                return resultado.ToList();
            }

        }

        /// <summary>
        /// Insercion de un objeto Usuario a la tabla
        /// </summary>
        /// <param name="usuario">Un objeto de la clase Usuario</param>
        /// <returns>0 si es exitoso, -1 si ocurre un error</returns>
        public int Insert(Usuario usuario)
        {
            usuarios usuarioTable = new usuarios
            {
                nombre_usuario = usuario.nombre,
                correo_usuario = usuario.correo,
                hash_usuario = usuario.hash,
                departamento_usuario = usuario.departamento,
                mensaje_usuario = usuario.mensaje
            };

            try
            {
                StreamingDSDataContext contexto = new StreamingDSDataContext();
                contexto.usuarios.InsertOnSubmit(usuarioTable);
                contexto.SubmitChanges();
                return 0;
            }
            catch (Exception ex)
            {
                Logger.StartLogger(ex.ToString());
                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="correo"></param>
        /// <param name="hash"></param>
        /// <param name="departamento"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public int Insert(string nombre, string correo, string hash, string departamento, string mensaje)
        {
            usuarios usuarioTable = new usuarios
            {
                nombre_usuario = nombre,
                correo_usuario = correo,
                hash_usuario = hash,
                departamento_usuario = departamento,
                mensaje_usuario = mensaje
            };

            try
            {
                StreamingDSDataContext contexto = new StreamingDSDataContext();
                contexto.usuarios.InsertOnSubmit(usuarioTable);
                contexto.SubmitChanges();
                return 0;
            }
            catch (Exception ex)
            {
                Logger.StartLogger(ex.ToString());
                return -1;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public int Update(Usuario usuario)
        {
            try
            {
                StreamingDSDataContext contexto = new StreamingDSDataContext();

                usuarios usuarioTable = contexto.usuarios.Single(usuarioRow => usuarioRow.id_usuario == usuario.id);

                usuarioTable.nombre_usuario = usuario.nombre;
                usuarioTable.correo_usuario = usuario.correo;
                usuarioTable.hash_usuario = usuario.hash;
                usuarioTable.departamento_usuario = usuario.departamento;
                usuarioTable.mensaje_usuario = usuario.mensaje;

                contexto.SubmitChanges();
            }
            catch(Exception ex)
            {
                Logger.StartLogger(ex.ToString());
                return -1;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="correo"></param>
        /// <param name="hash"></param>
        /// <param name="departamento"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public int Update(int id, string nombre, string correo, string hash, string departamento, string mensaje)
        {
            try
            {
                StreamingDSDataContext contexto = new StreamingDSDataContext();

                usuarios usuarioTable = contexto.usuarios.Single(usuarioRow => usuarioRow.id_usuario == id);

                usuarioTable.nombre_usuario = nombre;
                usuarioTable.correo_usuario = correo;
                usuarioTable.hash_usuario = hash;
                usuarioTable.departamento_usuario = departamento;
                usuarioTable.mensaje_usuario = mensaje;

                contexto.SubmitChanges();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.Message);
                return -1;
            }

            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public int Update(int id, string mensaje)
        {
            try
            {
                StreamingDSDataContext contexto = new StreamingDSDataContext();

                usuarios usuarioTable = contexto.usuarios.Single(usuarioRow => usuarioRow.id_usuario == id);

                usuarioTable.mensaje_usuario = mensaje;

                contexto.SubmitChanges();

            }
            catch (Exception ex)
            {
                Logger.StartLogger(ex.ToString());
                return -1;
            }

            return 0;
        }

    }
}