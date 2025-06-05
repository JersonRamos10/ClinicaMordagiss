using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace SistemaDeCitasMordagiss.DataAccess
{
    public class UsuarioRepo
    {
        private const string Cadena = @"Data Source=ClinicaMordargiss.db;Version=3;";

        // Inserta un UsuarioSistema y retorna el IdUsuarioSistema recién generado.
        public int CrearYRetornarId(UsuarioSistema u)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            using var cmd = new SQLiteCommand(
                "INSERT INTO UsuarioSistema " +
                "(NombreCompleto, NombreUsuario, Contrasena, Rol, Activo) " +
                "VALUES (@n, @u, @c, @r, @a);",
                con);
            cmd.Parameters.AddWithValue("@n", u.NombreCompleto);
            cmd.Parameters.AddWithValue("@u", u.NombreUsuario);
            cmd.Parameters.AddWithValue("@c", u.Contrasena);
            cmd.Parameters.AddWithValue("@r", u.Rol);
            cmd.Parameters.AddWithValue("@a", u.Activo);

            cmd.ExecuteNonQuery();

            // Obtener el último Id insertado en esta conexión
            using var cmdLast = new SQLiteCommand("SELECT last_insert_rowid();", con);
            long id = (long)cmdLast.ExecuteScalar()!;
            return Convert.ToInt32(id);
        }

        public void Crear(UsuarioSistema u)
        {
            CrearYRetornarId(u);
        }

        public List<UsuarioSistema> TraerTodos()
        {
            var lista = new List<UsuarioSistema>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            // Ahora incluimos la columna Contrasena en el SELECT
            const string sql = @"
                SELECT 
                    IdUsuarioSistema,
                    NombreCompleto,
                    NombreUsuario,
                    Contrasena,
                    Rol,
                    Activo
                FROM UsuarioSistema;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista.Add(new UsuarioSistema
                {
                    IdUsuarioSistema = Convert.ToInt32(r["IdUsuarioSistema"]),
                    NombreCompleto = r["NombreCompleto"].ToString()!,
                    NombreUsuario = r["NombreUsuario"].ToString()!,
                    Contrasena = r["Contrasena"].ToString()!,   
                    Rol = r["Rol"].ToString()!,
                    Activo = r["Activo"].ToString()!
                });
            }
            return lista;
        }

        public void Actualizar(UsuarioSistema u)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            using var cmd = new SQLiteCommand(
                "UPDATE UsuarioSistema SET " +
                "NombreCompleto=@n, NombreUsuario=@u, Contrasena=@c, Rol=@r, Activo=@a " +
                "WHERE IdUsuarioSistema=@id;",
                con);
            cmd.Parameters.AddWithValue("@n", u.NombreCompleto);
            cmd.Parameters.AddWithValue("@u", u.NombreUsuario);
            cmd.Parameters.AddWithValue("@c", u.Contrasena);
            cmd.Parameters.AddWithValue("@r", u.Rol);
            cmd.Parameters.AddWithValue("@a", u.Activo);
            cmd.Parameters.AddWithValue("@id", u.IdUsuarioSistema);

            cmd.ExecuteNonQuery();
        }

        public bool Borrar(int idUsuarioSistema)
        {
            using var conexion = new SQLiteConnection(Cadena);
            conexion.Open();

            using var comando = new SQLiteCommand(
                "DELETE FROM UsuarioSistema WHERE IdUsuarioSistema = @id;",
                conexion);
            comando.Parameters.AddWithValue("@id", idUsuarioSistema);

            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas > 0;
        }

        // Recupera un UsuarioSistema que coincida con nombreUsuario + contrasenaPlain.
        public UsuarioSistema? GetByNombreUsuarioAndContrasena(string nombreUsuario, string contrasenaPlain)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            const string sql = @"
                SELECT 
                    IdUsuarioSistema,
                    NombreCompleto,
                    NombreUsuario,
                    Contrasena,
                    Rol,
                    Activo
                FROM UsuarioSistema
                WHERE LOWER(NombreUsuario) = @usuario
                  AND Contrasena            = @pass
                LIMIT 1;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@usuario", nombreUsuario.Trim().ToLower());
            cmd.Parameters.AddWithValue("@pass", contrasenaPlain);

            using var r = cmd.ExecuteReader();
            if (r.Read())
            {
                return new UsuarioSistema
                {
                    IdUsuarioSistema = Convert.ToInt32(r["IdUsuarioSistema"]),
                    NombreCompleto = r["NombreCompleto"].ToString()!,
                    NombreUsuario = r["NombreUsuario"].ToString()!,
                    Contrasena = r["Contrasena"].ToString()!,
                    Rol = r["Rol"].ToString()!,
                    Activo = r["Activo"].ToString()!
                };
            }
            return null;
        }
    }
}
