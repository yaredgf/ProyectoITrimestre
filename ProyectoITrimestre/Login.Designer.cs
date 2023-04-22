namespace ProyectoITrimestre
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTopMenu = new Panel();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContrasenna = new TextBox();
            btnIngresar = new Button();
            panelTopMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.FromArgb(47, 50, 51);
            panelTopMenu.Controls.Add(btnSalir);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Size = new Size(450, 30);
            panelTopMenu.TabIndex = 0;
            panelTopMenu.MouseDown += panelTopMenu_MouseDown;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(410, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(40, 30);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 56);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 106);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(206, 54);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(184, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasenna
            // 
            txtContrasenna.Location = new Point(206, 104);
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.Size = new Size(184, 23);
            txtContrasenna.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(49, 54, 54);
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(47, 50, 51);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(206, 150);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(184, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 38, 38);
            ClientSize = new Size(450, 230);
            Controls.Add(btnIngresar);
            Controls.Add(txtContrasenna);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelTopMenu);
            ForeColor = Color.FromArgb(246, 246, 246);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            panelTopMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopMenu;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContrasenna;
        private Button btnIngresar;
    }
}