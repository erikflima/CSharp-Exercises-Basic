/*
**********************************************
3.11 Exercises (Page 42)

6. (Faded) Complete the program so it rolls a six-sided die, then prints whether the roll is a
“high roll” — defined as 4, 5, or 6. Use a relational operator, not a list of equality checks.
(Recall from Chapter 2 that rng.Next(1, 7) produces 1 through 6 — the upper bound 7 is
excluded.)

   Random rng = new Random();
   int roll = rng.Next(1, 7);

   bool isHighRoll = (roll ________ 4);

   Console.WriteLine($"You rolled {roll}.");
   Console.WriteLine($"High roll: {isHighRoll}");

**********************************************
*/

Random rng = new Random();
int roll = rng.Next(1, 7);

bool isHighRoll = (roll >= 4); // >=

Console.WriteLine($"You rolled {roll}.");
Console.WriteLine($"High roll: {isHighRoll}");