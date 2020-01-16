using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeginningCsharp {
    public enum TokenType {
        EOF,
        Quoted,
        Unquoted,
    }

    public class Token {
        public string contents;
        public TokenType type;
        public Token(TokenType type, string contents) {
            this.contents = contents;
            this.type = type;
        }
        public override string ToString() => type switch
        {
            TokenType.EOF => "EOF",
            TokenType.Quoted => "\"" + contents + "\"",
            _ => contents,
        };
    }

    class Exercise40_CSVFiles {
        public static void Run() {//This one is overkill, but in a real application it would be far more useful, because it can be expanded more easily, and gives useful tokens which you can work with
            for(string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                var lexer = new CSVLexer(input);
                Token t = lexer.GetNextToken();
                var tokens = new List<Token>();
                while (t.type != TokenType.EOF) {
                    tokens.Add(t);
                    Console.WriteLine(t);
                    t = lexer.GetNextToken();
                }
                Console.WriteLine(string.Join(';', tokens));
            }
        }

        public static void Run_Simple() {//This one is very simple, and completes the task, but it's not very useful
            for (string input = Console.ReadLine(); input != "#"; input = Console.ReadLine()) {
                bool quoted = false;
                char[] output = new char[input.Length];
                for (int i = 0; i < input.Length; i++) {
                    if(input[i] == '\"')
                        quoted = !quoted;
                    output[i] = !quoted && input[i] == ',' ? ';' : input[i];
                }
                Console.WriteLine(new string(output));
            }
        }
    }

    public class CSVLexer {//This is way overkill for this lab, but it's a fun little glipse of compiler theory
        public int pos;
        public int nestDepth;
        public string text;
        public char? currentChar;

        public CSVLexer(string text) {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException("text", "Text must have a value");
            this.text = text;
            pos = 0;
            currentChar = text.Length > 0 ? (char?)text[0] : null;
            nestDepth = currentChar.HasValue && text[pos] == '\"' ? 1 : 0;
        }

        public void Advance() {
            if (pos + 1 < text.Length)
                currentChar = text[++pos];
            else
                currentChar = null;
        }

        void SkipWhitespace() {
            while (currentChar == ' ')
                Advance();
        }

        Token GetQuoted() {
            Advance();
            string result = "";
            while (currentChar != null && currentChar != '\"') {
                result += currentChar;
                Advance();
            }
            Advance();
            return new Token(TokenType.Quoted, result);
        }

        Token GetUnquoted() {
            SkipWhitespace();
            if (currentChar == ',') {
                Advance();
                SkipWhitespace();
            }
            string result = "";
            while (currentChar != null && currentChar != ',') {
                result += currentChar;
                Advance();
            }
            Advance();
            return new Token(TokenType.Unquoted, result);
        }

        public Token GetNextToken() {
            SkipWhitespace();
            return currentChar switch
            {
                null => new Token(TokenType.EOF, ""),
                '\"' => GetQuoted(),
                _ => GetUnquoted()
            };
        }
    }
}
