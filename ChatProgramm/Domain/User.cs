using System;
namespace ChatProgramm
{
	public record User(string FullName, DateTime DateOfBirth, string Nickname)
    {
        //private DateTime DateOfBirth { get; init; } = DateOfBirth;
        /*
        public bool IsLeagalAge()
        {
            var now = DateTime.Now;
            var age = now - DateOfBirth;
            return age.Days > (365 * 18);
        }
        */

      
       
    }	

}

