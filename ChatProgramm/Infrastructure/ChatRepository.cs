using System;
using System.Linq;
using System.Text.Json;
using ChatProgramm.Interface;

namespace ChatProgramm
{
	public class ChatRepository : IChatRepository
	{
		private string _filePath;

		public ChatRepository(string filePath)
        {
			this._filePath = filePath;
        }

        public Chat LoadChat (User[] allUsers)
		{
			var chatText = File.ReadAllText(_filePath);
            var chatDto = JsonSerializer.Deserialize<ChatDto>(chatText, new JsonSerializerOptions { PropertyNameCaseInsensitive = true, WriteIndented = true });
            var chatUsers = new List<User>();
            foreach(var userId in chatDto.UserIds)
            {
                chatUsers.Add(GetById(userId, allUsers));
            }
            
			
            var messages = new List<Message>();
			foreach (var messageDto in chatDto.Messages)
			{
				
                var likes = new List<Like>();
                foreach (var l in messageDto.Like)
                {
                    likes.Add(new Like(GetById(l.AuthorId, allUsers)));
                }
                messages.Add(new Message(GetById(messageDto.AuthorId, allUsers), messageDto.Text, likes.ToArray()));
            }

			var mainChat = new Chat(messages.ToArray(), chatUsers.ToArray());
			return mainChat;
		}


        private User GetById(int Id, User[] allUsers)
        {
            foreach (var user in allUsers)
            {
                if (user.Id == Id)
                {
                    return user;
                }
            }
            return null;
        }
    }

    record ChatDto(MessageDto[] Messages, int[] UserIds);
    record MessageDto(int AuthorId, string Text, LikeDto[] Like);
    record LikeDto(int AuthorId);
}


