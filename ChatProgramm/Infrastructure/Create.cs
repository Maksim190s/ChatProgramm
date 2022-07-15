using System;
namespace ChatProgramm.Infrastructure
{
    public class Create
    {
        
        public Message NewMessageByUser(User[] users)
        {
            var nickname = RequestFor("Author: ");
            var text = RequestFor("Enter a message: ");
            var user = FindUserByNickname(users, nickname);
            var mes = new Message(user, text, new Like[0]);
            return mes;
        }

        public Like NewLikeForMessage(Message[] messages, User[] users)
        {
            var author = FindUserByNickname(users, RequestFor("Enter author of like: "));
            ShowMessageListWithIndexes(messages);
            var indexOfMessage = Convert.ToInt32(RequestFor("Enter index of message: ")) - 1;
            var newLike = new Like(author);
            newLike.Index = indexOfMessage;
            return newLike;
        }



        //additional

        public string RequestFor(string requestLineForConsole)
        {
            Console.WriteLine(requestLineForConsole);
            return Console.ReadLine();
        }

        private User FindUserByNickname(User[] users, string n)
        {
            foreach (var u in users)
            {
                if (u.Nickname == n) return u;
            }
            return null;
        }

        public void ShowMessageListWithIndexes(Message[] messages)
        {
            var number = 1;
            for (int i = 0; i < messages.Length; i++)
            {
                var likes = new List<string>();
                foreach (var l in messages[i].Like)
                {
                    if (l.Author != null)
                    {
                        likes.Add(l.Author.Nickname);
                    }
                }
                Console.WriteLine($"[{number}] - {messages[i].Author.Nickname}: {messages[i].Text}. Likes:{String.Join(",", likes.ToArray())}");
                number = number + 1;
            }
        }
 
    }

}

