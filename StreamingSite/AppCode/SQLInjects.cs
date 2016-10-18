using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StreamingSite.AppCode
{
    public class SQLInjects
    {
        /// <summary>
        /// Remueve los caracteres básicos de sql para crear una sql injection
        /// </summary>
        /// <param name="texto">El texto a ser analizado</param>
        /// <returns>El texto con los caracteres removidos</returns>
        public string Remover(string texto)
        {
            string temp = "";
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == '\'' || texto[i] == ';' ||
                    texto[i] == '%' || texto[i] == '\"' ||
                    texto[i] == '\\' || texto[i] == '/' ||
                    texto[i] == '|')
                    i++;
                if (i < texto.Length)
                    temp += texto[i];
            }

            return temp;
        }
    }
}