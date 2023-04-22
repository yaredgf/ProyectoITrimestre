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

        private void ActualizarDGV()
        {
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
                        }
                    }
                    if (!encontrado)
                    {
                        try
                        {
                            dgvBuscarTodos.Rows[i].Visible = false;
                        }
                        catch
                        {
                            dgvBuscarTodos.DataSource = new DataTable();
                        }
                    }
                        
                }
            }
            else
            {
                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    dgvBuscarTodos.Rows[i].Visible = true;
                }
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

    }
}
