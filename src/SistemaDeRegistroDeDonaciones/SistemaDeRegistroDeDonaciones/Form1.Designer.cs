using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace SistemaDeRegistroDeDonaciones
{
    partial class HomeForm
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
            btnDonantes = new Button();
            btnOrganizaciones = new Button();
            btnDonaciones = new Button();
            btnCampañas = new Button();
            btnExit = new Button();
            panel = new Panel();
            panelHeader = new Panel();
            lblHeader = new Label();
            panel.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btnDonantes
            // 
            btnDonantes.BackColor = Color.LightBlue;
            btnDonantes.FlatStyle = FlatStyle.Flat;
            btnDonantes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDonantes.Location = new Point(263, 101);
            btnDonantes.Name = "btnDonantes";
            btnDonantes.Size = new Size(241, 43);
            btnDonantes.TabIndex = 0;
            btnDonantes.Text = "Gestionar Donantes";
            btnDonantes.UseVisualStyleBackColor = false;
            btnDonantes.Click += btnDonantes_Click;
            // 
            // btnOrganizaciones
            // 
            btnOrganizaciones.BackColor = Color.LightBlue;
            btnOrganizaciones.FlatStyle = FlatStyle.Flat;
            btnOrganizaciones.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOrganizaciones.Location = new Point(263, 181);
            btnOrganizaciones.Name = "btnOrganizaciones";
            btnOrganizaciones.Size = new Size(241, 43);
            btnOrganizaciones.TabIndex = 1;
            btnOrganizaciones.Text = "Gestionar Organizaciones";
            btnOrganizaciones.UseVisualStyleBackColor = false;
            btnOrganizaciones.Click += btnOrganizaciones_Click;
            // 
            // btnDonaciones
            // 
            btnDonaciones.BackColor = Color.LightBlue;
            btnDonaciones.FlatStyle = FlatStyle.Flat;
            btnDonaciones.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDonaciones.Location = new Point(263, 260);
            btnDonaciones.Name = "btnDonaciones";
            btnDonaciones.Size = new Size(241, 43);
            btnDonaciones.TabIndex = 2;
            btnDonaciones.Text = "Gestionar Donaciones";
            btnDonaciones.UseVisualStyleBackColor = false;
            btnDonaciones.Click += btnDonaciones_Click;
            // 
            // btnCampañas
            // 
            btnCampañas.BackColor = Color.LightBlue;
            btnCampañas.FlatStyle = FlatStyle.Flat;
            btnCampañas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCampañas.Location = new Point(263, 341);
            btnCampañas.Name = "btnCampañas";
            btnCampañas.Size = new Size(241, 43);
            btnCampañas.TabIndex = 3;
            btnCampañas.Text = "Gestionar Campañas";
            btnCampañas.UseVisualStyleBackColor = false;
            btnCampañas.Click += btnCampañas_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(326, 423);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(119, 43);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.ControlDarkDark;
            panel.Controls.Add(btnOrganizaciones);
            panel.Controls.Add(btnDonaciones);
            panel.Controls.Add(btnExit);
            panel.Controls.Add(btnDonantes);
            panel.Controls.Add(btnCampañas);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(778, 544);
            panel.TabIndex = 6;
            panel.Paint += panel_Paint;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DarkSlateBlue;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(778, 50);
            panelHeader.TabIndex = 7;
            // 
            // lblHeader
            // 
            lblHeader.Dock = DockStyle.Fill;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(778, 50);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Sistema de Registro de Donaciones";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblHeader.Click += lblHeader_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(778, 544);
            Controls.Add(panelHeader);
            Controls.Add(panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Registro de Donaciones";
            Load += HomeForm_Load;
            panel.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnDonantes;
        private Button btnOrganizaciones;
        private Button btnDonaciones;
        private Button btnCampañas;
        private Button btnExit;
        private Panel panel;
        private Panel panelHeader;
        private Label lblHeader;
    }
}
