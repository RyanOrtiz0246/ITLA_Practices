using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using SistemaRegistroDonaciones;

namespace SistemaDeRegistroDeDonaciones
{
    public partial class GestióndeDonantes : Form
    {
        private OracleConnection connection;
        public GestióndeDonantes()
        {
            InitializeComponent();
            connection = DatabaseConfig.GetConnection();
            LoadDonantes();

            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(800, 600);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panelHeader = new Panel
            {
                Name = "panel",
                Size = new Size(this.Height, 50), // Ancho: 200 px; Altura: igual a la ventana
                Dock = DockStyle.Top,
                BackColor = Color.DarkSlateBlue
            };
            panelHeader.BringToFront();

            Label label4 = new Label
            {
                Name = "label4",
                Text = "Sistema de Registro de Donaciones",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Dock = DockStyle.Fill
            };
        }

        private void LoadDonantes()
        {
            try
            {
                connection.Open();
                string query = "SELECT DonanteID, Nombre, Correo, Telefono FROM Donantes";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvDonantes.DataSource = table;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar donantes: {ex.Message}");
            }
        }

        private void GestióndeDonantes_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO Donantes (DonanteID, Nombre, Correo, Telefono) VALUES (DonantesSeq.NEXTVAL, :Nombre, :Correo, :Telefono)";
                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(":Nombre", txtNombre.Text);
                    cmd.Parameters.Add(":Correo", txtCorreo.Text);
                    cmd.Parameters.Add(":Telefono", txtTelefono.Text);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Donante agregado exitosamente.");
                LoadDonantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar donante: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDonantes.CurrentRow != null)
                {
                    int donanteID = Convert.ToInt32(dgvDonantes.CurrentRow.Cells["DonanteID"].Value);
                    connection.Open();
                    string query = "UPDATE Donantes SET Nombre = :Nombre, Correo = :Correo, Telefono = :Telefono WHERE DonanteID = :DonanteID";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":Nombre", txtNombre.Text);
                        cmd.Parameters.Add(":Correo", txtCorreo.Text);
                        cmd.Parameters.Add(":Telefono", txtTelefono.Text);
                        cmd.Parameters.Add(":DonanteID", donanteID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Donante actualizado exitosamente.");
                    LoadDonantes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar donante: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDonantes.CurrentRow != null)
                {
                    int donanteID = Convert.ToInt32(dgvDonantes.CurrentRow.Cells["DonanteID"].Value);
                    connection.Open();
                    string query = "DELETE FROM Donantes WHERE DonanteID = :DonanteID";
                    using (OracleCommand cmd = new OracleCommand(query, connection))
                    {
                        cmd.Parameters.Add(":DonanteID", donanteID);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    MessageBox.Show("Donante eliminado exitosamente.");
                    LoadDonantes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar donante: {ex.Message}");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
    }
}