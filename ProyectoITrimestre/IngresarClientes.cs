using BL;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class IngresarClientes : Form
    {
        public IngresarClientes()
        {
            InitializeComponent();
            btnIngresarCli.Text = "Guardar";
        }

        private void IngresarClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarCli_Click(object sender, EventArgs e)
        {
            if (txtNombreCli.Text == String.Empty)
            {
                MessageBox.Show("Ingrese el nombre", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtApellido1Cli.Text == String.Empty)
            {
                MessageBox.Show("Ingrese el primer Apellido", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtApellido2Cli.Text == String.Empty)
            {
                MessageBox.Show("Ingrese el segundo Apellido", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCedulaCli.Text == String.Empty)
            {
                MessageBox.Show("Ingrese la cedula", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtTelefonoCli.Text == String.Empty)
            {
                MessageBox.Show("Ingrese el telefono", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClienteET cliente = new ClienteET();
                ClienteBL clienteBl = new ClienteBL();
                cliente.Nombre = txtNombreCli.Text;
                cliente.Apellido1 = txtApellido1Cli.Text;
                cliente.Apellido2 = txtApellido2Cli.Text;
                cliente.Cedula = txtCedulaCli.Text;
                cliente.Telefono = txtTelefonoCli.Text;

                if (clienteBl.Guardar(cliente))
                {
                    MessageBox.Show("Cliente guardado exitosamente", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreCli.Text = "";
                    txtApellido1Cli.Text = "";
                    txtApellido2Cli.Text = "";
                    txtCedulaCli.Text = "";
                    txtTelefonoCli.Text = "";
                    txtNombreCli.Focus();
                }
                else
                {
                    MessageBox.Show("Error al guardar el cliente", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
