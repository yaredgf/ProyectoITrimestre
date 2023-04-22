namespace GUI
{
    partial class BuscarTodos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtBuscar = new TextBox();
            dgvBuscarTodos = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarTodos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBuscar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(777, 100);
            panel1.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(296, 39);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(184, 23);
            txtBuscar.TabIndex = 4;
            txtBuscar.TextAlign = HorizontalAlignment.Center;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvBuscarTodos
            // 
            dgvBuscarTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscarTodos.Dock = DockStyle.Fill;
            dgvBuscarTodos.Location = new Point(0, 100);
            dgvBuscarTodos.Margin = new Padding(2);
            dgvBuscarTodos.Name = "dgvBuscarTodos";
            dgvBuscarTodos.RightToLeft = RightToLeft.No;
            dgvBuscarTodos.RowHeadersWidth = 62;
            dgvBuscarTodos.RowTemplate.Height = 33;
            dgvBuscarTodos.Size = new Size(777, 269);
            dgvBuscarTodos.TabIndex = 2;
            // 
            // BuscarTodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 45, 48);
            ClientSize = new Size(777, 369);
            Controls.Add(dgvBuscarTodos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "BuscarTodos";
            Text = "BuscarTodos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBuscarTodos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvBuscarTodos;
        private TextBox txtBuscar;
    }
}