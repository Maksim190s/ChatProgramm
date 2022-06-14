using System;
using System.Collections.Generic;

namespace ChatProgramm
{
	public class UserRepository
	{
        /* По аналогии с загрузкой чата сделал выгрузку Юзеров.
        В 19 строке выдвет такую же ошибку как в "LoadChat". "Index was outside the bounds of the array"
        В итоге, я даже не могу проверить, работает программа или нет*/
        public User[] LoadUsers(string path)
        {
            var userText = File.ReadAllText(path);
            var rawUsers = userText.Split("</|> USER </|>");
            var users = new List<User>();
            foreach (var rawUser in rawUsers)
            {
                var userAttributes = rawUser.Split("<+>");
                var user = new User(userAttributes[0], new DateTime(), userAttributes[1]);
                users.Add(user);

            }
            return users.ToArray();
        }




    }
   
}

