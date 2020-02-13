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
		public void Ingresar_Menores(string cui, string cuiM, string cuiP, string urlCP, string urlCM, string urlCertifNac, string urlCartaPoder, string ornato, string urlCopiaOrnato, string noBoleta)
		{
			string sql = "INSERT INTO documentos(nombre_documento,cui,url_documento,estado_documento)" +
				"  VALUES ('" + "DPI_Padre" + "','" + cuiP + "','" + urlCP + "','Activado')," +
				"  ('" + "DPI_Madre" + "','" + cuiM + "','" + urlCM + "','Activado')," +
				"  ('" + "Certificado_nacimiento" + "','" + cui + "','" + urlCertifNac + "','Activado')," +
				"  ('" + "Carta_Poder" + "','" + cui + "','" + urlCartaPoder + "','Activado')," +
				"  ('" + "Boleto_Ornato" + "','" + ornato + "','" + urlCopiaOrnato + "','Activado')," +
				"  ('" + "No_Boleta" + "','" + cui + "','" + noBoleta + "','Activado');";
			OdbcCommand command = new OdbcCommand(sql, conectar.conexion());
			command.ExecuteNonQuery();

		}
	}
}
