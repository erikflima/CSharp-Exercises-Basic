# 🧑🏽‍🎓Homework11 – Answers

**📋Instructions | Geral: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5583498** 

---

## ✏️Exercise 1 - Refactored - Arcade Corner v4:

**💻Code:**
```csharp
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

```
---

## ✏️Exercise 2 - Refactored - Exercise: Number Tools v4:

**💻Code:**
```csharp
const string MENU = """
********************************
*         Number Tools v4      *
*                              *
* A - Divisor checker          *
* B - Digit-izer               *
* C - Palindrome checker       *
* Q - Quit                     *
********************************
""";

bool hasQuit = false;

string result = "";

int number;

while ( !hasQuit ){

    Console.Clear();
    Console.WriteLine( MENU );
    Console.WriteLine( result );

    Console.WriteLine();

    Console.WriteLine("------------------------------");
    Console.Write( "Enter your selection: " );
    string selection = Console.ReadLine()!.ToUpper();

    result = "";

    switch ( selection ){

        case "A":

            number = ReadIntInRange("Enter a number: ");

            Console.WriteLine("------------------------------");
            int divisor = ReadIntInRange("Enter a divisor: ");

            if ( divisor == 0 ){

                result = "0 can't be a divisor.";
            }
            else if ( isDivisorOf(number, divisor) ){

                result = $"{divisor} is a divisor of {number}.";
            }
            else {

                result = $"{divisor} is not a divisor of {number}.";
            }

            break;


        case "B":

            number = ReadIntInRange("Enter a number: ");

            if ( number < 0 ){

                result = "Please enter a number that is 0 or more.";
            }
            else {

                result = Digitize(number);
            }

            break;


        case "C":

            number = ReadIntInRange("Enter a number: ");

            if ( number < 0 ){

                result = "A negative number can't be a palindrome.";
            }
            else if ( isPalindrome(number) ){

                result = $"{number} is a palindrome.";
            }
            else {

                result = $"{number} is not a palindrome.";
            }

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
Console.WriteLine( "Goodbye!" );



//Methods ---------------------------------------------------

static bool isDivisorOf( int numb, int divisor){

    return numb % divisor == 0;

}


static string Digitize( int numb ){

    string digits = "";

    if ( numb == 0 ){

        digits = "0";
    }

    while ( numb > 0 ){

        int digit = numb % 10;
        digits = $"{digit}{( digits == "" ? "" : " " )}{digits}";
        numb = numb / 10;
    }

    return digits;

}


static bool isPalindrome( int numb ){

    int original = numb;
    int reversed = 0;

    while ( numb > 0 ){

        reversed = reversed * 10 + numb % 10;
        numb = numb / 10;
    }

    return reversed == original;

}


static int ReadIntInRange( string prompt, int min = int.MinValue, int max = int.MaxValue ){

    Console.Write(prompt);
    string input = Console.ReadLine();


    bool IsNumber = int.TryParse(input, out int number);


    while ( !IsNumber || number < min || number > max ){

        Console.WriteLine($"That isn't a whole number from {min} to {max}. Try again.");

        Console.Write( prompt );

        input = Console.ReadLine();

        IsNumber = int.TryParse( input, out number );

    }

    return number;

}
```