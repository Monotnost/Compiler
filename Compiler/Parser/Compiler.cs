using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Compiler
{
    public static class Compiler
    {
        private static bool IntegerCheck(string token)
        {
            return Regex.IsMatch(token, @"^[0-9]+$");
        }
        private static bool AssignmentCheck(string token)
        {
            return token == ":=";
        }
        private static bool KeywordCheck(string token)
        {
            List<string> keywords = new List<string>() {"if", "then", "else", "or", "and", "xor"};
            return keywords.Contains(token);
        }

        private static bool DividerCheck(string token)
        {
            List<string> dividers = new List<string>() {"(", ")", ";"};
            return dividers.Contains(token);
        }
        private static bool IdentifierCheck(string token)
        {
            return Regex.IsMatch(token, @"^[a-zA-z]+[a-zA-z0-9]*$");
        }
        private static string TokenType(string token)
        {
            if (KeywordCheck(token)) return "keyword";
            if (DividerCheck(token)) return "divider";
            if (AssignmentCheck(token)) return "assignment character";
            if (IntegerCheck(token)) return "integer";
            if (IdentifierCheck(token)) return "identifier";
            return "null";
        }

        public static List<Token> TokensOut(string text)
        {
            var tokens = new List<Token>();
            var regex = new Regex(@"\w+|:=|\(|\)|;");
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                var type = TokenType(match.Value);
                tokens.Add(new Token(match.Value, type, match.Index));
            }

            return tokens;
        }
    }
}