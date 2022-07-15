using System;
using System.Text.Json;

namespace ChatProgramm.Infrastructure
{
	public static class Write
	{
		public static void Chat(string pathToFile, Chat chat )
        {
            var serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true };
            var serializedChat = JsonSerializer.Serialize(chat, serializerOptions);
            File.WriteAllText("DataBase/Users.json", serializedChat);
        }

        public static void Users(string pathToFile, User[] users)
        {
            var serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true };
            var serializedUsers = JsonSerializer.Serialize(users, serializerOptions);
            File.WriteAllText(pathToFile, serializedUsers);
        }




    }
}

