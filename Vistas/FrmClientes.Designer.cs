namespace SistemaAlquilerVehiculos.Vistas
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lb_id = new Label();
            lb_cedula = new Label();
            lb_nombre = new Label();
            lb_apellido = new Label();
            lb_telefono = new Label();
            lb_correo = new Label();
            txt_id = new TextBox();
            txt_cedula = new TextBox();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            txt_telefono = new TextBox();
            txt_correo = new TextBox();
            btn_nuevo = new Button();
            btn_guardar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            dgv_clientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            SuspendLayout();
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.ForeColor = Color.FromArgb(63, 58, 58);
            lb_id.Location = new Point(28, 20);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(27, 20);
            lb_id.TabIndex = 0;
            lb_id.Text = "ID:";
            // 
            // lb_cedula
            // 
            lb_cedula.AutoSize = true;
            lb_cedula.ForeColor = Color.FromArgb(63, 58, 58);
            lb_cedula.Location = new Point(28, 64);
            lb_cedula.Name = "lb_cedula";
            lb_cedula.Size = new Size(58, 20);
            lb_cedula.TabIndex = 1;
            lb_cedula.Text = "Cédula:";
            // 
            // lb_nombre
            // 
            lb_nombre.AutoSize = true;
            lb_nombre.ForeColor = Color.FromArgb(63, 58, 58);
            lb_nombre.Location = new Point(28, 108);
            lb_nombre.Name = "lb_nombre";
            lb_nombre.Size = new Size(67, 20);
            lb_nombre.TabIndex = 2;
            lb_nombre.Text = "Nombre:";
            // 
            // lb_apellido
            // 
            lb_apellido.AutoSize = true;
            lb_apellido.ForeColor = Color.FromArgb(63, 58, 58);
            lb_apellido.Location = new Point(402, 20);
            lb_apellido.Name = "lb_apellido";
            lb_apellido.Size = new Size(69, 20);
            lb_apellido.TabIndex = 3;
            lb_apellido.Text = "Apellido:";
            // 
            // lb_telefono
            // 
            lb_telefono.AutoSize = true;
            lb_telefono.ForeColor = Color.FromArgb(63, 58, 58);
            lb_telefono.Location = new Point(402, 64);
            lb_telefono.Name = "lb_telefono";
            lb_telefono.Size = new Size(70, 20);
            lb_telefono.TabIndex = 4;
            lb_telefono.Text = "Teléfono:";
            // 
            // lb_correo
            // 
            lb_correo.AutoSize = true;
            lb_correo.ForeColor = Color.FromArgb(63, 58, 58);
            lb_correo.Location = new Point(402, 108);
            lb_correo.Name = "lb_correo";
            lb_correo.Size = new Size(57, 20);
            lb_correo.TabIndex = 5;
            lb_correo.Text = "Correo:";
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.White;
            txt_id.Location = new Point(130, 20);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(205, 27);
            txt_id.TabIndex = 6;
            txt_id.TabStop = false;
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(130, 64);
            txt_cedula.MaxLength = 10;
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(205, 27);
            txt_cedula.TabIndex = 7;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(130, 108);
            txt_nombre.MaxLength = 50;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(205, 27);
            txt_nombre.TabIndex = 8;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(525, 20);
            txt_apellido.MaxLength = 50;
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(197, 27);
            txt_apellido.TabIndex = 9;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(525, 64);
            txt_telefono.MaxLength = 20;
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(197, 27);
            txt_telefono.TabIndex = 10;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(525, 108);
            txt_correo.MaxLength = 100;
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(197, 27);
            txt_correo.TabIndex = 11;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.FromArgb(110, 91, 91);
            btn_nuevo.Cursor = Cursors.Hand;
            btn_nuevo.FlatAppearance.BorderSize = 0;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.ForeColor = Color.White;
            btn_nuevo.Location = new Point(28, 160);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(126, 31);
            btn_nuevo.TabIndex = 12;
            btn_nuevo.Text = "Nuevo";
            btn_nuevo.UseVisualStyleBackColor = false;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.FromArgb(110, 91, 91);
            btn_guardar.Cursor = Cursors.Hand;
            btn_guardar.FlatAppearance.BorderSize = 0;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Location = new Point(169, 160);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(126, 31);
            btn_guardar.TabIndex = 13;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(63, 58, 58);
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.FlatAppearance.BorderSize = 0;
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.ForeColor = Color.White;
            btn_eliminar.Location = new Point(310, 160);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(126, 31);
            btn_eliminar.TabIndex = 14;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(167, 138, 127);
            btn_salir.Cursor = Cursors.Hand;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(596, 160);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(126, 31);
            btn_salir.TabIndex = 15;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // dgv_clientes
            // 
            dgv_clientes.AllowUserToAddRows = false;
            dgv_clientes.AllowUserToDeleteRows = false;
            dgv_clientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(201, 183, 156);
            dgv_clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_clientes.BackgroundColor = Color.FromArgb(228, 213, 183);
            dgv_clientes.BorderStyle = BorderStyle.None;
            dgv_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_clientes.ColumnHeadersHeight = 34;
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(228, 213, 183);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(110, 91, 91);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_clientes.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_clientes.EnableHeadersVisualStyles = false;
            dgv_clientes.GridColor = Color.FromArgb(167, 138, 127);
            dgv_clientes.Location = new Point(28, 210);
            dgv_clientes.MultiSelect = false;
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.ReadOnly = true;
            dgv_clientes.RowHeadersVisible = false;
            dgv_clientes.RowHeadersWidth = 51;
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_clientes.Size = new Size(694, 280);
            dgv_clientes.TabIndex = 16;
            dgv_clientes.SelectionChanged += dgv_clientes_SelectionChanged;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 213, 183);
            ClientSize = new Size(773, 510);
            Controls.Add(dgv_clientes);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_nuevo);
            Controls.Add(txt_correo);
            Controls.Add(txt_telefono);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(txt_cedula);
            Controls.Add(txt_id);
            Controls.Add(lb_correo);
            Controls.Add(lb_telefono);
            Controls.Add(lb_apellido);
            Controls.Add(lb_nombre);
            Controls.Add(lb_cedula);
            Controls.Add(lb_id);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_id;
        private Label lb_cedula;
        private Label lb_nombre;
        private Label lb_apellido;
        private Label lb_telefono;
        private Label lb_correo;
        private TextBox txt_id;
        private TextBox txt_cedula;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private TextBox txt_telefono;
        private TextBox txt_correo;
        private Button btn_nuevo;
        private Button btn_guardar;
        private Button btn_eliminar;
        private Button btn_salir;
        private DataGridView dgv_clientes;
    }
}
