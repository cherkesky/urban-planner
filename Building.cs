using System;

namespace Planner
{
  public class Building
  {
    /*
    constructor
    */
    public Building(string address)
    {
      _address = address;
    }
    /*
    fields
    */
    private string _designer;
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;
    /*
     properties
     */
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume
    {
      get
      {
        return Width * Depth;
      }
    }
    /*
    methods
    */
    public void Construct(){
      _dateConstructed = DateTime.Now;
    }
    public void Purchase(string owner){
      _owner = owner;
    }


  }
}