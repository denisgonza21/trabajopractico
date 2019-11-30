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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucion));
            this.dtgDevolucion = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnSalir2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btRegistrarEntrega = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLimpiar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDevolucion
            // 
            this.dtgDevolucion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevolucion.Location = new System.Drawing.Point(311, 360);
            this.dtgDevolucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDevolucion.Name = "dtgDevolucion";
            this.dtgDevolucion.RowTemplate.Height = 24;
            this.dtgDevolucion.Size = new System.Drawing.Size(630, 188);
            this.dtgDevolucion.TabIndex = 49;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCliente.Location = new System.Drawing.Point(396, 195);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(58, 20);
            this.lblCliente.TabIndex = 37;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(536, 80);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(348, 33);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Registro de Devoluciones";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(589, 154);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 28);
            this.comboBox1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(396, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nro Cedula";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(589, 192);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(286, 26);
            this.txtCliente.TabIndex = 55;
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
            this.btnSalir2.Location = new System.Drawing.Point(972, 475);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(145, 73);
            this.btnSalir2.TabIndex = 56;
            this.btnSalir2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btRegistrarEntrega.Location = new System.Drawing.Point(417, 256);
            this.btRegistrarEntrega.Margin = new System.Windows.Forms.Padding(5);
            this.btRegistrarEntrega.Name = "btRegistrarEntrega";
            this.btRegistrarEntrega.Size = new System.Drawing.Size(229, 73);
            this.btRegistrarEntrega.TabIndex = 57;
            this.btRegistrarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ActiveBorderThickness = 1;
            this.btnLimpiar.ActiveCornerRadius = 20;
            this.btnLimpiar.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnLimpiar.ActiveForecolor = System.Drawing.Color.White;
            this.btnLimpiar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.ButtonText = "Limpiar";
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLimpiar.IdleBorderThickness = 1;
            this.btnLimpiar.IdleCornerRadius = 20;
            this.btnLimpiar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnLimpiar.IdleForecolor = System.Drawing.Color.White;
            this.btnLimpiar.IdleLineColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(739, 256);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 73);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1450, 907);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btRegistrarEntrega);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDevolucion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Devoluciones";
            this.Load += new System.EventHandler(this.frmDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgDevolucion;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir2;
        private Bunifu.Framework.UI.BunifuThinButton2 btRegistrarEntrega;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLimpiar;
    }
}