using GUI;
using BL;
using System.Runtime.InteropServices;

namespace ProyectoITrimestre
{
    public partial class Login : Form
    {
        private int idRol;
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool ValidarCampos()
        {
            /* Instancia al BL para comunicarse con DAL
             * a la variable idRol le da el valor del id del usuario
             * en caso de no encontrarlo devolvera un 0 */
            ColaboradorBL usuarioBL = new ColaboradorBL();
            idRol = usuarioBL.BuscarUsuario(txtUsuario.Text, txtContrasenna.Text);

            /* Verifica si se ingreso un usuario 
             * Verifica si se ingreso una contrasenna
             *Verifica si el usuario existe en la Base de Datos
             *
             **/
            if (txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Ingrese su usuario");
                txtUsuario.Focus();
                return false;
            }
            if (txtContrasenna.Text == String.Empty)
            {
                MessageBox.Show("Ingrese su contraseña");
                txtContrasenna.Focus();
                return false;
            }
            if (idRol == 0)
            {
                MessageBox.Show("Usuario no esta registrado, avise al administrador");
                return false;
            }
            return true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Principal menu = new Principal(idRol);
                menu.Show();
                this.Hide();
            }
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

        
    }
}