using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
  class Location
  {
    static public List<Location> locationList = new List<Location>();
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

      locationList.Add(this);
    }

    public Location(string name)
    {
      locationName = name;
      availableEquipment = new List<Equipment>();
    }

    public void addEquipmentToLocation(Equipment newEquipment)
    {
      this.availableEquipment.Add(newEquipment);
    }

    public void removeEquipmentFromLocation(string equipmentName)
    {
      availableEquipment.RemoveAt(findEquipmentIndex(equipmentName));
    }

    public void deleteLocation(string eName)
    {
      int foundLocationIndex = findLocationIndex(eName);
      if (foundLocationIndex != -1)
      {
        locationList.RemoveAt(foundLocationIndex);
      }
      else
      {
        //code to say user was not found and therefore not removed.
      }
    }

    public int findLocationIndex(string name)
    {
      int foundLocationIndex = 0;
      bool found = false;
      while (!found && foundLocationIndex < locationList.Count() - 1)
      {
        if (locationList.ElementAt(foundLocationIndex).locationName.Equals(name))
        {
          found = true;
        }
        else
        {
          foundLocationIndex++;
        }
      }
      if (!found)
      {
        foundLocationIndex = -1;
      }
      return foundLocationIndex;
      
    }

    public int findEquipmentIndex(string name)
    {
      int foundEquipmentIndex = 0;
      bool found = false;
      while (!found && foundEquipmentIndex < locationList.Count() - 1)
      {
        if (locationList.ElementAt(foundEquipmentIndex).locationName.Equals(name))
        {
          found = true;
        }
        else
        {
          foundEquipmentIndex++;
        }
      }
      if (!found)
      {
        foundEquipmentIndex = -1;
      }
      return foundEquipmentIndex;

    }

    public List<Location> GetLocations()
    {
      return locationList;
    }

    public int getNoOfLocations()
    {
      return noOfLocations;
    }

    public string getName() {
      return this.locationName;
    }

  }
}