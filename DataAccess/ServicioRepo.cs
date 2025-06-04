using SistemaDeCitasMordagiss.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCitasMordagiss.DataAccess
{
    public class ServicioRepo
    {

        private const string CadenaConexion = @"Data Source=ClinicaMordargiss.db;Version=3;";

        // Listar todos los servicios
        public List<Servicio> TraerTodos()
        {
            var listaDeServicios = new List<Servicio>();
            using var conexion = new SQLiteConnection(CadenaConexion);
            conexion.Open();

            string sql = @"
                SELECT 
                    IdServicio,
                    NombreServicio,
                    Descripcion,
                    Costo,
                    DuracionEstimadaMin,
                    Activo
                FROM Servicio;
            ";
            using var comando = new SQLiteCommand(sql, conexion);
            using var lector = comando.ExecuteReader();

            while (lector.Read())
            {
                listaDeServicios.Add(new Servicio
                {
                    IdServicio = Convert.ToInt32(lector["IdServicio"]),
                    NombreServicio = lector["NombreServicio"].ToString()!,
                    Descripcion = lector["Descripcion"].ToString()!,
                    Costo = Convert.ToDecimal(lector["Costo"]),
                    DuracionEstimadaMin = Convert.ToInt32(lector["DuracionEstimadaMin"]),
                    Activo = lector["Activo"].ToString()!
                });
            }

            return listaDeServicios;
        }

        // Crear un nuevo servicio
        public void Crear(Servicio servicioNuevo)
        {
            using var conexion = new SQLiteConnection(CadenaConexion);
            conexion.Open();

            string sql = @"
                INSERT INTO Servicio 
                    (NombreServicio, Descripcion, Costo, DuracionEstimadaMin, Activo)
                VALUES 
                    (@nombre, @descripcion, @costo, @duracion, @activo);
            ";
            using var comando = new SQLiteCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", servicioNuevo.NombreServicio);
            comando.Parameters.AddWithValue("@descripcion", servicioNuevo.Descripcion);
            comando.Parameters.AddWithValue("@costo", servicioNuevo.Costo);
            comando.Parameters.AddWithValue("@duracion", servicioNuevo.DuracionEstimadaMin);
            comando.Parameters.AddWithValue("@activo", servicioNuevo.Activo);
            comando.ExecuteNonQuery();
        }

        // Actualizar un servicio existente
        public void Actualizar(Servicio servicioEditado)
        {
            using var conexion = new SQLiteConnection(CadenaConexion);
            conexion.Open();

            string sql = @"
                UPDATE Servicio
                SET 
                    NombreServicio      = @nombre,
                    Descripcion         = @descripcion,
                    Costo               = @costo,
                    DuracionEstimadaMin = @duracion,
                    Activo              = @activo
                WHERE 
                    IdServicio = @id;
            ";
            using var comando = new SQLiteCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", servicioEditado.NombreServicio);
            comando.Parameters.AddWithValue("@descripcion", servicioEditado.Descripcion);
            comando.Parameters.AddWithValue("@costo", servicioEditado.Costo);
            comando.Parameters.AddWithValue("@duracion", servicioEditado.DuracionEstimadaMin);
            comando.Parameters.AddWithValue("@activo", servicioEditado.Activo);
            comando.Parameters.AddWithValue("@id", servicioEditado.IdServicio);
            comando.ExecuteNonQuery();
        }

        // Borrar un servicio (borrado físico)
        public bool Borrar(int idServicio)
        {
            using var conexion = new SQLiteConnection(CadenaConexion);
            conexion.Open();

            string sql = "DELETE FROM Servicio WHERE IdServicio = @id;";
            using var comando = new SQLiteCommand(sql, conexion);
            comando.Parameters.AddWithValue("@id", idServicio);

            int filasAfectadas = comando.ExecuteNonQuery();
            return filasAfectadas > 0;
        }
    }

}

