using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.DataAccess
{
    class MedicoRepo
    {
        private const string Cadena = @"Data Source=ClinicaMordargiss.db;Version=3;";

        
        public List<ProfesionalMedico> TraerTodos()
        {
            var lista = new List<ProfesionalMedico>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            var sql = "SELECT IdProfesionalMedico,Nombre,Apellidos,Especialidad," +
                      "TelefonoContacto,CorreoElectronico,Activo,IdUsuarioSistema " +
                      "FROM ProfesionalMedico;";
            using var cmd = new SQLiteCommand(sql, con);
            using var r = cmd.ExecuteReader();

            while (r.Read())
            {
                lista.Add(new ProfesionalMedico
                {
                    IdProfesionalMedico = Convert.ToInt32(r["IdProfesionalMedico"]),
                    Nombre = r["Nombre"].ToString()!,
                    Apellidos = r["Apellidos"].ToString()!,
                    Especialidad = r["Especialidad"].ToString()!,
                    TelefonoContacto = r["TelefonoContacto"].ToString()!,
                    CorreoElectronico = r["CorreoElectronico"].ToString()!,
                    Activo = r["Activo"].ToString()!,
                    IdUsuarioSistema = r["IdUsuarioSistema"] is DBNull
                                          ? null
                                          : Convert.ToInt32(r["IdUsuarioSistema"])
                });
            }
            return lista;
        }

        
        public void Crear(ProfesionalMedico m)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            var sql = "INSERT INTO ProfesionalMedico " +
                      "(Nombre,Apellidos,Especialidad,TelefonoContacto,CorreoElectronico,Activo,IdUsuarioSistema) " +
                      "VALUES(@n,@a,@e,@t,@c,@ac,@idUsu);";

            using var cmd = new SQLiteCommand(sql, con);

            cmd.Parameters.AddWithValue("@n", m.Nombre);
            cmd.Parameters.AddWithValue("@a", m.Apellidos);
            cmd.Parameters.AddWithValue("@e", m.Especialidad);
            cmd.Parameters.AddWithValue("@t", m.TelefonoContacto);
            cmd.Parameters.AddWithValue("@c", m.CorreoElectronico);
            cmd.Parameters.AddWithValue("@ac", m.Activo);
            cmd.Parameters.AddWithValue("@idUsu", m.IdUsuarioSistema);

            cmd.ExecuteNonQuery();
        }

       
        public void Actualizar(ProfesionalMedico m)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            var sql = "UPDATE ProfesionalMedico SET " +
                      "Nombre=@n, Apellidos=@a, Especialidad=@e, " +
                      "TelefonoContacto=@t, CorreoElectronico=@c, Activo=@ac, " +
                      "IdUsuarioSistema=@idUsu " +
                      "WHERE IdProfesionalMedico=@id;";

            using var cmd = new SQLiteCommand(sql, con);

            cmd.Parameters.AddWithValue("@n", m.Nombre);
            cmd.Parameters.AddWithValue("@a", m.Apellidos);
            cmd.Parameters.AddWithValue("@e", m.Especialidad);
            cmd.Parameters.AddWithValue("@t", m.TelefonoContacto);
            cmd.Parameters.AddWithValue("@c", m.CorreoElectronico);
            cmd.Parameters.AddWithValue("@ac", m.Activo);
            cmd.Parameters.AddWithValue("@idUsu", m.IdUsuarioSistema);
            cmd.Parameters.AddWithValue("@id", m.IdProfesionalMedico);

            cmd.ExecuteNonQuery();
        }

        public bool Borrar(int idProfesionalMedico)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            var cmd = new SQLiteCommand(
                "DELETE FROM ProfesionalMedico WHERE IdProfesionalMedico=@id;", con);

            cmd.Parameters.AddWithValue("@id", idProfesionalMedico);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}

