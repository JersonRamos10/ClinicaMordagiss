using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Text;

namespace SistemaDeCitasMordagiss.DataAccess
{
    public class CitaRepo
    {
        private const string Cadena = @"Data Source=ClinicaMordargiss.db;Version=3;";

       
        public List<CitaVistaMedico> TraerCitasVistaMedico(int idMedico, DateTime fecha)
        {
            var lista = new List<CitaVistaMedico>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            string fechaStr = fecha.ToString("yyyy-MM-dd");

            const string sql = @"
                SELECT DISTINCT
                    c.HoraInicio                                   AS HoraInicio,
                    p.Nombre || ' ' || p.Apellidos                  AS NombrePaciente,
                    s.NombreServicio                                AS NombreServicio,
                    c.EstadoCita                                    AS EstadoCita
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

        public List<CitaHistorialVista> TraerCitasCompletasPorPaciente(int idPaciente)
        {
            var lista = new List<CitaHistorialVista>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            const string sql = @"
            SELECT
                c.FechaCita,
                c.HoraInicio,
                pm.Nombre || ' ' || pm.Apellidos AS NombreProfesional,
                s.NombreServicio,
                c.EstadoCita
            FROM Cita c
            LEFT JOIN ProfesionalMedico pm ON c.IdProfesionalMedico = pm.IdProfesionalMedico
            LEFT JOIN Servicio s ON c.IdServicio = s.IdServicio
            WHERE c.IdPaciente = @idPaciente
            ORDER BY c.FechaCita DESC, c.HoraInicio DESC; 
        ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                string fechaCitaStr = r["FechaCita"].ToString()!; // Fecha desde DB es yyyy-MM-dd
                string fechaFormateada = "";
                if (DateTime.TryParseExact(fechaCitaStr, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaCitaDt))
                {
                    fechaFormateada = fechaCitaDt.ToString("dd/MM/yyyy"); // Formato para mostrar
                }
                else
                {
                    fechaFormateada = fechaCitaStr;
                }

                lista.Add(new CitaHistorialVista
                {
                    FechaCita = fechaFormateada,
                    HoraInicio = r["HoraInicio"].ToString()!,
                    NombreProfesional = r["NombreProfesional"]?.ToString() ?? "N/A",
                    NombreServicio = r["NombreServicio"]?.ToString() ?? "N/A",
                    EstadoCita = r["EstadoCita"].ToString()!
                });
            }
            return lista;
        }
        public List<CitaVistaGeneral> TraerCitasVistaGeneral(DateTime fecha)
        {
            var lista = new List<CitaVistaGeneral>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            string fechaStr = fecha.ToString("yyyy-MM-dd");

            const string sql = @"
                SELECT DISTINCT
                    c.HoraInicio                                   AS HoraInicio,
                    p.Nombre || ' ' || p.Apellidos                  AS NombrePaciente,
                    m.Nombre || ' ' || m.Apellidos                  AS NombreProfesional,
                    s.NombreServicio                                AS NombreServicio,
                    c.EstadoCita                                    AS EstadoCita
                FROM Cita c
                INNER JOIN Paciente p        ON c.IdPaciente          = p.IdPaciente
                INNER JOIN ProfesionalMedico m ON c.IdProfesionalMedico = m.IdProfesionalMedico
                INNER JOIN Servicio s        ON c.IdServicio          = s.IdServicio
                WHERE c.FechaCita            = @fechaStr
                ORDER BY c.HoraInicio;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@fechaStr", fechaStr);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista.Add(new CitaVistaGeneral
                {
                    HoraInicio = r["HoraInicio"].ToString()!,
                    NombrePaciente = r["NombrePaciente"].ToString()!,
                    NombreProfesional = r["NombreProfesional"].ToString()!,
                    NombreServicio = r["NombreServicio"].ToString()!,
                    EstadoCita = r["EstadoCita"].ToString()!
                });
            }

            return lista;
        }

       
        public int ContarCitasPorConfirmar(DateTime fecha)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            string fechaStr = fecha.ToString("yyyy-MM-dd");

            const string sql = @"
                SELECT COUNT(*) 
                FROM Cita 
                WHERE FechaCita = @fechaStr 
                  AND EstadoCita = 'Programada';
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@fechaStr", fechaStr);

            return Convert.ToInt32(cmd.ExecuteScalar()!);
        }

       
        public int ContarCitasSinAsistirHoy()
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            string hoyStr = DateTime.Today.ToString("yyyy-MM-dd");
            string horaAhora = DateTime.Now.ToString("HH:mm");

            const string sql = @"
                SELECT COUNT(*)
                FROM Cita
                WHERE FechaCita = @hoyStr
                  AND EstadoCita = 'Programada'
                  AND HoraInicio < @horaAhora;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@hoyStr", hoyStr);
            cmd.Parameters.AddWithValue("@horaAhora", horaAhora);

            return Convert.ToInt32(cmd.ExecuteScalar()!);
        }

        public List<Cita> TraerCitasPorProfesionalYFecha(int idProfesionalMedico, DateTime fecha)
        {
            var lista = new List<Cita>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            string fechaStr = fecha.ToString("yyyy-MM-dd");
            const string sql = @"
                SELECT 
                    IdCita,
                    IdPaciente,
                    IdServicio,
                    IdProfesionalMedico,
                    FechaCita,
                    HoraInicio,
                    EstadoCita,
                    IdUsuarioRegistra,
                    FechaRegistroCita
                FROM Cita
                WHERE IdProfesionalMedico = @idMedico
                  AND FechaCita            = @fechaStr;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@idMedico", idProfesionalMedico); 
            cmd.Parameters.AddWithValue("@fechaStr", fechaStr);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista.Add(new Cita
                {
                    IdCita = Convert.ToInt32(r["IdCita"]),
                    IdPaciente = Convert.ToInt32(r["IdPaciente"]),
                    IdServicio = Convert.ToInt32(r["IdServicio"]),
                    IdProfesionalMedico = Convert.ToInt32(r["IdProfesionalMedico"]),
                    FechaCita = r["FechaCita"].ToString()!,
                    HoraInicio = r["HoraInicio"].ToString()!,
                    EstadoCita = r["EstadoCita"].ToString()!,
                    IdUsuarioRegistra = r["IdUsuarioRegistra"] is DBNull ? (int?)null : Convert.ToInt32(r["IdUsuarioRegistra"]),
                    FechaRegistroCita = Convert.ToDateTime(r["FechaRegistroCita"])
                });
            }
            return lista;
        }

        public bool TurnoDisponible(int idProfesionalMedico, DateTime fecha, string horaInicio)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            string fechaStr = fecha.ToString("yyyy-MM-dd");
            const string sql = @"
                SELECT COUNT(*) 
                FROM Cita
                WHERE IdProfesionalMedico = @idMedico
                  AND FechaCita            = @fechaStr
                  AND HoraInicio           = @horaInicio;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idMedico", idProfesionalMedico);
            cmd.Parameters.AddWithValue("@fechaStr", fechaStr);
            cmd.Parameters.AddWithValue("@horaInicio", horaInicio);

            int count = Convert.ToInt32(cmd.ExecuteScalar()!);
            return count == 0;
        }

       //insentar nueva cita a la base de datos
        public void CrearCita(Cita nuevaCita)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            const string sql = @"
                INSERT INTO Cita
                  (IdPaciente, IdServicio, IdProfesionalMedico, FechaCita, HoraInicio, HoraFin, EstadoCita, IdUsuarioRegistra, FechaRegistroCita)
                VALUES
                  (@idPaciente, @idServicio, @idProfesionalMedico, @fechaCita, @horaInicio,@horaFin, @estadoCita, @idUsuarioRegistra, @fechaRegistroCita);
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idPaciente", nuevaCita.IdPaciente);
            cmd.Parameters.AddWithValue("@idServicio", nuevaCita.IdServicio);
            cmd.Parameters.AddWithValue("@idProfesionalMedico", nuevaCita.IdProfesionalMedico);
            cmd.Parameters.AddWithValue("@fechaCita", nuevaCita.FechaCita);
            cmd.Parameters.AddWithValue("@horaInicio", nuevaCita.HoraInicio);
            cmd.Parameters.AddWithValue("@horaFin", nuevaCita.HoraFin);
            cmd.Parameters.AddWithValue("@estadoCita", nuevaCita.EstadoCita);
            cmd.Parameters.AddWithValue("@idUsuarioRegistra",
                nuevaCita.IdUsuarioRegistra.HasValue
                    ? (object)nuevaCita.IdUsuarioRegistra.Value
                    : DBNull.Value);
            cmd.Parameters.AddWithValue("@fechaRegistroCita", nuevaCita.FechaRegistroCita);

            cmd.ExecuteNonQuery();
        }

        public string? ObtenerUltimaFechaVisitaPorPaciente(int idPaciente)
        {
            string? ultimaVisita = null;
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            
            const string sql = @"
                SELECT MAX(FechaCita) 
                FROM Cita
                WHERE IdPaciente = @idPaciente
                  AND EstadoCita IN ('Realizada', 'Confirmada') 
                  AND FechaCita <= date('now', 'localtime'); 
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idPaciente", idPaciente);

            var result = cmd.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                ultimaVisita = result.ToString();
            }

            return ultimaVisita;
        }

        public List<Cita> TraerCitasCompletasPorProfesionalYFecha(int idProfesionalMedico, DateTime fecha)
        {
            var lista = new List<Cita>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            string fechaStr = fecha.ToString("yyyy-MM-dd"); // Formato de la BD
            const string sql = @"
                SELECT 
                    IdCita, IdPaciente, IdServicio, IdProfesionalMedico, FechaCita, 
                    HoraInicio, HoraFin, EstadoCita, IdUsuarioRegistra, FechaRegistroCita
                FROM Cita
                WHERE IdProfesionalMedico = @idProfesionalMedico
                  AND FechaCita = @fechaStr;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idProfesionalMedico", idProfesionalMedico);
            cmd.Parameters.AddWithValue("@fechaStr", fechaStr);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                lista.Add(new Cita
                {
                    IdCita = Convert.ToInt32(r["IdCita"]),
                    IdPaciente = Convert.ToInt32(r["IdPaciente"]),
                    IdServicio = Convert.ToInt32(r["IdServicio"]),
                    IdProfesionalMedico = Convert.ToInt32(r["IdProfesionalMedico"]),
                    FechaCita = r["FechaCita"].ToString()!, // yyyy-MM-dd
                    HoraInicio = r["HoraInicio"].ToString()!, // HH:mm
                    HoraFin = r["HoraFin"].ToString()!, // HH:mm
                    EstadoCita = r["EstadoCita"].ToString()!,
                    IdUsuarioRegistra = r["IdUsuarioRegistra"] is DBNull ? (int?)null : Convert.ToInt32(r["IdUsuarioRegistra"]),
                    FechaRegistroCita = DateTime.Parse(r["FechaRegistroCita"].ToString()!) // Asumiendo que es un formato parseable
                });
            }
            return lista;
        }

        public List<CitaGestionVista> TraerCitasParaGestion(DateTime? fechaDesde, DateTime? fechaHasta, string? estadoFiltro = null, int? idProfesionalFiltro = null)
        {
            var lista = new List<CitaGestionVista>();
            using var con = new SQLiteConnection(Cadena);
            con.Open();

            var sqlBuilder = new StringBuilder(@"
                SELECT
                    c.IdCita,
                    c.FechaCita AS FechaCitaDb, 
                    c.HoraInicio,
                    c.HoraFin,
                    p.Nombre || ' ' || p.Apellidos AS NombrePaciente,
                    pm.Nombre || ' ' || pm.Apellidos AS NombreProfesional,
                    s.NombreServicio,
                    c.EstadoCita,
                    c.IdPaciente,
                    c.IdProfesionalMedico,
                    c.IdServicio
                FROM Cita c
                INNER JOIN Paciente p ON c.IdPaciente = p.IdPaciente
                INNER JOIN ProfesionalMedico pm ON c.IdProfesionalMedico = pm.IdProfesionalMedico
                INNER JOIN Servicio s ON c.IdServicio = s.IdServicio
                WHERE 1=1 "); // Clausula base para anadir condiciones

            if (fechaDesde.HasValue)
            {
                sqlBuilder.Append(" AND date(c.FechaCita) >= date(@fechaDesde) ");
            }
            if (fechaHasta.HasValue)
            {
                sqlBuilder.Append(" AND date(c.FechaCita) <= date(@fechaHasta) ");
            }
            if (!string.IsNullOrEmpty(estadoFiltro) && estadoFiltro != "Todos") 
            {
                sqlBuilder.Append(" AND c.EstadoCita = @estadoCita ");
            }
            if (idProfesionalFiltro.HasValue) 
            {
                sqlBuilder.Append(" AND c.IdProfesionalMedico = @idProfesionalFiltro ");
            }
            sqlBuilder.Append(" ORDER BY c.FechaCita DESC, c.HoraInicio ASC;");

            using var cmd = new SQLiteCommand(sqlBuilder.ToString(), con);

            if (fechaDesde.HasValue)
            {
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Value.ToString("yyyy-MM-dd"));
            }
            if (fechaHasta.HasValue)
            {
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Value.ToString("yyyy-MM-dd"));
            }
            if (!string.IsNullOrEmpty(estadoFiltro) && estadoFiltro != "Todos")
            {
                cmd.Parameters.AddWithValue("@estadoCita", estadoFiltro);
            }
            if (idProfesionalFiltro.HasValue)
            {
                cmd.Parameters.AddWithValue("@idProfesionalFiltro", idProfesionalFiltro.Value);
            }

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                string fechaCitaDb = r["FechaCitaDb"].ToString()!;
                string fechaFormateada = "";
                if (DateTime.TryParseExact(fechaCitaDb, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
                {
                    fechaFormateada = dt.ToString("dd/MM/yyyy");
                }
                else
                {
                    fechaFormateada = fechaCitaDb;
                }

                lista.Add(new CitaGestionVista
                {
                    IdCita = Convert.ToInt32(r["IdCita"]),
                    FechaCita = fechaFormateada,
                    HoraInicio = r["HoraInicio"].ToString()!,
                    HoraFin = r["HoraFin"].ToString()!,
                    NombrePaciente = r["NombrePaciente"].ToString()!,
                    NombreProfesional = r["NombreProfesional"].ToString()!,
                    NombreServicio = r["NombreServicio"].ToString()!,
                    EstadoCita = r["EstadoCita"].ToString()!,
                    IdPaciente = Convert.ToInt32(r["IdPaciente"]),
                    IdProfesionalMedico = Convert.ToInt32(r["IdProfesionalMedico"]),
                    IdServicio = Convert.ToInt32(r["IdServicio"])
                });
            }
            return lista;
        }

     
        public bool ReprogramarCita(int idCita, string nuevaFecha, string nuevaHoraInicio, string nuevaHoraFin, string nuevoEstado, int? idUsuarioActualiza)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();
          
            const string sql = @"
                UPDATE Cita SET
                    FechaCita = @nuevaFecha,
                    HoraInicio = @nuevaHoraInicio,
                    HoraFin = @nuevaHoraFin,
                    EstadoCita = @nuevoEstado 
                    // , IdUsuarioUltimaModificacion = @idUsuarioActualiza -- si tuvieras esta columna
                    // , FechaUltimaModificacion = datetime('now', 'localtime') -- si tuvieras esta columna
                WHERE IdCita = @idCita;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@idCita", idCita);
            cmd.Parameters.AddWithValue("@nuevaFecha", nuevaFecha); 
            cmd.Parameters.AddWithValue("@nuevaHoraInicio", nuevaHoraInicio); 
            cmd.Parameters.AddWithValue("@nuevaHoraFin", nuevaHoraFin); 
            cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
         


            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
        public bool ActualizarEstadoCita(int idCita, string nuevoEstado, int? idUsuarioActualiza)
        {
            using var con = new SQLiteConnection(Cadena);
            con.Open();
            const string sql = @"
                UPDATE Cita SET
                    EstadoCita = @nuevoEstado
                WHERE IdCita = @idCita;
            ";

            using var cmd = new SQLiteCommand(sql, con);
            cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
            cmd.Parameters.AddWithValue("@idCita", idCita);
            // Podrias anadir logica para IdUsuarioActualiza si lo necesitas

            int filasAfectadas = cmd.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
    }
}

