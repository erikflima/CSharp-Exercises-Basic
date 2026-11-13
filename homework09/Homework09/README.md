# 🧑🏽‍🎓Homework09 - 6.11 Exercises(Page 97 - 98) – Answers

**📋Instructions:** https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5557992

## ✏️Exercise 6.11-1 Exercises(Page 97) - Answer:

**The output is:**
```console
Tile: @
Total damage: 15
```
---

## ✏️Exercise 6.11-2 Exercises(Page 97) - Answer:

**The output is:**
```console
Program starting.
Program done.
```
---

## ✏️Exercise 6.11-3 Exercises(Page 97 - 98) - Answer:

#### ✔️Corrected Code
```csharp
PrintTile('#'); // call 1 — wall (given)
PrintTile('.'); // (A) call 2 — floor


void PrintTile(char tile) // (B) the parameter's type
{
    Console.WriteLine("Tile: " + tile); // (C) print the parameter
}

```

**The output is:**
```console
Tile: #
Tile: .

```