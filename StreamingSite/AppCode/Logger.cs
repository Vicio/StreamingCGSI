using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Configuration;

namespace StreamingSite.AppCode
{
    public class Logger
    {

        /// <summary>
        /// Inicia el logger y agrega el mensaje
        /// </summary>
        /// <param name="mensaje">El error específico generado por el programa</param>
        public static void StartLogger(string mensaje)
        {
            using (StreamWriter w = File.AppendText("c:/logs/streaming/" + DateTime.Now.ToString(@"yyyy-mm-dd") + ".log"))
            {
                Log(mensaje, w);
            }

            using (StreamReader r = File.OpenText("c:/logs/streaming/" + DateTime.Now.ToString(@"yyyy-mm-dd") + ".log"))
            {
                DumpLog(r);
            }
        }

        /// <summary>
        /// Inserción del mensaje dentro del archivo
        /// </summary>
        /// <param name="logMessage">El mensaje de error</param>
        /// <param name="w">El buffer del archivo al que se va a escribir</param>
        private static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
        }

        /// <summary>
        /// Extracción del mensaje para ver en consola
        /// </summary>
        /// <param name="r">El buffer del archivo a leer</param>
        private static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}