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
        public readonly LoxClass Superclass;

        private readonly Dictionary<string, LoxFunction> methods;
        //Maybe this works
        //int ILoxCallable.Arity => throw new NotImplementedException();

        public LoxClass(string name, LoxClass superclass, Dictionary<string, LoxFunction> methods)
        {
            this.Name = name;
            this.Superclass = superclass;
            this.methods = methods;
        }
        public LoxFunction FindMethod(string name)
        {
            if (methods.ContainsKey(name))
            {
                return methods[name];
            }
            if (Superclass != null)
            {
                return Superclass.FindMethod(name);
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

        public int Arity => FindMethod("init")?.Arity ?? 0;

    }
}
