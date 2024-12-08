using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using SistemaRegistroDonaciones;

namespace SistemaDeRegistroDeDonaciones
{
    public partial class GestióndeDonaciones : Form
    {
        private OracleConnection connection;

        public GestióndeDonaciones()
        {
            InitializeComponent();
            connection = DatabaseConfig.GetConnection();
            LoadDonaciones();

            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel1 = new Panel
            {
                Name = "panel1",
                Size = new Size(this.Height, 50), // Ancho: 200 px; Altura: igual a la ventana
                Dock = DockStyle.Top,
                BackColor = Color.DarkSlateBlue
            };
            panel1.BringToFront();

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

        private void LoadDonaciones()
        {
            try
            {
                connection.Open();
                string query = "SELECT DonacionID, DonanteID, OrganizacionID, Monto, Fecha FROM Donaciones";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvDonaciones.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar donaciones: {ex.Message}");
            }
        }

        private void GestióndeDonaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarDonacion_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Donaciones (DonacionID, DonanteID, OrganizacionID, Monto, Fecha) VALUES (DonacionesSeq.NEXTVAL, :DonanteID, :OrganizacionID, :Monto, TO_DATE(:Fecha, 'DD-MM-YYYY'))";
                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(":DonanteID", txtDonanteID.Text);
                    cmd.Parameters.Add(":OrganizacionID", txtOrganizacionID.Text);
                    cmd.Parameters.Add(":Monto", txtMonto.Text);
                    cmd.Parameters.Add(":Fecha", txtFecha.Text);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Donación agregada exitosamente.");
                LoadDonaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar donación: {ex.Message}");
            }
        }

        private void btnActualizarDonacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDonaciones.CurrentRow != null)
                {
                    int donacionID = Convert.ToInt32(dgvDonaciones.CurrentRow.Cells["DonacionID"].Value);
                    connection.Open();
                    string query = "UPDATE Donaciones SET DonanteID = :DonanteID, OrganizacionID = :OrganizacionID, Monto = :Monto, Fecha = TO_DATE(:Fecha, 'DD-MM-YYYY') WHERE DonacionID = :DonacionID";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":DonanteID", txtDonanteID.Text);
                        cmd.Parameters.Add(":OrganizacionID", txtOrganizacionID.Text);
                        cmd.Parameters.Add(":Monto", txtMonto.Text);
                        cmd.Parameters.Add(":Fecha", txtFecha.Text);
                        cmd.Parameters.Add(":DonacionID", donacionID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Donación actualizada exitosamente.");
                    LoadDonaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar donación: {ex.Message}");
            }
        }

        private void btnEliminarDonacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDonaciones.CurrentRow != null)
                {
                    int donacionID = Convert.ToInt32(dgvDonaciones.CurrentRow.Cells["DonacionID"].Value);
                    connection.Open();
                    string query = "DELETE FROM Donaciones WHERE DonacionID = :DonacionID";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":DonacionID", donacionID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Donación eliminada exitosamente.");
                    LoadDonaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar donación: {ex.Message}");
            }
        }

        private void btnVolverDonacion_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOrganizacionID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonanteID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
