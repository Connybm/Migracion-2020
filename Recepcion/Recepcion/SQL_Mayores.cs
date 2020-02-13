using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Recepcion
{
    class SQL_Mayores
    {
        SQL_Conexion conectar = new SQL_Conexion();
		public void Ingresar_Mayores(string cui, string urlMayor, string urlOrnato)
		{
			string sql = "INSERT INTO documentos(nombre_documento,cui,url_documento,estado_documento)" +
				"  VALUES ('" + "DPI" + "','" + cui + "','" + urlMayor + "','Activado');" +
				"  VALUES ('" + "Boleto de Ornato" + "','" + cui + "','" + urlOrnato + "','Activado');";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
	}
}
