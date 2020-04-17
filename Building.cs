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
    private string _designer = "Guy Cherkesky";
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
        return Width * Depth * (3 * Stories);
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

    public string Description{
      get{
        return $@"
                {_address}
                --------------
                Designed by {_designer}
                Constructed on {_dateConstructed}
                Own by {_owner}
                {Volume} cubic meters of space";
      }
    }
  }
}