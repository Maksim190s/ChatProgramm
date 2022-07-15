using System;
namespace ChatProgramm
{
    public static class ConsoleUser
    {
        public static void DisplayEachUser(User[] users)
        {
            foreach (var user in users)
            {
                Console.Write($"Full Name:{user.FullName}, Nickname:{user.Nickname}\n");
            }
        }
    }
}

