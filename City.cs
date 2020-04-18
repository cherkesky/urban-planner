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

    }
    // fields
    private string _city;
    private string _mayor;
    private double _year;
    private List<Building> _allBuildings;

    // methods
    public void addBuilding(Building buildingToAdd)
    {
      _allBuildings.Add(buildingToAdd);
    }

  }


}
