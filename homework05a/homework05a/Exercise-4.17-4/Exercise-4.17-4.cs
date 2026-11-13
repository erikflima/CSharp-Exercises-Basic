/***********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5503764

4.17 Exercises (Page 60)

    4.(Faded) Complete the program so it reads a score from the user, converts it to an int, and
      prints "Pass" if the score is 50 or above, and "Fail" otherwise. Use a two-branch if/else.

        Console.Write("Enter score: ");

        string input = Console.ReadLine();
        int score = ________.________(input);
        
        if (score ________ 50){
            Console.WriteLine("________");
        }
        else{
            Console.WriteLine("________");
        }

***********************************************/

Console.Write("Enter score: ");
string input = Console.ReadLine();

int score = Convert.ToInt32(input);

if (score >= 50){
    Console.WriteLine("Pass");
}
else{
    Console.WriteLine("Fail");
}