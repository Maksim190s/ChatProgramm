using System;
namespace ChatProgramm.Interface
{
	public interface IUserRepository
	{
		User[] LoadUsers();
	}
}

