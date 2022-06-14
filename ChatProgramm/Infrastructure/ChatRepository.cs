using System;
using System.Collections.Generic;

namespace ChatProgramm
{
	public class ChatRepository
	{
		public Chat LoadChat (string path, User[] users)
		{
			var chatText = File.ReadAllText(path);
			var rawMessages = chatText.Split("</|> MESSAGE </|>");
			var messages = new List<Message>();
			foreach (var rawMessage in rawMessages)
            {
				var messageAttributes = rawMessage.Split("<+>");
				var user = FindUserByNickname(users, messageAttributes[0]);
				//var like = FindUserByNickname(users, messageAttributes[2]);
				var message = new Message(messageAttributes[1], user, new Like[0]);
				// В строке выше выдает "Index was outside the bounds of the array"
				messages.Add(message);
            }

			// CHAT
			var mainChat = new Chat(messages.ToArray(), users);
			return mainChat;
		}
		




		private User FindUserByNickname(User[] users, string nickname)
        {
			foreach (var user in users)
            {
				if (user.Nickname == nickname) return user;
            }
			return null;			
        }

       





    }
}

