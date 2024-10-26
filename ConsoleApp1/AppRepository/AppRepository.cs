using Npgsql;

namespace ConsoleApp1.AppRepository;

public class AppRepository
{
    static string connectionString = "Host=130.225.37.183; Port=9990; Database=mikael; User Id=apidev; Password=MS^uE48H$R6hw21ZWBydadt6G#Us6pJi;"; 
    NpgsqlConnection connection = new NpgsqlConnection(connectionString);
    
 
    
}