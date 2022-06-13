using ChatProgramm;
using ChatProgramm.Infrastructure;


// infrastructure

var userRepository = new UserRepository();
var allUsers = userRepository.LoadUsers("/Users/menswear/Projects/ChatProgramm/ChatProgramm/DataBase/Users.txt");

var chatRepository = new ChatRepository();
var chat = chatRepository.LoadChat("/Users/menswear/Projects/ChatProgramm/ChatProgramm/DataBase/Chat.txt", allUsers);


// domain
var messagesOfFirstUser = chat.GetUserMessages(chat.Users[0]);

var allLikes = chat.GetAllLikes();



// infrastructure
ConsoleChat.DisplayLongMessages(messagesOfFirstUser);

ConsoleUser.DisplayEachUser(allUsers);
