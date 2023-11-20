using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Lox_Interpreter
{
    class Lox
    {
        private static bool HadError = false;

        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Usage: clox [script]");
                Environment.Exit(64);
            }
            else if (args.Length == 1)
            {
                RunFile(args[0]);
            }
            else
            {
                RunPrompt();
            }
        }

        static void RunFile(string path)
        {
            var bytes = File.ReadAllBytes(path);
            Run(Encoding.UTF8.GetString(bytes));
            // Indicate an error in the exit code.
            if (HadError) Environment.Exit(65);
        }

        static void RunPrompt()
        {
            while (true)
            {
                Console.Write("> ");
                var line = Console.ReadLine();
                if (line == null) break;
                Run(line);
                HadError = false;
            }
        }

        static void Run(string source)
        {
            // Implementation of your interpreter logic goes here
            // This is where you process and execute the source code

            
            // SCANNER TEST
            Scanner scanner = new Scanner(source);
            List<Token> tokens = scanner.ScanTokens();

            // Print the parsed tokens
            foreach (Token token in tokens)
            {
                Console.WriteLine(token);
            }
            
        }

        internal static void Error(int line, string message)
        {
            Report(line, "", message);
        }

        private static void Report(int line, string where, string message)
        {
            Console.Error.WriteLine($"[line {line}] Error{where}: {message}");
            HadError = true;
        }

    }
}