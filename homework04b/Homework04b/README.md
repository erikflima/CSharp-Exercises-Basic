# Homework04b Chapter 3 – Answers

## 4) Answer

```csharp
Console.Write("Enter a number: ");
string input = Console.ReadLine();
int number = int.Parse(input);

bool isEven = (number % 2 == 0);
Console.WriteLine($"{number} is even: {isEven}");
```

---

## 5) Answer

```csharp
Console.Write("First number: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Second number: ");
int second = Convert.ToInt32(Console.ReadLine());

// TODO: compute the average as a real (fractional) number.
double average = (double)(first + second) / 2;

Console.WriteLine($"Average: {average}");
```

---

## 6) Answer

```csharp
Random rng = new Random();
int roll = rng.Next(1, 7);

bool isHighRoll = (roll >= 4); // >=

Console.WriteLine($"You rolled {roll}.");
Console.WriteLine($"High roll: {isHighRoll}");
```