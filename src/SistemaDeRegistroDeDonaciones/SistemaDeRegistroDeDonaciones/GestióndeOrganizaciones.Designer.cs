namespace SistemaDeRegistroDeDonaciones
{
    partial class GestióndeOrganizaciones
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
            txtNombreOrg = new TextBox();
            txtCorreoOrg = new TextBox();
            txtTelefonoOrg = new TextBox();
            dgvOrganizaciones = new DataGridView();
            btnAgregarOrg = new Button();
            btnActualizarOrg = new Button();
            btnEliminarOrg = new Button();
            btnVolverOrg = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrganizaciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreOrg
            // 
            txtNombreOrg.Location = new Point(39, 123);
            txtNombreOrg.Name = "txtNombreOrg";
            txtNombreOrg.Size = new Size(198, 31);
            txtNombreOrg.TabIndex = 0;
            // 
            // txtCorreoOrg
            // 
            txtCorreoOrg.Location = new Point(275, 123);
            txtCorreoOrg.Name = "txtCorreoOrg";
            txtCorreoOrg.Size = new Size(225, 31);
            txtCorreoOrg.TabIndex = 1;
            // 
            // txtTelefonoOrg
            // 
            txtTelefonoOrg.Location = new Point(531, 123);
            txtTelefonoOrg.Name = "txtTelefonoOrg";
            txtTelefonoOrg.Size = new Size(210, 31);
            txtTelefonoOrg.TabIndex = 2;
            // 
            // dgvOrganizaciones
            // 
            dgvOrganizaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrganizaciones.Location = new Point(137, 330);
            dgvOrganizaciones.Name = "dgvOrganizaciones";
            dgvOrganizaciones.RowHeadersWidth = 62;
            dgvOrganizaciones.Size = new Size(500, 202);
            dgvOrganizaciones.TabIndex = 3;
            dgvOrganizaciones.CellContentClick += dgvOrganizaciones_CellContentClick;
            // 
            // btnAgregarOrg
            // 
            btnAgregarOrg.BackColor = Color.LightBlue;
            btnAgregarOrg.FlatStyle = FlatStyle.Flat;
            btnAgregarOrg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregarOrg.Location = new Point(137, 182);
            btnAgregarOrg.Name = "btnAgregarOrg";
            btnAgregarOrg.Size = new Size(231, 44);
            btnAgregarOrg.TabIndex = 4;
            btnAgregarOrg.Text = "Agregar Organización";
            btnAgregarOrg.UseVisualStyleBackColor = false;
            btnAgregarOrg.Click += btnAgregarOrg_Click;
            // 
            // btnActualizarOrg
            // 
            btnActualizarOrg.BackColor = Color.LightBlue;
            btnActualizarOrg.FlatStyle = FlatStyle.Flat;
            btnActualizarOrg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnActualizarOrg.Location = new Point(406, 182);
            btnActualizarOrg.Name = "btnActualizarOrg";
            btnActualizarOrg.Size = new Size(231, 44);
            btnActualizarOrg.TabIndex = 5;
            btnActualizarOrg.Text = "Actualizar Organización";
            btnActualizarOrg.UseVisualStyleBackColor = false;
            btnActualizarOrg.Click += btnActualizarOrg_Click;
            // 
            // btnEliminarOrg
            // 
            btnEliminarOrg.BackColor = Color.LightBlue;
            btnEliminarOrg.FlatStyle = FlatStyle.Flat;
            btnEliminarOrg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminarOrg.Location = new Point(137, 258);
            btnEliminarOrg.Name = "btnEliminarOrg";
            btnEliminarOrg.Size = new Size(231, 44);
            btnEliminarOrg.TabIndex = 6;
            btnEliminarOrg.Text = "Eliminar Organización";
            btnEliminarOrg.UseVisualStyleBackColor = false;
            btnEliminarOrg.Click += btnEliminarOrg_Click;
            // 
            // btnVolverOrg
            // 
            btnVolverOrg.BackColor = Color.LightBlue;
            btnVolverOrg.FlatStyle = FlatStyle.Flat;
            btnVolverOrg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolverOrg.Location = new Point(406, 258);
            btnVolverOrg.Name = "btnVolverOrg";
            btnVolverOrg.Size = new Size(231, 44);
            btnVolverOrg.TabIndex = 7;
            btnVolverOrg.Text = "Volver";
            btnVolverOrg.UseVisualStyleBackColor = false;
            btnVolverOrg.Click += btnVolverOrg_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 50);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(778, 50);
            label1.TabIndex = 9;
            label1.Text = "Bienvenido a la Gestión de Organizaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 74);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(341, 74);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 11;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(583, 74);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 12;
            label4.Text = "Telefono";
            // 
            // GestióndeOrganizaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(778, 544);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnVolverOrg);
            Controls.Add(btnEliminarOrg);
            Controls.Add(btnActualizarOrg);
            Controls.Add(btnAgregarOrg);
            Controls.Add(dgvOrganizaciones);
            Controls.Add(txtTelefonoOrg);
            Controls.Add(txtCorreoOrg);
            Controls.Add(txtNombreOrg);
            Name = "GestióndeOrganizaciones";
            Text = "Gestión de Organizaciones";
            Load += GestióndeOrganizaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrganizaciones).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreOrg;
        private TextBox txtCorreoOrg;
        private TextBox txtTelefonoOrg;
        private DataGridView dgvOrganizaciones;
        private Button btnAgregarOrg;
        private Button btnActualizarOrg;
        private Button btnEliminarOrg;
        private Button btnVolverOrg;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}