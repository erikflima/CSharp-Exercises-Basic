/***********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5512430

5.13 Exercises (Page 81)

    3.(Trace) This is a sentinel loop — it runs until a value crosses a threshold. List the health values and check
      the condition each time. How many times does "Health: ..." print?

int playerHealth = 100;
while (playerHealth > 0){

    Console.WriteLine("Health: " + playerHealth);
    playerHealth = playerHealth - 40;
}

Console.WriteLine("Game over.");

***********************************************/

int playerHealth = 100;
while (playerHealth > 0){

    Console.WriteLine("Health: " + playerHealth);
    playerHealth = playerHealth - 40;
}

Console.WriteLine("Game over.");