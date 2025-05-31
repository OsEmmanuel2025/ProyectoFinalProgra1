namespace SistemaHospitalario
{
    partial class FrmPagoEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbTipoTrabajo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvPagoEmpleados;

        private System.Windows.Forms.Label lblTipoTrabajo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblEstado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbTipoTrabajo = new System.Windows.Forms.ComboBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dgvPagoEmpleados = new System.Windows.Forms.DataGridView();
            this.lblTipoTrabajo = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagoEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoTrabajo
            // 
            this.cmbTipoTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoTrabajo.Location = new System.Drawing.Point(150, 20);
            this.cmbTipoTrabajo.Name = "cmbTipoTrabajo";
            this.cmbTipoTrabajo.Size = new System.Drawing.Size(121, 26);
            this.cmbTipoTrabajo.TabIndex = 1;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSueldo.Location = new System.Drawing.Point(150, 60);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 24);
            this.txtSueldo.TabIndex = 3;
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(150, 100);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(126, 24);
            this.dtpFechaAlta.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbEstado.Location = new System.Drawing.Point(150, 140);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 26);
            this.cmbEstado.TabIndex = 7;
            // 
            // dgvPagoEmpleados
            // 
            this.dgvPagoEmpleados.ColumnHeadersHeight = 29;
            this.dgvPagoEmpleados.Location = new System.Drawing.Point(30, 200);
            this.dgvPagoEmpleados.Name = "dgvPagoEmpleados";
            this.dgvPagoEmpleados.RowHeadersWidth = 51;
            this.dgvPagoEmpleados.Size = new System.Drawing.Size(700, 200);
            this.dgvPagoEmpleados.TabIndex = 11;
            // 
            // lblTipoTrabajo
            // 
            this.lblTipoTrabajo.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblTipoTrabajo.Location = new System.Drawing.Point(14, 20);
            this.lblTipoTrabajo.Name = "lblTipoTrabajo";
            this.lblTipoTrabajo.Size = new System.Drawing.Size(130, 23);
            this.lblTipoTrabajo.TabIndex = 0;
            this.lblTipoTrabajo.Text = "Tipo de Trabajo:";
            // 
            // lblSueldo
            // 
            this.lblSueldo.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblSueldo.Location = new System.Drawing.Point(14, 63);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(100, 23);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo:";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblFechaAlta.Location = new System.Drawing.Point(12, 100);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(100, 23);
            this.lblFechaAlta.TabIndex = 4;
            this.lblFechaAlta.Text = "Fecha de Alta:";
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblEstado.Location = new System.Drawing.Point(12, 140);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(100, 23);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "FORMULARIO DE PAGO A EMPLEADOS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalcular.IconColor = System.Drawing.Color.Black;
            this.btnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcular.IconSize = 25;
            this.btnCalcular.Location = new System.Drawing.Point(401, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 34);
            this.btnCalcular.TabIndex = 35;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(401, 160);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 34);
            this.btnEditar.TabIndex = 34;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(401, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 34);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(633, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 34);
            this.btnSalir.TabIndex = 37;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(499, 405);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 34);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblFecha.Location = new System.Drawing.Point(572, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(138, 23);
            this.lblFecha.TabIndex = 39;
            this.lblFecha.Text = "Imprimir Fecha";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.label2.Location = new System.Drawing.Point(422, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha actual:";
            // 
            // FrmPagoEmpleados
            // 
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoTrabajo);
            this.Controls.Add(this.cmbTipoTrabajo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dgvPagoEmpleados);
            this.Name = "FrmPagoEmpleados";
            this.Text = "Formulario de Pago a Empleados";
            this.Load += new System.EventHandler(this.FrmPagoEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagoEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCalcular;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
    }
}