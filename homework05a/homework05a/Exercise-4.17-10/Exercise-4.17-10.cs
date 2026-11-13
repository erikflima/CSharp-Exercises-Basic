/***********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5503764 
  
4.17 Exercises (Page 62)

    10.(Trace) Without running it – and without the debugger – predict which line prints for each
       set of values. Evaluate the compound condition inside-out: innermost parentheses first, then the !.
       
       Case A x = true,  y = true; 
       Case B x = true,  y = false; 
       Case C x = false, y = false.


        bool x = / see each case /;
        bool y = / see each case /;
        if ( !(x && y) ){
            Console.WriteLine("first branch");
        }
        else{
            Console.WriteLine("second branch");
        }

***********************************************/

bool x = true; // see each case /
bool y = true; // see each case /

if ( !(x && y) ){
    
    Console.WriteLine("first branch");
}
else{

    Console.WriteLine("second branch");
}