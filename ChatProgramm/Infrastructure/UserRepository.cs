using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ChatProgramm
{
    public class UserRepository
    {
        private string _filePath;

        public UserRepository(string filePath)
        {
            this._filePath = filePath;
        }

        public User[] LoadUsers()
        {
            // domain

            var userText = File.ReadAllText(_filePath);
            var users = JsonSerializer.Deserialize<List<UserDto>>(userText, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
            var allUsers = new List<User>();
            foreach (var user in users)
            {
                allUsers.Add(new User(user.FullName, user.DateOfBirth, user.Nickname));
            }
            return allUsers.ToArray();
        }
    }
        record UserDto (string FullName, DateTime DateOfBirth, string Nickname);
}

