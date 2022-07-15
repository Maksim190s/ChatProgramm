using ChatProgramm;
using ChatProgramm.Infrastructure;
using System.Text.Json;



// infrastructure

var userRepository = new UserRepository();
var chatRepository = new ChatRepository();
var create = new Create();


// domain

var allUsers = userRepository.LoadUsers("DataBase/Users.json");
var chat = chatRepository.LoadChat("DataBase/Chat.json", allUsers);
var allMessages = chat.Messages;

var newMessage = create.NewMessageByUser(allUsers);
var newLike = create.NewLikeForMessage(allMessages, allUsers);


// infrastructure
chat.AddNewMessage(newMessage);
chat.AddNewLike(newLike);

Write.Chat("DataBase/Chat.json", chat);
Write.Users("DataBase/Users.json", allUsers);