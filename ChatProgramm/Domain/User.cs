using System;
namespace ChatProgramm
{
	public record User(string FullName, DateTime DateOfBirth, string Nickname)
    {
        public int Id { get; set; }

       
      
       
    }	

}

