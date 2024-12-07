namespace SistemaDeRegistroDeDonaciones
{
    partial class GestióndeDonaciones
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
            txtDonanteID = new TextBox();
            txtOrganizacionID = new TextBox();
            txtMonto = new TextBox();
            txtFecha = new TextBox();
            dgvDonaciones = new DataGridView();
            btnAgregarDonacion = new Button();
            btnActualizarDonacion = new Button();
            btnEliminarDonacion = new Button();
            btnVolverDonacion = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDonanteID
            // 
            txtDonanteID.Location = new Point(23, 127);
            txtDonanteID.Name = "txtDonanteID";
            txtDonanteID.Size = new Size(139, 31);
            txtDonanteID.TabIndex = 0;
            txtDonanteID.TextChanged += txtDonanteID_TextChanged;
            // 
            // txtOrganizacionID
            // 
            txtOrganizacionID.Location = new Point(191, 127);
            txtOrganizacionID.Name = "txtOrganizacionID";
            txtOrganizacionID.Size = new Size(188, 31);
            txtOrganizacionID.TabIndex = 1;
            txtOrganizacionID.TextChanged += txtOrganizacionID_TextChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(404, 127);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(180, 31);
            txtMonto.TabIndex = 2;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(614, 127);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(143, 31);
            txtFecha.TabIndex = 3;
            // 
            // dgvDonaciones
            // 
            dgvDonaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonaciones.Location = new Point(150, 312);
            dgvDonaciones.Name = "dgvDonaciones";
            dgvDonaciones.RowHeadersWidth = 62;
            dgvDonaciones.Size = new Size(484, 220);
            dgvDonaciones.TabIndex = 4;
            // 
            // btnAgregarDonacion
            // 
            btnAgregarDonacion.BackColor = Color.LightBlue;
            btnAgregarDonacion.FlatStyle = FlatStyle.Flat;
            btnAgregarDonacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregarDonacion.Location = new Point(150, 188);
            btnAgregarDonacion.Name = "btnAgregarDonacion";
            btnAgregarDonacion.Size = new Size(217, 36);
            btnAgregarDonacion.TabIndex = 5;
            btnAgregarDonacion.Text = "Agregar Donación";
            btnAgregarDonacion.UseVisualStyleBackColor = false;
            btnAgregarDonacion.Click += btnAgregarDonacion_Click;
            // 
            // btnActualizarDonacion
            // 
            btnActualizarDonacion.BackColor = Color.LightBlue;
            btnActualizarDonacion.FlatStyle = FlatStyle.Flat;
            btnActualizarDonacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarDonacion.Location = new Point(417, 188);
            btnActualizarDonacion.Name = "btnActualizarDonacion";
            btnActualizarDonacion.Size = new Size(217, 36);
            btnActualizarDonacion.TabIndex = 6;
            btnActualizarDonacion.Text = "Actualizar Donación";
            btnActualizarDonacion.UseVisualStyleBackColor = false;
            btnActualizarDonacion.Click += btnActualizarDonacion_Click;
            // 
            // btnEliminarDonacion
            // 
            btnEliminarDonacion.BackColor = Color.LightBlue;
            btnEliminarDonacion.FlatStyle = FlatStyle.Flat;
            btnEliminarDonacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarDonacion.Location = new Point(150, 251);
            btnEliminarDonacion.Name = "btnEliminarDonacion";
            btnEliminarDonacion.Size = new Size(217, 36);
            btnEliminarDonacion.TabIndex = 7;
            btnEliminarDonacion.Text = "Eliminar Donación";
            btnEliminarDonacion.UseVisualStyleBackColor = false;
            btnEliminarDonacion.Click += btnEliminarDonacion_Click;
            // 
            // btnVolverDonacion
            // 
            btnVolverDonacion.BackColor = Color.LightBlue;
            btnVolverDonacion.FlatStyle = FlatStyle.Flat;
            btnVolverDonacion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolverDonacion.Location = new Point(417, 251);
            btnVolverDonacion.Name = "btnVolverDonacion";
            btnVolverDonacion.Size = new Size(217, 36);
            btnVolverDonacion.TabIndex = 8;
            btnVolverDonacion.Text = "Volver";
            btnVolverDonacion.UseVisualStyleBackColor = false;
            btnVolverDonacion.Click += btnVolverDonacion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 50);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(778, 50);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a la Gestión de Donaciones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 74);
            label2.Name = "label2";
            label2.Size = new Size(139, 32);
            label2.TabIndex = 10;
            label2.Text = "ID Donante";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(191, 74);
            label3.Name = "label3";
            label3.Size = new Size(188, 32);
            label3.TabIndex = 11;
            label3.Text = "ID Organización";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(404, 74);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 12;
            label4.Text = "Monto Donado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(642, 74);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 13;
            label5.Text = "Fecha";
            // 
            // GestióndeDonaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(778, 544);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnVolverDonacion);
            Controls.Add(btnEliminarDonacion);
            Controls.Add(btnActualizarDonacion);
            Controls.Add(btnAgregarDonacion);
            Controls.Add(dgvDonaciones);
            Controls.Add(txtFecha);
            Controls.Add(txtMonto);
            Controls.Add(txtOrganizacionID);
            Controls.Add(txtDonanteID);
            Name = "GestióndeDonaciones";
            Text = "GestióndeDonaciones";
            Load += GestióndeDonaciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDonaciones).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonanteID;
        private TextBox txtOrganizacionID;
        private TextBox txtMonto;
        private TextBox txtFecha;
        private DataGridView dgvDonaciones;
        private Button btnAgregarDonacion;
        private Button btnActualizarDonacion;
        private Button btnEliminarDonacion;
        private Button btnVolverDonacion;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}