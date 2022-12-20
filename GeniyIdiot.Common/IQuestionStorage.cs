namespace GeniyIdiot.Common
{
    public interface IQuestionStorage
    {
        List<Question> GetQuestions();
        void AddRequiredQuestions();
        void AddQuestion(Question newQestion);
        void RemoveQuestion(string removeQuestion);
        void Save(List<Question> questions);
    }
}