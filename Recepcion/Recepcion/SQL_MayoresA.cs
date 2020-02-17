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
		public void Ingresar_MayoresA(string tramite, string cui, string urlMA, string noBoleta)
		{
			string sql = "INSERT INTO documentos(id_tramite,nombre_documento,cui,url_documento, no_documento,estado_documento)" +
				"  VALUES ('" + tramite + "','" + "DPI " + "','" + cui + "','" + urlMA + "','0','Activado')," +
				"  ('" + tramite + "','" + "No_Boleta" + "','" + cui + "','" + noBoleta + "','0','Activado');";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();
		}
	}
}
