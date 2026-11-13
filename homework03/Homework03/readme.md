**2.14.1 Exercise 1 (Trace)
Read the program below. Without running it, predict what will appear in the console output, one
line per Console.WriteLine.**



```text
int playerHealth = 75;

double speed = 2.5;
bool isAlive = true;

char symbol = '#';

string zone = "Dungeon";

Console.WriteLine(playerHealth);

Console.WriteLine(speed);

Console.WriteLine(isAlive);

Console.WriteLine(symbol);

Console.WriteLine(zone);
```



**Answer**:

75

2.5

True

`#`

Dungeon

----------------------------------------
**2.14.2 Exercise 2 (Trace)
Each of the following declarations contains a compile error. For each one, identify what is wrong
and write the corrected declaration.**


// (a)

int lives = 3.0;



// (b)

char direction = "N";


// (c)

bool hasKey = yes;


// (d)

string score = 100;




**Answer**:

```text
// (a)

int lives = 3; //Corrected


// (b)

char direction = 'N'; //Corrected


// (c)

bool hasKey = true; //Corrected


// (d)

int score = 100; //Corrected
```




---



**2.14.3 Exercise 3 (Faded)
Complete the program so that it declares one variable of each of the five types and prints each value. 
Follow the comments.**


// Declare an int variable called coins with value 50

___ coins = ___;

<br>

// Declare a double variable called weight with value 4.2

___ weight = ___;
<br><br>

// Declare a bool variable called isLocked with value false<br>
___ isLocked = ___;
<br><br>

// Declare a char variable called key with the character 'K'<br>
___ key = ___;
<br><br>

// Declare a string variable called roomName with value "Vault"<br>
___ roomName = ___;

Console.WriteLine(coins);<br>
Console.WriteLine(weight);<br>
Console.WriteLine(isLocked);<br>
Console.WriteLine(key);<br>
Console.WriteLine(roomName);<br>

<br>

**Answer**:

```text
// Declare an int variable called coins with value 50
int coins = 50;

// Declare a double variable called weight with value 4.2
double weight = 4.2;

// Declare a bool variable called isLocked with value false
bool isLocked = false;

// Declare a char variable called key with the character 'K'
char key = 'K';

// Declare a string variable called roomName with value "Vault"
string roomName = "Vault";

Console.WriteLine(coins);
Console.WriteLine(weight);
Console.WriteLine(isLocked);
Console.WriteLine(key);
Console.WriteLine(roomName);
```
