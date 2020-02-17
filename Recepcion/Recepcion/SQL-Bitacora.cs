using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Recepcion
{
    class SQL_Bitacora
    {
		SQL_Conexion conectar = new SQL_Conexion();
		public void Ingresar_Bitacora(string cui, string accion, string fecha)
		{

			string sql = "INSERT INTO bitacora_usuarios (cui,accion_bitacora,fecha_bitacora) " +
				"VALUES ('" + cui + "','" + accion + "','" + fecha + "');";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
	}
}
