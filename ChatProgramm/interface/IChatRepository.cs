using System;
namespace ChatProgramm.Interface
{
	public interface IChatRepository
	{
		Chat LoadChat(User[] users);
		//test
	}
}

