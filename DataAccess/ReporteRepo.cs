using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.DataAccess
{
    class ReporteRepo
    {
        private const string CadenaConexion = @"Data Source=ClinicaMordargiss.db;Version=3;";

        public List<ReporteActividadProfesional> GenerarReporte(
            DateTime fechaInicio,
            DateTime fechaFin,
            int? idProfesional)
        {
            var listaReporte = new List<ReporteActividadProfesional>();

            using var conexion = new SQLiteConnection(CadenaConexion);
            conexion.Open();

            // Normalizar fechas para comparar solo la parte DATE
            var fechaInicioSolo = fechaInicio.Date;
            var fechaFinSolo = fechaFin.Date;

            // Construimos la consulta SQL:
            // - Contamos todas las citas cuya FechaCita esté entre fechaInicio y fechaFin.
            // - Agrupamos por profesional.
            // - Obtenemos el nombre completo desde la tabla ProfesionalMedico.
            string sql = @"
                SELECT 
                    p.IdProfesionalMedico,
                    p.Nombre || ' ' || p.Apellidos AS NombreCompleto,
                    COUNT(c.IdCita) AS TotalCitas
                FROM Cita AS c
                INNER JOIN ProfesionalMedico AS p 
                    ON p.IdProfesionalMedico = c.IdProfesionalMedico
                WHERE 
                    date(c.FechaCita) >= @fechaInicio 
                    AND date(c.FechaCita) <= @fechaFin
                    AND (@idProf IS NULL OR c.IdProfesionalMedico = @idProf)
                GROUP BY 
                    p.IdProfesionalMedico, 
                    NombreCompleto
                ORDER BY 
                    NombreCompleto;
            ";
            using var comando = new SQLiteCommand(sql, conexion);
            comando.Parameters.AddWithValue("@fechaInicio", fechaInicioSolo.ToString("yyyy-MM-dd"));
            comando.Parameters.AddWithValue("@fechaFin", fechaFinSolo.ToString("yyyy-MM-dd"));
            // Si idProfesional es null, pasamos DBNull.Value para que funcione la condición
            comando.Parameters.AddWithValue("@idProf",
                idProfesional.HasValue ? (object)idProfesional.Value : DBNull.Value);

            using var lector = comando.ExecuteReader();
            while (lector.Read())
            {
                listaReporte.Add(new ReporteActividadProfesional
                {
                    IdProfesionalMedico = Convert.ToInt32(lector["IdProfesionalMedico"]),
                    NombreCompleto = lector["NombreCompleto"].ToString() ?? "",
                    TotalCitas = Convert.ToInt32(lector["TotalCitas"])
                });
            }

            return listaReporte;
        }
    }
}
