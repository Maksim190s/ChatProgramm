using ChatProgramm;
using ChatProgramm.Infrastructure;
using System.Text.Json;
/*
if (args.Length == 0)
{
    Console.WriteLine("Invalid arg");
    return;
}
*/


// infrastructure

var userRepository = new UserRepository();
var chatRepository = new ChatRepository();



// domain

var allUsers = userRepository.LoadUsers("DataBase/Users.json");

var chat = chatRepository.LoadChat("DataBase/Chat.json", allUsers);
/*
var messagesOfFirstUser = chat.GetUserMessages(allUsers[3]);
var newMessage = Create.NewMessage();
chat.AddNewMessage(newMessage);
var newLike = Create.NewLike();
*/

// infrastructure

/*
ConsoleChat.DisplayLongMessages(messagesOfFirstUser);

ConsoleUser.DisplayEachUser(allUsers);
ConsoleChat.DisplayChat(chat);

LikeRepository.AddLike(allUsers, allMessages);
*/



// Console Menue
/*
var command = args[0];

switch (command)
{
    case "displayChat":
        DisplayWholeChat();
        break;
    case "addMessage":
        AddNewMessage();
        break;
    case "findUserMessages" when args.Length == 2:
        FindUserMessages(args[2]);
        break;
    case "addLike":
        LikeRepository.AddLike(allUsers, allMessages);
        break;
    default:
        break;


}

void DisplayWholeChat()
{
    ConsoleChat.DisplayChat(chat);
}

void AddNewMessage()
{
    ConsoleChat.AddMessage();
}
void FindUserMessages(string s)
{
    var u = FindUserByNickname(allUsers, s);
    ConsoleChat.DisplayLongMessages(chat.GetUserMessages(u));
}
User FindUserByNickname(User[] users, string nickname)
{
    foreach (var u in users)
    {
        if (u.Nickname == nickname) return u;
    }
    return null;
}
*/