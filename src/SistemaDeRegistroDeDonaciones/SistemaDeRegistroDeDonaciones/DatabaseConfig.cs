using Oracle.ManagedDataAccess.Client;

namespace SistemaRegistroDonaciones
{
    public static class DatabaseConfig
    {
        public static string ConnectionString = "User Id=Ryan_ORTIZ;Password=Hades2314@;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SID=xe)))";

        public static OracleConnection GetConnection()
        {
            return new OracleConnection(ConnectionString);
        }
    }
}