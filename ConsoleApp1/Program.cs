// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Security.Cryptography;
using Npgsql;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string connectionString = "Host=130.225.37.183; Port=9990; Database=mikael; User Id=apidev; Password=MS^uE48H$R6hw21ZWBydadt6G#Us6pJi;";
      using NpgsqlConnection connection = new NpgsqlConnection(connectionString);

      string insertQuery = "INSERT INTO professor(id, name) VALUES (@id, @name)";


      var value1 = 2;
      var value2 = "Fred";
      
      
      try
      {
        connection.Open();


        using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
        {
          command.Parameters.AddWithValue("@id", value1);
          command.Parameters.AddWithValue("@name", value2);
          
          int rowsAffected = command.ExecuteNonQuery();
          
          Console.WriteLine($"Rows affected: {rowsAffected}");
          
          
        }
        




      }
      catch (Exception ex)
      {
        Console.WriteLine($"Error: {ex.Message}");

      }
      finally
      {
        connection.Close();
      }






    }


  }
}