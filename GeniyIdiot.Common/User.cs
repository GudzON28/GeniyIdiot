using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name { get; set; }
        public int RightAnswer { get; set; }
        public string Diagnose { get; set; }

        [JsonConstructor]
        public User(string name) : this(name, 0)
        {
        }

        public User(string name, int rightAnswer) : this(name, rightAnswer, "Неизвестный диагноз")
        {
        }

        public User(string name, int rightAnswer, string diagnose)
        {
            Name = name;
            RightAnswer = rightAnswer;
            Diagnose = diagnose;
        }
    }
}