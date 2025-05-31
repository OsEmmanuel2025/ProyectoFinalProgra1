namespace SistemaHospitalario
{
    partial class FrmPagoCitas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbCodigoCita;
        private System.Windows.Forms.TextBox txtMontoCita;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.DataGridView dgvPagoCitas;

        private System.Windows.Forms.Label lblCodigoCita;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblTipoPago;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbCodigoCita = new System.Windows.Forms.ComboBox();
            this.txtMontoCita = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.dgvPagoCitas = new System.Windows.Forms.DataGridView();
            this.lblCodigoCita = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagoCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCodigoCita
            // 
            this.cmbCodigoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbCodigoCita.Location = new System.Drawing.Point(150, 20);
            this.cmbCodigoCita.Name = "cmbCodigoCita";
            this.cmbCodigoCita.Size = new System.Drawing.Size(121, 26);
            this.cmbCodigoCita.TabIndex = 1;
            // 
            // txtMontoCita
            // 
            this.txtMontoCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtMontoCita.Location = new System.Drawing.Point(150, 60);
            this.txtMontoCita.Name = "txtMontoCita";
            this.txtMontoCita.Size = new System.Drawing.Size(100, 24);
            this.txtMontoCita.TabIndex = 3;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtImpuesto.Location = new System.Drawing.Point(150, 100);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 24);
            this.txtImpuesto.TabIndex = 5;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtDescuento.Location = new System.Drawing.Point(150, 140);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 24);
            this.txtDescuento.TabIndex = 7;
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtTotalPago.Location = new System.Drawing.Point(150, 180);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(100, 24);
            this.txtTotalPago.TabIndex = 9;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPago.Location = new System.Drawing.Point(150, 220);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(121, 24);
            this.dtpFechaPago.TabIndex = 11;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbTipoPago.Location = new System.Drawing.Point(150, 260);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(121, 26);
            this.cmbTipoPago.TabIndex = 13;
            // 
            // dgvPagoCitas
            // 
            this.dgvPagoCitas.ColumnHeadersHeight = 29;
            this.dgvPagoCitas.Location = new System.Drawing.Point(30, 296);
            this.dgvPagoCitas.Name = "dgvPagoCitas";
            this.dgvPagoCitas.RowHeadersWidth = 51;
            this.dgvPagoCitas.Size = new System.Drawing.Size(700, 200);
            this.dgvPagoCitas.TabIndex = 17;
            this.dgvPagoCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagoCitas_CellContentClick);
            // 
            // lblCodigoCita
            // 
            this.lblCodigoCita.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblCodigoCita.Location = new System.Drawing.Point(30, 20);
            this.lblCodigoCita.Name = "lblCodigoCita";
            this.lblCodigoCita.Size = new System.Drawing.Size(100, 23);
            this.lblCodigoCita.TabIndex = 0;
            this.lblCodigoCita.Text = "Código Cita:";
            // 
            // lblMonto
            // 
            this.lblMonto.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblMonto.Location = new System.Drawing.Point(30, 60);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(100, 23);
            this.lblMonto.TabIndex = 2;
            this.lblMonto.Text = "Monto Cita:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblImpuesto.Location = new System.Drawing.Point(30, 100);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(100, 23);
            this.lblImpuesto.TabIndex = 4;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblDescuento.Location = new System.Drawing.Point(30, 140);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(100, 23);
            this.lblDescuento.TabIndex = 6;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblTotal.Location = new System.Drawing.Point(30, 180);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total Pago:";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblFechaPago.Location = new System.Drawing.Point(30, 220);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(100, 23);
            this.lblFechaPago.TabIndex = 10;
            this.lblFechaPago.Text = "Fecha Pago:";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblTipoPago.Location = new System.Drawing.Point(30, 260);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(100, 23);
            this.lblTipoPago.TabIndex = 12;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(330, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "FORMULARIO DE PAGO DE CITAS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalcular.IconColor = System.Drawing.Color.Black;
            this.btnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcular.IconSize = 25;
            this.btnCalcular.Location = new System.Drawing.Point(320, 97);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 34);
            this.btnCalcular.TabIndex = 20;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAgregar.IconColor = System.Drawing.Color.Black;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 25;
            this.btnAgregar.Location = new System.Drawing.Point(320, 137);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 34);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.lblFecha.Location = new System.Drawing.Point(550, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(139, 23);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "Imprimir Fecha";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.label2.Location = new System.Drawing.Point(425, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha actual:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 25;
            this.btnEliminar.Location = new System.Drawing.Point(459, 500);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 34);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 25;
            this.btnSalir.Location = new System.Drawing.Point(593, 501);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 34);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnEditar.IconColor = System.Drawing.Color.Black;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 25;
            this.btnEditar.Location = new System.Drawing.Point(320, 180);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 34);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmPagoCitas
            // 
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigoCita);
            this.Controls.Add(this.cmbCodigoCita);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMontoCita);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotalPago);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.dgvPagoCitas);
            this.Name = "FrmPagoCitas";
            this.Text = "Formulario de Pago de Citas";
            this.Load += new System.EventHandler(this.FrmPagoCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagoCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCalcular;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEditar;
    }
}