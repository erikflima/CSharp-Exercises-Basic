/**************************************************
Instructions: 
  https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5518880
  https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_ArcadeCorner_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977

  Version 2:
     https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5521190

Exercise: Arcade Corner

**************************************************/

const string MENU = """
****************************************
*        Arcade Corner         *
*                              *
* A - Flip a coin              *
* B - Prize counter            *
* C - Launch countdown         *
* D - Guess the number         *
* Q - Quit                     *
****************************************
""";

const int PRIZE_COST = 15;

Random random = new Random();

bool hasQuit = false;

string result = "";


while ( !hasQuit ){

    Console.Clear();
    Console.WriteLine(MENU);

    Console.WriteLine();
    Console.WriteLine(result);
    Console.WriteLine();

    Console.WriteLine("------------------------------");
    Console.Write("Enter your selection: ");
    string selection = Console.ReadLine()!.ToUpper();

    result = "";


    switch ( selection ){

        case "A":

            int coin = random.Next(1, 3);

            if (coin == 1){

                result = "Heads!";
            }
            else{
                result = "Tails!";
            }

            break;


        case "B":

            Console.WriteLine("------------------------------");
            Console.Write("How many tickets do you have? ");

            string ticketsInput = Console.ReadLine()!;

            if ( int.TryParse(ticketsInput, out int tickets) ){

                int prizes = tickets / PRIZE_COST;
                int remainingTickets = tickets % PRIZE_COST;

                result = $"{tickets} tickets gets you {prizes} prizes, with {remainingTickets} tickets left over.";
            }
            else{
                result = "Please enter a valid number.";
            }

            break;


        case "C":

            Console.WriteLine("------------------------------");
            Console.Write("What number should the countdown start from? ");

            string countdownInput = Console.ReadLine()!;

            if ( int.TryParse(countdownInput, out int countdown) ){

                string countdownResult = "";

                while (countdown > 0){

                    countdownResult += $"{countdown}... ";
                    countdown--;
                }

                countdownResult += "Liftoff!";
                result = countdownResult;
            }
            else{
                result = "Please enter a valid number.";
            }

            break;


        case "D":

            int secretNumber = random.Next(1, 11);
            int guess = 0;
            int guesses = 0;

            while (guess != secretNumber){

                Console.WriteLine("------------------------------");
                Console.Write("Guess a number from 1 to 10: ");

                string guessInput = Console.ReadLine()!;

                if ( int.TryParse(guessInput, out guess) ){

                    if (guess >= 1 && guess <= 10){

                        guesses++;

                        if ( guess < secretNumber ){

                            Console.WriteLine("Too low.");
                        }
                        else if (guess > secretNumber){

                            Console.WriteLine("Too high.");
                        }
                    }
                    else{
                        Console.WriteLine("Please enter a number from 1 to 10.");
                        guess = 0;
                    }
                }
                else{
                    Console.WriteLine("Please enter a valid number.");
                    guess = 0;
                }
            }

            result = $"You got it! The number was {secretNumber}. It took you {guesses} guesses.";
            break;


        case "Q":
            hasQuit = true;
            break;


        default:
            result = $"{selection} isn't an option. Please choose from the menu.";
            break;
    }

}

Console.WriteLine("------------------------------");
Console.WriteLine("Goodbye!");