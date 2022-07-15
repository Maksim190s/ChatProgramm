using System;
namespace ChatProgramm.Infrastructure
{

	public static class ConsoleChat
	{
		public static void DisplayLongMessages(Message[] messages)
		{
			foreach (var message in messages)
			{
				Console.WriteLine($"{message.Author}: {message.Text}");
			}
		}

        public static void DisplayChat(Chat chat)
        {
            var messages = chat.Messages;
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
                Console.WriteLine($"{messages[i].Author.Nickname}: {messages[i].Text}. Likes:{String.Join(",", likes.ToArray())}");
            }
        }

    }
}

