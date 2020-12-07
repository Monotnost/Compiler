using System;

namespace Compiler
{
    public class Token
    {
        public string Value;
        public string Type;
        public int Position;

        public Token(string value, string type, int position)
        {
            Value = value;
            Type = type;
            Position = position;
        }

        public override string ToString()
        {
            return $"{this.Value} --- {Type}";
        }
    }
}