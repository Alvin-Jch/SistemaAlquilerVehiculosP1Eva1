using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaAlquilerVehiculos.Datos
{
    public static class Db
    {
        public static MySqlConnection Conectar()
        {
            var cn = new MySqlConnection(Conexion.Cadena);
            cn.Open();
            return cn;
        }

        public static DataTable Tabla(string sql)
        {
            using var cn = Conectar();
            using var da = new MySqlDataAdapter(sql, cn);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int Ejecutar(string sql, params MySqlParameter[] parametros)
        {
            using var cn = Conectar();
            using var cmd = new MySqlCommand(sql, cn);
            cmd.Parameters.AddRange(parametros);
            return cmd.ExecuteNonQuery();
        }

        public static MySqlParameter P(string nombre, object valor)
        {
            return new MySqlParameter(nombre, valor ?? DBNull.Value);
        }
    }
}
