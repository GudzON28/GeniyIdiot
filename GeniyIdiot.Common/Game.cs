namespace GeniyIdiot.Common
{
    public class Game
    {
        private static IQuestionStorage QuestionStorage = new JsonQuestionStorage();

        public static List<Question> GetQuestions()
        {
            return QuestionStorage.GetQuestions();
        }

        public static void AddRequiredQuestions()
        {
            QuestionStorage.AddRequiredQuestions();
        }

        public static void AddQuestion(Question newQestion)
        {
            QuestionStorage.AddQuestion(newQestion);
        }

        public static void RemoveQuestion(string removeQuestion)
        {
            QuestionStorage.RemoveQuestion(removeQuestion);
        }

        public static void Save(List<Question> questions)
        {
            QuestionStorage.Save(questions);
        }

        private static IUserResultStorage UserResultStorage = new JsonUserResultStorage();

        public static void SaveResultTesting(User user)
        {
            UserResultStorage.SaveResultTesting(user);
        }

        public static List<User> GetUserResults()
        {
            return UserResultStorage.GetUserResults();
        }

        public static List<User> SortingUsers(List<User> readedData)
        {
            var testingUsers = new List<User>();
            var filteredUsers = readedData.GroupBy(s => s.Name);
            int totalScore;

            foreach (var learnUser in filteredUsers)
            {
                totalScore = 0;

                foreach (var currentUser in learnUser)
                {
                    totalScore += currentUser.RightAnswer;
                }

                testingUsers.Add(new User(learnUser.Key, totalScore));
            }

            return testingUsers.OrderByDescending(n => n.RightAnswer).ToList();
        }

        public static void CheckRequaredQuestions()
        {
            var questions = GetQuestions();

            if (questions.Count == 0)
            {
                AddRequiredQuestions();
            }
        }

        public static string GetDiagnose(int questionsCount, int countRightAnswer)
        {
            var diagnoses = new List<string>();
            diagnoses.Add("Кретин");
            diagnoses.Add("Идиот");
            diagnoses.Add("Дурак");
            diagnoses.Add("Нормальный");
            diagnoses.Add("Талант");
            diagnoses.Add("Гений");

            double step = questionsCount / (diagnoses.Count - 1.0);
            int indexDiagnose = 0;
            double currentStep = 0;

            if (countRightAnswer < step)
            {
                return diagnoses[indexDiagnose];
            }
            else
            {
                while (countRightAnswer > currentStep)
                {
                    currentStep += step;
                    indexDiagnose++;
                }
            }

            return diagnoses[indexDiagnose];
        }

        public static List<int> GetRandomIndexes(int countQuestions)
        {
            List<int> outList = new List<int>();
            List<int> randomIdexes = GetIndexes(countQuestions);

            Random random = new();

            while (randomIdexes.Count != 0)
            {
                int tempInt = randomIdexes[random.Next(0, randomIdexes.Count - 1)];
                randomIdexes.Remove(tempInt);
                outList.Add(tempInt);
            }

            return outList;
        }

        static List<int> GetIndexes(int countQuestions)
        {
            List<int> outList = new List<int>();

            for (int i = 0; i < countQuestions; i++)
            {
                outList.Add(i);
            }
            return outList;
        }
    }
}
