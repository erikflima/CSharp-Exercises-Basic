/***********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5503764

    Do this problem (not in the text book): 

    Find the largest of 3 number: 
        prompt the user to enter 3 whole numbers
        write the numbers back to the console biggest first, smallest last. 
        How could you extend this to 4 or 5, or 10 numbers. 

***********************************************/

Console.WriteLine("How many integers do you want to enter?");
Console.Write("Options [3, 4, 5, or 10]: ");

int amount = Convert.ToInt32( Console.ReadLine() );

switch (amount){

    case 3:
        Console.WriteLine("\nYou chose to enter 3 numbers.");
        break;

    case 4:
        Console.WriteLine("\nYou chose to enter 4 numbers.");
        break;

    case 5:
        Console.WriteLine("\nYou chose to enter 5 numbers.");
        break;

    case 10:
        Console.WriteLine("\nYou chose to enter 10 numbers.");
        break;

    default:
        Console.WriteLine("\nInvalid option.");
        return;
}

int[] numbers = new int[amount];

Console.WriteLine("\n----------------------------------------\n");

//Ask the user to enter the numbers
for (int i = 0; i < amount; i++){

    Console.Write($"Enter integer #{i + 1}: ");
    numbers[i] = Convert.ToInt32( Console.ReadLine() );
}

//Sort numbers
Array.Sort(numbers);
Array.Reverse(numbers);


Console.WriteLine("\n----------------------------------------\n");
Console.WriteLine("\nNumbers from biggest to smallest:");

for (int i = 0; i < numbers.Length; i++){
    Console.Write(numbers[i] + " ");
}

Console.WriteLine("\n----------------------------------------\n");
Console.WriteLine($"Smallest number: {numbers.Min()}");
Console.WriteLine($"Biggest number: {numbers.Max()}");
Console.WriteLine("\n----------------------------------------\n");