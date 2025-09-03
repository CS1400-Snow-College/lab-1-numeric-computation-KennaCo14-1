// See https://aka.ms/new-console-template for more information

//Step 1: Explore Integer Math
Console.WriteLine("Integer Math");
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int d = a - b;
Console.WriteLine(d);

int e = a / b;
Console.WriteLine(e);

int f = a * b;
Console.WriteLine(f);

//Step 2: Order of Operations

Console.WriteLine("Order of Operations");
int opA = 5;
int opB = 4;
int opC = 2;
int opD = opA + opB * opC;
Console.WriteLine(opD);

int opE = (opA + opB) * opC;
Console.WriteLine(opE);

int opF = (opA + opB) - 6 * opC + (12 * 4) / 3 + 12;
Console.WriteLine(opF);

int opG = (opA + opB) / opC;
Console.WriteLine(opG);

//Step 3: Precision and Limits
Console.WriteLine("Integer Precision and Limits");

int precA = 7;
int precB = 4;
int precC = 3;
int precD = (precA + precB) / precC;
int precE = (precA + precB) % precC;
Console.WriteLine($"quotient: {precD}");
Console.WriteLine($"remainder: {precE}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int extraMax = max + 3;
Console.WriteLine($"An example of overflow: {extraMax}");
