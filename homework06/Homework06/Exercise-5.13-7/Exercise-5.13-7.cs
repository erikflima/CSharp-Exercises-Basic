/**********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5512430

5.13 Exercises(Page 82 - 83)

    7.(Write from scratch) A program is meant to print the numbers 1 through 5, one per line, then stop. 
      The student put the counter’s update inside an if, so on one path the counter never advances and the loop runs forever.

            int i = 1;
            while (i <= 5){
    
                Console.WriteLine(i);

                if (i % 2 == 1) {  // only update on odd numbers 
                    i = i + 1;
                }
            }

      Trace the first few passes: what is the value of i when the program gets stuck, and why does it stop advancing?
      Then fix the loop so it prints 1 through 5 and ends, and state the rule in one line.
      (If you run this, it will hang — be ready to stop it with Ctrl+C or the stop button / Shift+F5.)



***********************************************/

int i = 1;
while (i <= 5){

    Console.WriteLine(i);

    /* Incorrect: i only increases when it is odd.
    if (i % 2 == 1) { 
        i = i + 1; 
    }
    */

    i = i + 1; // Correct: increment i on every iteration.
}