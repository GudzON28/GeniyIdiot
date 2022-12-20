using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class Question
    {
        public string Text { get; set; }
        public int RightAnswer { get; set; }
        public int RightAnwerTotal { get; set; }
        public int AskTotal { get; set; }
        public int IsAnswerCorrect { get; set; }

        [JsonConstructor]
        public Question(string text, int answer)
        {
            Text = text;
            RightAnswer = answer;
            RightAnwerTotal = 0;
            AskTotal = 0;
            IsAnswerCorrect = 0;
        }

        public Question(string text, int answer, int rightAnwerTotal, int askTotal)
        {
            Text = text;
            RightAnswer = answer;
            RightAnwerTotal = rightAnwerTotal;
            AskTotal = askTotal;
            IsAnswerCorrect = 0;
        }
    }
}