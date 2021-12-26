using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using TheBTeam.BLL.DAL.Entities;
using TheBTeam.BLL.Models;

namespace TheBTeam.BLL.Services

{
    public class LoadDataFromFile
    {
        public static List<UserDto> ReadUserFile()
        {
            string fileName = @"SourceFiles\users.json";

            string jsonString = File.ReadAllText(fileName);
            List<UserDto> userData = JsonConvert.DeserializeObject<List<UserDto>>(jsonString);
            return userData;
        }
        public static List<User> ReadDalUserFile()
        {
            string fileName = @"SourceFiles\users.json";

            string jsonString = File.ReadAllText(fileName);
            List<User> userData = JsonConvert.DeserializeObject<List<User>>(jsonString);
            return userData;
        }
    }
    
}
