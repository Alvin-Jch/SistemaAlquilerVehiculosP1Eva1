using System.Data;
using MySql.Data.MySqlClient;
using SistemaAlquilerVehiculos.Datos;
using SistemaAlquilerVehiculos.Modelos;

namespace SistemaAlquilerVehiculos.Controladores
{
    public class ClientesController
    {
        public List<Cliente> Seleccionar()
        {
            var dt = Db.Tabla("SELECT id_cliente, cedula, nombre, apellido, telefono, correo FROM clientes ORDER BY apellido, nombre");
            var lista = new List<Cliente>();
            foreach (DataRow r in dt.Rows)
            {
                lista.Add(new Cliente
                {
                    IdCliente = Convert.ToInt32(r["id_cliente"]),
                    Cedula = Convert.ToString(r["cedula"]),
                    Nombre = Convert.ToString(r["nombre"]),
                    Apellido = Convert.ToString(r["apellido"]),
                    Telefono = Convert.ToString(r["telefono"]),
                    Correo = Convert.ToString(r["correo"])
                });
            }
            return lista;
        }

        public bool Insertar(Cliente c)
        {
            return Db.Ejecutar(
                "INSERT INTO clientes (cedula, nombre, apellido, telefono, correo) VALUES (@cedula, @nombre, @apellido, @telefono, @correo)",
                Db.P("@cedula", c.Cedula),
                Db.P("@nombre", c.Nombre),
                Db.P("@apellido", c.Apellido),
                Db.P("@telefono", c.Telefono),
                Db.P("@correo", c.Correo)) > 0;
        }

        public bool Eliminar(Cliente c)
        {
            return Db.Ejecutar(
                "DELETE FROM clientes WHERE id_cliente = @id_cliente",
                Db.P("@id_cliente", c.IdCliente)) > 0;
        }
        public DataTable Combo()
        {
            return Db.Tabla("SELECT id_cliente AS Id, CONCAT(nombre, ' ', apellido, ' - ', cedula) AS Texto FROM clientes ORDER BY apellido, nombre");
        }
    }
}
