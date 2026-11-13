/**********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5521190

5.13.13 Exercises(Page 84)

    Exercise 13 (Faded)
    For each problem below, the first decision is while or for — and the reason matters more than the label.
    
    Ask: 
      do I know the count up front, or am I waiting for something to change? 
      For each, write while, for, or nested for, and one sentence of reasoning. 
      Do not write full code.

        1. Print “Hello” exactly 7 times.
        2. Keep asking the user for a password until they type the correct one.
        3. Print a 4-by-4 grid of asterisks.
        4. Double a number repeatedly until it exceeds 1000.
        5. Print the numbers 100 down to 1.
        6. Read numbers from the user and sum them until they enter -1.

***********************************************/



//1.Print "Hello" exactly 7 times.

for (int i = 0; i < 7; i++){

    Console.WriteLine("Hello");
}

//-----------------------------------------

//2.Keep asking for a password until it is correct. 
string password = "";

while (password != "123"){

    Console.Write("Enter the password: ");
    password = Console.ReadLine() ?? "";

}

Console.WriteLine("Correct password!");

//-----------------------------------------

//3.Print a 4-by-4 grid of asterisks.
for ( int row = 0; row < 4; row++ ){

    for (int col = 0; col < 4; col++){

        Console.Write("* ");
    }

    Console.WriteLine();
}

//-----------------------------------------

//4.Double a number repeatedly until it exceeds 1000.
int number = 1;

while (number <= 1000){

    number *= 2;
}

Console.WriteLine($"Final number: {number}");

//-----------------------------------------

//5.Print the numbers 100 down to 1.
for ( int i = 100; i >= 1; i-- ){

    Console.WriteLine(i);
}

//-----------------------------------------

// 6. Read numbers and sum them until the user enters -1.
int input;
int sum = 0;

Console.Write("Enter a number (-1 to stop): ");

while ( int.TryParse(Console.ReadLine(), out input ) && input != -1 ) {

    sum += input;
    Console.Write("Enter a number (-1 to stop): ");
}

Console.WriteLine( $"Sum: {sum}" );