/**********************************************
Instructions: 
  https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_NumberTools_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977

  Version 4:
     https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5583498

Exercise: Number Tools

***********************************************/

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