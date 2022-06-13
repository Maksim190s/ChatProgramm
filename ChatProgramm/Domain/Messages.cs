using System;
namespace ChatProgramm
{
    public record Messages(string pathToText, User User)
    {

        public string GetText(string pathToText)
        {
            string text = File.ReadAllText(pathToText);
            return text;
        }



        public static void ShowMessagesByUser(Messages[] allMessages, User user)
        {
            foreach (var message in allMessages)
            {
                var (path, author) = message;
                if (author == user)
                {
                    Console.WriteLine($"{user.Nickname}: {message.GetText(path)}");
                }
            }
        }




        public void ShowMessage()
        { 
            Console.WriteLine($"{User.Nickname}: {File.ReadAllText(pathToText)}");
        }


        public static void ShowAllMessages(Messages[] Messages)
        {
            foreach (var message in Messages)
            {
                var (pathToText, user) = message;
                Console.WriteLine($"{user.Nickname}: {message.GetText(pathToText)}");
                //Console.WriteLine($"{message.ShowMessage}");
            }
        }
    }
}

