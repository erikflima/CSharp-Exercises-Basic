/**************************************************
Instructions: 
  https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_ArcadeCorner_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977

Version 4:
     https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5583498

Exercise: Arcade Corner - Refactored

**************************************************/

const string MENU = """
********************************
*        Arcade Corner v4      *
*                              *
* A - Flip a coin              *
* B - Prize counter            *
* C - Launch countdown         *
* D - Guess the number         *
* Q - Quit                     *
********************************
""";

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

            result = CoinFlip();

            break;


        case "B":

            int tickets = ReadIntInRange("How many tickets do you have? ");

            result = PrizeForTickets(tickets);

            break;


        case "C":

            result = CountDownFrom();

            break;


        case "D":

            int secretNumber = random.Next(1, 11);
            int guess = 0;
            int guesses = 0;

            while (guess != secretNumber){

                guess = ReadIntInRange("Guess a number from 1 to 10: ", 1, 10);

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


//Functions -------------------------------------------------

static string CoinFlip(){

    Random random = new Random();

    int coin = random.Next(1, 3);

    if ( coin == 1 ){

        return "Heads!";
    }
    else{

        return "Tails!";
    }

}


static string PrizeForTickets(int tickets){

    const int PRIZE_COST = 15;

    int prizes = tickets / PRIZE_COST;
    int remainingTickets = tickets % PRIZE_COST;

    return $"{tickets} tickets gets you {prizes} prizes, with {remainingTickets} tickets left over.";

}


static string CountDownFrom(){

    int countdown = ReadIntInRange("What number should the countdown start from? ");

    string countdownResult = "";

    while ( countdown > 0){

        countdownResult += $"{countdown}... ";
        countdown--;
    }

    countdownResult += "Liftoff!";

    return countdownResult;

}


static int ReadIntInRange( string prompt, int min = int.MinValue, int max = int.MaxValue ){

    Console.Write( prompt );
    string input = Console.ReadLine();


    bool IsNumber = int.TryParse( input, out int number );


    while ( !IsNumber || number < min || number > max ){

        Console.WriteLine( $"That isn't a whole number from {min} to {max}. Try again." );

        Console.Write(prompt);

        input = Console.ReadLine();

        IsNumber = int.TryParse(input, out number);

    }

    return number;

}