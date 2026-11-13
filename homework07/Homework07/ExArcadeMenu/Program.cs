/**********************************************
Instructions: 
  https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5518880
  https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_ArcadeCorner_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977

Exercise: Arcade Corner

***********************************************/

const string MENU = """
********************************
*        Arcade Corner         *
*                              *
* A - Flip a coin              *
* B - Prize counter            *
* C - Launch countdown         *
* D - Guess the number         *
* Q - Quit                     *
********************************
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
            int tickets = Convert.ToInt32( Console.ReadLine() );

            int prizes = tickets / PRIZE_COST;
            int remainingTickets = tickets % PRIZE_COST;

            result = $"{tickets} tickets gets you {prizes} prizes, with {remainingTickets} tickets left over.";
            break;


        case "C":

            Console.WriteLine("------------------------------");
            Console.Write("What number should the countdown start from? ");
            int countdown = Convert.ToInt32( Console.ReadLine() );

            string countdownResult = "";

            while (countdown > 0){

                countdownResult += $"{countdown}... ";
                countdown--;
            }

            countdownResult += "Liftoff!";
            result = countdownResult;
            break;


        case "D":

            int secretNumber = random.Next(1, 11);
            int guess = 0;
            int guesses = 0;

            while (guess != secretNumber){

                Console.WriteLine("------------------------------");
                Console.Write("Guess a number from 1 to 10: ");
                guess = Convert.ToInt32( Console.ReadLine() );

                guesses++;

                if ( guess < secretNumber ){

                    Console.WriteLine("Too low.");
                }
                else if (guess > secretNumber){

                    Console.WriteLine("Too high.");
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