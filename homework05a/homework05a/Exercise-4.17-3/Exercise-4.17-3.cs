/***********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5503764

4.17 Exercises (Page 60)

    3.(Trace) Trace this switch for each command value: Case A 'w', Case B 'q', Case C 'x'. One
      case is missing its break on purpose – figure out what that changes.

        char command = / see each case /;
        switch (command){
            case 'w':
                Console.WriteLine("Move up.");
                break;

            case 's':
                Console.WriteLine("Move down.");
                break;

            case 'q':
                Console.WriteLine("Quit requested.");
            // note: no break here

            default:
                Console.WriteLine("Unknown command.");
                break;
        }
***********************************************/


char command = 'w';

switch (command){

    case 'w':
        Console.WriteLine("Move up.");
        break;

    case 's':
        Console.WriteLine("Move down.");
        break;

    case 'q':
        Console.WriteLine("Quit requested.");
        break; 

    default:
        Console.WriteLine("Unknown command.");
        break;
}