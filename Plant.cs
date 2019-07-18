using System;
using System.Collections.Generic;
using GreenHouse.plant;

namespace Greenhouse
{
  public class Program
  {

    public static void Main()
    {
      Plants Ficus = new Plants();
      string userInput;
        Console.WriteLine("You have bought a Plant.");

      while (Ficus.PlantAlive == true) {
        Console.WriteLine("What would you like to do? Please type in the corresponding number.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Write("( 1. Water plant 2. Feed plant 3. Give plant some sun 4. Check Plant status)");
        Console.ResetColor();
        Console.WriteLine();
        userInput = Console.ReadLine();
        Ficus.Plantlife(userInput);
      }
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Game Over. Your Plant is dead. Hint: buying a plant is futile. It always dies.");
      Console.ResetColor();










    }
  }
}
