using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLibro
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatAutor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmAutores());
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelChart.Controls.Count > 0)
                this.PanelChart.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelChart.Controls.Add(fh);
            this.PanelChart.Tag = fh;
            fh.Show();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmEditorial());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmPrestamo());
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmCliente());
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmFuncionario());
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmLibro());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmDevolucion());
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                LineaSidebar.Width = 52;
                AnimacionSidebar.Show(Sidebar);
                
            }
            else
            {
                Sidebar.Visible = false;
                Sidebar.Width = 270;
                SidebarWrapper.Width = 300;
                LineaSidebar.Width = 252;
                AnimacionSidebarBack.Show(Sidebar);
            }
           
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmAcercaDe());
        }
    }
}
