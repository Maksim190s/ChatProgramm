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

      
        private User FindUserByNickname(User[] users, string nickname)
        {
			foreach(var u in users)
            {
				if (u.Nickname == nickname) return u; 
            }
			return null;
        }

		Like[] DetectLikes(User[] users, string likes)
        {
            var likesSep = likes.Split(',');
            var whoLiked = new List<User>();
            foreach (var l in likesSep)
            {
                var usersWhoLike = FindUserByNickname(users, l);
                whoLiked.Add(usersWhoLike);
            }
            var likeAuthors = ConvertUserToLike(whoLiked.ToArray());
            return likeAuthors;
        }

        private Like[] ConvertUserToLike(User[] users)
        {
            if (users != null)
            {
                var likeList = new List<Like>();
                foreach (var u in users)
                {
                    var like = new Like(u);
                    likeList.Add(like);
                }
                return likeList.ToArray();
            }
            return null;

            
	
        }
    }
}


