using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOpzApp
{
    internal class MathExpression
    {
        public string Expression { set; get; } = "";
        public string ExpressionOpz { set; get; } = "";

        Dictionary<string, double> variables = new();

        const string bracketsOpen = "([{";
        const string bracketsClose = ")]}";

        const string operatorsAdditive = "+-";
        const string operatorsMultiplex = "*/";

        public MathExpression() { }
        public MathExpression(string expression) => Expression = expression;

        public double this[string name]
        {
            set
            {
                if (!variables.ContainsKey(name))
                    variables.Add(name, 0.0);
                variables[name] = value;
            }
            get
            {
                if (variables.ContainsKey(name))
                    return variables[name];
                else
                    throw new Exception("Invalid variables name");
            }
        }

        public int CheckBrackets()
        {
            const string brackets = bracketsOpen + bracketsClose;
            Stack<char> bracketsStack = new();

            int position = 0;
            foreach(var symbol in Expression)
            {
                if (!brackets.Contains(symbol))
                {
                    position++;
                    continue;
                }
                    

                if(bracketsOpen.Contains(symbol))
                {
                    position++;
                    bracketsStack.Push(symbol);
                    continue;
                }

                if (bracketsStack.Count == 0)
                    return position;

                int typeClose = bracketsClose.IndexOf(symbol);
                int typeOpen = bracketsOpen.IndexOf(bracketsStack.Peek());

                if(typeClose != typeOpen) return position;

                bracketsStack.Pop();
                position++;
            }

            if (bracketsStack.Count > 0) return position;
            return -1;
        }

        public void OpzCreate()
        {
            Stack<char> operationsStack = new();

            for(int position = 0; position < Expression.Length; position++)
            {
                if (Char.IsWhiteSpace(Expression[position])) continue;

                double x = .5;


            }
        }
    }
}
