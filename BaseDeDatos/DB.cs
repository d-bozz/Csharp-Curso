using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    // Creo una clase para conectarse a la base de datos mediante un string de conexion
    public abstract class DB
    {
        private string connectionstring;
        protected SqlConnection connection; // Lo hago protected para que pueda usarse en la herencia

        public DB(string server, string db, string user, string password)
        {
            connectionstring = $"Data Source={server}; Initial Catalog={db};" +
                $"User={user};Password={password}";
        }

        // Creo un metodo para conectarme creando una instancia de conexion
        public void Connect()
        {
            connection = new SqlConnection(connectionstring);
            connection.Open();
        }

        // Creo un metodo para cerrar la conexion.
        public void Close()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open) { 
                connection.Close();
            }
        }
    }
}
