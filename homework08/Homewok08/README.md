# 🧑🏽‍🎓Homework08 – Answers

**📋Instructions | Geral: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5521190** 

---

## ✏️Exercise 1 - Arcade Corner:
**📋Instructions | Exercise-Arcade Corner:** 



**💻Code:**
```csharp
/**************************************************
Instructions: 
  https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5518880
  https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_ArcadeCorner_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977

  Version 2:
     https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5521190

Exercise: Arcade Corner

**************************************************/

const string MENU = """
****************************************
*        Arcade Corner         *
*                              *
* A - Flip a coin              *
* B - Prize counter            *
* C - Launch countdown         *
* D - Guess the number         *
* Q - Quit                     *
****************************************
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

            string ticketsInput = Console.ReadLine()!;

            if ( int.TryParse(ticketsInput, out int tickets) ){

                int prizes = tickets / PRIZE_COST;
                int remainingTickets = tickets % PRIZE_COST;

                result = $"{tickets} tickets gets you {prizes} prizes, with {remainingTickets} tickets left over.";
            }
            else{
                result = "Please enter a valid number.";
            }

            break;


        case "C":

            Console.WriteLine("------------------------------");
            Console.Write("What number should the countdown start from? ");

            string countdownInput = Console.ReadLine()!;

            if ( int.TryParse(countdownInput, out int countdown) ){

                string countdownResult = "";

                while (countdown > 0){

                    countdownResult += $"{countdown}... ";
                    countdown--;
                }

                countdownResult += "Liftoff!";
                result = countdownResult;
            }
            else{
                result = "Please enter a valid number.";
            }

            break;


        case "D":

            int secretNumber = random.Next(1, 11);
            int guess = 0;
            int guesses = 0;

            while (guess != secretNumber){

                Console.WriteLine("------------------------------");
                Console.Write("Guess a number from 1 to 10: ");

                string guessInput = Console.ReadLine()!;

                if ( int.TryParse(guessInput, out guess) ){

                    if (guess >= 1 && guess <= 10){

                        guesses++;

                        if ( guess < secretNumber ){

                            Console.WriteLine("Too low.");
                        }
                        else if (guess > secretNumber){

                            Console.WriteLine("Too high.");
                        }
                    }
                    else{
                        Console.WriteLine("Please enter a number from 1 to 10.");
                        guess = 0;
                    }
                }
                else{
                    Console.WriteLine("Please enter a valid number.");
                    guess = 0;
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
**📋Instructions | Exercise-Number Tools: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5521190** 


**💻Code:**
```csharp
/**********************************************
Instructions: 
  https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5518880
  https://elearning.nbcc.ca/content/enforced/321977-126901184/Ex_NumberTools_INSTRUCTIONS.pdf?isCourseFile=true&ou=321977

  Version 2:
     https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5521190

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
    string selection = Console.ReadLine()!.ToUpper();

    result = "";

    switch ( selection ){

        case "A":

            Console.WriteLine("------------------------------");
            Console.Write( "Enter a number: " );
            string numberInput = Console.ReadLine()!;

            if ( int.TryParse(numberInput, out number) ){

                Console.WriteLine("------------------------------");
                Console.Write( "Enter a divisor: " );
                string divisorInput = Console.ReadLine()!;

                if ( int.TryParse(divisorInput, out int divisor) ){

                    if ( divisor == 0 ){

                        result = "0 can't be a divisor.";
                    }
                    else if ( number % divisor == 0 ){

                        result = $"{divisor} is a divisor of {number}.";
                    }
                    else {

                        result = $"{divisor} is not a divisor of {number}.";
                    }
                }
                else{
                    result = "Please enter a valid number.";
                }
            }
            else{
                result = "Please enter a valid number.";
            }

            break;


        case "B":

            Console.WriteLine("------------------------------");
            Console.Write( "Enter a number: " );
            string digitInput = Console.ReadLine()!;

            if ( int.TryParse(digitInput, out number) ){

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
            }
            else{
                result = "Please enter a valid number.";
            }

            break;


        case "C":

            Console.WriteLine("------------------------------");
            Console.Write( "Enter a number: " );
            string palindromeInput = Console.ReadLine()!;

            if ( int.TryParse(palindromeInput, out number) ){

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
            }
            else{
                result = "Please enter a valid number.";
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

---

## ✏️Exercise 5.13-13 (Page 84) - Answer:

#### 1. Print "Hello" exactly 7 times.

**Answer:** `for`
**💻Code:**
```csharp
for (int i = 0; i < 7; i++){

    Console.WriteLine("Hello");
}

```
---

#### 2. Keep asking the user for a password until they type the correct one.

**Answer:** `while`
**💻Code:**
```csharp
string password = "";

while (password != "123"){

    Console.Write("Enter the password: ");
    password = Console.ReadLine() ?? "";

}

Console.WriteLine("Correct password!");

```
---

#### 3. Print a 4-by-4 grid of asterisks.

**Answer:** `nested for`
**💻Code:**
```csharp
for ( int row = 0; row < 4; row++ ){

    for (int col = 0; col < 4; col++){

        Console.Write("* ");
    }

    Console.WriteLine();
}

```

---

#### 4. Double a number repeatedly until it exceeds 1000.

**Answer:** `while`
**💻Code:**
```csharp
int number = 1;

while (number <= 1000){

    number *= 2;
}

Console.WriteLine($"Final number: {number}");

```

---

#### 5. Print the numbers 100 down to 1.

**Answer:** `for`
**💻Code:**
```csharp
for ( int i = 100; i >= 1; i-- ){

    Console.WriteLine(i);
}

```

---

#### 6. Read numbers from the user and sum them until they enter -1.

**Answer:** `while`
**💻Code:**
```csharp
int input;
int sum = 0;

Console.Write("Enter a number (-1 to stop): ");

while ( int.TryParse(Console.ReadLine(), out input ) && input != -1 ) {

    sum += input;
    Console.Write("Enter a number (-1 to stop): ");
}

Console.WriteLine( $"Sum: {sum}" );

```


---

## ✏️Exercise Triangle Maker - Answer:


**💻Code:**

```csharp
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

```