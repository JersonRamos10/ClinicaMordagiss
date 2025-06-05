using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SistemaDeCitasMordagiss.DataAccess
{
    public class HorarioRepo
    {
        private const string Cadena = @"Data Source=ClinicaMordargiss.db;Version=3;";

    
        public List<HorarioProfesionalMedico> TraerHorariosPorProfesional(int idProfesionalMedico)
        {
            var lista = new List<HorarioProfesionalMedico>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            const string sql = @"
                SELECT 
                    IdHorario,
                    IdProfesionalMedico,
                    DiaSemana,
                    HoraInicioTrabajo,
                    HoraFinTrabajo
                FROM HorarioProfesionalMedico
                WHERE IdProfesionalMedico = @idMedico;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idMedico", idProfesionalMedico);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista.Add(new HorarioProfesionalMedico
                {
                    IdHorario = Convert.ToInt32(r["IdHorario"]),
                    IdProfesionalMedico = Convert.ToInt32(r["IdProfesionalMedico"]),
                    DiaSemana = r["DiaSemana"].ToString()!,
                    HoraInicioTrabajo = r["HoraInicioTrabajo"].ToString()!,
                    HoraFinTrabajo = r["HoraFinTrabajo"].ToString()!
                });
            }

            return lista;
        }
        public bool InsertarHorarioDia(HorarioProfesionalMedico nuevoHorario)
        {

            var horariosExistentes = TraerHorariosPorProfesional(nuevoHorario.IdProfesionalMedico);
            if (horariosExistentes.Any(h => h.DiaSemana.Equals(nuevoHorario.DiaSemana, StringComparison.OrdinalIgnoreCase)))
            {
               
                return false; 
            }

            using var con = new SQLiteConnection(Cadena);
            con.Open();
            const string sql = @"
                INSERT INTO HorarioProfesionalMedico 
                    (IdProfesionalMedico, DiaSemana, HoraInicioTrabajo, HoraFinTrabajo)
                VALUES 
                    (@IdProfesionalMedico, @DiaSemana, @HoraInicioTrabajo, @HoraFinTrabajo);
            ";
            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@IdProfesionalMedico", nuevoHorario.IdProfesionalMedico);
            cmd.Parameters.AddWithValue("@DiaSemana", nuevoHorario.DiaSemana);
            cmd.Parameters.AddWithValue("@HoraInicioTrabajo", nuevoHorario.HoraInicioTrabajo);
            cmd.Parameters.AddWithValue("@HoraFinTrabajo", nuevoHorario.HoraFinTrabajo);

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }

        public bool ActualizarHorario(HorarioProfesionalMedico horarioModificado)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();
            const string sql = @"
                UPDATE HorarioProfesionalMedico SET
                    HoraInicioTrabajo = @HoraInicioTrabajo,
                    HoraFinTrabajo = @HoraFinTrabajo
                WHERE IdHorario = @IdHorario; 
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@HoraInicioTrabajo", horarioModificado.HoraInicioTrabajo);
            cmd.Parameters.AddWithValue("@HoraFinTrabajo", horarioModificado.HoraFinTrabajo);
            cmd.Parameters.AddWithValue("@IdHorario", horarioModificado.IdHorario);

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }

        public bool EliminarHorario(int idHorario)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();
            const string sql = @"
                DELETE FROM HorarioProfesionalMedico 
                WHERE IdHorario = @IdHorario;
            ";
            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@IdHorario", idHorario);

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
    }
}
