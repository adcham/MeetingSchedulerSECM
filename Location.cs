using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
  class Location
  {
    private static int noOfLocations = 0;
    private int locationID;
    private string locationName;
    private string locationAddress;
    private List<Equipment> availableEquipment;

    public Location(string name, string address)
    {
      locationID = noOfLocations;
      noOfLocations++;

      locationName = name;
      locationAddress = address;

      availableEquipment = new List<Equipment>();
    }

    public void addEquipment(Equipment newEquipment)
    {
      availableEquipment.Add(newEquipment);
    }
  }
}