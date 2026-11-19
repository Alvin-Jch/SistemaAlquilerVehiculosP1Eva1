using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAlquilerVehiculos.Controladores;
using SistemaAlquilerVehiculos.Modelos;

namespace SistemaAlquilerVehiculos.Vistas
{
    public partial class FrmAlquileres : Form
    {
        private readonly AlquileresController _ctrl = new AlquileresController();
        private Alquiler _seleccionado;
        private bool _cargando;

        public FrmAlquileres()
        {
            InitializeComponent();
        }

        private void FrmAlquileres_Load(object sender, EventArgs e)
        {
            _cargando = true;
            try
            {
                cmb_cliente.DisplayMember = "Texto";
                cmb_cliente.ValueMember = "Id";
                cmb_cliente.DataSource = new ClientesController().Combo();
                cmb_vehiculo.DisplayMember = "Texto";
                cmb_vehiculo.ValueMember = "Id";
                cmb_vehiculo.DataSource = new VehiculosController().Combo();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            _cargando = false;
            CargarDatos();
        }

        private void CargarDatos()
        {
            _cargando = true;
            try
            {
                dgv_alquileres.DataSource = _ctrl.Seleccionar();
                dgv_alquileres.Columns["FechaInicio"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv_alquileres.Columns["FechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv_alquileres.Columns["Total"].DefaultCellStyle.Format = "N2";
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
            if (cmb_cliente.Items.Count > 0) cmb_cliente.SelectedIndex = 0;
            if (cmb_vehiculo.Items.Count > 0) cmb_vehiculo.SelectedIndex = 0;
            dtp_inicio.Value = DateTime.Today;
            dtp_fin.Value = DateTime.Today;
            dgv_alquileres.ClearSelection();
            dgv_alquileres.CurrentCell = null;
            SetModoEdicion(false);
            _cargando = false;
            ActualizarTotal();
        }
        private void SetModoEdicion(bool edicion)
        {
            cmb_cliente.Enabled = !edicion;
            cmb_vehiculo.Enabled = !edicion;
            dtp_inicio.Enabled = !edicion;
            dtp_fin.Enabled = !edicion;
            btn_guardar.Enabled = !edicion;
            btn_eliminar.Enabled = edicion;
        }

        private void Mostrar(Alquiler a)
        {
            _cargando = true;
            txt_id.Text = a.IdAlquiler.ToString();
            cmb_cliente.SelectedValue = a.IdCliente;
            cmb_vehiculo.SelectedValue = a.IdVehiculo;
            dtp_inicio.Value = a.FechaInicio;
            dtp_fin.Value = a.FechaFin;
            txt_total.Text = a.Total.ToString("N2");
            SetModoEdicion(true);
            _cargando = false;
        }

        private decimal CalcularTotal()
        {
            if (cmb_vehiculo.SelectedItem is DataRowView fila)
            {
                int dias = (dtp_fin.Value.Date - dtp_inicio.Value.Date).Days + 1;
                if (dias > 0) return dias * Convert.ToDecimal(fila["PrecioDia"]);
            }
            return 0;
        }

        private void ActualizarTotal()
        {
            if (_cargando) return;
            txt_total.Text = CalcularTotal().ToString("N2");
        }

        private Alquiler LeerFormulario()
        {
            if (cmb_cliente.SelectedValue == null)
            {
                Aviso("Seleccione un valor en 'Cliente'. Registre un cliente antes de crear un alquiler.", cmb_cliente);
                return null;
            }
            if (cmb_vehiculo.SelectedValue == null)
            {
                Aviso("Seleccione un valor en 'Vehículo'. Registre un vehículo antes de crear un alquiler.", cmb_vehiculo);
                return null;
            }
            if (dtp_fin.Value.Date < dtp_inicio.Value.Date)
            {
                Aviso("'Fecha fin' no puede ser anterior a 'Fecha inicio'.", dtp_fin);
                return null;
            }
            var a = new Alquiler
            {
                IdCliente = Convert.ToInt32(cmb_cliente.SelectedValue),
                IdVehiculo = Convert.ToInt32(cmb_vehiculo.SelectedValue),
                FechaInicio = dtp_inicio.Value.Date,
                FechaFin = dtp_fin.Value.Date,
                Total = CalcularTotal(),
            };
            if (a.Total <= 0)
            {
                Aviso("El total debe ser mayor a cero.", cmb_vehiculo);
                return null;
            }
            return a;
        }

        private void Combo_Cambio(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void dgv_alquileres_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando) return;
            if (dgv_alquileres.CurrentRow?.DataBoundItem is Alquiler a)
            {
                _seleccionado = a;
                Mostrar(a);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            var a = LeerFormulario();
            if (a == null) return;
            try
            {
                _ctrl.Insertar(a);
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
                Aviso("Seleccione un registro de la tabla para eliminarlo.", dgv_alquileres);
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
            string detalle = ex is MySqlException ? "Error de base de datos: " + ex.Message : ex.Message;
            MessageBox.Show(detalle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
