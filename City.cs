using System;
using System.Collections.Generic;

namespace Planner
{
  public class City
  {
    // constructor
    public City(string cityname, string mayor, double year)
    {
      _city=cityname;
      _mayor=mayor;
      _year=year;
      allBuildings = new List<Building>();

    }
    // fields
    private string _city;
    private string _mayor;
    private double _year;

    // properties
    public List<Building> allBuildings;

    // methods
    public void addBuilding(Building buildingToAdd)
    {
      allBuildings.Add(buildingToAdd);
    }

  }


}
