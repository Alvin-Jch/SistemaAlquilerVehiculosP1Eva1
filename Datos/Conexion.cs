using MySql.Data.MySqlClient;

namespace SistemaAlquilerVehiculos.Datos
{
    public static class Conexion
    {
        public static string Cadena = "Server=localhost;Port=3306;Database=alquiler_vehiculos_db;Uid=root;Pwd=alvinadmin;";

        public static bool ProbarConexion()
        {
            try
            {
                using var cn = new MySqlConnection(Cadena);
                cn.Open();
                return true;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al conectar con la base de datos. Por favor, verifica la configuración de la conexión.", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
