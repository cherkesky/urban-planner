using System;
using System.Collections.Generic;

namespace Planner
{
  public class City
  {
    // constructor
    public City()
    {

    }
    // fields
    private string _city;
    private string _mayor;
    private double _year;
    private List<Building> _allBuildings;


    public void addBuilding(Building buildingToAdd)
    {
      _allBuildings.Add(buildingToAdd);
    }

  }


}
