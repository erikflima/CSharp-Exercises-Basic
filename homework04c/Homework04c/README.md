# 🧑🏽‍🎓Homework04c - 3.11 Exercises (Page 44) – Answers

## 7) Answer
**Code:**
```csharp
Console.WriteLine("--------------------------------------");
Console.WriteLine("        DAMAGE CALCULATOR"         );
Console.WriteLine("--------------------------------------");

Console.Write("\nEnter an integer for attack (Ex: 4, 10, 25, etc): ");
int attack = Convert.ToInt32( Console.ReadLine() );


Console.Write("\nEnter an multiplier for attack (Ex: 4, 10, 25, etc): ");
int multiplier = Convert.ToInt32( Console.ReadLine() );

int defense = 3;

int damage = (attack * multiplier) - defense;



Console.WriteLine("\n--------------------------------------");
Console.WriteLine("             RESULT");
Console.WriteLine("--------------------------------------");
Console.WriteLine($"{attack} attack x {multiplier} - {defense} defense = {damage} damage.");
Console.WriteLine("--------------------------------------");
```

---

## 8) Answer

**Code:**
```csharp
int health = 100;
double stamina = 75.5;
bool isAlive = true;

double promoted = health; // implicit int -> double

Console.WriteLine(promoted);
Console.WriteLine(stamina);
Console.WriteLine(isAlive);

// int wounded = stamina; // what would this line do?
```
**The program outputs is:**
```csharp
100
75.5
True
```
If the commented line is uncommented, the program **will not compile** because **double cannot be implicitly converted to int**.