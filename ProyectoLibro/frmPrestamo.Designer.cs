namespace ProyectoLibro
{
    partial class frmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamo));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNroDocumento = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.cboNroDocumento = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cboLibro = new System.Windows.Forms.ComboBox();
            this.dtgDetallePrestamo = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnSalir2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGuardar2 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(586, 98);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(426, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Prestamos";
            // 
            // lblNroDocumento
            // 
            this.lblNroDocumento.AutoSize = true;
            this.lblNroDocumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNroDocumento.Location = new System.Drawing.Point(442, 176);
            this.lblNroDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDocumento.Name = "lblNroDocumento";
            this.lblNroDocumento.Size = new System.Drawing.Size(121, 20);
            this.lblNroDocumento.TabIndex = 1;
            this.lblNroDocumento.Text = "Nro Documento";
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(442, 326);
            this.lblFechaPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(148, 20);
            this.lblFechaPrestamo.TabIndex = 2;
            this.lblFechaPrestamo.Text = "Fecha de Prestamo";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(442, 362);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(168, 20);
            this.lblFechaVencimiento.TabIndex = 4;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(635, 321);
            this.dtpFechaPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(148, 26);
            this.dtpFechaPrestamo.TabIndex = 5;
            this.dtpFechaPrestamo.TabStop = false;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(635, 356);
            this.dtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(148, 26);
            this.dtpFechaVencimiento.TabIndex = 4;
            // 
            // cboNroDocumento
            // 
            this.cboNroDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNroDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboNroDocumento.FormattingEnabled = true;
            this.cboNroDocumento.Location = new System.Drawing.Point(635, 173);
            this.cboNroDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNroDocumento.Name = "cboNroDocumento";
            this.cboNroDocumento.Size = new System.Drawing.Size(286, 28);
            this.cboNroDocumento.TabIndex = 1;
            this.cboNroDocumento.SelectedIndexChanged += new System.EventHandler(this.cboNroDocumento_SelectedIndexChanged);
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLibro.Location = new System.Drawing.Point(442, 250);
            this.lblLibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(44, 20);
            this.lblLibro.TabIndex = 17;
            this.lblLibro.Text = "Libro";
            // 
            // cboLibro
            // 
            this.cboLibro.FormattingEnabled = true;
            this.cboLibro.Location = new System.Drawing.Point(635, 247);
            this.cboLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLibro.Name = "cboLibro";
            this.cboLibro.Size = new System.Drawing.Size(286, 28);
            this.cboLibro.TabIndex = 2;
            // 
            // dtgDetallePrestamo
            // 
            this.dtgDetallePrestamo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDetallePrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetallePrestamo.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDetallePrestamo.Location = new System.Drawing.Point(361, 523);
            this.dtgDetallePrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDetallePrestamo.Name = "dtgDetallePrestamo";
            this.dtgDetallePrestamo.RowTemplate.Height = 24;
            this.dtgDetallePrestamo.Size = new System.Drawing.Size(630, 188);
            this.dtgDetallePrestamo.TabIndex = 32;
            this.dtgDetallePrestamo.TabStop = false;
            this.dtgDetallePrestamo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDetallePrestamo_CellContentClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(635, 285);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(286, 26);
            this.txtCantidad.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidad.Location = new System.Drawing.Point(442, 288);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 33;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(635, 393);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(286, 26);
            this.txtEstado.TabIndex = 37;
            this.txtEstado.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstado.Location = new System.Drawing.Point(442, 396);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 36;
            this.lblEstado.Text = "Estado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(635, 211);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 26);
            this.txtNombre.TabIndex = 39;
            this.txtNombre.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(442, 214);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 38;
            this.lblNombre.Text = "Nombre";
            // 
            // btnSalir2
            // 
            this.btnSalir2.ActiveBorderThickness = 1;
            this.btnSalir2.ActiveCornerRadius = 20;
            this.btnSalir2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnSalir2.ActiveForecolor = System.Drawing.Color.White;
            this.btnSalir2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSalir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnSalir2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir2.BackgroundImage")));
            this.btnSalir2.ButtonText = "Salir";
            this.btnSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSalir2.IdleBorderThickness = 1;
            this.btnSalir2.IdleCornerRadius = 20;
            this.btnSalir2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnSalir2.IdleForecolor = System.Drawing.Color.White;
            this.btnSalir2.IdleLineColor = System.Drawing.Color.White;
            this.btnSalir2.Location = new System.Drawing.Point(1027, 638);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(145, 73);
            this.btnSalir2.TabIndex = 43;
            this.btnSalir2.TabStop = false;
            this.btnSalir2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // btnLimpiar2
            // 
            this.btnLimpiar2.ActiveBorderThickness = 1;
            this.btnLimpiar2.ActiveCornerRadius = 20;
            this.btnLimpiar2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnLimpiar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiar2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnLimpiar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar2.BackgroundImage")));
            this.btnLimpiar2.ButtonText = "Limpiar";
            this.btnLimpiar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar2.IdleBorderThickness = 1;
            this.btnLimpiar2.IdleCornerRadius = 20;
            this.btnLimpiar2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnLimpiar2.IdleForecolor = System.Drawing.Color.White;
            this.btnLimpiar2.IdleLineColor = System.Drawing.Color.White;
            this.btnLimpiar2.Location = new System.Drawing.Point(846, 429);
            this.btnLimpiar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar2.Name = "btnLimpiar2";
            this.btnLimpiar2.Size = new System.Drawing.Size(145, 73);
            this.btnLimpiar2.TabIndex = 42;
            this.btnLimpiar2.TabStop = false;
            this.btnLimpiar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar2.Click += new System.EventHandler(this.btnLimpiar2_Click);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.ActiveBorderThickness = 1;
            this.btnEliminar2.ActiveCornerRadius = 20;
            this.btnEliminar2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnEliminar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminar2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEliminar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar2.BackgroundImage")));
            this.btnEliminar2.ButtonText = "Eliminar";
            this.btnEliminar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar2.IdleBorderThickness = 1;
            this.btnEliminar2.IdleCornerRadius = 20;
            this.btnEliminar2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnEliminar2.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminar2.IdleLineColor = System.Drawing.Color.White;
            this.btnEliminar2.Location = new System.Drawing.Point(623, 429);
            this.btnEliminar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(145, 73);
            this.btnEliminar2.TabIndex = 41;
            this.btnEliminar2.TabStop = false;
            this.btnEliminar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.ActiveBorderThickness = 1;
            this.btnAgregar2.ActiveCornerRadius = 20;
            this.btnAgregar2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnAgregar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregar2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAgregar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar2.BackgroundImage")));
            this.btnAgregar2.ButtonText = "Agregar";
            this.btnAgregar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregar2.IdleBorderThickness = 1;
            this.btnAgregar2.IdleCornerRadius = 20;
            this.btnAgregar2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnAgregar2.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregar2.IdleLineColor = System.Drawing.Color.White;
            this.btnAgregar2.Location = new System.Drawing.Point(381, 429);
            this.btnAgregar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(145, 73);
            this.btnAgregar2.TabIndex = 40;
            this.btnAgregar2.TabStop = false;
            this.btnAgregar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.ActiveBorderThickness = 1;
            this.btnGuardar2.ActiveCornerRadius = 20;
            this.btnGuardar2.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnGuardar2.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnGuardar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar2.BackgroundImage")));
            this.btnGuardar2.ButtonText = "Guardar";
            this.btnGuardar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar2.IdleBorderThickness = 1;
            this.btnGuardar2.IdleCornerRadius = 20;
            this.btnGuardar2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnGuardar2.IdleForecolor = System.Drawing.Color.White;
            this.btnGuardar2.IdleLineColor = System.Drawing.Color.White;
            this.btnGuardar2.Location = new System.Drawing.Point(1027, 555);
            this.btnGuardar2.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(145, 73);
            this.btnGuardar2.TabIndex = 44;
            this.btnGuardar2.TabStop = false;
            this.btnGuardar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar2.Click += new System.EventHandler(this.btnGuardar2_Click);
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1472, 963);
            this.Controls.Add(this.btnGuardar2);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.btnLimpiar2);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dtgDetallePrestamo);
            this.Controls.Add(this.cboLibro);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.cboNroDocumento);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.lblNroDocumento);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrestamo";
            this.Text = "Registro de Prestamos";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNroDocumento;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.ComboBox cboNroDocumento;
        private System.Windows.Forms.Label lblLibro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cboLibro;
        private System.Windows.Forms.DataGridView dtgDetallePrestamo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar2;
    }
}