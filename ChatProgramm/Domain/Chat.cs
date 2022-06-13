using System;
namespace ChatProgramm
{
    public record Chat(Messages[] Message, User[] Users)
    {
        public static void ShowAllMessages(Messages[] Message)
        {
            foreach (var mes in Message)
            {
                Console.WriteLine($"{mes.ShowMessage}");
            }
        }
    }

}

