using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;
using StreamingSite.AppCode;

namespace StreamingSite.AppCode
{
    public class Correo
    {
        /// <summary>
        /// Correo del cliente, el correo de destino
        /// </summary>
        private MailAddress correoCliente;

        /// <summary>
        /// Correo del servidor, el correo de origen
        /// </summary>
        private MailAddress correoServidor;

        /// <summary>
        /// El directorio raiz de la aplicacion de streaming
        /// </summary>
        private string directorioServidor = ConfigurationManager.AppSettings["directorioServidor"];

        /// <summary>
        /// Mensaje a ser enviado
        /// </summary>
        private MailMessage mensaje;

        /// <summary>
        /// Clase de envío del smtp
        /// </summary>
        SmtpClient smtp;

        /// <summary>
        /// Constructor de la clase Correo
        /// </summary>
        public Correo()
        {
            smtp = new SmtpClient();
            //El correo del servidor
            correoServidor = new MailAddress("dsiv.uaq@hotmail.com", "Universidad Autónoma de Querétaro");
            //Activar correo seguro
            smtp.EnableSsl = true;
        }

        /// <summary>
        /// Enviar confirmación de que la cuenta existe al correo asignado
        /// </summary>
        /// <param name="correo">El correo del solicitante</param>
        /// <param name="nombre">El nombre del solicitante</param>
        /// <param name="hash">El hash para validar la cuenta</param>
        /// <returns>Mensaje de éxito al enviar el correo</returns>
        public string EnviarConfirmacionCuenta(string correo, string nombre, string hash)
        {
            try
            {
                //Correo del cliente
                correoCliente = new MailAddress(correo, nombre);

                //Asignación del origen y destino del correo
                mensaje = new MailMessage(correoServidor, correoCliente);

                //Titulo del correo
                mensaje.Subject = "Verificacion de cuenta (no responder)";

                //El cuerpo del mensaje que incluye el codigo de verificacion de la cuenta en un enlace.
                mensaje.Body = "<a href=\"" + directorioServidor + "Login/Verificacion.aspx?VerificarCorreo=" + hash + "\" >Click aquí para verificar su cuenta.</a>";

                //Formato html para el correo
                mensaje.IsBodyHtml = true;

                //Prioridad alta en el correo
                mensaje.Priority = MailPriority.High;

                //Se intenta enviar el correo
                smtp.Send(mensaje);
            }
            catch(SmtpFailedRecipientException smtpRecEx)
            {
                Logger.StartLogger(smtpRecEx.ToString());
                return "Error al enviar el correo, correo no válido o temporalmente inaccesible.";
            }
            catch(Exception ex)
            {
                Logger.StartLogger(ex.ToString());
                return "Error desconocido al enviar el correo, contacte a su administrador.";
            }

            return "Correo enviado exitosamente";
        }

        /// <summary>
        /// Correo enviado para restaurar la contraseña
        /// </summary>
        /// <param name="correo">El correo del cliente</param>
        /// <param name="nombre">El nombre del cliente</param>
        /// <param name="hash">El hash del link de validación</param>
        /// <returns></returns>
        public string EnviarConfirmacionCambioPassword(string correo, string nombre, string hash)
        {
            try
            {
                //Correo del cliente
                correoCliente = new MailAddress(correo, nombre);

                //Asignación del origen y destino del correo
                mensaje = new MailMessage(correoServidor, correoCliente);

                //Titulo del correo
                mensaje.Subject = "Cambio de contraseña (no responder)";

                //El cuerpo del mensaje que incluye el codigo de verificacion de la cuenta en un enlace.
                mensaje.Body = "<a href=\"" + directorioServidor + "Login/Verificacion.aspx?VerificarCorreo=" + hash + "\" >Click aquí para cambiar su contraseña.</a>";

                //Formato html para el correo
                mensaje.IsBodyHtml = true;

                //Prioridad alta en el correo
                mensaje.Priority = MailPriority.High;

                //Se intenta enviar el correo
                smtp.Send(mensaje);
            }
            catch (SmtpFailedRecipientException smtpRecEx)
            {
                Logger.StartLogger(smtpRecEx.ToString());
                return "Error al enviar el correo, correo no válido o temporalmente inaccesible.";
            }
            catch (Exception ex)
            {
                Logger.StartLogger(ex.ToString());
                return "Error desconocido al enviar el correo, contacte a su administrador.";
            }

            return "Correo enviado exitosamente";
        }

    }
}