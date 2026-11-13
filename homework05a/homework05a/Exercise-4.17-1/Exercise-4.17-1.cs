/***********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5503764

4.17 Exercises (Page 59)

    2. (Trace) The two snippets below look almost identical, but one has an else and one does not.
        For input playerHealth = 75, predict exactly what each prints – including how many lines.

        -------------------
        Snippet A (no else):

            int playerHealth = 75;
            
            if (playerHealth <= 0){
                Console.WriteLine("Game over.");
            }
            Console.WriteLine("Turn complete.");
        -------------------
        Snippet B (with else):

        int playerHealth = 75;

        if (playerHealth <= 0){
            Console.WriteLine("Game over.");
        }
        else{
            Console.WriteLine("Still standing.");
        }
    
        Console.WriteLine("Turn complete.");

***********************************************/


//Snippet A(no else)

Console.WriteLine("---------------Snippet A-------------------");
int playerHealthA = 75;

if (playerHealthA <= 0){

    Console.WriteLine("Game over.");
}

Console.WriteLine("Turn complete.");
Console.WriteLine("----------------------------------");


//Snippet B(with else)
Console.WriteLine("---------------Snippet B-------------------");
int playerHealthB = 75;

if (playerHealthB <= 0){
    Console.WriteLine("Game over.");
}
else{
    Console.WriteLine("Still standing.");
}

Console.WriteLine("Turn complete.");
Console.WriteLine("----------------------------------");