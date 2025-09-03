// See https://aka.ms/new-console-template for more information

//Step 1
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

//Step 2

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

//Step 3
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



//Step 4
Console.WriteLine("Double Type");

double twoA = 5;
double twoB = 4;
double twoC = 2;
double twoD = (twoA + twoB) / twoC;
Console.WriteLine(twoD);

double twoE = 19;
double twoF = 23;
double twoG = 8;
double twoH = (twoE + twoF) / twoG;
Console.WriteLine(twoH);

double twoMax = double.MaxValue;
double twoMin = double.MinValue;
Console.WriteLine($"The range of double is {twoMin} to {twoMax}");

double third = 1.0 / 3.0;
Console.WriteLine(third);

//Step 5
Console.WriteLine("Decimal Types");

decimal decMin = decimal.MinValue;
decimal decMax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {decMin} to {decMax}");

double thirdA = 1.0;
double thirdB = 3.0;
Console.WriteLine(thirdA / thirdB);

decimal decA = 1.0M;
decimal decB = 3.0M;
Console.WriteLine(decA / decB);