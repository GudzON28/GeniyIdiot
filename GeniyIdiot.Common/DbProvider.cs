using System.Data.SQLite;

namespace GeniyIdiot.Common
{
    public class DbProvider
    {
        public static SQLiteDataReader GetData(string dataBaseName, string command)
        {
            var dbConnection = new SQLiteConnection(string.Format("Data Source={0};", dataBaseName));
            var operation = new SQLiteCommand($"{command}", dbConnection);
            dbConnection.Open();
            var rows = operation.ExecuteReader();

            return rows;
        }

        public static void PutData(string dataBaseName, string command)
        {
            var dbConnection = new SQLiteConnection(string.Format("Data Source={0};", dataBaseName));
            var operation = new SQLiteCommand($"{command}", dbConnection);

            dbConnection.Open();
            operation.ExecuteNonQuery();

            dbConnection.Close();
        }

        public static void CheckExist(string dataBaseName)
        {
            if (!File.Exists(dataBaseName))
            {
                DbInitialisation.First();
            }
        }
    }
}
