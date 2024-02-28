
using System.Data.SqlClient;


namespace APIBancoDeDados.Database
{
    public class ConexaoSqlServer
    {
        public static SqlConnection Conectar()
        {
            /*string connectionString = "Data Source=localhost,1433;User ID=sa;Password=senha@1234xxxy;Initial Catalog=DevPraticaPDVAtualizado;";*/
            string connectionString = "Data Source=bd.thor.hostazul.com.br,3533;User ID=139_renan;Password=swvaedijkmgpzuhc7xqr;Initial Catalog=139_renan;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
