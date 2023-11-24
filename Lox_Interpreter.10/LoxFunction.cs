using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lox_Interpreter
{
    public class LoxFunction : ILoxCallable
    {
        private readonly Stmt.Function declaration;
        private readonly EnvironmentLox closure;
        public LoxFunction(Stmt.Function declaration, EnvironmentLox closure)
        {
            this.closure = closure;
            this.declaration = declaration;
        }

        public object Call(Interpreter interpreter, List<object> arguments)
        {
            EnvironmentLox environment = new EnvironmentLox(closure);

            for (int i = 0; i < declaration.Parameters.Count; i++)
            {
                environment.Define(declaration.Parameters[i].Lexeme, arguments[i]);
            }

            try
            {
                interpreter.ExecuteBlock(declaration.Body, environment);
            }
            catch (Return returnValue)
            {
                return returnValue.Value;
            }

            return null;
        }
        public int Arity => declaration.Parameters.Count;
        public override string ToString()
        {
            return $"<fn {declaration.Name.Lexeme}>";

        }

    }
}
