using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Laboratorio_3_AimeeMatias
{
    public static class Utilidades
    {
        public static bool EsCorreoValido(string Email)
        {
            if ((EstaEnBlanco(Email)))
            {
                return false;
            }

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(Email, patron);
        }
        public static bool EstaEnBlanco(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }

    }
}
