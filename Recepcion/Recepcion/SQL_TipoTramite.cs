using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recepcion
{
    class SQL_TipoTramite
    {
        SQL_Conexion conectar = new SQL_Conexion();

        public string tipoTramite;
        public void obtenerTipoTramite(string cui, string idTramite)
        {
            OdbcConnection conn = conectar.conexion();
            var resultado = conectar.conexion();
            OdbcCommand comando = conn.CreateCommand();
            OdbcTransaction transaccion = conn.BeginTransaction();
            OdbcDataReader reader;

            string sql = "SELECT tipo_tramite " +
                "from tramites " +
                "where cui = '" + cui + "' and id_tramite = '"+idTramite+"';";

            comando.Transaction = transaccion;
            comando.CommandText = sql;

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                tipoTramite = reader.GetString(0);
            }

        }
    }
}
