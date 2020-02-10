using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Recepcion
{
    class SQL_MayoresA
    {
        SQL_Conexion conectar = new SQL_Conexion();
		public void Ingresar_MayoresA(string cui, string urlMA)
		{

			string sql = "INSERT INTO documentos(nombre_tramite,cui,url_documento,estado_tramite)" +
				"  VALUES ('" + "DPI " + "','" + cui + "','" + urlMA + "','Activado');";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
	}
}
