using System;
using System.IO;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "your_connection_string_here"; // Update with actual DB connection string
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
        string outputFilePath = "employees_report.csv";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    // Write CSV header
                    writer.WriteLine("Employee ID,Name,Department,Salary");
                    
                    // Write data rows
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string department = reader.GetString(2);
                        decimal salary = reader.GetDecimal(3);

                        writer.WriteLine($"{id},{name},{department},{salary:F2}");
                    }
                }
            }

            Console.WriteLine("Employee report generated: employees_report.csv");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error fetching data: " + ex.Message);
        }
    }
}
