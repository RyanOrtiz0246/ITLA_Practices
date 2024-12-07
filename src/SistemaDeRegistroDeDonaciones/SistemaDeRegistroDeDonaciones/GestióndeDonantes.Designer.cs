namespace SistemaDeRegistroDeDonaciones
{
    partial class GestióndeDonantes
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
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            dgvDonantes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDonantes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(269, 115);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(239, 31);
            txtCorreo.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(543, 115);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(190, 31);
            txtTelefono.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightBlue;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(139, 181);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(212, 38);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar Donante";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LightBlue;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(417, 181);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(212, 38);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar Donante";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightBlue;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(139, 253);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(212, 38);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Donante";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.LightBlue;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(417, 253);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(212, 38);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // dgvDonantes
            // 
            dgvDonantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonantes.Location = new Point(139, 312);
            dgvDonantes.Name = "dgvDonantes";
            dgvDonantes.RowHeadersWidth = 62;
            dgvDonantes.Size = new Size(490, 220);
            dgvDonantes.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 77);
            label1.Name = "label1";
            label1.Size = new Size(103, 32);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 77);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 10;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(584, 77);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 11;
            label3.Text = "Telefono";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 50);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(778, 50);
            label4.TabIndex = 0;
            label4.Text = "Bienvenido a la Gestión de Donantes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 115);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(198, 31);
            txtNombre.TabIndex = 0;
            // 
            // GestióndeDonantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(778, 544);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDonantes);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Name = "GestióndeDonantes";
            Text = "Gestión de Donantes";
            Load += GestióndeDonantes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonantes).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnVolver;
        private DataGridView dgvDonantes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private TextBox txtNombre;
    }
}