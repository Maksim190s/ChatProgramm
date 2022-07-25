﻿using System;
namespace ChatProgramm
{
    public record Chat(Message[] Messages, User[] Users)
    {
        public Message[] GetUserMessages(User user)
        {
            var filteredMessages = new List<Message>();
            foreach (var message in Messages)
            {
                if (message.Author == user)
                {
                    filteredMessages.Add(message);
                }
            }
            return filteredMessages.ToArray();
        }

        public void AddNewMessage(Message message)
        {
            var newList = new List<Message>();
            foreach (var m in Messages)
            {
                newList.Add(m);
            }
            newList.Add(message);
        }

        public void AddNewLike(Like like)
        {
            for (int i = 0; i < Messages.Length; i++)
            {
                if (i == like.Index)
                {
                    Messages[i].Like.Append(like);
                }
            }
        }
    }
}

