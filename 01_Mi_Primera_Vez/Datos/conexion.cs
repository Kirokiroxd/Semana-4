﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _01_Mi_Primera_Vez.Datos
{
    public class conexion
    {
        private readonly string varconexion =
            "Server=DESKTOP-HTSSO6T\\SQLEXPRESS;database=Asistencias;uid=sa;pwd=1600591927";

        public SqlConnection obtenerConexion() {
            return new SqlConnection(varconexion);
        }

    }
}
