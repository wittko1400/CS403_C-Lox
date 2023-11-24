using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lox_Interpreter.tools
{
    public class AstPrinter : Expr.IVisitor<string>
    {
        public string Print(Expr expr)
        {
            return expr.Accept(this);
        }
        public string VisitBinaryExpr(Expr.Binary expr)
        {
            return Parenthesize(expr.Operator.Lexeme, expr.Left, expr.Right);
        }

        public string VisitGroupingExpr(Expr.Grouping expr)
        {
            return Parenthesize("group", expr.Expression);
        }

        public string VisitLiteralExpr(Expr.Literal expr)
        {
            if (expr.Value == null) return "nil";
            return expr.Value.ToString();
        }

        public string VisitUnaryExpr(Expr.Unary expr)
        {
            return Parenthesize(expr.Operator.Lexeme, expr.Right);
        }

        private string Parenthesize(string name, params Expr[] exprs)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("(").Append(name);
            foreach (Expr expr in exprs)
            {
                builder.Append(" ");
                builder.Append(expr.Accept(this));
            }
            builder.Append(")");
            
            return builder.ToString();
        }
        public string VisitAssignExpr(Expr.Assign expr)
        {
            throw new NotImplementedException();
        }
        public string VisitVariableExpr(Expr.Variable expr)
        {
            throw new NotImplementedException();
        }
        public string VisitLogicalExpr(Expr.Logical expr)
        {
            throw new NotImplementedException();
        }
    }
}
