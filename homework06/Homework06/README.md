# 🧑🏽‍🎓Homework06 - 5.13 Exercises (Page 80) – Answers

**📋Instructions:** https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5512430

## ✏️Exercise 5.13-1 (Page 81) - Answer:

**The loop body runs 5 times. The output is:**
```console
i = 2
i = 3
i = 4
i = 5
i = 6
```
---

## ✏️Exercise 5.13-3 (Page 81) - Answer:

**The loop body runs 3 times. The output is:**
```console
Health: 100
Health: 60
Health: 20
Game over.
```
---


## ✏️Exercise 5.13-5 (Page 82) - Answer:


### ❌Incorrect Code

The variable `sum` is declared inside the loop, so it resets to `0` during every iteration.

```csharp
int i = 1;
while (i <= 5)
{
    int sum = 0;
    sum = sum + i;
    i = i + 1;

    Console.WriteLine("Running sum: " + sum);
}
```

**❌Output:**

```text
Running sum: 1
Running sum: 2
Running sum: 3
Running sum: 4
Running sum: 5
```

### ✔️Corrected Code

Move `int sum = 0;` outside the loop so the variable retains its value between iterations.

```csharp
int i = 1;
int sum = 0;

while (i <= 5)
{
    sum = sum + i;
    i = i + 1;

    Console.WriteLine("Running sum: " + sum);
}
```

**✔️Correct Output:**

```text
Running sum: 1
Running sum: 3
Running sum: 6
Running sum: 10
Running sum: 15
```

The final total is 15, which is the sum of the numbers from 1 through 5.

---

## ✏️Exercise 5.13-6 (Page 82) - Answer:

#### Loop A:

The loop runs 5 times. <br>
The values of a are: 0, 1, 2, 3, 4.

**Last line printed:**

```console
A4
```

#### Loop B:

The loop runs 5 times.<br>
The values of b are 1, 2, 3, 4, 5.

**Last line printed:**

```console
B5
```

---
## ✏️Exercise 5.13-7 (Page 82 - 83) - Answer:

The loop gets stuck at <b>i = 2</b> because the counter only increases when i is odd.<br>
Since <b>2 is even</b>, the condition is false and <b>i never changes</b>.

#### ✔️Corrected Code

```csharp
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
```

#### ✔️Output

```console
1
2
3
4
5
```