using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Venta_Restaurante.CONEXION
{
    class CONEXIONMAESTRA
    {
        public static string conexion = Convert.ToString(LIBRERIAS.Desencryptacion.checkServer());
    }
}
