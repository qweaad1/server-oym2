using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace oymAPI
{
    public static class Sell
    {
        public static string add(string jsonr, string namePlayer)
        {

            try
            {
                string json = $"{{\"obj\":[ {jsonr}]}}";
                string path = "C:\\AD\\OSPanel\\home\\example.local\\note4.txt";
                using StreamWriter writer = new StreamWriter(path, append: false);
                writer.WriteLineAsync(json);


                // Строка подключения к MySQL
                string connectionString = "Server=localhost;Database=qweaad;Uid=root;Pwd=your_password;";

                using JsonDocument doc = JsonDocument.Parse(json);
                JsonElement root = doc.RootElement;

                // Получаем массив obj
                JsonElement objArray = root.GetProperty("obj");

                using MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                foreach (JsonElement item in objArray.EnumerateArray())
                {
                     
                    string type = item.GetProperty("type").GetString();
                    string kind = item.GetProperty("kind").GetString();
                    string age = item.GetProperty("age").GetString();
                    
                    string id = item.GetProperty("id").GetString();
                    int index = item.GetProperty("index").GetInt32();

                   
                    string owner = "player1";
                    string rare = "common";

                    // SQL запрос
                    string sql = @"INSERT INTO `qweaad`.`inventory` 
                   (`id`, `id_string`, `name`, `type`, `age`, `owner`, `rare`) 
                   VALUES (@id, @id_string, @name, @type, @age, @owner, @rare)";

                    using MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", index);
                    cmd.Parameters.AddWithValue("@id_string", id);
                    cmd.Parameters.AddWithValue("@name", "NULL");
                    cmd.Parameters.AddWithValue("@type", kind);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@owner", namePlayer);
                    cmd.Parameters.AddWithValue("@rare", "NULL");

                    cmd.ExecuteNonQuery();
                    Console.WriteLine($"Inserted: {kind} (index: {index})");
                }

                connection.Close();
                Console.WriteLine("Done!");

            }
            catch (Exception value)
            {
                Console.WriteLine(($"warn(\"{value}\")").Replace("\r\n"," ").Replace("\r", " "));
            }
            return "print 1";
        }
    }
}

