using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamingSite.AppCode.DAO;
using StreamingSite.AppCode.POCO;
using StreamingSite.AppCode;

namespace StreamingSite.Test.DAO
{
    [TestClass]
    public class UsuarioDAOTest
    {
        [TestMethod]
        public void CrearUsuario()
        {
            Usuario usuario = new Usuario();

            usuario.correo = "adela.vallejosolis@hotmail.com";
            usuario.departamento = "pry2";
            usuario.hash = PasswordHash.CreateHash("23Adela.@");
            usuario.mensaje = "";
            usuario.nombre = "Adel Vallejo Solis";

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            int resultado = usuarioDAO.Insert(usuario);

            Trace.WriteLine("resultado: " + resultado);
        }
    }
}
