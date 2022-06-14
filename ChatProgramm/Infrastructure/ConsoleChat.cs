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

	}

	public static class ConsoleUser
    {
		public static void DisplayEachUser(User[] users)
        {
			foreach (var user in users)
            {
                Console.WriteLine($"Full Name: {user.FullName}; Nickname: {user.Nickname}");
            }

        }
    }
	


}