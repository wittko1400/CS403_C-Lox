﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lox_Interpreter
{
    class GenerateAst
    {
        /*static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("Usage: generate_ast <output directory>");
                System.Environment.Exit(64);
            }
            string outputDir = args[0];
            DefineAst(outputDir, "Expr", new List<string> {
            "Assign   : Token name, Expr value",
            "Binary   : Expr Left, Token Operator, Expr Right",
            "Call     : Expr callee, Token paren, List<Expr> arguments",
            "Get      : Expr object, Token name",
            "Grouping : Expr Expression",
            "Literal  : object Value",
            "Logical  : Expr left, Token operator, Expr right",
            "Set      : Expr object, Token name, Expr value",
            "This     : Token keyword",
            "Unary    : Token Operator, Expr Right",
            "Variable : Token name"
            });
            DefineAst(outputDir, "Stmt", new List<string> {
            "Block      : List<Stmt> statements",
            "Class      : Token name, List<Stmt.Function> methods",
            "Expression : Expr expression",
            "Function   : Token name, List<Token> params," +
                        " List<Stmt> body",
            "If         : Expr condition, Stmt thenBranch," +
                        " Stmt elseBranch",
            "Print      : Expr expression",
            "Return     : Token keyword, Expr value",
            "Var        : Token name, Expr initializer",
            "While      : Expr condition, Stmt body"
            });

        }*/
        private static void DefineAst(string outputDir, string baseName, List<string> types)
        {
            string path = Path.Combine(outputDir, baseName + ".cs");
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("namespace Lox_Interpreter");
                writer.WriteLine("{");
                writer.WriteLine("    using System.Collections.Generic;");
                writer.WriteLine();
                writer.WriteLine($"    abstract class {baseName}");
                writer.WriteLine("    {");
                DefineVisitor(writer, baseName, types);
                writer.WriteLine();
                // The AST classes.
                foreach (string type in types)
                {
                    string className = type.Split(':')[0].Trim();
                    string fields = type.Split(':')[1].Trim();
                    DefineType(writer, baseName, className, fields);
                }
                // The base Accept() method.
                writer.WriteLine();
                writer.WriteLine("  public abstract R Accept<R>(IVisitor<R> visitor);");
                writer.WriteLine("    }");
                writer.WriteLine("}");
            }
        }
        private static void DefineType(
        StreamWriter writer, string baseName,
        string className, string fieldList)
        {
            writer.WriteLine($"  public class {className} : {baseName}");
            writer.WriteLine("  {");

            // Constructor.
            writer.WriteLine($"    public {className}({fieldList})");
            writer.WriteLine("    {");

            // Store parameters in fields.
            string[] fields = fieldList.Split(", ");
            foreach (string field in fields)
            {
                string name = field.Split(' ')[1];
                writer.WriteLine($"      this.{name} = {name};");
            }

            writer.WriteLine("    }");
            // Visitor pattern.
            writer.WriteLine();
            writer.WriteLine("    public override R Accept<R>(IVisitor<R> visitor)");
            writer.WriteLine("    {");
            writer.WriteLine($"      return visitor.Visit{className}{baseName}(this);");
            writer.WriteLine("    }");

            // Fields.
            writer.WriteLine();
            foreach (string field in fields)
            {
                writer.WriteLine($"    public readonly {field};");
            }

            writer.WriteLine("  }");
        }
        private static void DefineVisitor(
        StreamWriter writer, string baseName, List<string> types)
        {
            writer.WriteLine("  public interface IVisitor<R>");
            writer.WriteLine("  {");

            foreach (string type in types)
            {
                string typeName = type.Split(':')[0].Trim();
                writer.WriteLine($"    R Visit{typeName}{baseName}({typeName} {baseName.ToLower()});");
            }

            writer.WriteLine("  }");
        }


    }
}
