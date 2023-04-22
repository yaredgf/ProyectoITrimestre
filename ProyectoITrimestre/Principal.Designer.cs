namespace GUI
{
    partial class Principal
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
            panelTodo = new Panel();
            panelContenedor = new Panel();
            panelTopMenu = new Panel();
            btnMin = new Button();
            btnNormal = new Button();
            btnMax = new Button();
            btnSalir = new Button();
            panelSideMenu = new Panel();
            panelColaborador = new Panel();
            btnTipo = new Button();
            btnColaboradores = new Button();
            panel5 = new Panel();
            BtnColaborador = new Button();
            panelHorario = new Panel();
            btnSemana = new Button();
            btnDia = new Button();
            panel3 = new Panel();
            btnHorario = new Button();
            btnCitas = new Button();
            panelMascotas = new Panel();
            btnRaza = new Button();
            btnEspecies = new Button();
            btnMascotasOpc = new Button();
            panel2 = new Panel();
            btnMascotas = new Button();
            btnCliente = new Button();
            panelLogo = new Panel();
            panelTodo.SuspendLayout();
            panelTopMenu.SuspendLayout();
            panelSideMenu.SuspendLayout();
            panelColaborador.SuspendLayout();
            panelHorario.SuspendLayout();
            panelMascotas.SuspendLayout();
            SuspendLayout();
            // 
            // panelTodo
            // 
            panelTodo.BorderStyle = BorderStyle.FixedSingle;
            panelTodo.Controls.Add(panelContenedor);
            panelTodo.Controls.Add(panelTopMenu);
            panelTodo.Controls.Add(panelSideMenu);
            panelTodo.Dock = DockStyle.Fill;
            panelTodo.Location = new Point(0, 0);
            panelTodo.Name = "panelTodo";
            panelTodo.Size = new Size(1000, 600);
            panelTodo.TabIndex = 0;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(43, 47, 47);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(200, 30);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(798, 568);
            panelContenedor.TabIndex = 6;
            // 
            // panelTopMenu
            // 
            panelTopMenu.Controls.Add(btnMin);
            panelTopMenu.Controls.Add(btnNormal);
            panelTopMenu.Controls.Add(btnMax);
            panelTopMenu.Controls.Add(btnSalir);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(200, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(798, 30);
            panelTopMenu.TabIndex = 5;
            panelTopMenu.MouseDown += panelTopMenu_MouseDown;
            // 
            // btnMin
            // 
            btnMin.Dock = DockStyle.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Location = new Point(638, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 30);
            btnMin.TabIndex = 3;
            btnMin.Text = "▁";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnNormal
            // 
            btnNormal.Dock = DockStyle.Right;
            btnNormal.FlatAppearance.BorderSize = 0;
            btnNormal.FlatStyle = FlatStyle.Flat;
            btnNormal.Location = new Point(678, 0);
            btnNormal.Name = "btnNormal";
            btnNormal.Size = new Size(40, 30);
            btnNormal.TabIndex = 2;
            btnNormal.Text = "❐";
            btnNormal.UseVisualStyleBackColor = true;
            btnNormal.Visible = false;
            btnNormal.Click += btnNormal_Click;
            // 
            // btnMax
            // 
            btnMax.Dock = DockStyle.Right;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Location = new Point(718, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(40, 30);
            btnMax.TabIndex = 1;
            btnMax.Text = "🔲";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(758, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 30);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(47, 50, 51);
            panelSideMenu.BorderStyle = BorderStyle.FixedSingle;
            panelSideMenu.Controls.Add(panelColaborador);
            panelSideMenu.Controls.Add(BtnColaborador);
            panelSideMenu.Controls.Add(panelHorario);
            panelSideMenu.Controls.Add(btnHorario);
            panelSideMenu.Controls.Add(btnCitas);
            panelSideMenu.Controls.Add(panelMascotas);
            panelSideMenu.Controls.Add(btnMascotas);
            panelSideMenu.Controls.Add(btnCliente);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(200, 598);
            panelSideMenu.TabIndex = 4;
            // 
            // panelColaborador
            // 
            panelColaborador.BackColor = Color.FromArgb(35, 38, 38);
            panelColaborador.Controls.Add(btnTipo);
            panelColaborador.Controls.Add(btnColaboradores);
            panelColaborador.Controls.Add(panel5);
            panelColaborador.Dock = DockStyle.Top;
            panelColaborador.Location = new Point(0, 379);
            panelColaborador.Name = "panelColaborador";
            panelColaborador.Size = new Size(198, 54);
            panelColaborador.TabIndex = 13;
            panelColaborador.Visible = false;
            // 
            // btnTipo
            // 
            btnTipo.BackColor = Color.FromArgb(42, 45, 48);
            btnTipo.Dock = DockStyle.Top;
            btnTipo.FlatAppearance.BorderColor = Color.FromArgb(35, 38, 38);
            btnTipo.FlatStyle = FlatStyle.Flat;
            btnTipo.Location = new Point(20, 24);
            btnTipo.Name = "btnTipo";
            btnTipo.Size = new Size(178, 24);
            btnTipo.TabIndex = 12;
            btnTipo.Text = "Tipo";
            btnTipo.UseVisualStyleBackColor = false;
            btnTipo.Click += btnTipo_Click;
            // 
            // btnColaboradores
            // 
            btnColaboradores.BackColor = Color.FromArgb(42, 45, 48);
            btnColaboradores.Dock = DockStyle.Top;
            btnColaboradores.FlatAppearance.BorderColor = Color.FromArgb(35, 38, 38);
            btnColaboradores.FlatStyle = FlatStyle.Flat;
            btnColaboradores.Location = new Point(20, 0);
            btnColaboradores.Name = "btnColaboradores";
            btnColaboradores.Size = new Size(178, 24);
            btnColaboradores.TabIndex = 11;
            btnColaboradores.Text = "Colaboradores";
            btnColaboradores.UseVisualStyleBackColor = false;
            btnColaboradores.Click += btnColaboradores_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(20, 54);
            panel5.TabIndex = 10;
            // 
            // BtnColaborador
            // 
            BtnColaborador.BackColor = Color.FromArgb(49, 54, 60);
            BtnColaborador.Dock = DockStyle.Top;
            BtnColaborador.FlatAppearance.BorderColor = Color.FromArgb(47, 50, 51);
            BtnColaborador.FlatStyle = FlatStyle.Flat;
            BtnColaborador.Location = new Point(0, 349);
            BtnColaborador.Name = "BtnColaborador";
            BtnColaborador.Size = new Size(198, 30);
            BtnColaborador.TabIndex = 12;
            BtnColaborador.Text = "Colaborador";
            BtnColaborador.UseVisualStyleBackColor = false;
            BtnColaborador.Click += BtnColaborador_Click;
            // 
            // panelHorario
            // 
            panelHorario.BackColor = Color.FromArgb(35, 38, 38);
            panelHorario.Controls.Add(btnSemana);
            panelHorario.Controls.Add(btnDia);
            panelHorario.Controls.Add(panel3);
            panelHorario.Dock = DockStyle.Top;
            panelHorario.Location = new Point(0, 295);
            panelHorario.Name = "panelHorario";
            panelHorario.Size = new Size(198, 54);
            panelHorario.TabIndex = 11;
            panelHorario.Visible = false;
            // 
            // btnSemana
            // 
            btnSemana.BackColor = Color.FromArgb(42, 45, 48);
            btnSemana.Dock = DockStyle.Top;
            btnSemana.FlatAppearance.BorderColor = Color.FromArgb(35, 38, 38);
            btnSemana.FlatStyle = FlatStyle.Flat;
            btnSemana.Location = new Point(20, 24);
            btnSemana.Name = "btnSemana";
            btnSemana.Size = new Size(178, 24);
            btnSemana.TabIndex = 12;
            btnSemana.Text = "Semana";
            btnSemana.UseVisualStyleBackColor = false;
            btnSemana.Click += btnSemana_Click;
            // 
            // btnDia
            // 
            btnDia.BackColor = Color.FromArgb(42, 45, 48);
            btnDia.Dock = DockStyle.Top;
            btnDia.FlatAppearance.BorderColor = Color.FromArgb(35, 38, 38);
            btnDia.FlatStyle = FlatStyle.Flat;
            btnDia.Location = new Point(20, 0);
            btnDia.Name = "btnDia";
            btnDia.Size = new Size(178, 24);
            btnDia.TabIndex = 11;
            btnDia.Text = "Dia";
            btnDia.UseVisualStyleBackColor = false;
            btnDia.Click += btnDia_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 54);
            panel3.TabIndex = 10;
            // 
            // btnHorario
            // 
            btnHorario.BackColor = Color.FromArgb(49, 54, 60);
            btnHorario.Dock = DockStyle.Top;
            btnHorario.FlatAppearance.BorderColor = Color.FromArgb(47, 50, 51);
            btnHorario.FlatStyle = FlatStyle.Flat;
            btnHorario.Location = new Point(0, 265);
            btnHorario.Name = "btnHorario";
            btnHorario.Size = new Size(198, 30);
            btnHorario.TabIndex = 10;
            btnHorario.Text = "Horario";
            btnHorario.UseVisualStyleBackColor = false;
            btnHorario.Click += btnHorario_Click;
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.FromArgb(49, 54, 60);
            btnCitas.Dock = DockStyle.Top;
            btnCitas.FlatAppearance.BorderColor = Color.FromArgb(47, 50, 51);
            btnCitas.FlatStyle = FlatStyle.Flat;
            btnCitas.Location = new Point(0, 235);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(198, 30);
            btnCitas.TabIndex = 9;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = false;
            // 
            // panelMascotas
            // 
            panelMascotas.BackColor = Color.FromArgb(35, 38, 38);
            panelMascotas.Controls.Add(btnRaza);
            panelMascotas.Controls.Add(btnEspecies);
            panelMascotas.Controls.Add(btnMascotasOpc);
            panelMascotas.Controls.Add(panel2);
            panelMascotas.Dock = DockStyle.Top;
            panelMascotas.Location = new Point(0, 160);
            panelMascotas.Name = "panelMascotas";
            panelMascotas.Size = new Size(198, 75);
            panelMascotas.TabIndex = 8;
            panelMascotas.Visible = false;
            // 
            // btnRaza
            // 
            btnRaza.BackColor = Color.FromArgb(42, 45, 48);
            btnRaza.Dock = DockStyle.Top;
            btnRaza.FlatAppearance.BorderColor = Color.FromArgb(35, 38, 38);
            btnRaza.FlatStyle = FlatStyle.Flat;
            btnRaza.Location = new Point(20, 48);
            btnRaza.Name = "btnRaza";
            btnRaza.Size = new Size(178, 24);
            btnRaza.TabIndex = 13;
            btnRaza.Text = "Raza";
            btnRaza.UseVisualStyleBackColor = false;
            btnRaza.Click += btnRaza_Click;
            // 
            // btnEspecies
            // 
            btnEspecies.BackColor = Color.FromArgb(42, 45, 48);
            btnEspecies.Dock = DockStyle.Top;
            btnEspecies.FlatAppearance.BorderColor = Color.FromArgb(35, 38, 38);
            btnEspecies.FlatStyle = FlatStyle.Flat;
            btnEspecies.Location = new Point(20, 24);
            btnEspecies.Name = "btnEspecies";
            btnEspecies.Size = new Size(178, 24);
            btnEspecies.TabIndex = 12;
            btnEspecies.Text = "Especies";
            btnEspecies.UseVisualStyleBackColor = false;
            btnEspecies.Click += btnEspecies_Click;
            // 
            // btnMascotasOpc
            // 
            btnMascotasOpc.BackColor = Color.FromArgb(42, 45, 48);
            btnMascotasOpc.Dock = DockStyle.Top;
            btnMascotasOpc.FlatAppearance.BorderColor = Color.FromArgb(35, 38, 38);
            btnMascotasOpc.FlatStyle = FlatStyle.Flat;
            btnMascotasOpc.Location = new Point(20, 0);
            btnMascotasOpc.Name = "btnMascotasOpc";
            btnMascotasOpc.Size = new Size(178, 24);
            btnMascotasOpc.TabIndex = 11;
            btnMascotasOpc.Text = "Mascotas";
            btnMascotasOpc.UseVisualStyleBackColor = false;
            btnMascotasOpc.Click += btnMascotasOpc_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 75);
            panel2.TabIndex = 10;
            // 
            // btnMascotas
            // 
            btnMascotas.BackColor = Color.FromArgb(49, 54, 60);
            btnMascotas.Dock = DockStyle.Top;
            btnMascotas.FlatAppearance.BorderColor = Color.FromArgb(47, 50, 51);
            btnMascotas.FlatStyle = FlatStyle.Flat;
            btnMascotas.Location = new Point(0, 130);
            btnMascotas.Name = "btnMascotas";
            btnMascotas.Size = new Size(198, 30);
            btnMascotas.TabIndex = 7;
            btnMascotas.Text = "Mascotas";
            btnMascotas.UseVisualStyleBackColor = false;
            btnMascotas.Click += btnMascotas_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(49, 54, 60);
            btnCliente.Dock = DockStyle.Top;
            btnCliente.FlatAppearance.BorderColor = Color.FromArgb(47, 50, 51);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Location = new Point(0, 100);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(198, 30);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(198, 100);
            panelLogo.TabIndex = 0;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 47, 47);
            ClientSize = new Size(1000, 600);
            Controls.Add(panelTodo);
            ForeColor = Color.FromArgb(246, 246, 246);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Principal";
            panelTodo.ResumeLayout(false);
            panelTopMenu.ResumeLayout(false);
            panelSideMenu.ResumeLayout(false);
            panelColaborador.ResumeLayout(false);
            panelHorario.ResumeLayout(false);
            panelMascotas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTodo;
        private Panel panelContenedor;
        private Panel panelTopMenu;
        private Button btnMin;
        private Button btnNormal;
        private Button btnMax;
        private Button btnSalir;
        private Panel panelSideMenu;
        private Panel panelMascotas;
        private Button btnEspecies;
        private Button btnMascotasOpc;
        private Panel panel2;
        private Button btnMascotas;
        private Button btnCliente;
        private Panel panelLogo;
        private Button btnRaza;
        private Button btnCitas;
        private Button btnHorario;
        private Panel panelColaborador;
        private Button btnTipo;
        private Button btnColaboradores;
        private Panel panel5;
        private Button BtnColaborador;
        private Panel panelHorario;
        private Button btnSemana;
        private Button btnDia;
        private Panel panel3;
    }
}