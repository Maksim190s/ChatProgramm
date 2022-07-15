using System;
using ChatProgramm;

namespace ChatProgramm
{
    public record Like(User Author)
    {
        public int Index { get; set; }
    }
    
}

