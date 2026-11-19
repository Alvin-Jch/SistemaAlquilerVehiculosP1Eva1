using System;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAlquilerVehiculos.Controladores;
using SistemaAlquilerVehiculos.Modelos;

namespace SistemaAlquilerVehiculos.Vistas
{
    public partial class FrmVehiculos : Form
    {
        private readonly VehiculosController _ctrl = new VehiculosController();
        private Vehiculo _seleccionado;
        private bool _cargando;

        public FrmVehiculos()
        {
            InitializeComponent();
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            _cargando = true;
            try
            {
                dgv_vehiculos.DataSource = _ctrl.Seleccionar();
                dgv_vehiculos.Columns["PrecioDia"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            _cargando = false;
            Nuevo();
        }

        private void Nuevo()
        {
            _cargando = true;
            _seleccionado = null;
            txt_id.Clear();
            txt_placa.Clear();
            txt_marca.Clear();
            txt_modelo.Clear();
            txt_anio.Clear();
            txt_color.Clear();
            txt_precio.Clear();
            dgv_vehiculos.ClearSelection();
            dgv_vehiculos.CurrentCell = null;
            SetModoEdicion(false);
            _cargando = false;
            txt_placa.Focus();
        }
        private void SetModoEdicion(bool edicion)
        {
            txt_placa.ReadOnly = edicion;
            txt_marca.ReadOnly = edicion;
            txt_modelo.ReadOnly = edicion;
            txt_anio.ReadOnly = edicion;
            txt_color.ReadOnly = edicion;
            txt_precio.ReadOnly = edicion;
            btn_guardar.Enabled = !edicion;
            btn_eliminar.Enabled = edicion;
        }

        private void Mostrar(Vehiculo v)
        {
            _cargando = true;
            txt_id.Text = v.IdVehiculo.ToString();
            txt_placa.Text = v.Placa ?? "";
            txt_marca.Text = v.Marca ?? "";
            txt_modelo.Text = v.Modelo ?? "";
            txt_anio.Text = v.Anio.ToString();
            txt_color.Text = v.Color ?? "";
            txt_precio.Text = v.PrecioDia.ToString("N2");
            SetModoEdicion(true);
            _cargando = false;
        }

        private Vehiculo LeerFormulario()
        {
            var v = new Vehiculo();
            v.Placa = txt_placa.Text.Trim().ToUpper();
            if (v.Placa.Length == 0)
            {
                Aviso("Ingrese un valor en 'Placa'.", txt_placa);
                return null;
            }
            v.Marca = txt_marca.Text.Trim();
            if (v.Marca.Length == 0)
            {
                Aviso("Ingrese un valor en 'Marca'.", txt_marca);
                return null;
            }
            v.Modelo = txt_modelo.Text.Trim();
            if (v.Modelo.Length == 0)
            {
                Aviso("Ingrese un valor en 'Modelo'.", txt_modelo);
                return null;
            }
            if (!int.TryParse(txt_anio.Text.Trim(), out int anio) || anio < 1950 || anio > DateTime.Today.Year + 1)
            {
                Aviso("'Año' debe ser un número entero válido.", txt_anio);
                return null;
            }
            v.Anio = anio;
            v.Color = txt_color.Text.Trim();
            if (v.Color.Length == 0)
            {
                Aviso("Ingrese un valor en 'Color'.", txt_color);
                return null;
            }
            if (!decimal.TryParse(txt_precio.Text.Trim().Replace(',', '.'), NumberStyles.Number,
                    CultureInfo.InvariantCulture, out decimal precio) || precio <= 0)
            {
                Aviso("'Precio por día' debe ser un número mayor a cero.", txt_precio);
                return null;
            }
            v.PrecioDia = precio;
            return v;
        }

        private void dgv_vehiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            if (dgv_vehiculos.CurrentRow?.DataBoundItem is Vehiculo v)
            {
                _seleccionado = v;
                Mostrar(v);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            var v = LeerFormulario();
            if (v == null) return;
            try
            {
                _ctrl.Insertar(v);
                MessageBox.Show("Registro guardado correctamente.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (_seleccionado == null)
            {
                Aviso("Seleccione un registro de la tabla para eliminarlo.", dgv_vehiculos);
                return;
            }
            var r = MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;
            try
            {
                if (_ctrl.Eliminar(_seleccionado))
                    MessageBox.Show("Registro eliminado correctamente.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Aviso(string mensaje, Control control)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }

        private static void Error(Exception ex)
        {
            string detalle = ex.Message;
            if (ex is MySqlException mx)
            {
                if (mx.Number == 1062) detalle = "Ya existe un vehículo con esa placa.";
                else if (mx.Number == 1451) detalle = "No se puede eliminar el vehículo porque tiene alquileres registrados.";
                else detalle = "Error de base de datos: " + mx.Message;
            }
            MessageBox.Show(detalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
