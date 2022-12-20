using System.Data.SQLite;

namespace GeniyIdiot.Common
{
    public class DbInitialisation
    {
        static string databaseName = "GeniusIdiot.db";
        static string dbTableQuestions = "QuestionsAnswersStatistic";
        static string dbTableTestResults = "TestResults";

        public static void First()
        {
            SQLiteConnection.CreateFile(databaseName);

            var dbCommand = $"CREATE TABLE {dbTableQuestions} " +
                            "(id INTEGER  NOT NULL, " +
                            "question STRING, " +
                            "current_answer INTEGER, " +
                            "number_current_answers INTEGER, " +
                            "total_ask_question INTEGER, " +
                            "PRIMARY KEY(\"id\" AUTOINCREMENT));";

            dbCommand += $"CREATE TABLE {dbTableTestResults} " +
                         "(id INTEGER  NOT NULL, " +
                         "user_name STRING, " +
                         "total_point INTEGER, " +
                         "user_diagnose STRING, " +
                         "PRIMARY KEY(\"id\" AUTOINCREMENT));";

            DbProvider.PutData(databaseName, dbCommand);
        }
    }
}
