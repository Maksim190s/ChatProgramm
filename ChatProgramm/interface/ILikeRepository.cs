using System;
namespace ChatProgramm.Interface
{
	public interface ILikeRepository
	{
        void DeleteLikesOfUserWhoLeftTheChat(Chat chat, Like like);

    }
}

