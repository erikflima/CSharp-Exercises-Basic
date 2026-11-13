/**********************************************
Instructions: https://elearning.nbcc.ca/d2l/le/lessons/321977/topics/5557992

6.11 Exercises(Page 97)

    1.(Trace) Two methods are defined; the main code calls both. Predict the exact output without
      running it. When you hit a method name plus (), jump into that method’s body, run it, and
      (if it returns) bring the value back to where you called it.


        PrintTile('@'); // CALL a void method

        int damage = AddBonus(10); // CALL a returning method — CATCH the result
        Console.WriteLine("Total damage: " + damage);

        void PrintTile(char tile){
            Console.WriteLine("Tile: " + tile);
        }

        int AddBonus(int baseDamage){
            return baseDamage + 5; // hand the value back
        }

***********************************************/


PrintTile('@'); // CALL a void method

int damage = AddBonus(10); // CALL a returning method — CATCH the result
Console.WriteLine("Total damage: " + damage);


//-----------------
void PrintTile(char tile){

    Console.WriteLine("Tile: " + tile);
}

int AddBonus(int baseDamage){

    return baseDamage + 5; // hand the value back
}