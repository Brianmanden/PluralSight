using Interpreter;

Console.Title = "Interpreter";

List<RomanExpression> expressions = new()
{
	new RomanHundredExpression(),
	new RomanTenExpression(),
	new RomanOneExpression(),
};


//RomanContext context = new(5);
//RomanContext context = new(49);
//RomanContext context = new(133);
//RomanContext context = new(181);
RomanContext context = new(987);
foreach (RomanExpression expression in expressions)
{
	expression.Interpret(context);
}

Console.WriteLine($"Translating Arabic numerals to Roman numerals: {context.PristineInput} = {context.Output}");

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();