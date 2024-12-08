using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using SistemaRegistroDonaciones;

namespace SistemaDeRegistroDeDonaciones
{
    public partial class GestióndeOrganizaciones : Form
    {
        private OracleConnection connection;
        public GestióndeOrganizaciones()
        {
            InitializeComponent();
            connection = DatabaseConfig.GetConnection();
            LoadOrganizaciones();

            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel1Header = new Panel
            {
                Name = "panel1",
                Size = new Size(this.Height, 50),
                Dock = DockStyle.Top,
                BackColor = Color.DarkSlateBlue
            };
            panel1Header.BringToFront();

            Label label1 = new Label
            {
                Name = "label1",
                Text = "Sistema de Registro de Donaciones",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Dock = DockStyle.Fill
            };
        }

        private void LoadOrganizaciones()
        {
            try
            {
                connection.Open();
                string query = "SELECT OrganizacionID, Nombre, Correo, Telefono FROM Organizaciones";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvOrganizaciones.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar organizaciones: {ex.Message}");
            }
        }

        private void GestióndeOrganizaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarOrg_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Organizaciones (OrganizacionID, Nombre, Correo, Telefono) VALUES (OrganizacionesSeq.NEXTVAL, :Nombre, :Correo, :Telefono)";
                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(":Nombre", txtNombreOrg.Text);
                    cmd.Parameters.Add(":Correo", txtCorreoOrg.Text);
                    cmd.Parameters.Add(":Telefono", txtTelefonoOrg.Text);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Organización agregada exitosamente.");
                LoadOrganizaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar organización: {ex.Message}");
            }
        }

        private void btnActualizarOrg_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrganizaciones.CurrentRow != null)
                {
                    int orgID = Convert.ToInt32(dgvOrganizaciones.CurrentRow.Cells["OrganizacionID"].Value);
                    connection.Open();
                    string query = "UPDATE Organizaciones SET Nombre = :Nombre, Correo = :Correo, Telefono = :Telefono WHERE OrganizacionID = :OrganizacionID";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":Nombre", txtNombreOrg.Text);
                        cmd.Parameters.Add(":Correo", txtCorreoOrg.Text);
                        cmd.Parameters.Add(":Telefono", txtTelefonoOrg.Text);
                        cmd.Parameters.Add(":OrganizacionID", orgID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Organización actualizada exitosamente.");
                    LoadOrganizaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}");
            }
        }

        private void btnEliminarOrg_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOrganizaciones.CurrentRow != null)
                {
                    int orgID = Convert.ToInt32(dgvOrganizaciones.CurrentRow.Cells["OrganizacionID"].Value);
                    connection.Open();
                    string query = "DELETE FROM Organizaciones WHERE OrganizacionID = :OrganizacionID";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":OrganizacionID", orgID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Organización eliminada exitosamente.");
                    LoadOrganizaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar organización: {ex.Message}");
            }
        }

        private void btnVolverOrg_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }

        private void dgvOrganizaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
