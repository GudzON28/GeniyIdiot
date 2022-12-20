using System.Data.Common;

namespace GeniyIdiot.Common
{

    public class DbUserResultStorage : IUserResultStorage
    {
        string databaseName = "GeniusIdiot.db";
        string dbTable = "TestResults";

        public void SaveResultTesting(User user)
        {
            var dbCommand = $"INSERT INTO {dbTable} (user_name, total_point, user_diagnose) " +
                            $"VALUES ('{user.Name}', {user.RightAnswer}, '{user.Diagnose}');";

            DbProvider.PutData(databaseName, dbCommand);
        }

        public List<User> GetUserResults()
        {
            var userResults = new List<User>();
            var dbCommand = $"SELECT * FROM {dbTable};";

            var answer = DbProvider.GetData(databaseName, dbCommand);

            foreach (DbDataRecord record in answer)
            {
                userResults.Add(new User(
                    record[1].ToString(),
                    Convert.ToInt32(record[2]),
                    record[3].ToString()
                    ));
            }

            return userResults;
        }
    }
}