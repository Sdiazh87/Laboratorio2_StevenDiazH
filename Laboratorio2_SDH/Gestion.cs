using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Laboratorio2_SDH
{
    public class Gestion
    {

        public static double multiplicar(double numero)
        {
            return 2 * numero;
        }

        public static void bitacorasalvada(string texto)
        {
            using (StreamWriter guardar = new StreamWriter(@"C:\Users\papi6\Documents\Backup_progra\bitacora_laboratorio2.txt", true))
            {
                guardar.WriteLine(texto);
                guardar.Flush();
            }
        }
    }
}