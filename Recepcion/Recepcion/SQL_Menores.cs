using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Recepcion
{
    class SQL_Menores
    {
        SQL_Conexion conectar = new SQL_Conexion();
		public void Ingresar_Menores(string cui, string urlM)
		{
			string sql = "INSERT INTO documentos(nombre_tramite,cui,url_documento,estado_tramite)" +
				"  VALUES ('" + "DPI_Padre" + "','" + cui + "','" + urlM + "','Activado');" +
				"  VALUES ('" + "DPI_Madre" + "','" + cui + "','" + urlM + "','Activado');" +
				"  VALUES ('" + "Certificado_nacimiento" + "','" + cui + "','" + urlM + "','Activado');" +
				"  VALUES ('" + "Carta_Poder" + "','" + cui + "','" + urlM + "','Activado');" +
				"  VALUES ('" + "Boleto_Ornato" + "','" + cui + "','" + urlM + "','Activado');";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
	}
}
