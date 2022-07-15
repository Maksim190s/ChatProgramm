using System;
namespace ChatProgramm.Infrastructure
{
	public class Write
	{
		public static void Message(string path, string Nick, string Text, string Likes)
        {
			File.AppendAllText(path, $"</|> MESSAGE </|>\n{Nick}<+>{Text}<+>{Likes}\n");
        }

		

		
	}
}

