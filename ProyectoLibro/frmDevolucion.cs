﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBiblioteca;

namespace ProyectoLibro
{
    public partial class frmDevolucion : Form
    {
        
       SqlConnection conexion = new SqlConnection("server = DENIS\\DENISSQLSERVER;Database = Biblioteca;User Id = sa;Password = 123");
        public SqlCommand comando;
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
           
            this.prestamo_DetalleTableAdapter1.Fill(this.bibliotecaDataSet2.Prestamo_Detalle);
            cboNroCedula.Focus();
            txtNombre.Enabled = false;
            cboNroCedula.DataSource = Cliente.ObtenerCliente();
            cboNroCedula.SelectedItem = null;
            txtNombre.Text = "";
            txtId.Enabled = false;
            txtId.Text = "";
            cboNroCedula.Text = "";
           
            dtgDevolucion.DataSource = null;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            actualizar();
            


        }



        public void actualizar()
        {
            int indice;
            SqlCommand comando = new SqlCommand("SELECT * FROM Cliente where nroDocumento=@nroDocumento", conexion);
            comando.Parameters.AddWithValue("@nroDocumento", cboNroCedula.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtNombre.Text = registro["nombre"].ToString();
                indice = Convert.ToInt32(registro["id"]);
                txtId.Text = Convert.ToString(indice);
                //String query = "select * from Prestamo WHERE cliente='" + txtId.Text + "'";
                /*String query = "select PD.id,PD.prestamo_id, PD.fecha_vencimiento, PD.fecha_devolucion, PD.cantidad, PD.libro, PD.estado from Prestamo_Detalle PD, Prestamo P where P.cliente ='" + txtId.Text + "'and PD.prestamo_id = P.id and estado = 1";
                */
                String query = "select PD.id as IdDetalle, P.id  as IdPrestamo,PD.fecha_vencimiento as FechaVencimiento, PD.fecha_devolucion as FechaDevolucion, PD.cantidad as Cantidad, L.id as IdLibro,L.nombre as NombreLibro, PD.estado as Estado from Prestamo P, Prestamo_Detalle PD inner join Libro L on L.id = PD.libro where P.cliente ='" + txtId.Text + "' and PD.prestamo_id = P.id and estado = 1 ";

                updateGrid(query, "Prestamo");
                            }
            conexion.Close();
        }
        public void updateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.BibliotecaConnectionString));
            BibliotecaDataSet3 dad = new BibliotecaDataSet3();
            ada.Fill(dad, tbl);
            dtgDevolucion.DataSource = dad;
            dtgDevolucion.DataMember = tbl;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btRegistrarEntrega_Click(object sender, EventArgs e)
        {
            int n = 0;
            DateTime fecha = DateTime.Now;
            string actualizar = "estado= '" + n + "' , fecha_devolucion= '" + fecha + "'" ;
            if (modificar(actualizar,"id=" + txtIdDetalle.Text))
            {
                MessageBox.Show("Datos Actualizados");

            }
            else
            {
                MessageBox.Show("Error al actualizar");

            }
            txtIdDetalle.Text="";
        }

        public bool modificar(string campos, string condicion)
        {
            conexion.Open();
            string actualizar2 = "update Prestamo_Detalle set " + campos + " where " + condicion;
            comando = new SqlCommand(actualizar2, conexion);
            try
            {
                int i = comando.ExecuteNonQuery();
                conexion.Close();
                if (i > 0)
                {
                    actualizar();
                    

                    conexion.Close();
                    return true;
                }
                else
                {
                    actualizar();
                    conexion.Close();
                    return false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe seleccionar una fila");
                conexion.Close();

                return false;
            }
            
            
        }

        private void dtgDevolucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dtgDevolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow dgv = dtgDevolucion.Rows[e.RowIndex];
                txtIdDetalle.Text = dgv.Cells[0].Value.ToString();
            }
            
        }

        private void dtgDevolucion_RowContextMenuStripChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void prestamoDetalleBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prestamo_DetalleTableAdapter1.FillBy(this.bibliotecaDataSet2.Prestamo_Detalle);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

