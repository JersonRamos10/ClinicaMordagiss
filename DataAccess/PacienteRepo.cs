using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeCitasMordagiss.Models;

namespace SistemaDeCitasMordagiss.DataAccess
{
    public class PacienteRepo
    {
        private const string Cadena = @"Data Source=ClinicaMordargiss.db;Version=3;";

        public List<Paciente> BuscarPacientes(string filtro)
        {
            var lista = new List<Paciente>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            const string sql = @"
                SELECT 
                    IdPaciente, 
                    Nombre, 
                    Apellidos, 
                    Genero, 
                    Telefono, 
                    NumeroIdentidad,
                    FechaNacimiento,
                    Direccion,
                    CorreoElectronico
                FROM Paciente
                WHERE 
                    LOWER(Nombre)           LIKE @filtro
                    OR LOWER(Apellidos)     LIKE @filtro
                    OR NumeroIdentidad      LIKE @filtro
                ORDER BY Apellidos, Nombre;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@filtro", "%" + filtro.Trim().ToLower() + "%");

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista.Add(new Paciente
                {
                    IdPaciente = Convert.ToInt32(r["IdPaciente"]),
                    Nombre = r["Nombre"].ToString()!,
                    Apellidos = r["Apellidos"].ToString()!,
                    Genero = r["Genero"].ToString()!,
                    Telefono = r["Telefono"].ToString()!,
                    NumeroIdentidad = r["NumeroIdentidad"].ToString()!,
                FechaNacimiento = DateTime.Parse(r["FechaNacimiento"].ToString()!),
                    Direccion = r["Direccion"].ToString()!,
                    CorreoElectronico = r["CorreoElectronico"].ToString()!
                });
            }

            return lista;
        }
    
    public void Crear(Paciente p)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            const string sql = @"
                INSERT INTO Paciente
                (Nombre, Apellidos, Genero, Telefono, NumeroIdentidad,
                 FechaNacimiento, Direccion, CorreoElectronico)
                VALUES
                (@nombre, @apellidos, @genero, @telefono, @dui,
                 @fechaNac, @direccion, @correo);
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@apellidos", p.Apellidos);
            cmd.Parameters.AddWithValue("@genero", p.Genero);
            cmd.Parameters.AddWithValue("@telefono", p.Telefono);
            cmd.Parameters.AddWithValue("@dui", p.NumeroIdentidad);
            cmd.Parameters.AddWithValue("@fechaNac", p.FechaNacimiento.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@direccion", p.Direccion);
            cmd.Parameters.AddWithValue("@correo", p.CorreoElectronico);

            cmd.ExecuteNonQuery();
        }

        public Paciente? ObtenerPorId(int idPaciente)
        {
            Paciente? paciente = null;
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            const string sql = @"
                SELECT 
                    IdPaciente, 
                    Nombre, 
                    Apellidos, 
                    Genero, 
                    Telefono, 
                    NumeroIdentidad,
                    FechaNacimiento,
                    Direccion,
                    CorreoElectronico
                FROM Paciente
                WHERE IdPaciente = @idPaciente;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

            using var r = cmd.ExecuteReader();
            if (r.Read())
            {
                paciente = new Paciente
                {
                    IdPaciente = Convert.ToInt32(r["IdPaciente"]),
                    Nombre = r["Nombre"].ToString()!,
                    Apellidos = r["Apellidos"].ToString()!,
                    Genero = r["Genero"].ToString()!,
                    Telefono = r["Telefono"].ToString()!,
                    NumeroIdentidad = r["NumeroIdentidad"].ToString()!,
                    FechaNacimiento = Convert.ToDateTime(r["FechaNacimiento"]),
                    Direccion = r["Direccion"].ToString()!,
                    CorreoElectronico = r["CorreoElectronico"].ToString()!
                };
            }
            return paciente;
        }

        public bool Actualizar(Paciente paciente)
        {
            int filasAfectadas = 0;
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            const string sql = @"
                UPDATE Paciente SET
                    Nombre = @nombre,
                    Apellidos = @apellidos,
                    Genero = @genero,
                    Telefono = @telefono,
                    NumeroIdentidad = @numeroIdentidad,
                    FechaNacimiento = @fechaNacimiento,
                    Direccion = @direccion,
                    CorreoElectronico = @correoElectronico
                WHERE IdPaciente = @idPaciente;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@nombre", paciente.Nombre);
            cmd.Parameters.AddWithValue("@apellidos", paciente.Apellidos);
            cmd.Parameters.AddWithValue("@genero", paciente.Genero);
            cmd.Parameters.AddWithValue("@telefono", paciente.Telefono);
            cmd.Parameters.AddWithValue("@numeroIdentidad", paciente.NumeroIdentidad);
            cmd.Parameters.AddWithValue("@fechaNacimiento", paciente.FechaNacimiento.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@direccion", paciente.Direccion);
            cmd.Parameters.AddWithValue("@correoElectronico", paciente.CorreoElectronico);
            cmd.Parameters.AddWithValue("@idPaciente", paciente.IdPaciente);

            filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
    }


}

