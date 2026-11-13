/*
**********************************************
3.11 Exercises (Page 44)

7.(Write from scratch) Write a complete program that:

   1.Reads an attack value from the user (a whole number).
   2.Reads a multiplier value from the user (a whole number).
   3.Sets defense to a fixed value of 3.
   4.Computes damage as attack * multiplier - defense, using parentheses to make the precedence explicit.

   5.Prints the result with string interpolation, in this form:
      [attack] attack x[multiplier] - [defense] defense = [damage] damage.

    Remember the conversion convention: Console.ReadLine() always returns a string, so
    convert each input with Convert.ToInt32(...) before doing any arithmetic. 
    Test with atleast two inputs: try 4 and 2 (expect 5 damage), then 3 and 3 (expect 6 damage).

**********************************************
*/

Console.WriteLine("--------------------------------------");
Console.WriteLine("        DAMAGE CALCULATOR"         );
Console.WriteLine("--------------------------------------");

Console.Write("\nEnter an integer for attack (Ex: 4, 10, 25, etc): ");
int attack = Convert.ToInt32( Console.ReadLine() );


Console.Write("\nEnter an multiplier for attack (Ex: 4, 10, 25, etc): ");
int multiplier = Convert.ToInt32( Console.ReadLine() );

int defense = 3;

int damage = (attack * multiplier) - defense;



Console.WriteLine("\n--------------------------------------");
Console.WriteLine("             RESULT");
Console.WriteLine("--------------------------------------");
Console.WriteLine($"{attack} attack x {multiplier} - {defense} defense = {damage} damage.");
Console.WriteLine("--------------------------------------");


