using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lox_Interpreter
{
    public abstract class Expr
    {
        public interface IVisitor<R>
        {
            R VisitAssignExpr(Assign expr);
            R VisitBinaryExpr(Binary expr);
            R VisitCallExpr(Call expr);
            //R VisitGetExpr(Get expr);
            R VisitGroupingExpr(Grouping expr);
            R VisitLiteralExpr(Literal expr);
            R VisitLogicalExpr(Logical expr);
            //R VisitSetExpr(Set expr);
            //R VisitSuperExpr(Super expr);
            //R VisitThisExpr(This expr);
            R VisitUnaryExpr(Unary expr);
            R VisitVariableExpr(Variable expr);
        }

        // Nested Expr classes here...
        
        public class Assign : Expr
        {
            public Assign(Token name, Expr value)
            {
                this.Name = name;
                this.Value = value;
            }

            public Token Name { get; }
            public Expr Value { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitAssignExpr(this);
            }
        }
        public class Binary : Expr
        {
            public Binary(Expr left, Token @operator, Expr right)
            {
                this.Left = left;
                this.Operator = @operator;
                this.Right = right;
            }

            public Expr Left { get; }
            public Token Operator { get; }
            public Expr Right { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitBinaryExpr(this);
            }
        }
        
        public class Call : Expr
        {
            public Call(Expr callee, Token paren, List<Expr> arguments)
            {
                this.Callee = callee;
                this.Paren = paren;
                this.Arguments = arguments;
            }

            public Expr Callee { get; }
            public Token Paren { get; }
            public List<Expr> Arguments { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitCallExpr(this);
            }
        }
        
        /*
        public class Get : Expr
        {
            public Get(Expr obj, Token name)
            {
                Object = obj;
                Name = name;
            }

            public Expr Object { get; }
            public Token Name { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitGetExpr(this);
            }
        }
        */
        public class Grouping : Expr
        {
            public Grouping(Expr expression)
            {
                Expression = expression;
            }

            public Expr Expression { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitGroupingExpr(this);
            }
        }
        public class Literal : Expr
        {
            public Literal(object value)
            {
                Value = value;
            }

            public object Value { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitLiteralExpr(this);
            }
        }
        
        public class Logical : Expr
        {
            public Logical(Expr left, Token @operator, Expr right)
            {
                Left = left;
                Operator = @operator;
                Right = right;
            }

            public Expr Left { get; }
            public Token Operator { get; }
            public Expr Right { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitLogicalExpr(this);
            }
        }
        
        /*
        public class Set : Expr
        {
            public Set(Expr obj, Token name, Expr value)
            {
                Object = obj;
                Name = name;
                Value = value;
            }

            public Expr Object { get; }
            public Token Name { get; }
            public Expr Value { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitSetExpr(this);
            }
        }
        */
        /*
        public class Super : Expr
        {
            public Super(Token keyword, Token method)
            {
                Keyword = keyword;
                Method = method;
            }

            public Token Keyword { get; }
            public Token Method { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitSuperExpr(this);
            }
        }
        */
        /*
        public class This : Expr
        {
            public This(Token keyword)
            {
                Keyword = keyword;
            }

            public Token Keyword { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitThisExpr(this);
            }
        }
        */
        public class Unary : Expr
        {
            public Unary(Token @operator, Expr right)
            {
                Operator = @operator;
                Right = right;
            }

            public Token Operator { get; }
            public Expr Right { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitUnaryExpr(this);
            }
        }
        
        public class Variable : Expr
        {
            public Variable(Token name)
            {
                Name = name;
            }

            public Token Name { get; }

            public override R Accept<R>(IVisitor<R> visitor)
            {
                return visitor.VisitVariableExpr(this);
            }
        }
        

        public abstract R Accept<R>(IVisitor<R> visitor);
    }
}
