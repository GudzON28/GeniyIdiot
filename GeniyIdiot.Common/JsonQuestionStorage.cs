using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class JsonQuestionStorage : IQuestionStorage
    {
        static string fileName = "questions.json";

        public List<Question> GetQuestions()
        {
            if (!FileProvider.Exist(fileName))
            {
                return new List<Question>();
            }

            var fileData = FileProvider.Get(fileName);
            return JsonConvert.DeserializeObject<List<Question>>(fileData);
        }

        public void AddRequiredQuestions()
        {
            List<Question> questions = new List<Question>();

            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
            questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

            Save(questions);
        }

        public void AddQuestion(Question newQestion)
        {
            var questions = GetQuestions();
            questions.Add(newQestion);
            Save(questions);
        }

        public void RemoveQuestion(string removeQuestion)
        {
            var questions = GetQuestions();

            foreach (var question in questions)
            {
                if (question.Text == removeQuestion)
                {
                    questions.Remove(question);
                    break;
                }
            }

            Save(questions);
        }

        public void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Put(fileName, jsonData);
        }
    }
}