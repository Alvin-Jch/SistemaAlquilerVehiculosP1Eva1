namespace SistemaAlquilerVehiculos.Vistas
{
    partial class FrmVehiculos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lb_id = new Label();
            lb_placa = new Label();
            lb_marca = new Label();
            lb_modelo = new Label();
            lb_anio = new Label();
            lb_color = new Label();
            lb_precio = new Label();
            txt_placa = new TextBox();
            txt_marca = new TextBox();
            txt_modelo = new TextBox();
            txt_anio = new TextBox();
            txt_color = new TextBox();
            txt_precio = new TextBox();
            btn_nuevo = new Button();
            btn_guardar = new Button();
            btn_eliminar = new Button();
            btn_salir = new Button();
            dgv_vehiculos = new DataGridView();
            txt_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_vehiculos).BeginInit();
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
            // lb_placa
            // 
            lb_placa.AutoSize = true;
            lb_placa.ForeColor = Color.FromArgb(63, 58, 58);
            lb_placa.Location = new Point(28, 64);
            lb_placa.Name = "lb_placa";
            lb_placa.Size = new Size(47, 20);
            lb_placa.TabIndex = 1;
            lb_placa.Text = "Placa:";
            // 
            // lb_marca
            // 
            lb_marca.AutoSize = true;
            lb_marca.ForeColor = Color.FromArgb(63, 58, 58);
            lb_marca.Location = new Point(28, 108);
            lb_marca.Name = "lb_marca";
            lb_marca.Size = new Size(53, 20);
            lb_marca.TabIndex = 2;
            lb_marca.Text = "Marca:";
            // 
            // lb_modelo
            // 
            lb_modelo.AutoSize = true;
            lb_modelo.ForeColor = Color.FromArgb(63, 58, 58);
            lb_modelo.Location = new Point(28, 152);
            lb_modelo.Name = "lb_modelo";
            lb_modelo.Size = new Size(64, 20);
            lb_modelo.TabIndex = 3;
            lb_modelo.Text = "Modelo:";
            // 
            // lb_anio
            // 
            lb_anio.AutoSize = true;
            lb_anio.ForeColor = Color.FromArgb(63, 58, 58);
            lb_anio.Location = new Point(402, 20);
            lb_anio.Name = "lb_anio";
            lb_anio.Size = new Size(39, 20);
            lb_anio.TabIndex = 4;
            lb_anio.Text = "Año:";
            // 
            // lb_color
            // 
            lb_color.AutoSize = true;
            lb_color.ForeColor = Color.FromArgb(63, 58, 58);
            lb_color.Location = new Point(402, 64);
            lb_color.Name = "lb_color";
            lb_color.Size = new Size(48, 20);
            lb_color.TabIndex = 5;
            lb_color.Text = "Color:";
            // 
            // lb_precio
            // 
            lb_precio.AutoSize = true;
            lb_precio.ForeColor = Color.FromArgb(63, 58, 58);
            lb_precio.Location = new Point(402, 108);
            lb_precio.Name = "lb_precio";
            lb_precio.Size = new Size(105, 20);
            lb_precio.TabIndex = 6;
            lb_precio.Text = "Precio por día:";
            // 
            // txt_placa
            // 
            txt_placa.Location = new Point(130, 64);
            txt_placa.MaxLength = 10;
            txt_placa.Name = "txt_placa";
            txt_placa.Size = new Size(205, 27);
            txt_placa.TabIndex = 8;
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(130, 108);
            txt_marca.MaxLength = 50;
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(205, 27);
            txt_marca.TabIndex = 9;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(130, 152);
            txt_modelo.MaxLength = 50;
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(205, 27);
            txt_modelo.TabIndex = 10;
            // 
            // txt_anio
            // 
            txt_anio.Location = new Point(525, 20);
            txt_anio.MaxLength = 4;
            txt_anio.Name = "txt_anio";
            txt_anio.Size = new Size(197, 27);
            txt_anio.TabIndex = 11;
            // 
            // txt_color
            // 
            txt_color.Location = new Point(525, 64);
            txt_color.MaxLength = 30;
            txt_color.Name = "txt_color";
            txt_color.Size = new Size(197, 27);
            txt_color.TabIndex = 12;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(525, 108);
            txt_precio.MaxLength = 12;
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(197, 27);
            txt_precio.TabIndex = 13;
            // 
            // btn_nuevo
            // 
            btn_nuevo.BackColor = Color.FromArgb(110, 91, 91);
            btn_nuevo.Cursor = Cursors.Hand;
            btn_nuevo.FlatAppearance.BorderSize = 0;
            btn_nuevo.FlatStyle = FlatStyle.Flat;
            btn_nuevo.ForeColor = Color.White;
            btn_nuevo.Location = new Point(28, 205);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(126, 31);
            btn_nuevo.TabIndex = 14;
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
            btn_guardar.Location = new Point(169, 205);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(126, 31);
            btn_guardar.TabIndex = 15;
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
            btn_eliminar.Location = new Point(310, 205);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(126, 31);
            btn_eliminar.TabIndex = 16;
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
            btn_salir.Location = new Point(596, 205);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(126, 31);
            btn_salir.TabIndex = 17;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // dgv_vehiculos
            // 
            dgv_vehiculos.AllowUserToAddRows = false;
            dgv_vehiculos.AllowUserToDeleteRows = false;
            dgv_vehiculos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(201, 183, 156);
            dgv_vehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_vehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_vehiculos.BackgroundColor = Color.FromArgb(228, 213, 183);
            dgv_vehiculos.BorderStyle = BorderStyle.None;
            dgv_vehiculos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv_vehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_vehiculos.ColumnHeadersHeight = 34;
            dgv_vehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(228, 213, 183);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(63, 58, 58);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(110, 91, 91);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_vehiculos.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_vehiculos.EnableHeadersVisualStyles = false;
            dgv_vehiculos.GridColor = Color.FromArgb(167, 138, 127);
            dgv_vehiculos.Location = new Point(28, 255);
            dgv_vehiculos.MultiSelect = false;
            dgv_vehiculos.Name = "dgv_vehiculos";
            dgv_vehiculos.ReadOnly = true;
            dgv_vehiculos.RowHeadersVisible = false;
            dgv_vehiculos.RowHeadersWidth = 51;
            dgv_vehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_vehiculos.Size = new Size(694, 280);
            dgv_vehiculos.TabIndex = 18;
            dgv_vehiculos.SelectionChanged += dgv_vehiculos_SelectionChanged;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.White;
            txt_id.Location = new Point(130, 20);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(205, 27);
            txt_id.TabIndex = 7;
            txt_id.TabStop = false;
            txt_id.TextChanged += txt_id_TextChanged;
            // 
            // FrmVehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 213, 183);
            ClientSize = new Size(773, 560);
            Controls.Add(dgv_vehiculos);
            Controls.Add(btn_salir);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_guardar);
            Controls.Add(btn_nuevo);
            Controls.Add(txt_precio);
            Controls.Add(txt_color);
            Controls.Add(txt_anio);
            Controls.Add(txt_modelo);
            Controls.Add(txt_marca);
            Controls.Add(txt_placa);
            Controls.Add(txt_id);
            Controls.Add(lb_precio);
            Controls.Add(lb_color);
            Controls.Add(lb_anio);
            Controls.Add(lb_modelo);
            Controls.Add(lb_marca);
            Controls.Add(lb_placa);
            Controls.Add(lb_id);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Vehículos";
            Load += FrmVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_vehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_id;
        private Label lb_placa;
        private Label lb_marca;
        private Label lb_modelo;
        private Label lb_anio;
        private Label lb_color;
        private Label lb_precio;
        private TextBox txt_placa;
        private TextBox txt_marca;
        private TextBox txt_modelo;
        private TextBox txt_anio;
        private TextBox txt_color;
        private TextBox txt_precio;
        private Button btn_nuevo;
        private Button btn_guardar;
        private Button btn_eliminar;
        private Button btn_salir;
        private DataGridView dgv_vehiculos;
        private TextBox txt_id;
    }
}
