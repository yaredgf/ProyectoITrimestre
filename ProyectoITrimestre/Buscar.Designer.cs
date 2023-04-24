namespace GUI
{
    partial class Buscar
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
            dgvBuscar = new DataGridView();
            txtBuscar = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).BeginInit();
            SuspendLayout();
            // 
            // dgvBuscar
            // 
            dgvBuscar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscar.Location = new Point(33, 71);
            dgvBuscar.Name = "dgvBuscar";
            dgvBuscar.ReadOnly = true;
            dgvBuscar.RowTemplate.Height = 25;
            dgvBuscar.Size = new Size(714, 225);
            dgvBuscar.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(394, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(184, 23);
            txtBuscar.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(246, 246, 246);
            label1.Location = new Point(272, 25);
            label1.Name = "label1";
            label1.Size = new Size(30, 17);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(49, 54, 54);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(246, 246, 246);
            btnBuscar.Location = new Point(98, 311);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 37);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(49, 54, 54);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.FromArgb(246, 246, 246);
            btnActualizar.Location = new Point(340, 311);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 37);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(49, 54, 54);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.FromArgb(246, 246, 246);
            btnEliminar.Location = new Point(585, 311);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 37);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 45, 48);
            ClientSize = new Size(777, 369);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(dgvBuscar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Buscar";
            Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)dgvBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBuscar;
        private TextBox txtBuscar;
        private Label label1;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}