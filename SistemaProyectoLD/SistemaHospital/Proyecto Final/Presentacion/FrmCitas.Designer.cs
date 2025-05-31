namespace SistemaHospitalario
{
    partial class FrmCitas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbCodigoPaciente;
        private System.Windows.Forms.ComboBox cmbCodigoEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaEgreso;
        private System.Windows.Forms.TextBox txtCostoTratamiento;
        private System.Windows.Forms.TextBox txtCostoHabitacion;
        private System.Windows.Forms.DataGridView dgvCitas;

        private System.Windows.Forms.Label lblCodigoPaciente;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblFechaEgreso;
        private System.Windows.Forms.Label lblCostoTratamiento;
        private System.Windows.Forms.Label lblCostoHabitacion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbCodigoPaciente = new System.Windows.Forms.ComboBox();
            this.cmbCodigoEmpleado = new System.Windows.Forms.ComboBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.txtCostoTratamiento = new System.Windows.Forms.TextBox();
            this.txtCostoHabitacion = new System.Windows.Forms.TextBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.lblCodigoPaciente = new System.Windows.Forms.Label();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblFechaEgreso = new System.Windows.Forms.Label();
            this.lblCostoTratamiento = new System.Windows.Forms.Label();
            this.lblCostoHabitacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnCalcular = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCodigoPaciente
            // 
            this.cmbCodigoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCodigoPaciente.Location = new System.Drawing.Point(160, 10);
            this.cmbCodigoPaciente.Name = "cmbCodigoPaciente";
            this.cmbCodigoPaciente.Size = new System.Drawing.Size(121, 26);
            this.cmbCodigoPaciente.TabIndex = 6;
            // 
            // cmbCodigoEmpleado
            // 
            this.cmbCodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCodigoEmpleado.Location = new System.Drawing.Point(160, 50);
            this.cmbCodigoEmpleado.Name = "cmbCodigoEmpleado";
            this.cmbCodigoEmpleado.Size = new System.Drawing.Size(121, 26);
            this.cmbCodigoEmpleado.TabIndex = 7;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(160, 90);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(121, 24);
            this.dtpFechaIngreso.TabIndex = 8;
            // 
            // dtpFechaEgreso
            // 
            this.dtpFechaEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEgreso.Location = new System.Drawing.Point(160, 130);
            this.dtpFechaEgreso.Name = "dtpFechaEgreso";
            this.dtpFechaEgreso.Size = new System.Drawing.Size(121, 24);
            this.dtpFechaEgreso.TabIndex = 9;
            // 
            // txtCostoTratamiento
            // 
            this.txtCostoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCostoTratamiento.Location = new System.Drawing.Point(181, 169);
            this.txtCostoTratamiento.Name = "txtCostoTratamiento";
            this.txtCostoTratamiento.Size = new System.Drawing.Size(100, 24);
            this.txtCostoTratamiento.TabIndex = 10;
            // 
            // txtCostoHabitacion
            // 
            this.txtCostoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCostoHabitacion.Location = new System.Drawing.Point(181, 210);
            this.txtCostoHabitacion.Name = "txtCostoHabitacion";
            this.txtCostoHabitacion.Size = new System.Drawing.Size(100, 24);
            this.txtCostoHabitacion.TabIndex = 11;
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeight = 29;
            this.dgvCitas.Location = new System.Drawing.Point(30, 292);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.Size = new System.Drawing.Size(700, 200);
            this.dgvCitas.TabIndex = 15;
            // 
            // lblCodigoPaciente
            // 
            this.lblCodigoPaciente.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblCodigoPaciente.Location = new System.Drawing.Point(30, 10);
            this.lblCodigoPaciente.Name = "lblCodigoPaciente";
            this.lblCodigoPaciente.Size = new System.Drawing.Size(124, 23);
            this.lblCodigoPaciente.TabIndex = 0;
            this.lblCodigoPaciente.Text = "Código Paciente:";
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(30, 50);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(100, 23);
            this.lblCodigoEmpleado.TabIndex = 1;
            this.lblCodigoEmpleado.Text = "Código Empleado:";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblFechaIngreso.Location = new System.Drawing.Point(30, 90);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(100, 23);
            this.lblFechaIngreso.TabIndex = 2;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // lblFechaEgreso
            // 
            this.lblFechaEgreso.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblFechaEgreso.Location = new System.Drawing.Point(30, 130);
            this.lblFechaEgreso.Name = "lblFechaEgreso";
            this.lblFechaEgreso.Size = new System.Drawing.Size(100, 23);
            this.lblFechaEgreso.TabIndex = 3;
            this.lblFechaEgreso.Text = "Fecha Egreso:";
            // 
            // lblCostoTratamiento
            // 
            this.lblCostoTratamiento.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblCostoTratamiento.Location = new System.Drawing.Point(30, 170);
            this.lblCostoTratamiento.Name = "lblCostoTratamiento";
            this.lblCostoTratamiento.Size = new System.Drawing.Size(150, 23);
            this.lblCostoTratamiento.TabIndex = 4;
            this.lblCostoTratamiento.Text = "Costo Tratamiento:";
            // 
            // lblCostoHabitacion
            // 
            this.lblCostoHabitacion.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblCostoHabitacion.Location = new System.Drawing.Point(30, 210);
            this.lblCostoHabitacion.Name = "lblCostoHabitacion";
            this.lblCostoHabitacion.Size = new System.Drawing.Size(150, 23);
            this.lblCostoHabitacion.TabIndex = 5;
            this.lblCostoHabitacion.Text = "Costo Habitación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(376, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "FORMULAR DE CITAS";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.label2.Location = new System.Drawing.Point(415, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha actual:";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblFecha.Location = new System.Drawing.Point(565, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(138, 23);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Imprimir Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(380, 208);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 34);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(597, 498);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 34);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(463, 497);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 34);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(380, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 34);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnCalcular
            // 
            this.btnCalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalcular.IconColor = System.Drawing.Color.Black;
            this.btnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcular.IconSize = 25;
            this.btnCalcular.Location = new System.Drawing.Point(380, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 34);
            this.btnCalcular.TabIndex = 32;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // FrmCitas
            // 
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigoPaciente);
            this.Controls.Add(this.lblCodigoEmpleado);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.lblFechaEgreso);
            this.Controls.Add(this.lblCostoTratamiento);
            this.Controls.Add(this.lblCostoHabitacion);
            this.Controls.Add(this.cmbCodigoPaciente);
            this.Controls.Add(this.cmbCodigoEmpleado);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.dtpFechaEgreso);
            this.Controls.Add(this.txtCostoTratamiento);
            this.Controls.Add(this.txtCostoHabitacion);
            this.Controls.Add(this.dgvCitas);
            this.Name = "FrmCitas";
            this.Text = "Formulario de Citas";
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnCalcular;
    }
}