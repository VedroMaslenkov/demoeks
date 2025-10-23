using System;
using System.Data.SqlClient;

namespace PartnerManagementSystem
{
    public static class CostCalculator
    {
        private static string connectionString = @"Data Source=ADCLG1;Initial Catalog=DEMOEGOR;Integrated Security=True";

        public static decimal CalculateServiceCost(int serviceId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string checkQuery = "SELECT COUNT(*) FROM Services WHERE id = @ServiceID";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@ServiceID", serviceId);

                    int serviceExists = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (serviceExists == 0)
                        return -1;

                    
                    string typeQuery = "SELECT Тип_услуги FROM Services WHERE id = @ServiceID";
                    SqlCommand typeCommand = new SqlCommand(typeQuery, connection);
                    typeCommand.Parameters.AddWithValue("@ServiceID", serviceId);
                    string serviceType = typeCommand.ExecuteScalar()?.ToString();

                    
                    decimal complexityCoefficient = GetComplexityCoefficient(serviceType);

                    
                    decimal materialCost = 100.00m * complexityCoefficient;
                    decimal laborCost = 150.00m * complexityCoefficient;

                    decimal totalCost = materialCost + laborCost;
                    return totalCost;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private static decimal GetComplexityCoefficient(string serviceType)
        {
            if (string.IsNullOrEmpty(serviceType))
                return 1.0m;

           
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Коэффициент_сложности_услуги FROM Service_type WHERE Тип_услуги = @Type";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Type", serviceType);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToDecimal(result);
                    }
                }
            }
            catch
            {
               
            }

           
            switch (serviceType.ToLower())
            {
                case "стирка":
                    return 1.0m;
                case "химчистка":
                    return 2.5m;
                case "ремонт":
                    return 3.0m;
                case "аквачистка":
                    return 1.8m;
                case "сушка":
                    return 0.5m;
                default:
                    return 1.0m;
            }
        }
    }
}