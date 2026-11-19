using System.Data;
using MySql.Data.MySqlClient;
using SistemaAlquilerVehiculos.Datos;
using SistemaAlquilerVehiculos.Modelos;

namespace SistemaAlquilerVehiculos.Controladores
{
    public class VehiculosController
    {
        public List<Vehiculo> Seleccionar()
        {
            var dt = Db.Tabla("SELECT id_vehiculo, placa, marca, modelo, anio, color, precio_dia FROM vehiculos ORDER BY marca, modelo");
            var lista = new List<Vehiculo>();
            foreach (DataRow r in dt.Rows)
            {
                lista.Add(new Vehiculo
                {
                    IdVehiculo = Convert.ToInt32(r["id_vehiculo"]),
                    Placa = Convert.ToString(r["placa"]),
                    Marca = Convert.ToString(r["marca"]),
                    Modelo = Convert.ToString(r["modelo"]),
                    Anio = Convert.ToInt32(r["anio"]),
                    Color = Convert.ToString(r["color"]),
                    PrecioDia = Convert.ToDecimal(r["precio_dia"])
                });
            }
            return lista;
        }

        public bool Insertar(Vehiculo v)
        {
            return Db.Ejecutar(
                "INSERT INTO vehiculos (placa, marca, modelo, anio, color, precio_dia) VALUES (@placa, @marca, @modelo, @anio, @color, @precio_dia)",
                Db.P("@placa", v.Placa),
                Db.P("@marca", v.Marca),
                Db.P("@modelo", v.Modelo),
                Db.P("@anio", v.Anio),
                Db.P("@color", v.Color),
                Db.P("@precio_dia", v.PrecioDia)) > 0;
        }

        public bool Eliminar(Vehiculo v)
        {
            return Db.Ejecutar(
                "DELETE FROM vehiculos WHERE id_vehiculo = @id_vehiculo",
                Db.P("@id_vehiculo", v.IdVehiculo)) > 0;
        }
        public DataTable Combo()
        {
            return Db.Tabla("SELECT id_vehiculo AS Id, CONCAT(placa, ' - ', marca, ' ', modelo) AS Texto, precio_dia AS PrecioDia FROM vehiculos ORDER BY marca, modelo");
        }
    }
}
