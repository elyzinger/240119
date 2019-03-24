using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite2403
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection connection = new SQLiteConnection($"Data Source = C:\\ely\\ely.db; version = 3;");
            connection.Open();
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * from COMPANY", connection))
            {
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read() == true)
                    {
                        Console.WriteLine($"{reader.GetValue(0)} {reader.GetValue(1)} {reader.GetValue(2)} {reader.GetValue(3)} {reader.GetValue(4)}");
                    }
                }
            }
            connection.Close();
        }
    }
}
