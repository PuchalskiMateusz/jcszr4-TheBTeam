using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TheBTeam.BLL.DAL.Entities;
using TheBTeam.BLL.Models;

namespace TheBTeam.BLL.Services

{
    public class LoadDataFromFile
    {
        public static List<User> ReadUserFile()
        {
            string fileName = @"SourceFiles\users.json";

            string jsonString = File.ReadAllText(fileName);
            List<User> userData = JsonConvert.DeserializeObject<List<User>>(jsonString);
            return userData;
        }
    }
}
