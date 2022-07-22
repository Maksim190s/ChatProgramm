using ChatProgramm;
using ChatProgramm.Infrastructure;
using System.Text.Json;



// infrastructure

var userRepository = new UserRepository("DataBase/Users.json");
var chatRepository = new ChatRepository("DataBase/Chat.json");
var create = new Create();


// domain

var allUsers = userRepository.LoadUsers();
var chat = chatRepository.LoadChat(allUsers);
//var allMessages = chat.Messages;
var usersFromChat = chat.Users;
ConsoleUser.DisplayEachUser(usersFromChat);
//var newMessage = create.NewMessageByUser(allUsers);
//var newLike = create.NewLikeForMessage(allMessages, allUsers);


// infrastructure
//chat.AddNewMessage(newMessage);
//chat.AddNewLike(newLike);

//Write.Chat("DataBase/Chat.json", chat);
//Write.Users("DataBase/Users.json", allUsers);