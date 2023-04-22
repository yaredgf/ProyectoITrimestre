using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Principal : Form
    {
        private int rol = 0;
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(int rol)
        {
            InitializeComponent();
            this.rol = rol;
        }



        /* Importaciones para la ventana arrastrable */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panelTopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /* Cierra la aplicacion */
            Application.Exit();
        }

        private void CargarFormHijo(object pformHijo)
        {
            /* recibe el form que va a mostrar
             * verifica si el contenedor esta ocupado, si lo esta lo vacia  */
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form formHijo = pformHijo as Form;
            /* Configura el form para que se adecue al contenedor */
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            /* annade al form hijo y lo muestra */
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();

        }

        private void CerrarPaneles()
        {
            panelColaborador.Visible = false;
            panelHorario.Visible = false;
            panelMascotas.Visible = false;
        }






        private void btnCliente_Click(object sender, EventArgs e)
        {
            SubMenuPrincipal subMenu = new SubMenuPrincipal(1, "Clientes");
            CargarFormHijo(subMenu);
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            if (panelMascotas.Visible)
            {
                CerrarPaneles();
            }
            else
            {
                CerrarPaneles();
                panelMascotas.Visible = true;
            }
        }

        private void btnMascotasOpc_Click(object sender, EventArgs e)
        {
            SubMenuPrincipal subMenu = new SubMenuPrincipal(2, "Mascotas");
            CargarFormHijo(subMenu);
        }

        private void btnEspecies_Click(object sender, EventArgs e)
        {
            SubMenuPrincipal subMenu = new SubMenuPrincipal(3, "Especies");
            CargarFormHijo(subMenu);
        }

        private void btnRaza_Click(object sender, EventArgs e)
        {
            SubMenuPrincipal subMenu = new SubMenuPrincipal(4, "Raza");
            CargarFormHijo(subMenu);
        }

        private void btnHorario_Click(object sender, EventArgs e)
        {
            if (panelHorario.Visible)
            {
                CerrarPaneles();
            }
            else
            {
                CerrarPaneles();
                panelHorario.Visible = true;
            }
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            SubMenuPrincipal subMenu = new SubMenuPrincipal(6, "Dia");
            CargarFormHijo(subMenu);
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            SubMenuPrincipal subMenu = new SubMenuPrincipal(7, "Semana");
            CargarFormHijo(subMenu);
        }

        private void BtnColaborador_Click(object sender, EventArgs e)
        {
            if (panelColaborador.Visible)
            {
                CerrarPaneles();
            }
            else
            {
                CerrarPaneles();
                panelColaborador.Visible = true;
            }
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            SubMenuPrincipal subMenu = new SubMenuPrincipal(8, "Colaboradores");
            CargarFormHijo(subMenu);
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            SubMenuPrincipal subMenu = new SubMenuPrincipal(9, "Tipo de Colaborador");
            CargarFormHijo(subMenu);
        }


    }
}
