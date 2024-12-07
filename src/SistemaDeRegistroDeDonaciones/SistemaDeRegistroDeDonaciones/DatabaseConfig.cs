using Oracle.ManagedDataAccess.Client;

namespace SistemaRegistroDonaciones
{
    public static class DatabaseConfig
    {
        // Cadena de conexión a la base de datos Oracle
        public static string ConnectionString = "User Id=Ryan_ORTIZ;Password=Hades2314@;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SID=xe)))";

        // Crear el objeto de conexión
        public static OracleConnection GetConnection()
        {
            return new OracleConnection(ConnectionString);
        }
    }
}