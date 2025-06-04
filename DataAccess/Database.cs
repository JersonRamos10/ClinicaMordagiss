using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.DataAccess
{
    
    class Database
    {
        private static readonly string _connectionString =
            @"Data Source=|DataDirectory|\ClinicaMordargiss.db;Version=3;";
    
        public static SQLiteConnection GetConnection()
        {
           
            var conn = new SQLiteConnection(_connectionString);
            // abre la conexion a la base de datos
            conn.Open();
            return conn;
        }

        //para verificar que la BD responde.
        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                    using (var cmd = new SQLiteCommand("SELECT 1;", conn))
                {
                    cmd.ExecuteScalar();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }
    }
}
