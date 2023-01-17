using System.Data.Common;

namespace GeniyIdiot.Common
{
    public class DbQuestionStorage : IQuestionStorage
    {
        static string databaseName = "GeniusIdiot.db";
        static string dbTable = "QuestionsAnswersStatistic";

        public List<Question> GetQuestions()
        {
            var questions = new List<Question>();
            var dbCommand = $"SELECT * FROM {dbTable};";
            var answer = DbProvider.GetData(databaseName, dbCommand);

            DbProvider.CheckExist(databaseName);

            foreach (DbDataRecord record in answer)
            {
                questions.Add(new Question(
                    record[1].ToString(),
                    Convert.ToInt32(record[2]),
                    Convert.ToInt32(record[3]),
                    Convert.ToInt32(record[4])
                    ));
            }

            return questions;
        }

        public void AddRequiredQuestions()
        {
            List<Question> questions = new List<Question>();

            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

            for (int i = 0; i < questions.Count; i++)
            {
                var dbCommand = $"INSERT INTO {dbTable} (question, current_answer, number_current_answers, total_ask_question) " +
                                $"SELECT '{questions[i].Text}', {questions[i].RightAnswer}, {questions[i].RightAnwerTotal}, {questions[i].AskTotal} " +
                                $"WHERE NOT EXISTS (SELECT 1 FROM {dbTable} WHERE question = '{questions[i].Text}');";

                DbProvider.PutData(databaseName, dbCommand);
            }
        }

        public void AddQuestion(Question newQestion)
        {
            var dbCommand = $"INSERT INTO {dbTable} (question, current_answer, number_current_answers, total_ask_question) " +
                            $"SELECT '{newQestion.Text}', {newQestion.RightAnswer}, 0, 0 " +
                            $"WHERE NOT EXISTS (SELECT 1 FROM {dbTable} WHERE question = '{newQestion.Text}');";

            DbProvider.PutData(databaseName, dbCommand);
        }

        public void RemoveQuestion(string removeQuestion)
        {
            var dbCommand = $"DELETE FROM {dbTable} WHERE question='{removeQuestion}';";

            DbProvider.PutData(databaseName, dbCommand);
        }

        public void Save(List<Question> questions)
        {
            string dbCommand = "";

            foreach (var question in questions)
            {
                dbCommand += $"UPDATE {dbTable} SET number_current_answers = number_current_answers + {question.RightAnwerTotal}, " +
                             $"total_ask_question = total_ask_question + 1 WHERE question = '{question.Text}';";
            }
            DbProvider.PutData(databaseName, dbCommand);
        }
    }
}