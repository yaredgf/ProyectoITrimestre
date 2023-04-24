namespace GUI
{
    partial class SubMenuPrincipal
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
            lblTitulo = new Label();
            btnIngresar = new Button();
            pnlSubPrincipal = new Panel();
            btnBuscarTodos = new Button();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(340, 9);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(31, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "x";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(49, 54, 54);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.FromArgb(246, 246, 246);
            btnIngresar.Location = new Point(97, 130);
            btnIngresar.Margin = new Padding(2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(97, 37);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pnlSubPrincipal
            // 
            pnlSubPrincipal.BackColor = Color.FromArgb(42, 45, 48);
            pnlSubPrincipal.BorderStyle = BorderStyle.FixedSingle;
            pnlSubPrincipal.ForeColor = Color.FromArgb(246, 246, 246);
            pnlSubPrincipal.Location = new Point(11, 189);
            pnlSubPrincipal.Margin = new Padding(2);
            pnlSubPrincipal.Name = "pnlSubPrincipal";
            pnlSubPrincipal.RightToLeft = RightToLeft.Yes;
            pnlSubPrincipal.Size = new Size(778, 370);
            pnlSubPrincipal.TabIndex = 2;
            // 
            // btnBuscarTodos
            // 
            btnBuscarTodos.BackColor = Color.FromArgb(49, 54, 54);
            btnBuscarTodos.FlatStyle = FlatStyle.Flat;
            btnBuscarTodos.ForeColor = Color.FromArgb(246, 246, 246);
            btnBuscarTodos.Location = new Point(620, 130);
            btnBuscarTodos.Margin = new Padding(2);
            btnBuscarTodos.Name = "btnBuscarTodos";
            btnBuscarTodos.Size = new Size(97, 37);
            btnBuscarTodos.TabIndex = 3;
            btnBuscarTodos.Text = "BuscarTodos";
            btnBuscarTodos.UseVisualStyleBackColor = false;
            btnBuscarTodos.Click += btnBuscarTodos_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(49, 54, 54);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(246, 246, 246);
            btnBuscar.Location = new Point(354, 130);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 37);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // SubMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 38, 38);
            ClientSize = new Size(800, 473);
            Controls.Add(btnBuscar);
            Controls.Add(btnBuscarTodos);
            Controls.Add(pnlSubPrincipal);
            Controls.Add(btnIngresar);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "SubMenuPrincipal";
            Text = "SubMenuPrincipalcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnIngresar;
        private Panel pnlSubPrincipal;
        private Button btnBuscarTodos;
        private Button btnBuscar;
    }
}