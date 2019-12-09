namespace ProyectoLibro
{
    partial class frmDevolucion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucion));
            this.dtgDevolucion = new System.Windows.Forms.DataGridView();
            this.bibliotecaDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet3 = new ProyectoLibro.BibliotecaDataSet3();
            this.prestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet1 = new ProyectoLibro.BibliotecaDataSet1();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboNroCedula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSalir2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btRegistrarEntrega = new Bunifu.Framework.UI.BunifuThinButton2();
            this.prestamoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prestamo_DetalleTableAdapter = new ProyectoLibro.BibliotecaDataSetTableAdapters.Prestamo_DetalleTableAdapter();
            this.prestamoTableAdapter = new ProyectoLibro.BibliotecaDataSet1TableAdapters.PrestamoTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.prestamoDetalleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet2 = new ProyectoLibro.BibliotecaDataSet2();
            this.prestamo_DetalleTableAdapter1 = new ProyectoLibro.BibliotecaDataSet2TableAdapters.Prestamo_DetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDetalleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDevolucion
            // 
            this.dtgDevolucion.AllowUserToAddRows = false;
            this.dtgDevolucion.AllowUserToDeleteRows = false;
            this.dtgDevolucion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevolucion.Location = new System.Drawing.Point(114, 421);
            this.dtgDevolucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDevolucion.Name = "dtgDevolucion";
            this.dtgDevolucion.ReadOnly = true;
            this.dtgDevolucion.RowHeadersVisible = false;
            this.dtgDevolucion.RowTemplate.Height = 24;
            this.dtgDevolucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDevolucion.Size = new System.Drawing.Size(1179, 473);
            this.dtgDevolucion.TabIndex = 49;
            this.dtgDevolucion.TabStop = false;
            this.dtgDevolucion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevolucion_CellClick);
            this.dtgDevolucion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDevolucion_CellContentClick);
            this.dtgDevolucion.RowContextMenuStripChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dtgDevolucion_RowContextMenuStripChanged);
            // 
            // bibliotecaDataSet3BindingSource
            // 
            this.bibliotecaDataSet3BindingSource.DataSource = this.bibliotecaDataSet3;
            this.bibliotecaDataSet3BindingSource.Position = 0;
            // 
            // bibliotecaDataSet3
            // 
            this.bibliotecaDataSet3.DataSetName = "BibliotecaDataSet3";
            this.bibliotecaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamoBindingSource
            // 
            this.prestamoBindingSource.DataMember = "Prestamo";
            this.prestamoBindingSource.DataSource = this.bibliotecaDataSet1;
            // 
            // bibliotecaDataSet1
            // 
            this.bibliotecaDataSet1.DataSetName = "BibliotecaDataSet1";
            this.bibliotecaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(402, 253);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(497, 120);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(476, 46);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Registro de Devoluciones";
            // 
            // cboNroCedula
            // 
            this.cboNroCedula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboNroCedula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboNroCedula.FormattingEnabled = true;
            this.cboNroCedula.Location = new System.Drawing.Point(595, 212);
            this.cboNroCedula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNroCedula.Name = "cboNroCedula";
            this.cboNroCedula.Size = new System.Drawing.Size(286, 28);
            this.cboNroCedula.TabIndex = 1;
            this.cboNroCedula.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(402, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nro Cedula";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(595, 250);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 26);
            this.txtNombre.TabIndex = 55;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
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
            this.btnSalir2.Location = new System.Drawing.Point(768, 339);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(145, 73);
            this.btnSalir2.TabIndex = 56;
            this.btnSalir2.TabStop = false;
            this.btnSalir2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // btRegistrarEntrega
            // 
            this.btRegistrarEntrega.ActiveBorderThickness = 1;
            this.btRegistrarEntrega.ActiveCornerRadius = 20;
            this.btRegistrarEntrega.ActiveFillColor = System.Drawing.Color.Teal;
            this.btRegistrarEntrega.ActiveForecolor = System.Drawing.Color.White;
            this.btRegistrarEntrega.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btRegistrarEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btRegistrarEntrega.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRegistrarEntrega.BackgroundImage")));
            this.btRegistrarEntrega.ButtonText = "Registrar Entrega";
            this.btRegistrarEntrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegistrarEntrega.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrarEntrega.ForeColor = System.Drawing.Color.SeaGreen;
            this.btRegistrarEntrega.IdleBorderThickness = 1;
            this.btRegistrarEntrega.IdleCornerRadius = 20;
            this.btRegistrarEntrega.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btRegistrarEntrega.IdleForecolor = System.Drawing.Color.White;
            this.btRegistrarEntrega.IdleLineColor = System.Drawing.Color.White;
            this.btRegistrarEntrega.Location = new System.Drawing.Point(443, 339);
            this.btRegistrarEntrega.Margin = new System.Windows.Forms.Padding(5);
            this.btRegistrarEntrega.Name = "btRegistrarEntrega";
            this.btRegistrarEntrega.Size = new System.Drawing.Size(229, 73);
            this.btRegistrarEntrega.TabIndex = 57;
            this.btRegistrarEntrega.TabStop = false;
            this.btRegistrarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btRegistrarEntrega.Click += new System.EventHandler(this.btRegistrarEntrega_Click);
            // 
            // prestamo_DetalleTableAdapter
            // 
            this.prestamo_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // prestamoTableAdapter
            // 
            this.prestamoTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(595, 286);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(286, 26);
            this.txtId.TabIndex = 60;
            this.txtId.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblId.Location = new System.Drawing.Point(402, 289);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 59;
            this.lblId.Text = "Id";
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Location = new System.Drawing.Point(84, 88);
            this.txtIdDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(286, 26);
            this.txtIdDetalle.TabIndex = 61;
            this.txtIdDetalle.TabStop = false;
            this.txtIdDetalle.Visible = false;
            // 
            // prestamoDetalleBindingSource1
            // 
            this.prestamoDetalleBindingSource1.DataMember = "Prestamo_Detalle";
            this.prestamoDetalleBindingSource1.DataSource = this.bibliotecaDataSet2;
            // 
            // bibliotecaDataSet2
            // 
            this.bibliotecaDataSet2.DataSetName = "BibliotecaDataSet2";
            this.bibliotecaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamo_DetalleTableAdapter1
            // 
            this.prestamo_DetalleTableAdapter1.ClearBeforeFill = true;
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1450, 914);
            this.Controls.Add(this.txtIdDetalle);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btRegistrarEntrega);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboNroCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDevolucion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Devoluciones";
            this.Load += new System.EventHandler(this.frmDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDetalleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgDevolucion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboNroCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir2;
        private Bunifu.Framework.UI.BunifuThinButton2 btRegistrarEntrega;
        private System.Windows.Forms.BindingSource prestamoDetalleBindingSource;
        private BibliotecaDataSetTableAdapters.Prestamo_DetalleTableAdapter prestamo_DetalleTableAdapter;
        private BibliotecaDataSet1 bibliotecaDataSet1;
        private System.Windows.Forms.BindingSource prestamoBindingSource;
        private BibliotecaDataSet1TableAdapters.PrestamoTableAdapter prestamoTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private BibliotecaDataSet2 bibliotecaDataSet2;
        private System.Windows.Forms.BindingSource prestamoDetalleBindingSource1;
        private BibliotecaDataSet2TableAdapters.Prestamo_DetalleTableAdapter prestamo_DetalleTableAdapter1;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.BindingSource bibliotecaDataSet3BindingSource;
        private BibliotecaDataSet3 bibliotecaDataSet3;
    }
}