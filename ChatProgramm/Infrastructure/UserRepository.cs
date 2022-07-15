using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ChatProgramm
{
    public class UserRepository
    {
        public User[] LoadUsers(string path)
        {
            var userText = File.ReadAllText(path);
            var users = JsonSerializer.Deserialize<List<User>>(userText, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
            var mmmmmmm = users.ToArray().Count();
            return users.ToArray();
        }
    }
}

