/*
**********************************************
3.11 Exercises (Page 42)

5. (Faded) The program below is meant to read two integers and print their average as a
decimal. It contains the chapter’s silent bug. The reading and conversion are done for you —
complete the average calculation so it prints 2.5 for inputs 2 and 3, not 2.

    Console.Write("First number: ");
    int first = Convert.ToInt32(Console.ReadLine());

    Console.Write("Second number: ");
    int second = Convert.ToInt32(Console.ReadLine());

    // TODO: compute the average as a real (fractional) number.
    double average = ________;
    Console.WriteLine($"Average: {average}");

**********************************************
*/

Console.Write("First number: ");
int first = Convert.ToInt32( Console.ReadLine() );

Console.Write("Second number: ");
int second = Convert.ToInt32( Console.ReadLine() );

// TODO: compute the average as a real (fractional) number.
double average = (double)(first + second) / 2;

Console.WriteLine($"Average: {average}");