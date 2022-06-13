using System;
namespace ChatProgramm
{
	public record User(string FullName, DateOnly DateOfBirth, string Nickname)
    {
        internal DateOnly DateOfBirth { get; init; } = DateOfBirth;
        internal string FullName { get; init; } = FullName;
    }	
		
}

