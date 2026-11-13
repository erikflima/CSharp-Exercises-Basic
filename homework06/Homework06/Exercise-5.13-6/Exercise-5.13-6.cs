/***********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5512430

5.13 Exercises (Page 82)

    6.(Trace)Two loops differ only in the comparison operator and the starting value. 
            Count the iterations of each before running — list the values, don’t guess. 
            For each loop, give how many times it runs and the last line it prints.

        // Loop A
        int a = 0;
        while (a < 5) { 
            Console.WriteLine("A" + a); a = a + 1; 
        }


        // Loop B
        int b = 1;
        while (b <= 5) { 
            Console.WriteLine("B" + b); b = b + 1; 
        }

***********************************************/

// Loop A
int a = 0;
while (a < 5)
{
    Console.WriteLine("A" + a); a = a + 1;
}

Console.WriteLine("-------------------");

// Loop B
int b = 1;
while (b <= 5)
{
    Console.WriteLine("B" + b); b = b + 1;
}