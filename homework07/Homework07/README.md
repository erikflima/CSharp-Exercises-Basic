# 🧑🏽‍🎓Homework07 – Answers

**📋Instructions | Geral:** https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5518880

---

## ✏️Exercise 1 - Arcade Corner:
**📋Instructions | Exercise-Arcade Corner:** https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_ArcadeCorner_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977


**🛠️Features implemented:**
- **A - Flip a coin:** Randomly displays Heads or Tails.
- **B - Prize counter:** Calculates the number of prizes and remaining tickets. Each prize costs 15 tickets.
- **C - Launch countdown:** Counts down to Liftoff!
- **D - Guess the number:** Optional game where the player guesses a random number between 1 and 10.
- **Q - Quit:** Exits the application.

**💻Code:**
```csharp
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
```
---

## ✏️Exercise 2 - Exercise: Number Tools:
**📋Instructions | Exercise-Number Tools:** https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_NumberTools_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977



**🛠️Features implemented:**
- Divisor Checker
- Digit-izer
- Palindrome Checker
- Interactive Menu
- Input Validation


**💻Code:**
```csharp
/**********************************************
Instructions: 
  https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5518880
  https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_NumberTools_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977

Exercise: Number Tools

***********************************************/

const string MENU = """
********************************
*         Number Tools         *
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
    string selection = Console.ReadLine().ToUpper();

    switch ( selection ){

        case "A":

            Console.WriteLine("------------------------------");
            Console.Write( "Enter a number: " );
            number = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("------------------------------");
            Console.Write( "Enter a divisor: " );
            int divisor = Convert.ToInt32( Console.ReadLine() );

            if ( divisor == 0 ){

                result = "0 can't be a divisor.";
            }
            else if ( number % divisor == 0 ){

                result = $"{divisor} is a divisor of {number}.";
            }
            else {

                result = $"{divisor} is not a divisor of {number}.";
            }
            break;


        case "B":

            Console.WriteLine("------------------------------");
            Console.Write( "Enter a number: " );
            number = Convert.ToInt32( Console.ReadLine() );

            if ( number < 0 ){

                result = "Please enter a number that is 0 or more.";
            }
            else {

                string digits = "";

                if ( number == 0 ){

                    digits = "0";
                }

                while ( number > 0 ){

                    int digit = number % 10;
                    digits = $"{digit}{( digits == "" ? "" : " " )}{digits}";
                    number = number / 10;
                }

                result = digits;
            }

            break;


        case "C":

            Console.WriteLine("------------------------------");
            Console.Write( "Enter a number: " );
            number = Convert.ToInt32( Console.ReadLine() );

            if ( number < 0 ){

                result = "A negative number can't be a palindrome.";
            }
            else {

                int original = number;
                int reversed = 0;

                while ( number > 0 ){

                    reversed = reversed * 10 + number % 10;
                    number = number / 10;
                }

                if ( reversed == original ){

                    result = $"{original} is a palindrome.";
                }
                else {

                    result = $"{original} is not a palindrome.";
                }
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
```
---