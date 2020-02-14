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
        public void Ingresar_Menores(string tramite, string cui, string cuiM, string cuiP, string urlCP, string urlCM, string urlCertifNac, string urlCartaPoder, string ornato, string urlCopiaOrnato, string noBoleta)
        {
            string sql = "INSERT INTO documentos(id_tramite,nombre_documento,cui,url_documento,estado_documento)" +
                "  VALUES ('" + tramite + "','" + "DPI_Padre" + "','" + cuiP + "','" + urlCP + "' '" + "',0,'Activado')," +
                "  ('" + tramite + "','" + "DPI_Madre" + "','" + cuiM + "','" + urlCM + "' '" + "',0,'Activado')," +
                "  ('" + tramite + "','" + "Certificado_nacimiento" + "','" + cui + "','" + urlCertifNac + "' '" + "',0,'Activado')," +
                "  ('" + tramite + "','" + "Carta_Poder" + "','" + cui + "','" + urlCartaPoder + "' '" + "',0,'Activado')," +
                "  ('" + tramite + "','" + "Boleto_Ornato" + "','" + ornato + "','" + urlCopiaOrnato + "' '" + "',0,'Activado')," +
                "  ('" + tramite + "','" + "No_Boleta" + "','" + cui + "','" + noBoleta + "' '" + "',0,'Activado');";
        }
    }
}
