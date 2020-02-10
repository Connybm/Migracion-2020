using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Recepcion
{
    class SQL_Conexion
    {
		public OdbcConnection conexion()
		{
			// creacion de la conexion via ODBC
			OdbcConnection conn = new OdbcConnection("Dsn=GCP");
			try
			{
				conn.Open();
			}
			catch (OdbcException)
			{
				Console.WriteLine("No Conectó");
			}
			return conn;
		}
	}
}
