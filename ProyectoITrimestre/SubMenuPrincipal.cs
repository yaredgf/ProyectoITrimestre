using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;
using BL;

namespace GUI
{
    public partial class SubMenuPrincipal : Form
    {
        private int opcPrincipal;

        public SubMenuPrincipal()
        {
            InitializeComponent();
        }
        public SubMenuPrincipal(int opc, string titulo)
        {
            InitializeComponent();
            this.opcPrincipal = opc;
            this.lblTitulo.Text = titulo;
        }

        private void SubMenuPrincipalcs_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            switch (opcPrincipal)
            {
                case 1:
                    //pnlSubPrincipal.Controls.Clear();
                    //IngresarCliente IngresarCliente = new IngresarCliente();
                    //IngresarCliente.TopLevel = false;
                    //pnlSubPrincipal.Controls.Add(IngresarCliente);
                    //IngresarCliente.Show();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }

        private void pnlSubPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //pnlSubPrincipal.Controls.Clear();
            //Buscar Buscar = new Buscar(opcPrincipal);
            //Buscar.TopLevel = false;
            //pnlSubPrincipal.Controls.Add(Buscar);
            //Buscar.Show();
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            switch (opcPrincipal)
            {
                case 1:
                    ClienteBL clienteBL = new ClienteBL();
                    dt = clienteBL.BuscarTodos();
                    break;
                case 2:
                    MascotaBL mascotaBL = new MascotaBL();
                    dt = mascotaBL.BuscarTodos();
                    break;
                case 3:
                    EspecieBL especieBL = new EspecieBL();
                    dt = especieBL.BuscarTodos();
                    break;
                case 4:
                    RazaBL razaBL = new RazaBL();
                    dt = razaBL.BuscarTodos();
                    break;
                case 5:
                    break;
                case 6:
                    HorarioDiaBL horarioDiaBL = new HorarioDiaBL();
                    dt = horarioDiaBL.BuscarTodos();
                    break;
                case 7:
                    break;
                case 8:
                    ColaboradorBL colaboradorBL = new ColaboradorBL();
                    dt = colaboradorBL.BuscarTodos();
                    break;
                case 9:
                    TipoColaboradorBL tipoBL = new TipoColaboradorBL();
                    dt = tipoBL.BuscarTodos();
                    break;

            }

            if (dt != null)
            {
                if (dt.Columns.Contains("estado"))
                    dt.Columns.Remove("estado");
                pnlSubPrincipal.Controls.Clear();
                BuscarTodos buscarTodos = new BuscarTodos(dt);
                buscarTodos.TopLevel = false;
                pnlSubPrincipal.Controls.Add(buscarTodos);
                buscarTodos.Show();
            }
            else
                MessageBox.Show("No ha sido posible realizar la consulta");
        }
    }
}
