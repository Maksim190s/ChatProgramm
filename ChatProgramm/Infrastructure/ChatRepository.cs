using System;
using System.Linq;
using System.Text.Json;

namespace ChatProgramm
{
	public class ChatRepository
	{
		public Chat LoadChat (string path, User[] users)
		{
			var chatText = File.ReadAllText(path);
            var chat = JsonSerializer.Deserialize<Chat>(chatText, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true});
			foreach(var u in users)
            {
                chat.Users.Append(users);
            }
			
			return chat;
		}
    }
}


