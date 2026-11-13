# 🧑🏽‍🎓Homework05a - 4.17 Exercises (Page 59) – Answers

**📋Instructions:** https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5503764

## Exercise 1 - Answer
**Code:**
```csharp
int playerHealth = 0; //Case A 0, Case B 30, Case C 80

if (playerHealth <= 0){
    Console.WriteLine("Game over.");
}

else if (playerHealth < 50){

    Console.WriteLine("Warning: low health!");
}

else{
    Console.WriteLine("Healthy.");
}
```

**Results of the program for each case are:**

| Case | playerHealth | Output               |
|------|--------------|----------------------|
| A    | 0            | `Game over.`          |
| B    | 30           | `Warning: low health!` |
| C    | 80           | `Healthy.`             |

---

## Exercise 2 - Answer
**Code:**
```csharp
Console.WriteLine("-------------Snippet A------------------");
int playerHealthA = 75;

if (playerHealthA <= 0){
    Console.WriteLine("Game over.");
}

Console.WriteLine("Turn complete.");
Console.WriteLine("----------------------------------------\n\n");




Console.WriteLine("-------------Snippet B------------------");
int playerHealthB = 75;

if (playerHealthB <= 0){
    Console.WriteLine("Game over.");
}
else{
    Console.WriteLine("Still standing.");
}

Console.WriteLine("Turn complete.");
Console.WriteLine("----------------------------------------");


```

**Results of the program for each case are:**

| Snippet | Output | Lines |
|---|---|---:|
| A | `Turn complete.` | 1 |
| B | `Still standing.`<br>`Turn complete.` | 2 |

---

## Exercise 3 - Answer
**Code:**
```csharp
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
```
The case 'q' causes a compile-time error because **C# does not allow control to fall through from one case to another**.
<br>To fix it, add a break after "Quit requested."


**Results of the program for each case are:**

| Case | command | Output |
|---|---|---|
| A | `'w'` | `Move up.` |
| B | `'q'` | Compile-time error |
| C | `'x'` | `Unknown command.` |


---

## Exercise 4 - Answer
**Code:**
```csharp
Console.Write("Enter score: ");
string input = Console.ReadLine();

int score = Convert.ToInt32(input);

if (score >= 50){
    Console.WriteLine("Pass");
}
else{
    Console.WriteLine("Fail");
}
```


---

## Exercise 10 - Answer
**Code:**
```csharp
bool x = true; // see each case /
bool y = true; // see each case /

if ( !(x && y) ){
    
    Console.WriteLine("first branch");
}
else{

    Console.WriteLine("second branch");
}
```

**Results of the program for each case are:**

| Case | x | y | Output |
|---|---|---|---|
| A | `true` | `true` | `second branch` |
| B | `true` | `false` | `first branch` |
| C | `false` | `false` | `first branch` |


---

## Exercise Extra - Answer
**Code:**
```csharp
Console.WriteLine("How many integers do you want to enter?");
Console.Write("Options [3, 4, 5, or 10]: ");

int amount = Convert.ToInt32( Console.ReadLine() );

switch (amount){

    case 3:
        Console.WriteLine("\nYou chose to enter 3 numbers.");
        break;

    case 4:
        Console.WriteLine("\nYou chose to enter 4 numbers.");
        break;

    case 5:
        Console.WriteLine("\nYou chose to enter 5 numbers.");
        break;

    case 10:
        Console.WriteLine("\nYou chose to enter 10 numbers.");
        break;

    default:
        Console.WriteLine("\nInvalid option.");
        return;
}

int[] numbers = new int[amount];

Console.WriteLine("\n----------------------------------------\n");

//Ask the user to enter the numbers
for (int i = 0; i < amount; i++){

    Console.Write($"Enter integer #{i + 1}: ");
    numbers[i] = Convert.ToInt32( Console.ReadLine() );
}

//Sort numbers
Array.Sort(numbers);
Array.Reverse(numbers);


Console.WriteLine("\n----------------------------------------\n");
Console.WriteLine("\nNumbers from biggest to smallest:");

for (int i = 0; i < numbers.Length; i++){
    Console.Write(numbers[i] + " ");
}

Console.WriteLine("\n----------------------------------------\n");
Console.WriteLine($"Smallest number: {numbers.Min()}");
Console.WriteLine($"Biggest number: {numbers.Max()}");
Console.WriteLine("\n----------------------------------------\n");
```