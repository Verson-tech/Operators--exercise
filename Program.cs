//Exercise 1:
using OperatorExercise;
int a = 17;
int b = 4;

Console.WriteLine($"sum: {Operators.OperatorStringAdd(a, b)}");
Console.WriteLine($"Substraction: {Operators.OperatorStringSubstarct(a, b)}");
Console.WriteLine($"Division: {Operators.OperatorStringDivide(a, b)}");
Console.WriteLine($"Modulus: {Operators.OperatorStringModulus(a, b)}");
Console.WriteLine($"Multiply: {Operators.OperatorStringMultiply(a, b)}");
Console.WriteLine($"Quotient:");
int quotient = Operators.OperatorStringDivide(a, b);
Console.WriteLine($"{quotient}");
int remainder = Operators.OperatorStringModulus(a, b);
Console.WriteLine($"Remainder:");
Console.WriteLine($"{remainder}");


string opString = (a == 17 && b == 4) ? $"{a} / {b} is {quotient} remainder {1}" : "Brush up on your math";

Console.WriteLine(opString);


//Exercise 2:
Operators.AreaOfCircle();




 


