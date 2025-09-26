using Devart.Data.MySql;

var key = File.ReadAllText("devart.key");

var connStringBuilder = new MySqlConnectionStringBuilder
{
    Server = "localhost",
    Database = "grv_dev",
    UserId = "grv_dev_user",
    Password = "Welcome1docker",
    LicenseKey = key
};

using var connection = new MySqlConnection(connStringBuilder.ConnectionString);
connection.Open();

using var command = connection.CreateCommand();
command.CommandText = "select count(*) from store";

var result = command.ExecuteScalar();

Console.WriteLine($"Number of stores: {result}");
