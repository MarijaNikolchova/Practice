string connectionString = "Server=DESKTOP-MOOICF1;Database=Register;User Id=myUsername;Password=myPassword;";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    SqlCommand command = new SqlCommand("SELECT * FROM users", connection);
    SqlDataReader reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine("{0}\t{1}\t{2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
    }
}