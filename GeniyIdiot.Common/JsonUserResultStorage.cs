using Newtonsoft.Json;

namespace GeniyIdiot.Common
{
    public class JsonUserResultStorage : IUserResultStorage
    {
        string fileName = "resultsGame.json";

        public void SaveResultTesting(User user)
        {
            var allUserResults = GetUserResults();
            allUserResults.Add(user);

            var jsonData = JsonConvert.SerializeObject(allUserResults, Formatting.Indented);
            FileProvider.Put(fileName, jsonData);
        }

        public List<User> GetUserResults()
        {
            if (FileProvider.Exist(fileName))
            {
                var fileData = FileProvider.Get(fileName);
                return JsonConvert.DeserializeObject<List<User>>(fileData);
            }

            return new List<User>();
        }
    }
}