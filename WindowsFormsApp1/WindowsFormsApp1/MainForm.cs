using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PartnerManagementSystem
{
    public partial class MainForm : Form
    {
        private string connectionString = @"Data Source=ADCLG1;Initial Catalog=DEMOEGOR;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            LoadPartners();
        }

        private void LoadPartners()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            id as PartnerID,
                            Наименование_партнера as 'Наименование',
                            Тип_партнера as 'Тип партнера',
                            Руководитель as 'Руководитель',
                            Электронная_почта_партнера as 'Email',
                            Телефон_партнера as 'Телефон',
                            Рейтинг as 'Рейтинг'
                        FROM Partners
                        ORDER BY Рейтинг DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewPartners.DataSource = dataTable;

                    if (dataGridViewPartners.Columns.Contains("PartnerID"))
                        dataGridViewPartners.Columns["PartnerID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            PartnerForm partnerForm = new PartnerForm();
            if (partnerForm.ShowDialog() == DialogResult.OK)
            {
                LoadPartners();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPartners();
        }

        private void dataGridViewPartners_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPartners.RowCount)
            {
                int partnerId = Convert.ToInt32(dataGridViewPartners.Rows[e.RowIndex].Cells["PartnerID"].Value);
                PartnerForm partnerForm = new PartnerForm(partnerId);
                if (partnerForm.ShowDialog() == DialogResult.OK)
                {
                    LoadPartners();
                }
            }
        }

        private void btnViewServiceHistory_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartners.CurrentRow != null && dataGridViewPartners.CurrentRow.Index >= 0)
            {
                int partnerId = Convert.ToInt32(dataGridViewPartners.CurrentRow.Cells["PartnerID"].Value);
                string partnerName = dataGridViewPartners.CurrentRow.Cells["Наименование"].Value.ToString();

                ServiceHistoryForm historyForm = new ServiceHistoryForm(partnerId, partnerName);
                historyForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите партнера для просмотра истории услуг", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            if (dataGridViewPartners.CurrentRow != null && dataGridViewPartners.CurrentRow.Index >= 0)
            {
                int partnerId = Convert.ToInt32(dataGridViewPartners.CurrentRow.Cells["PartnerID"].Value);
                string partnerName = dataGridViewPartners.CurrentRow.Cells["Наименование"].Value.ToString();

                CostCalculationForm costForm = new CostCalculationForm(partnerId, partnerName);
                costForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите партнера для расчета стоимости", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}