namespace Datos.Repositorios
{
    internal class MysqlConnection
    {
        private string? cadenaConexion;

        public MysqlConnection(string? cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        internal IEnumerable<T> QueryAsync<T>(string sql)
        {
            throw new NotImplementedException();
        }

        internal Task OpenAsync()
        {
            throw new NotImplementedException();
        }
    }
}