using System;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using SistemaRegistroDonaciones;

namespace SistemaDeRegistroDeDonaciones
{
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();

            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);

            this.Controls.Add(panelHeader);
            this.Controls.Add(panel);
            SetBackgroundImage();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Panel panelHeader = new Panel
            {
                Name = "panelHeader",
                Size = new Size(this.Height, 50), // Ancho: 200 px; Altura: igual a la ventana
                Dock = DockStyle.Top,
                BackColor = Color.DarkSlateBlue
            };
            panelHeader.BringToFront();

            Label lblHeader = new Label
            {
                Name = "lblHeader",
                Text = "Sistema de Registro de Donaciones",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Dock = DockStyle.Fill
            };
        }

            private void panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = new Panel
            {
                Name = "panel",
                Size = new Size(300, this.Height), // Ancho: 200 px; Altura: igual a la ventana
                Dock = DockStyle.Left,
                BackColor = Color.DarkSlateGray
            };
        }

        private void SetBackgroundImage()
        {
            // Configurar la imagen de fondo en el Panel Lateral
            panel.BackgroundImage = Image.FromFile(@"C:\Users\ryan1\OneDrive\Im�genes\Donaciones.jpg");
            panel.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnDonantes_Click(object sender, EventArgs e)
        {
            Gesti�ndeDonantes donantes = new Gesti�ndeDonantes();
            donantes.Show();
            this.Hide();
        }

        private void btnOrganizaciones_Click(object sender, EventArgs e)
        {
            Gesti�ndeOrganizaciones organizaciones = new Gesti�ndeOrganizaciones();
            organizaciones.Show();
            this.Hide();
        }

        private void btnDonaciones_Click(object sender, EventArgs e)
        {
            Gesti�ndeDonaciones donaciones = new Gesti�ndeDonaciones();
            donaciones.Show();
            this.Hide();
        }

        private void btnCampa�as_Click(object sender, EventArgs e)
        {
            Gesti�ndeCampa�as campa�as = new Gesti�ndeCampa�as();
            campa�as.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
