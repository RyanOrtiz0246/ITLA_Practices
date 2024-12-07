using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using SistemaRegistroDonaciones;

namespace SistemaDeRegistroDeDonaciones
{
    public partial class GestióndeCampañas : Form
    {
        private OracleConnection connection;

        public GestióndeCampañas()
        {
            InitializeComponent();
            connection = DatabaseConfig.GetConnection();
            LoadCampañas();

            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
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

        private void LoadCampañas()
        {
            try
            {
                connection.Open();
                string query = "SELECT CampañaID, Nombre, FechaInicio, FechaFin FROM Campañas";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCampañas.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar campañas: {ex.Message}");
            }
        }
        private void GestióndeCampañas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCampaña_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Campañas (CampañaID, Nombre, FechaInicio, FechaFin) VALUES (CampañasSeq.NEXTVAL, :Nombre, TO_DATE(:FechaInicio, 'DD-MM-YYYY'), TO_DATE(:FechaFin, 'DD-MM-YYYY'))";
                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(":Nombre", txtNombreCampaña.Text);
                    cmd.Parameters.Add(":FechaInicio", txtFechaInicio.Text);
                    cmd.Parameters.Add(":FechaFin", txtFechaFin.Text);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Campaña agregada exitosamente.");
                LoadCampañas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar campaña: {ex.Message}");
            }
        }

        private void btnActualizarCampaña_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCampañas.CurrentRow != null)
                {
                    int campañaID = Convert.ToInt32(dgvCampañas.CurrentRow.Cells["CampañaID"].Value);
                    connection.Open();
                    string query = "UPDATE Campañas SET Nombre = :Nombre, FechaInicio = TO_DATE(:FechaInicio, 'DD-MM-YYYY'), FechaFin = TO_DATE(:FechaFin, 'DD-MM-YYYY') WHERE CampañaID = :CampañaID";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":Nombre", txtNombreCampaña.Text);
                        cmd.Parameters.Add(":FechaInicio", txtFechaInicio.Text);
                        cmd.Parameters.Add(":FechaFin", txtFechaFin.Text);
                        cmd.Parameters.Add(":CampañaID", campañaID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Campaña actualizada exitosamente.");
                    LoadCampañas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar campaña: {ex.Message}");
            }
        }

        private void btnEliminarCampaña_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCampañas.CurrentRow != null)
                {
                    int campañaID = Convert.ToInt32(dgvCampañas.CurrentRow.Cells["CampañaID"].Value);
                    connection.Open();
                    string query = "DELETE FROM Campañas WHERE CampañaID = :CampañaID";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":CampañaID", campañaID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Campaña eliminada exitosamente.");
                    LoadCampañas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar campaña: {ex.Message}");
            }
        }

        private void btnVolverCampaña_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
    }
}
