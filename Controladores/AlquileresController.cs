using MySql.Data.MySqlClient;
using SistemaAlquilerVehiculos.Datos;
using SistemaAlquilerVehiculos.Modelos;
using System.Data;

namespace SistemaAlquilerVehiculos.Controladores
{
    public class AlquileresController
    {
        public List<Alquiler> Seleccionar()
        {
            var dt = Db.Tabla(
                "SELECT a.id_alquiler, a.id_cliente, a.id_vehiculo, a.fecha_inicio, a.fecha_fin, a.total, " +
                "CONCAT(c.nombre, ' ', c.apellido) AS cliente, " +
                "CONCAT(v.placa, ' - ', v.marca, ' ', v.modelo) AS vehiculo " +
                "FROM alquileres a " +
                "INNER JOIN clientes c ON c.id_cliente = a.id_cliente " +
                "INNER JOIN vehiculos v ON v.id_vehiculo = a.id_vehiculo " +
                "ORDER BY a.id_alquiler");
            var lista = new List<Alquiler>();
            foreach (DataRow r in dt.Rows)
            {
                lista.Add(new Alquiler
                {
                    IdAlquiler = Convert.ToInt32(r["id_alquiler"]),
                    IdCliente = Convert.ToInt32(r["id_cliente"]),
                    IdVehiculo = Convert.ToInt32(r["id_vehiculo"]),
                    FechaInicio = Convert.ToDateTime(r["fecha_inicio"]),
                    FechaFin = Convert.ToDateTime(r["fecha_fin"]),
                    Total = Convert.ToDecimal(r["total"]),
                    Cliente = Convert.ToString(r["cliente"]),
                    Vehiculo = Convert.ToString(r["vehiculo"])
                });
            }
            return lista;
        }

        public bool Insertar(Alquiler a)
        {
            return Db.Ejecutar(
                "INSERT INTO alquileres (id_cliente, id_vehiculo, fecha_inicio, fecha_fin, total) VALUES (@id_cliente, @id_vehiculo, @fecha_inicio, @fecha_fin, @total)",
                Db.P("@id_cliente", a.IdCliente),
                Db.P("@id_vehiculo", a.IdVehiculo),
                Db.P("@fecha_inicio", a.FechaInicio.Date),
                Db.P("@fecha_fin", a.FechaFin.Date),
                Db.P("@total", a.Total)) > 0;
        }

        public bool Eliminar(Alquiler a)
        {
            return Db.Ejecutar(
                "DELETE FROM alquileres WHERE id_alquiler = @id_alquiler",
                Db.P("@id_alquiler", a.IdAlquiler)) > 0;
        }
    }
}
