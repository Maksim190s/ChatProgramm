using ChatProgramm;


// USERS

User tim = new User("Timothee", new DateOnly(1990, 04, 19), "Tim");
User john = new User("John Smith", new DateOnly(1989, 09, 11), "John");
User mey = new User("Mey Mey", new DateOnly(1975, 08, 01), "JustM");

User[] users = new User[] { tim, john, mey };



// MESSAGES
var path1 = "/Users/menswear/Desktop/ChatProgramm/message1.txt";
var path2 = "/Users/menswear/Desktop/ChatProgramm/message2.txt";
var path3 = "/Users/menswear/Desktop/ChatProgramm/message3.txt";
var path4 = "/Users/menswear/Desktop/ChatProgramm/message4.txt";
var path5 = "/Users/menswear/Desktop/ChatProgramm/message5.txt";

Messages message0 = new Messages(path1, tim);
Messages message1 = new Messages(path2, mey);
Messages message3 = new Messages(path3, tim);
Messages message4 = new Messages(path4, john);
Messages message5 = new Messages(path5, mey);
Messages[] allMessages = new Messages[] { message0, message1, message3, message4, message5 };


// LIKES
Like like1 = new Like(message0, mey);
Like like2 = new Like(message4, tim);
Like like3 = new Like(message1, john);
Like like4 = new Like(message3, tim);
Like[] likes = new Like[] { like1, like2, like3, like4 };


// CHAT
Chat MainChat = new Chat(allMessages, users);



//Requests 
Messages.ShowAllMessages(allMessages);


Messages.ShowMessagesByUser(allMessages, mey);


message4.ShowMessage();



Like.LikeItBy(message0, mey);



Like.ShowLikesByUser(likes, mey);
// Не понимаю, что нужно сделать, чтоб нормальный результат вышел.
//Это похоже на "System.Int32[]".