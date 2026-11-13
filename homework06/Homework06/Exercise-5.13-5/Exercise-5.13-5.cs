/***********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5512430

5.13 Exercises (Page 82)

    5.(Faded) This program is supposed to sum the numbers 1 through 5 and print a correct running total ending
      at 15. A student declared the accumulator inside the loop, so it resets every pass.

        int i = 1;
        while (i <= 5){

            int sum = 0; // BUG: declared and reset inside the loop
            sum = sum + i;
            i = i + 1;

            Console.WriteLine("Running sum: " + sum);
        }

    Trace the buggy code: what does each "Running sum: ..." line print, and why? 
    Then move and fix the accumulator so the program prints a correct running total ending at 15.

***********************************************/

int i = 1;
int sum = 0;

while (i <= 5){

    sum = sum + i;
    i = i + 1;

    Console.WriteLine("Running sum: " + sum);
}