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
    public partial class Buscar : Form
    {
        private int opcPrincipal = 0;
        private int id;
        public Buscar()
        {
            InitializeComponent();
        }
        public Buscar(int opcPrincipal)
        {
            InitializeComponent();
            this.opcPrincipal = opcPrincipal;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvBuscar.ReadOnly = true;
            dgvBuscar.ForeColor = Color.Black;
        }

        private void Limpiar()
        {
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvBuscar.DataSource = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (txtBuscar.Text != string.Empty)
            {
                try
                {
                    switch (opcPrincipal)
                    {
                        case 1:
                            ClienteBL clienteBL = new ClienteBL();
                            dt = clienteBL.Buscar(int.Parse(txtBuscar.Text));
                            break;
                        case 2:
                            MascotaBL mascotaBL = new MascotaBL();
                            dt = mascotaBL.Buscar(int.Parse(txtBuscar.Text));
                            break;
                        case 3:
                            EspecieBL especieBL = new EspecieBL();
                            dt = especieBL.Buscar(int.Parse(txtBuscar.Text));
                            break;
                        case 4:
                            RazaBL razaBL = new RazaBL();
                            dt = razaBL.Buscar(int.Parse(txtBuscar.Text));
                            break;
                        case 5:
                            break;
                        case 6:
                            HorarioDiaBL horarioDiaBL = new HorarioDiaBL();
                            dt = horarioDiaBL.Buscar(int.Parse(txtBuscar.Text));
                            break;
                        case 7:
                            break;
                        case 8:
                            ColaboradorBL colaboradorBL = new ColaboradorBL();
                            dt = colaboradorBL.Buscar(int.Parse(txtBuscar.Text));
                            break;
                        case 9:
                            TipoColaboradorBL tipoBL = new TipoColaboradorBL();
                            dt = tipoBL.Buscar(int.Parse(txtBuscar.Text));
                            break;
                    }
                }
                catch
                {

                }
                if (dt != null)
                {
                    if (dt.Rows[0][0].Equals(DBNull.Value))
                    {
                        MessageBox.Show("No se ha encontrado el valor");
                        Limpiar();
                    }
                    else
                    {
                        dt.Columns.Remove("estado");
                        dgvBuscar.DataSource = dt;
                        btnActualizar.Enabled = true;
                        btnEliminar.Enabled = true;
                        id= Convert.ToInt32(dt.Rows[0][0]);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error en la consulta");
                    Limpiar();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool borrarCorrecto = false;
            switch (opcPrincipal)
            {
                case 1:
                    ClienteBL clienteBL = new ClienteBL();
                    borrarCorrecto = clienteBL.Borrar(id);
                    break;
                case 2:
                    MascotaBL mascotaBL = new MascotaBL();
                    borrarCorrecto = mascotaBL.Borrar(id);
                    break;
                case 3:
                    EspecieBL especieBL = new EspecieBL();
                    borrarCorrecto = especieBL.Borrar(id);
                    break;
                case 4:
                    RazaBL razaBL = new RazaBL();
                    borrarCorrecto = razaBL.Borrar(id);
                    break;
                case 5:
                    break;
                case 6:
                    HorarioDiaBL horarioDiaBL = new HorarioDiaBL();
                    borrarCorrecto = horarioDiaBL.Borrar(id);
                    break;
                case 7:
                    break;
                case 8:
                    ColaboradorBL colaboradorBL = new ColaboradorBL();
                    borrarCorrecto = colaboradorBL.Borrar(id);
                    break;
                case 9:
                    TipoColaboradorBL tipoBL = new TipoColaboradorBL();
                    borrarCorrecto = tipoBL.Borrar(id);
                    break;
            }
            if (borrarCorrecto)
            {
                MessageBox.Show("Se ha eliminado con exito");
                Limpiar();
            }
            else
                MessageBox.Show("Ha habido un error al eliminar");
        }
    }
}
