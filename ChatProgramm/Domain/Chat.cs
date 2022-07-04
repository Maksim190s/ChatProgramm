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

        
        
        
    }

}

