using System;


namespace ChatProgramm
{
    public class LikeRepository
    {
        public static void AddLike(User[] users, Message[] messages)
        {
            
            var stringNickname = RequestOfAuthor();
            var author = FindUserByNickname(users, stringNickname);
            var like = ConvertUserToLike(author);
            var messagesUserView = GetMessagesUserUserView(messages);
            ShowMessageListWithIndexes(messages);
           
            
            var index = Int32.Parse(RequestOfMessageIndex());

            var newMessageList = DetectMessageAddLikeAndReturnList(index, messages, like);
            var last = GetMessagesUserUserView(newMessageList);

            File.WriteAllText("/Users/menswear/Projects/ChatProgramm/ChatProgramm/DataBase/Chat.txt", String.Join("",last));
        }

      

        private static string[] GetMessagesUserUserView(Message[] messages)
        {
            var stringArray = new List<string>();
            foreach (var m in messages)
            {
                var likes = new List<string>();
                foreach (var item in m.Like)
                {
                    if (item.Author != null)
                    {
                        likes.Add(item.Author.Nickname);
                    }
                }
                var arrLikes = likes.ToArray();

                var line = $"</|> MESSAGE </|>{m.Author.Nickname}<+>{m.Text}<+>{String.Join(",", arrLikes)}";
                stringArray.Add(line);
            }
            var list = stringArray.ToArray();
            return list;
        }
        
        private static Message[] DetectMessageAddLikeAndReturnList(int index, Message[] messages, Like like)
        {
            var list = new List<Message>();
            for (int i = 0; i < messages.Length; i++)
            {
                if (i == (index - 1))
                {  
                    if (messages[i].Like is null)
                    {
                        var newLikeList = new List<Like>();
                        newLikeList.Add(like);
                        var n = new Message(messages[i].Author, messages[i].Text, newLikeList.ToArray());
                        list.Add(n);
                        
                    }
                    else
                    {
                        var n = new Message(messages[i].Author, messages[i].Text, messages[i].Like.Append(like).ToArray());
                        list.Add(n);
                    }
                }
                else
                {
                    list.Add(messages[i]);
                }
            }
            return list.ToArray();
        }


        private static User FindUserByNickname(User[] users, string nickname)
        {
            foreach (var u in users)
            {
                if (u.Nickname == nickname) return u;
            }
            return null;
        }


        public static void ShowMessageListWithIndexes(Message[] messages)
        {
            var number = 1;
            for (int i = 0; i<messages.Length; i++)
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

        public static string RequestOfAuthor()
        {
            Console.WriteLine($"Enter author of like: ");
            var author = Console.ReadLine();
            return author;
        }

        public static string RequestOfMessageIndex()
        {
            Console.WriteLine($"Enter message index: ");
            var mesIndex = Console.ReadLine();
            return mesIndex;
        }

        private static Like ConvertUserToLike(User user)
        {
            var newLike = new Like(user);
            return newLike;
        }
    }
}