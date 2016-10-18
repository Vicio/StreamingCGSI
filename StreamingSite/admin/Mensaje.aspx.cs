using System;
using StreamingSite.AppCode.DAO;
using StreamingSite.AppCode;
using StreamingSite.AppCode.POCO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StreamingSite.admin
{
    public partial class Mensaje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if ((int)Session["id"] == 0 && Session["hash"].ToString().Length <= 20)
            {
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();

                Usuario usuario = usuarioDAO.FindByMail((string)Session["correo"]);

                if((int)Session["id"] != usuario.id)
                {
                    Response.Redirect("Inicio.aspx");
                }
            }

            Session["tituloPagina"] = "Coordinación General de Servicios de Informatización - UAQ";
            Session["subtituloCuerpo"] = "Coordinación General de Servicios de Informatización";
            Session["temaStreaming"] = Session["mensaje"] + "<-- Aqui se verá el título que escoja";
        }

        protected void buttonCambiarMensaje_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            usuarioDAO.Update((int)Session["id"], textboxMensaje.Value);

            Session["mensaje"] = usuarioDAO.FindById((int)Session["id"]).mensaje;

            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }
}