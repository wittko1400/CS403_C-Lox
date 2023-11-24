using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lox_Interpreter
{
    internal class LoxClass : ILoxCallable

    {
        public readonly string Name;

        private readonly Dictionary<string, LoxFunction> methods;
        //Maybe this works
        int ILoxCallable.Arity => throw new NotImplementedException();

        public LoxClass(string name, Dictionary<string, LoxFunction> methods)
        {
            this.Name = name;
            this.methods = methods;
        }
        public LoxFunction FindMethod(string name)
        {
            if (methods.ContainsKey(name))
            {
                return methods[name];
            }

            return null;
        }


        public override string ToString()
        {
            return Name;
        }
        public object Call(Interpreter interpreter, List<object> arguments)
        {
            LoxInstance instance = new LoxInstance(this);
            LoxFunction initializer = FindMethod("init");
            if (initializer != null)
            {
                initializer.Bind(instance).Call(interpreter, arguments);
            }

            return instance;
        }

        public int Arity()
        {
            LoxFunction initializer = FindMethod("init");
            if (initializer == null)
            {
                return 0;
            }

            return initializer.Arity;

        }

    }
}
