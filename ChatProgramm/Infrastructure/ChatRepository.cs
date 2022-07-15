using System;
using System.Text.Json;

namespace ChatProgramm
{
	public class ChatRepository
	{
		public Chat LoadChat (string path, User[] users)
		{
			var chatText = File.ReadAllText(path);
            var rawMessages = JsonSerializer.Deserialize<List<Message>>(chatText, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true});

            // CHAT
			var mainChat = new Chat(rawMessages.ToArray(), users);
            return mainChat;
		}
    }
}


