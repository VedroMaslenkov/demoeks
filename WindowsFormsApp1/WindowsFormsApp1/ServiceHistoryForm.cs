using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PartnerManagementSystem
{
    public partial class ServiceHistoryForm : Form
    {
        private string connectionString = @"Data Source=ADCLG1;Initial Catalog=DEMOEGOR;Integrated Security=True";
        private int partnerId;

        public ServiceHistoryForm(int partnerId, string partnerName)
        {
            this.partnerId = partnerId;
            InitializeComponent(partnerName);
            LoadServiceHistory();
        }

        private void LoadServiceHistory()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            Услуга as 'Услуга',
                            Количество_услуг as 'Количество',
                            Дата_выполнения as 'Дата выполнения'
                        FROM Partner_services 
                        WHERE Наименование_партнера IN (SELECT Наименование_партнера FROM Partners WHERE id = @PartnerID)
                        ORDER BY Дата_выполнения DESC";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PartnerID", partnerId);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewHistory.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки истории услуг: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}