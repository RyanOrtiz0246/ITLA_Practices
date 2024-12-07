namespace SistemaDeRegistroDeDonaciones
{
    partial class GestióndeCampañas
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
            txtNombreCampaña = new TextBox();
            txtFechaInicio = new TextBox();
            txtFechaFin = new TextBox();
            dgvCampañas = new DataGridView();
            btnAgregarCampaña = new Button();
            btnActualizarCampaña = new Button();
            btnEliminarCampaña = new Button();
            btnVolverCampaña = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCampañas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreCampaña
            // 
            txtNombreCampaña.Location = new Point(32, 126);
            txtNombreCampaña.Name = "txtNombreCampaña";
            txtNombreCampaña.Size = new Size(178, 31);
            txtNombreCampaña.TabIndex = 1;
            // 
            // txtFechaInicio
            // 
            txtFechaInicio.Location = new Point(240, 126);
            txtFechaInicio.Name = "txtFechaInicio";
            txtFechaInicio.Size = new Size(215, 31);
            txtFechaInicio.TabIndex = 2;
            // 
            // txtFechaFin
            // 
            txtFechaFin.Location = new Point(481, 126);
            txtFechaFin.Name = "txtFechaFin";
            txtFechaFin.Size = new Size(257, 31);
            txtFechaFin.TabIndex = 3;
            // 
            // dgvCampañas
            // 
            dgvCampañas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCampañas.Location = new Point(152, 312);
            dgvCampañas.Name = "dgvCampañas";
            dgvCampañas.RowHeadersWidth = 62;
            dgvCampañas.Size = new Size(416, 220);
            dgvCampañas.TabIndex = 4;
            // 
            // btnAgregarCampaña
            // 
            btnAgregarCampaña.BackColor = Color.LightBlue;
            btnAgregarCampaña.FlatStyle = FlatStyle.Flat;
            btnAgregarCampaña.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregarCampaña.Location = new Point(152, 181);
            btnAgregarCampaña.Name = "btnAgregarCampaña";
            btnAgregarCampaña.Size = new Size(185, 39);
            btnAgregarCampaña.TabIndex = 5;
            btnAgregarCampaña.Text = "Agregar Campaña";
            btnAgregarCampaña.UseVisualStyleBackColor = false;
            btnAgregarCampaña.Click += btnAgregarCampaña_Click;
            // 
            // btnActualizarCampaña
            // 
            btnActualizarCampaña.BackColor = Color.LightBlue;
            btnActualizarCampaña.FlatStyle = FlatStyle.Flat;
            btnActualizarCampaña.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnActualizarCampaña.Location = new Point(383, 181);
            btnActualizarCampaña.Name = "btnActualizarCampaña";
            btnActualizarCampaña.Size = new Size(185, 40);
            btnActualizarCampaña.TabIndex = 6;
            btnActualizarCampaña.Text = "Actualizar Campaña";
            btnActualizarCampaña.UseVisualStyleBackColor = false;
            btnActualizarCampaña.Click += btnActualizarCampaña_Click;
            // 
            // btnEliminarCampaña
            // 
            btnEliminarCampaña.BackColor = Color.LightBlue;
            btnEliminarCampaña.FlatStyle = FlatStyle.Flat;
            btnEliminarCampaña.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminarCampaña.Location = new Point(152, 251);
            btnEliminarCampaña.Name = "btnEliminarCampaña";
            btnEliminarCampaña.Size = new Size(185, 40);
            btnEliminarCampaña.TabIndex = 7;
            btnEliminarCampaña.Text = "Eliminar Campaña";
            btnEliminarCampaña.UseVisualStyleBackColor = false;
            btnEliminarCampaña.Click += btnEliminarCampaña_Click;
            // 
            // btnVolverCampaña
            // 
            btnVolverCampaña.BackColor = Color.LightBlue;
            btnVolverCampaña.FlatStyle = FlatStyle.Flat;
            btnVolverCampaña.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVolverCampaña.Location = new Point(383, 252);
            btnVolverCampaña.Name = "btnVolverCampaña";
            btnVolverCampaña.Size = new Size(185, 38);
            btnVolverCampaña.TabIndex = 8;
            btnVolverCampaña.Text = "Volver";
            btnVolverCampaña.UseVisualStyleBackColor = false;
            btnVolverCampaña.Click += btnVolverCampaña_Click;
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
            label1.Text = "Bienvenido a la Gestión de Campañas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 82);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 10;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(261, 82);
            label3.Name = "label3";
            label3.Size = new Size(176, 32);
            label3.TabIndex = 11;
            label3.Text = "Fecha de Inicio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(481, 82);
            label4.Name = "label4";
            label4.Size = new Size(250, 32);
            label4.TabIndex = 12;
            label4.Text = "Fecha de Terminación";
            // 
            // GestióndeCampañas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(778, 544);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnVolverCampaña);
            Controls.Add(btnEliminarCampaña);
            Controls.Add(btnActualizarCampaña);
            Controls.Add(btnAgregarCampaña);
            Controls.Add(dgvCampañas);
            Controls.Add(txtFechaFin);
            Controls.Add(txtFechaInicio);
            Controls.Add(txtNombreCampaña);
            Name = "GestióndeCampañas";
            Text = "Gestiónde Campañas";
            Load += GestióndeCampañas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCampañas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombreCampaña;
        private TextBox txtFechaInicio;
        private TextBox txtFechaFin;
        private DataGridView dgvCampañas;
        private Button btnAgregarCampaña;
        private Button btnActualizarCampaña;
        private Button btnEliminarCampaña;
        private Button btnVolverCampaña;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}