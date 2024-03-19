using NetOpzApp;

MathExpression mathExpression = new MathExpression();

mathExpression["a"] = 10.9;
mathExpression["b"] = 4.75;
mathExpression["c"] = 3;
mathExpression.Expression = "a + b";
mathExpression.OpzCreate();

Console.WriteLine(mathExpression.ExpressionOpz);
Console.WriteLine(mathExpression.OpzCalculate());

