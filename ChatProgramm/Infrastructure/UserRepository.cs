using System;
using System.Collections.Generic;
using System.Text.Json;
using ChatProgramm.Interface;

namespace ChatProgramm
{
    public class UserRepository : IUserRepository
    {
        private string _filePath;

        public UserRepository(string filePath)
        {
            this._filePath = filePath;
        }

        public User[] LoadUsers()
        {
            var userText = File.ReadAllText(_filePath);
            var users = JsonSerializer.Deserialize<List<User>>(userText, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
            var allUsers = new List<User>();
            foreach (var user in users)
            {
                allUsers.Add(new User(user.FullName, user.DateOfBirth, user.Nickname));
            }
            return allUsers.ToArray();
        }
    }
        //record UserDto (string FullName, DateTime DateOfBirth, string Nickname);
}

