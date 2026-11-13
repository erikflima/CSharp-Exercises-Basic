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