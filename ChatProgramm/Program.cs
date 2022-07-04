using ChatProgramm;
using ChatProgramm.Infrastructure;

if (args.Length == 0)
{
    Console.WriteLine("Invalid arg");
    return;
}
// infrastructure

var userRepository = new UserRepository();
var allUsers = userRepository.LoadUsers("/Users/menswear/Projects/ChatProgramm/ChatProgramm/DataBase/Users.txt");

var chatRepository = new ChatRepository();
var chat = chatRepository.LoadChat("/Users/menswear/Projects/ChatProgramm/ChatProgramm/DataBase/Chat.txt", allUsers);

var likeRepository = new LikeRepository();


// domain

var messagesOfFirstUser = chat.GetUserMessages(chat.Users[1]);
var allMessages = chat.Messages;

// infrastructure

/*
ConsoleChat.DisplayLongMessages(messagesOfFirstUser);

ConsoleUser.DisplayEachUser(allUsers);
ConsoleChat.DisplayChat(chat);

LikeRepository.AddLike(allUsers, allMessages);
*/



// Console Menue

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
