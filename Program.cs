using System;
namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building FiveOneTwo = new Building("512 8th Avenue")
      {
        Stories = 4,
        Width = 40,
        Depth = 40
      };
      Building ThreeTwenty = new Building("320 11th Avenue S"){
          Stories = 3,
          Width = 100,
          Depth = 100
      };
      Building Laskov = new Building("35 Haim Laskov St"){
          Stories = 7,
          Width = 50,
          Depth = 50
      };

        FiveOneTwo.Construct();
        ThreeTwenty.Construct();
        Laskov.Construct();

        FiveOneTwo.Purchase("Guy Cherkesky");
        ThreeTwenty.Purchase("Guy Cherkesky");
        Laskov.Purchase("Guy Cherkesky");

        // Console.WriteLine(FiveOneTwo.Description);
        // Console.WriteLine(ThreeTwenty.Description);
        // Console.WriteLine(Laskov.Description);

        City nashville = new City("Nashville", "Guy Cherkesky", 1980);

        nashville.addBuilding(FiveOneTwo);
        nashville.addBuilding(ThreeTwenty);
        nashville.addBuilding(Laskov);
        

        foreach (Building building in nashville.allBuildings) {
          Console.WriteLine(building.Description);
}
    }
  }
}
