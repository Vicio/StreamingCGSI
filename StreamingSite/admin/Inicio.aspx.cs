using System;
using StreamingSite.AppCode;
using StreamingSite.AppCode.DAO;
using StreamingSite.AppCode.POCO;

namespace StreamingSite.admin
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["tituloPagina"] = "Coordinación General de Servicios de Informatización - UAQ";
            Session["subtituloCuerpo"] = "Coordinación General de Servicios de Informatización";
            Session["temaStreaming"] = "";
        }

        protected void buttonIngresar_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            Usuario usuario = usuarioDAO.FindByMail(textboxCorreo.Value);

            if (PasswordHash.ValidatePassword(textboxPassword.Value, usuario.hash))
            {
                Session["canal"] = usuario.departamento;
                Session["hash"] = usuario.hash;
                Session["id"] = usuario.id;
                Session["mensaje"] = usuario.mensaje;
                Session["correo"] = usuario.correo;

                Response.Redirect("Mensaje.aspx");
            }

        }
    }
}