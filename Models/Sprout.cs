namespace GreenHouse.plant
{
  class Plants
  {

    public int Growth { get; set; }
    public int PlantWater { get; set; }
    public int PlantFood { get; set; }
    public int PlantSun { get; set; }
    public bool PlantAlive { get; set; }



    public Plant()
    {
      Growth = 1;
      PlantWater = 5;
      PlantFood = 5;
      PlantSun = 5;
      PlantAlive = true;
    }


    public void Plantlife(string playerChoice)
    {
      if (playerChoice == "1")
      {
        GiveWater();
        Console.WriteLine("The plant feels a little more hydrated.");
      } else if (playerChoice == "2")
      {
        GiveFood();
        Console.WriteLine("The plant feels a little less hungry.");
      } else if (playerChoice == "3")
      {
        GiveSun();
        Console.WriteLine(@"The plant praises the sun. \o/");
      } else
      {
        Console.WriteLine("Not a valid input. No, you don't get your turn back.");
      }

      Random random = new Random();
      int rand = random.next(10);
      if (rand == 7)
      {
        WindStorm();
        Console.WriteLine("The winds become severe and the clouds block the sun.");
      } else  if (rand == 8)
      {
        AphidAttack();
        Console.WriteLine("Pestilence come out of the ether and saps the lifeblood of the Plant.");
      } else if (rand == 9)
      {
        SlugBite();
        Console.WriteLine("Slug chomps on Plant. That asshole.");
      }
      GrowPlant();
      WinLose();

    }

    private void GrowPlant()
    {
      if (PlantFood > 0 && PlantWater > 0 && PlantSun > 0)
      {
        PlantWater--;
        PlantFood--;
        PlantSun--;
        Growth++;
      } else {
        Growth--;
      }
    }

    private void GiveWater()
    {
      PlantWater += 4;
    }

    private void GiveFood()
    {
      PlantFood += 4;
    }

    private void GiveSun()
    {
      PlantSun += 4;
    }

    private void WindStorm()
    {
      PlantSun--;
    }

    private void AphidAttack()
    {
      PlantFood--;
      PlantWater--;
    }

    private void SlugBite()
    {
      growth--;
    }

    private void WinLose()
    {
      if (Growth <= 0)
      {
        PlantAlive = false;
      }
    }












  }
}
