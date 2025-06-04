using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.DataAccess
{
    class UsuarioRepo
    {
        private const string Cadena = @"Data Source=ClinicaMordargiss.db;Version=3;";
        public List<UsuarioSistema> TraerTodos()
        {
            var lista = new List<UsuarioSistema>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            var cmd = new SQLiteCommand(
                "SELECT IdUsuarioSistema,NombreCompleto,NombreUsuario,Rol,Activo " +
                "FROM UsuarioSistema;", con);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista.Add(new UsuarioSistema
                {
                    IdUsuarioSistema = Convert.ToInt32(r["IdUsuarioSistema"]),
                    NombreCompleto = r["NombreCompleto"].ToString(),
                    NombreUsuario = r["NombreUsuario"].ToString(),
                    Rol = r["Rol"].ToString(),
                    Activo = r["Activo"].ToString()
                });
            }
            return lista;
        }

        public void Crear(UsuarioSistema u)
        {
            using var con = new SQLiteConnection(Cadena); con.Open();
            var cmd = new SQLiteCommand(
                "INSERT INTO UsuarioSistema " +
                "(NombreCompleto,NombreUsuario,Contrasena,Rol,Activo) " +
                "VALUES(@n,@u,@c,@r,@a);", con);
            cmd.Parameters.AddWithValue("@n", u.NombreCompleto);
            cmd.Parameters.AddWithValue("@u", u.NombreUsuario);
            cmd.Parameters.AddWithValue("@c", u.Contrasena);
            cmd.Parameters.AddWithValue("@r", u.Rol);
            cmd.Parameters.AddWithValue("@a", u.Activo);
            cmd.ExecuteNonQuery();
        }

        public void Actualizar(UsuarioSistema u)
        {
            using var con = new SQLiteConnection(Cadena); con.Open();
            var cmd = new SQLiteCommand(
                "UPDATE UsuarioSistema SET " +
                "NombreCompleto=@n, NombreUsuario=@u, Rol=@r, Activo=@a " +
                "WHERE IdUsuarioSistema=@id;", con);
            cmd.Parameters.AddWithValue("@n", u.NombreCompleto);
            cmd.Parameters.AddWithValue("@u", u.NombreUsuario);
            cmd.Parameters.AddWithValue("@r", u.Rol);
            cmd.Parameters.AddWithValue("@a", u.Activo);
            cmd.Parameters.AddWithValue("@id", u.IdUsuarioSistema);
            cmd.ExecuteNonQuery();
        }

        public bool Borrar(int idUsuarioSistema)
        {
            using var conexion = new SQLiteConnection(Cadena);
            conexion.Open();

            var comando = new SQLiteCommand(
                "DELETE FROM UsuarioSistema WHERE IdUsuarioSistema = @id;", conexion);

            comando.Parameters.AddWithValue("@id", idUsuarioSistema);

            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas > 0;    
        }



    }
}
