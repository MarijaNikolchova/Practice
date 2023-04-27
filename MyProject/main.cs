using System;
using System.Collections.Generic;
using System.IO;
using MyProject;
using Newtonsoft.Json;

namespace MyProject
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public static class Registration
    {
        private static readonly string FilePath = "users.json";

        public static string SaveUser(User user)
        {
            string error = "";

            // Is username valid
            if (string.IsNullOrEmpty(user.Username))
            {
                error += "Username is required.\n";
            }

            // Is email valid
            if (string.IsNullOrEmpty(user.Email) || !IsValidEmail(user.Email))
            {
                error += "Email is invalid.\n";
            }

            // Is password valid
            if (string.IsNullOrEmpty(user.Password) || user.Password.Length < 8)
            {
                error += "Password must be at least 8 characters.\n";
            }

            // If there are errors, throw an exception with the error message
            if (!string.IsNullOrEmpty(error))
            {
                throw new Exception(error);
            }

            //  Save to file to JSON
            string json = JsonConvert.SerializeObject(user);
            File.AppendAllText(FilePath, json + Environment.NewLine);

            return null;
        }

        // Method to check if email is valid
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Does user already exists in the JSON file
        public static bool UserExists(string username, string email)
        {
            List<User> users = GetAllUsers();
            foreach (User user in users)
            {
                if (user.Username == username || user.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        // Retrieve all users from the JSON file
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);
                foreach (string line in lines)
                {
                    User user = JsonConvert.DeserializeObject<User>(line);
                    users.Add(user);
                }
            }
            return users;
        }
    }

    public static class Login
    {
        // Check if the given login credentials are valid
        public static bool IsValidUser(string username, string password)
        {
            List<User> users = Registration.GetAllUsers();
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

/*string connectionString = "Server[@Name='DESKTOP-MOOICF1']/Database[@Name='Register']/Table[@Name='Register' and @Schema='dbo']";
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    SqlCommand command = new SqlCommand("SELECT * FROM users", connection);
    SqlDataReader reader = command.ExecuteReader();
    while (reader.Read())
    {
        Console.WriteLine("{0}\t{1}\t{2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
    }
}*/
