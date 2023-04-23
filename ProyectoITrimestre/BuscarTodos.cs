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

namespace GUI
{

    public partial class BuscarTodos : Form
    {
        private DataTable lista;
        public BuscarTodos()
        {
            InitializeComponent();
        }
        public BuscarTodos(DataTable dt)
        {
            InitializeComponent();
            DataTable data = dt;
            dgvBuscarTodos.DataSource = data;
            dgvBuscarTodos.ReadOnly = true;
            lista = data;
        }
        private DataTable CargarDataTable(DataTable dt)
        {
            DataTable data = new DataTable();
            for (int i = 1; i <= dt.Columns.Count; i++)
            {
                data.Columns.Add(dt.Columns[dt.Columns.Count - i].ColumnName);
            }
            return data;

        }

        private DataTable SetTitulo()
        {
            DataTable dt = new DataTable();
            for (int i=0;i<lista.Columns.Count;i++)
            {
                dt.Columns.Add(lista.Columns[i].ColumnName);
            }
            return dt;
        }

        private DataTable LlenarFila(DataTable dt,int i)
        {
            dt.Rows.Add(lista.Rows[i][0]);
            dgvBuscarTodos.DataSource = dt;
            MessageBox.Show("");
            for (int j=1;j<lista.Columns.Count;j++)
            {
                dt.Rows[i][j] = lista.Rows[i][j];
            }
            return dt;
        }

        private void ActualizarDGV()
        {
            DataTable dt = SetTitulo();
            dgvBuscarTodos.DataSource = lista;
            if (txtBuscar.Text != string.Empty)
            {
                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    bool encontrado = false;
                    for (int j = 0; j < lista.Columns.Count; j++)
                    {
                        if (lista.Rows[i][j].ToString().ToUpper().Trim().Contains(txtBuscar.Text.ToUpper().Trim()))
                        {
                            MessageBox.Show(lista.Rows[i][j].ToString());
                            encontrado = true;
                            dt = LlenarFila(dt,i);
                            break;
                        }
                    }
                        
                    


                }
                dgvBuscarTodos.DataSource = dt;
            }
            else
            {
                dgvBuscarTodos.DataSource = lista;
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

    }
}
