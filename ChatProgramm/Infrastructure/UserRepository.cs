using System;
using System.Collections.Generic;

namespace ChatProgramm
{
    public class UserRepository
    {
        public User[] LoadUsers(string path)
        {
            var userText = File.ReadAllText(path);
            var rawUsers = userText.Split("</|> USER </|>");
            var user= new List<User>();
            foreach (var rawUser in rawUsers)
            {
                
                string[] userAttributes = rawUser.Split("<+>");
                var u = new User(userAttributes[0], new DateTime(), userAttributes[2]);
                user.Add(u);
                
            }
            return user.ToArray();
        }


        

    }
   
}

