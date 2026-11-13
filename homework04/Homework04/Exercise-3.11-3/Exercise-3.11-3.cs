/*
**********************************************
3.11 Exercises

3. (Trace) Each snippet has one problem. For each, say whether it is a compile-time error
(caught before the program runs, shows in the Error List) or a runtime error (the program
builds and starts, then crashes), and explain why. Then describe the fix.

Snippet A:
    int level = "5";
    Console.WriteLine(level);

Snippet B:
    string input = Console.ReadLine(); // user types: hello
    int score = Convert.ToInt32(input);
    Console.WriteLine(score);

Snippet C:
    int health = 100;
    Console.WriteLine("Health: {health}");
**********************************************
*/

//Snippet A:
Console.WriteLine("---------Snippet A---------");
int level = 5;
Console.WriteLine(level);


//Snippet B:
Console.WriteLine("\n\n---------Snippet B---------");
string input = Console.ReadLine();
if ( int.TryParse(input, out int score) ){

    Console.WriteLine(score);
}
else{
    Console.WriteLine("Please enter an integer number. Example: 10");
}


//Snippet C:
Console.WriteLine("\n\n---------Snippet C---------");
int health = 100;
Console.WriteLine($"Health: {health}");