/**********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5557992

6.11 Exercises(Page 97 - 98)

    3.(Faded) Complete the method so it is a void method with one parameter that prints a
      labelled tile, then complete the two calls so the program prints a wall tile and a floor tile.

    PrintTile('#'); // call 1 — wall (given)
    ____     ('.'); // (A) call 2 — floor


    void PrintTile(____ tile) // (B) the parameter's type
    {
        Console.WriteLine("Tile: " + ____); // (C) print the parameter
    }
***********************************************/

PrintTile('#'); // call 1 — wall (given)
PrintTile('.'); // (A) call 2 — floor


void PrintTile(char tile) // (B) the parameter's type
{
    Console.WriteLine("Tile: " + tile); // (C) print the parameter
}