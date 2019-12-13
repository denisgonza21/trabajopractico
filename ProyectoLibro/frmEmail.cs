using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace ProyectoLibro
{
    public partial class frmEmail : Form
    {
        SqlConnection conexion = new SqlConnection("server = DENIS\\DENISSQLSERVER;Database = Biblioteca;User Id = sa;Password = 123");
        public SqlCommand comando;
        public frmEmail()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*MessageBox.Show("ola");
            string hora = DateTime.Now.Hour.ToString("00");
            foreach (Control c in this.Controls)
            {
                if (hora == txtHora.Text.ToString())
                {
                    try
                    {
                        conexion.Open();
                        string cadena = "select PD.id as IdDetalle, P.id  as IdPrestamo,PD.fecha_vencimiento as FechaVencimiento,L.id as IdLibro, L.nombre as NombreLibro, PD.estado as Estado, C.email as Email from Cliente C, Prestamo P, Prestamo_Detalle PD inner join Libro L on L.id = PD.libro where P.cliente = 1 and PD.prestamo_id = P.id and estado = 1";
                        comando = new SqlCommand(cadena, conexion);
                        SqlDataReader lector = comando.ExecuteReader();
                        System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                        while (lector.Read())
                        {
                            mmsg.To.Add(lector.GetValue(8).ToString());
                            txtAsunto.Text = lector.GetValue(8).ToString();
                            mmsg.Subject = txtAsunto.Text;
                            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                            mmsg.Body = txtBody.Text;
                            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                            mmsg.From = new System.Net.Mail.MailAddress("bibliotecauaa2019@gmail.com");

                            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                            cliente.Credentials = new System.Net.NetworkCredential("bibliotecauaa2019@gmail.com", "biblioteca2019");

                            cliente.Port = 587;
                            cliente.EnableSsl = true;
                            cliente.Host = "smtp.gmail.com";
                            try
                            {
                                cliente.Send(mmsg);
                                MessageBox.Show("Enviado");
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("Error al enviar");
                            }


                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }*/
            

        }

        private void frmEmail_Load(object sender, EventArgs e)
        {
            actualizar();
           
        }

        public void actualizar()
        {
         
            conexion.Open();

            /*String query = "select PD.id as IdDetalle, P.id  as IdPrestamo,PD.fecha_vencimiento as FechaVencimiento, PD.fecha_devolucion as FechaDevolucion, PD.cantidad as Cantidad, L.id as IdLibro,L.nombre as NombreLibro, PD.estado as Estado, C.email from Prestamo P, Prestamo_Detalle PD inner join Libro L on L.id = PD.libro where P.cliente ='" + txtId.Text + "' and PD.prestamo_id = P.id and estado = 1 ";*/

            String query = "select PD.id as IdDetalle, P.id  as IdPrestamo,PD.fecha_vencimiento as FechaVencimiento,L.id as IdLibro, L.nombre as NombreLibro, PD.estado as Estado, C.email as Email from Cliente C, Prestamo P, Prestamo_Detalle PD inner join Libro L on L.id = PD.libro where PD.fecha_vencimiento= '" + dtpFechaPrestamo.Value + "' and PD.prestamo_id = P.id and estado = 1";

            updateGrid(query, "Prestamo");
            
            conexion.Close();
        }
        public void updateGrid(String query, String tbl)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, new SqlConnection(Properties.Settings.Default.BibliotecaConnectionString));
            BibliotecaDataSet3 dad = new BibliotecaDataSet3();
            ada.Fill(dad, tbl);
            dtgVencido.DataSource = dad;
            dtgVencido.DataMember = tbl;
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(txtCorreo.Text);
            mmsg.Subject = txtAsunto.Text;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
            mmsg.Body = txtBody.Text;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.From = new System.Net.Mail.MailAddress("bibliotecauaa2019@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("bibliotecauaa2019@gmail.com","biblioteca2019");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(mmsg);
                MessageBox.Show("Enviado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dtgVencido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtpFechaPrestamo_ValueChanged(object sender, EventArgs e)
        {
            conexion.Open();

            /*String query = "select PD.id as IdDetalle, P.id  as IdPrestamo,PD.fecha_vencimiento as FechaVencimiento, PD.fecha_devolucion as FechaDevolucion, PD.cantidad as Cantidad, L.id as IdLibro,L.nombre as NombreLibro, PD.estado as Estado, C.email from Prestamo P, Prestamo_Detalle PD inner join Libro L on L.id = PD.libro where P.cliente ='" + txtId.Text + "' and PD.prestamo_id = P.id and estado = 1 ";*/

            String query = "select PD.id as IdDetalle, P.id  as IdPrestamo,PD.fecha_vencimiento as FechaVencimiento,L.id as IdLibro, L.nombre as NombreLibro, PD.estado as Estado, C.email as Email from Cliente C, Prestamo P, Prestamo_Detalle PD inner join Libro L on L.id = PD.libro where PD.fecha_vencimiento= '" + dtpFechaPrestamo.Value + "' and PD.prestamo_id = P.id and estado = 1";

            updateGrid(query, "Prestamo");

            conexion.Close();
        }

        private void dtgVencido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dtgVencido.Rows[e.RowIndex];
                txtCorreo.Text = dgv.Cells[6].Value.ToString();
            }
        }
    }
}
