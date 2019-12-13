namespace ProyectoLibro
{
    partial class frmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmail));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.dtgVencido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnEnvio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSalir2 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVencido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(406, 130);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(565, 46);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Envio de Correo Automatizado";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(495, 216);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(315, 35);
            this.txtCorreo.TabIndex = 15;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCorreo.Location = new System.Drawing.Point(379, 219);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(88, 29);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "Correo";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtpFechaPrestamo
            // 
            this.dtpFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(658, 261);
            this.dtpFechaPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(152, 35);
            this.dtpFechaPrestamo.TabIndex = 17;
            this.dtpFechaPrestamo.TabStop = false;
            this.dtpFechaPrestamo.ValueChanged += new System.EventHandler(this.dtpFechaPrestamo_ValueChanged);
            // 
            // lblFechaPrestamo
            // 
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPrestamo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(379, 266);
            this.lblFechaPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(253, 29);
            this.lblFechaPrestamo.TabIndex = 16;
            this.lblFechaPrestamo.Text = "Fecha de Vencimiento";
            // 
            // dtgVencido
            // 
            this.dtgVencido.AllowUserToAddRows = false;
            this.dtgVencido.AllowUserToDeleteRows = false;
            this.dtgVencido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgVencido.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgVencido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVencido.Location = new System.Drawing.Point(130, 325);
            this.dtgVencido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgVencido.Name = "dtgVencido";
            this.dtgVencido.ReadOnly = true;
            this.dtgVencido.RowHeadersVisible = false;
            this.dtgVencido.RowTemplate.Height = 24;
            this.dtgVencido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVencido.Size = new System.Drawing.Size(911, 473);
            this.dtgVencido.TabIndex = 50;
            this.dtgVencido.TabStop = false;
            this.dtgVencido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVencido_CellClick);
            this.dtgVencido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVencido_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1217, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Asunto";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(1105, 325);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsunto.Multiline = true;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(305, 108);
            this.txtAsunto.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1226, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Body";
            // 
            // txtBody
            // 
            this.txtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBody.Location = new System.Drawing.Point(1105, 536);
            this.txtBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(305, 262);
            this.txtBody.TabIndex = 54;
            // 
            // btnEnvio
            // 
            this.btnEnvio.ActiveBorderThickness = 1;
            this.btnEnvio.ActiveCornerRadius = 20;
            this.btnEnvio.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnEnvio.ActiveForecolor = System.Drawing.Color.White;
            this.btnEnvio.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnEnvio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnvio.BackgroundImage")));
            this.btnEnvio.ButtonText = "Enviar";
            this.btnEnvio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvio.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEnvio.IdleBorderThickness = 1;
            this.btnEnvio.IdleCornerRadius = 20;
            this.btnEnvio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(4)))), ((int)(((byte)(89)))));
            this.btnEnvio.IdleForecolor = System.Drawing.Color.White;
            this.btnEnvio.IdleLineColor = System.Drawing.Color.White;
            this.btnEnvio.Location = new System.Drawing.Point(931, 189);
            this.btnEnvio.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(229, 73);
            this.btnEnvio.TabIndex = 59;
            this.btnEnvio.TabStop = false;
            this.btnEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
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
            this.btnSalir2.Location = new System.Drawing.Point(1256, 189);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(145, 73);
            this.btnSalir2.TabIndex = 58;
            this.btnSalir2.TabStop = false;
            this.btnSalir2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // frmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1450, 907);
            this.Controls.Add(this.btnEnvio);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgVencido);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmail";
            this.Load += new System.EventHandler(this.frmEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVencido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.DataGridView dtgVencido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBody;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnvio;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir2;
    }
}