using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PartnerManagementSystem
{
    public partial class CostCalculationForm : Form
    {
        private string connectionString = @"Data Source=ADCLG1;Initial Catalog=DEMOEGOR;Integrated Security=True";
        private int partnerId;

        public CostCalculationForm(int partnerId, string partnerName)
        {
            this.partnerId = partnerId;
            InitializeComponent(partnerName);
            LoadServices();
        }

        private void LoadServices()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            id as ServiceID,
                            Наименование_услуги as 'Услуга',
                            Код_услуги as 'Код услуги',
                            Минимальная_стоимость_для_партнера as 'Мин. стоимость'
                        FROM Services
                        ORDER BY Наименование_услуги";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewServices.DataSource = dataTable;

                    if (dataGridViewServices.Columns.Contains("ServiceID"))
                        dataGridViewServices.Columns["ServiceID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки услуг: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.CurrentRow != null && dataGridViewServices.CurrentRow.Index >= 0)
            {
                int serviceId = Convert.ToInt32(dataGridViewServices.CurrentRow.Cells["ServiceID"].Value);
                string serviceName = dataGridViewServices.CurrentRow.Cells["Услуга"].Value.ToString();

                decimal cost = CostCalculator.CalculateServiceCost(serviceId);

                if (cost >= 0)
                {
                    lblCostResult.Text = $"Себестоимость услуги '{serviceName}': {cost:C2}";
                    lblCostResult.ForeColor = Color.Green;
                }
                else
                {
                    lblCostResult.Text = "Ошибка расчета себестоимости";
                    lblCostResult.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Выберите услугу для расчета", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalculateMaterial_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.CurrentRow != null && dataGridViewServices.CurrentRow.Index >= 0 &&
                !string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                int serviceId = Convert.ToInt32(dataGridViewServices.CurrentRow.Cells["ServiceID"].Value);
                string serviceName = dataGridViewServices.CurrentRow.Cells["Услуга"].Value.ToString();

                if (double.TryParse(txtWeight.Text, out double weight) && weight > 0)
                {
                    int materialRequired = MaterialCalculator.CalculateMaterialRequired(
                        1, // serviceTypeId 
                        1, // materialTypeId
                        1, // serviceCount
                        weight // параметр услуги (вес)
                    );

                    if (materialRequired >= 0)
                    {
                        lblMaterialResult.Text = $"Для услуги '{serviceName}' (вес: {weight}кг) требуется: {materialRequired} ед. материала";
                        lblMaterialResult.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMaterialResult.Text = "Ошибка расчета материала";
                        lblMaterialResult.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректный вес (положительное число)", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeight.Focus();
                }
            }
            else
            {
                MessageBox.Show("Выберите услугу и введите вес", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}