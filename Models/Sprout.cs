namespace GreenHouse.plant
{
  class Plants
  {

    public int Growth { get; set; }
    public int PlantWater { get; set; }
    public int PlantFood { get; set; }
    public int PlantSun { get; set; }


    public Plant(int growth, int plantWater, int plantFood, int plantSUn)
    {
      Growth = growth;
      PlantWater = plantWater;
      PlantFood = plantFood;
      PlantSun = plantSUn;
    }


    public void Plantlife()
    {

    }

    private void GrowPlant()
    {
      PlantWater--;
      PlantFood--;
      PlantSun--;
      Growth++;
    }

    private void GiveWater()
    {
      PlantWater += 3;
    }

    private void GiveFood()
    {
      PlantFood += 3;
    }

    private void GiveSun()
    {
      PlantSun += 3;
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










  }
}
