/*
**********************************************
3.11 Exercises

2. (Trace) Without running it, predict the output. Pay attention to == vs = and to how the operators combine.

    int health = 30;
    int potions = 2;
    bool isDead = (health == 0);
    bool inDanger = (health < 50) && (potions > 0);
    bool canAct = (health > 0) || (potions > 0);
    bool isFull = !(health < 100);
    Console.WriteLine(isDead);
    Console.WriteLine(inDanger);
    Console.WriteLine(canAct);
    Console.WriteLine(isFull);
**********************************************
*/

int health = 30;
int potions = 2;
bool isDead = (health == 0);
bool inDanger = (health < 50) && (potions > 0);
bool canAct = (health > 0) || (potions > 0);
bool isFull = !(health < 100);

Console.WriteLine("isDead: " +isDead);
Console.WriteLine("-----------------------");

Console.WriteLine("inDanger: " + inDanger);
Console.WriteLine("-----------------------");

Console.WriteLine("canAct: " +canAct);
Console.WriteLine("-----------------------");

Console.WriteLine("isFull: " +isFull);
Console.WriteLine("-----------------------");