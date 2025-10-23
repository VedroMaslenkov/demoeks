using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PartnerManagementSystem
{
    public partial class PartnerForm : Form
    {
        private string connectionString = @"Data Source=ADCLG1;Initial Catalog=DEMOEGOR;Integrated Security=True";
        private int? partnerId;

        public PartnerForm(int? partnerId = null)
        {
            this.partnerId = partnerId;
            InitializeComponent();
            LoadPartnerTypes();

            if (partnerId.HasValue)
            {
                this.Text = "Редактирование партнера";
                btnViewHistory.Visible = true;
                LoadPartnerData();
            }
            else
            {
                this.Text = "Добавление партнера";
                btnViewHistory.Visible = false;
            }
        }

        private void LoadPartnerTypes()
        {
            try
            {
               
                comboPartnerType.Items.Clear();
                comboPartnerType.Items.Add("ИП");
                comboPartnerType.Items.Add("ООО");
                comboPartnerType.Items.Add("ЗАО");
                comboPartnerType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки типов партнеров: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPartnerData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Partners WHERE id = @PartnerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@PartnerID", partnerId.Value);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Наименование_партнера"].ToString();
                            comboPartnerType.Text = reader["Тип_партнера"].ToString();
                            txtDirector.Text = reader["Руководитель"].ToString();
                            txtEmail.Text = reader["Электронная_почта_партнера"].ToString();
                            txtPhone.Text = reader["Телефон_партнера"].ToString();
                            txtAddress.Text = reader["Юридический_адрес_партнера"].ToString();
                            txtINN.Text = reader["ИНН"].ToString();
                            txtRating.Text = reader["Рейтинг"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных партнера: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command;

                    if (partnerId.HasValue)
                    {
                        command = new SqlCommand(@"
                            UPDATE Partners SET 
                                Наименование_партнера = @Name,
                                Тип_партнера = @Type,
                                Руководитель = @Director,
                                Электронная_почта_партнера = @Email,
                                Телефон_партнера = @Phone,
                                Юридический_адрес_партнера = @Address,
                                ИНН = @INN,
                                Рейтинг = @Rating
                            WHERE id = @PartnerID", connection);
                        command.Parameters.AddWithValue("@PartnerID", partnerId.Value);
                    }
                    else
                    {
                        command = new SqlCommand(@"
                            INSERT INTO Partners 
                            (Наименование_партнера, Тип_партнера, Руководитель, Электронная_почта_партнера, Телефон_партнера, Юридический_адрес_партнера, ИНН, Рейтинг)
                            VALUES (@Name, @Type, @Director, @Email, @Phone, @Address, @INN, @Rating)", connection);
                    }

                    command.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    command.Parameters.AddWithValue("@Type", comboPartnerType.Text);
                    command.Parameters.AddWithValue("@Director", txtDirector.Text.Trim());
                    command.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    command.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    command.Parameters.AddWithValue("@INN", txtINN.Text.Trim());
                    command.Parameters.AddWithValue("@Rating", Convert.ToInt32(txtRating.Text.Trim()));

                    command.ExecuteNonQuery();

                    MessageBox.Show("Данные успешно сохранены", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            ServiceHistoryForm historyForm = new ServiceHistoryForm(partnerId.Value, txtName.Text);
            historyForm.ShowDialog();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите наименование партнера", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRating.Text) || !int.TryParse(txtRating.Text, out int rating) || rating < 0 || rating > 10)
            {
                MessageBox.Show("Рейтинг должен быть целым числом от 0 до 10", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRating.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Введите корректный email адрес", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Введите телефон партнера", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            return true;
        }

        private void txtRating_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}