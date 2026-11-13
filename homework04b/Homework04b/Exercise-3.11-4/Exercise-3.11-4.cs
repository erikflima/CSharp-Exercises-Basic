/*
**********************************************
3.11 Exercises (Page 42)

4. (Faded) Complete the program so it reads a whole number from the user, converts it to an
int, and prints whether it is even.  Use % for the even test.

   Console.Write("Enter a number: ");
   string input = Console.ReadLine();
   int number = ________.________(input);

   bool isEven = (number ________ 2 == 0);
   Console.WriteLine($"________ is even: {isEven}");

**********************************************
*/


Console.Write("Enter a number: ");
string input = Console.ReadLine();
int number = int.Parse(input);

bool isEven = (number % 2 == 0);
Console.WriteLine( $"{number} is even: {isEven}" );