/*
**********************************************
3.11 Exercises

1. (Trace) Without running it, predict what each line prints. Watch the precedence and the division:
    int a = 2 + 3 * 4;
    int b = (2 + 3) * 4;
    int c = 5 / 2;
    double d = 5 / 2;
    double e = 5.0 / 2;
    int f = 7 % 3;

    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(e);
    Console.WriteLine(f);
**********************************************
*/

int a = 2 + 3 * 4;
int b = (2 + 3) * 4;
int c = 5 / 2;
double d = 5 / 2;
double e = 5.0 / 2;
int f = 7 % 3;

Console.WriteLine("int a = 2 + 3 * 4;");
Console.WriteLine("Result: " +a);
Console.WriteLine("-----------------------");

Console.WriteLine("int b = (2 + 3) * 4;");
Console.WriteLine("Result: " + b);
Console.WriteLine("-----------------------");

Console.WriteLine("int c = 5 / 2;");
Console.WriteLine("Result: " + c);
Console.WriteLine("-----------------------");

Console.WriteLine("double d = 5 / 2;");
Console.WriteLine("Result: " + d);
Console.WriteLine("-----------------------");

Console.WriteLine("double e = 5.0 / 2;");
Console.WriteLine("Result: " + e);
Console.WriteLine("-----------------------");

Console.WriteLine("int f = 7 % 3;");
Console.WriteLine("Result: " + f);
Console.WriteLine("-----------------------");