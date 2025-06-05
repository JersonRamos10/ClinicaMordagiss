using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.DataAccess
{
    class UsuarioSistemaRepository
    {
        public UsuarioSistema GetByNombreUsuarioAndContrasena(string nombreUsuario, string contrasenaPlain)
        {
            const string sql = @"
                SELECT 
                    IdUsuarioSistema,
                    NombreCompleto,
                    NombreUsuario,
                    Contrasena,
                    Rol,
                    Activo
                FROM UsuarioSistema
                WHERE NombreUsuario = @user 
                  AND Contrasena    = @pass 
                  AND Activo        = 'Si';  
            ";

            using (var conn = Database.GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@user", nombreUsuario);
                cmd.Parameters.AddWithValue("@pass", contrasenaPlain);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return new UsuarioSistema
                    {
                        IdUsuarioSistema = Convert.ToInt32(reader["IdUsuarioSistema"]),
                        NombreCompleto = reader["NombreCompleto"].ToString(),
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        Contrasena = reader["Contrasena"].ToString(),
                        Rol = reader["Rol"].ToString(),
                        Activo = reader["Activo"].ToString() 
                    };
                }
            }
        }
        public List<UsuarioSistema> GetAllActiveUsers()
        {
            var lista = new List<UsuarioSistema>();
            const string sql = @"
                SELECT IdUsuarioSistema, NombreCompleto, NombreUsuario, Contrasena, Rol, Activo
                FROM UsuarioSistema
                WHERE lower(Activo) = 'si';
            ";

            using (var conn = Database.GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new UsuarioSistema
                    {
                        IdUsuarioSistema = Convert.ToInt32(reader["IdUsuarioSistema"]),
                        NombreCompleto = reader["NombreCompleto"]?.ToString(),
                        NombreUsuario = reader["NombreUsuario"]?.ToString(),
                        Contrasena = reader["Contrasena"]?.ToString(),
                        Rol = reader["Rol"]?.ToString(),
                        Activo = reader["Activo"]?.ToString()
                    });
                }
            }

            return lista;
        }

      
        public bool Delete(int idUsuario)
        {
            const string sql = @"
                UPDATE UsuarioSistema
                   SET Activo = 'no'
                 WHERE IdUsuarioSistema = @id;
            ";

            using (var conn = Database.GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idUsuario);
                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
        }
    }
} 

