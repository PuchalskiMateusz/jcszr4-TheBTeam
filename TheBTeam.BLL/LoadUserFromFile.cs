﻿using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TheBTeam.BLL
{
    public class LoadUserFromFile
    {
        public static List<User> ReadUserFile()
        {
            string fileName = "users.json";
            string jsonstring = File.ReadAllText(fileName);
            List<User> userData = JsonConvert.DeserializeObject<List<User>>(jsonstring);
            Console.WriteLine(userData[1].Balance);
            return userData;
        }

    }
}
