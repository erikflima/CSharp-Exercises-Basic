/*
**********************************************
3.11 Exercises (Page 44)

8.(Trace) This recalls variables and types from Chapter 2. 
  Without running it, write what this prints, and for the commented-out line, say what would happen if you uncommented it.

    int health = 100;
    double stamina = 75.5;
    bool isAlive = true;

    double promoted = health; // implicit int -> double

    Console.WriteLine(promoted);
    Console.WriteLine(stamina);
    Console.WriteLine(isAlive);

    // int wounded = stamina; // what would this line do?

**********************************************
*/

int health = 100;
double stamina = 75.5;
bool isAlive = true;

double promoted = health; // implicit int -> double

Console.WriteLine(promoted);
Console.WriteLine(stamina);
Console.WriteLine(isAlive);

//int wounded = stamina; // what would this line do?