using System;
namespace ChatProgramm
{
    public record Chat(Message[] Messages, User[] Users)
    {
        public Message[] GetUserMessages(User user)
        {
            var filteredMessages = new List<Message>();
            foreach (var message in Messages)
            {
                if (message.Author == user)
                {
                    filteredMessages.Add(message);
                }
            }
            return filteredMessages.ToArray();
        }

        //
        public Like[] GetAllLikes()
        {
            var allLikes = new List<Like>();
            foreach (var m in Messages)
            {
                if (m.Likes != null) allLikes.Add(m.Likes);
            }
            return allLikes.ToArray();
        }


    }

}

