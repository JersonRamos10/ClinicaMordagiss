using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SistemaDeCitasMordagiss.DataAccess
{
    public class CitaRepo
    {
        private const string Cadena = @"Data Source=ClinicaMordargiss.db;Version=3;";

        /// <summary>
        /// Recupera solo las columnas que el médico necesita ver:
        /// HoraInicio, NombrePaciente, NombreServicio, EstadoCita.
        /// Hace JOIN con Paciente y Servicio para obtener los nombres.
        /// </summary>
        public List<CitaVistaMedico> TraerCitasVistaMedico(int idMedico, DateTime fecha)
        {
            var lista = new List<CitaVistaMedico>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            // Convertimos la fecha a "yyyy-MM-dd" para comparar con el TEXT FechaCita en SQLite
            string fechaStr = fecha.ToString("yyyy-MM-dd");

            const string sql = @"
               SELECT DISTINCT
                    c.HoraInicio                                   AS HoraInicio,
                    p.Nombre || ' ' || p.Apellidos                  AS NombrePaciente,
                    s.NombreServicio                                AS NombreServicio,
                    c.EstadoCita                                     AS EstadoCita
                FROM Cita c
                INNER JOIN Paciente p ON c.IdPaciente   = p.IdPaciente
                INNER JOIN Servicio s ON c.IdServicio   = s.IdServicio
                WHERE c.IdProfesionalMedico = @idMedico
                  AND c.FechaCita            = @fechaStr
                ORDER BY c.HoraInicio;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idMedico", idMedico);
            cmd.Parameters.AddWithValue("@fechaStr", fechaStr);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista.Add(new CitaVistaMedico
                {
                    HoraInicio = r["HoraInicio"].ToString()!,
                    NombrePaciente = r["NombrePaciente"].ToString()!,
                    NombreServicio = r["NombreServicio"].ToString()!,
                    EstadoCita = r["EstadoCita"].ToString()!
                });
            }

            return lista;
        }
    }
}
