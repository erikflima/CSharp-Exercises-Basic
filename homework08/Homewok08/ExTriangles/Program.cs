/**********************************************
Geral Instructions:https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5521190
PDF Instructions: https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_Triangles_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977

Exercise: Triangle Maker
    You'll build a menu program that draws triangles out of * characters. 
    Each option draws the triangle pointing a different way. The user picks one, says how many lines
    tall it should be, and the triangle appears under the menu.

    This exercise practises for loops inside for loops. The outer loop counts the rows, and the inner loops count the spaces and stars on each row. 
    You'll also build up a multi-line answer in a string, because a menu case never prints its own answer.

**********************************************/
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Blue;

const string MENU = """
********************************
*        Triangle Maker        *
*                              *
*        A - Up left           *
*        B - Down left         *
*        C - Up right          *
*        D - Down right        *
*        Q - Quit              *
********************************
""";

const int MAX_HEIGHT = 20;

bool hasQuit = false;
string result = "";

while ( !hasQuit ){

    Console.Clear();
    Console.WriteLine(MENU);
    Console.WriteLine(result);
    Console.WriteLine();

    Console.WriteLine("-------------------------------------");
    Console.Write("Enter your selection: ");
    string selection = Console.ReadLine()!.ToUpper();

    result = "";

    int height;
    string triangle = "";


    switch ( selection ){

        case "A":

            Console.Write("How many lines tall? ");
            height = Convert.ToInt32( Console.ReadLine() );

            if (height < 1 || height > MAX_HEIGHT){

                result = $"Please enter a height from 1 to {MAX_HEIGHT}.";
            }
            else{


                for (int row = 1; row <= height; row = row + 1){


                    for (int star = 1; star <= row; star = star + 1){
                        triangle += "*";
                    }

                    triangle += "\n";

                }

                result = triangle;
            }

            break;


        case "B":

            Console.Write("How many lines tall? ");
            height = Convert.ToInt32( Console.ReadLine() );

            if (height < 1 || height > MAX_HEIGHT){

                result = $"Please enter a height from 1 to {MAX_HEIGHT}.";
            }
            else{


                for ( int row = 1; row <= height; row = row + 1 ){


                    for ( int star = 1; star <= height - row + 1; star = star + 1){

                        triangle += "*";
                    }

                    triangle += "\n";
                }

                result = triangle;
            }

            break;


        case "C":

            Console.Write("How many lines tall? ");
            height = Convert.ToInt32( Console.ReadLine() );

            if (height < 1 || height > MAX_HEIGHT){

                result = $"Please enter a height from 1 to {MAX_HEIGHT}.";
            }
            else{

                for (int row = 1; row <= height; row = row + 1){


                    for (int space = 1; space <= height - row; space = space + 1){

                        triangle += " ";
                    }


                    for (int star = 1; star <= row; star = star + 1){

                        triangle += "*";
                    }


                    triangle += "\n";
                }

                result = triangle;
            }

            break;


        case "D":

            Console.Write("How many lines tall? ");
            height = Convert.ToInt32( Console.ReadLine() );


            if ( height < 1 || height > MAX_HEIGHT ){

                result = $"Please enter a height from 1 to {MAX_HEIGHT}.";
            }
            else{

                for ( int row = 1; row <= height; row = row + 1 ){


                    for ( int space = 1; space < row; space = space + 1 ){

                        triangle += " ";
                    }


                    for ( int star = 1; star <= height - row + 1; star = star + 1 ){

                        triangle += "*";
                    }


                    triangle += "\n";
                }

                result = triangle;
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


Console.WriteLine("""
----------------------------------------
----------------------------------------
                                        
   GOODBYE!                             
                                        
   NO MORE HOMEWORK!                    
                                        
   /\_/\\                                
  ( o.o )                               
   > ^ <                                
                                        
----------------------------------------
----------------------------------------
""");
