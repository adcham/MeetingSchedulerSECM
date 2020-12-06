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
    private int noOfEquipment;
    private int locationID;
    private string locationName;
    //private string locationAddress;
    private List<Equipment> availableEquipment;

    public Location(string name)
    {
      locationID = noOfLocations;
      noOfLocations++;

      locationName = name;
      //  locationAddress = address;

      availableEquipment = new List<Equipment>();
      noOfEquipment = 0;

      locationList.Add(this);
    }

    public Location()
    {
      availableEquipment = new List<Equipment>();
    }

    public void addEquipmentToLocation(Equipment newEquipment)
    {
      this.availableEquipment.Add(newEquipment);
      noOfEquipment++;
    }
    public void addEquipmentToLocation(Equipment newEquipment,int indexOfLocation)
    {
      locationList.ElementAt(indexOfLocation).addEquipmentToLocation(newEquipment);
    }

    public void removeEquipmentFromLocation(string equipmentName)
    {
      availableEquipment.RemoveAt(findEquipmentIndex(equipmentName));
      noOfEquipment--;
    }

    public void removeEquipmentFromLocation(string equipmentName, int locationLindex)
    {
      locationList.ElementAt(locationLindex).removeEquipmentFromLocation(equipmentName);
    }

    public void deleteLocation(string eName)
    {
      int foundLocationIndex = findLocationIndex(eName);
      locationList.RemoveAt(foundLocationIndex);
      noOfLocations--;
    }

    public int findLocationIndex(string name)
    {
      int foundLocationIndex = 0;
      bool found = false;
      while (!found && foundLocationIndex < noOfLocations)
      {
        if (locationList.ElementAt(foundLocationIndex).locationName == name)
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
      while (!found && foundEquipmentIndex < this.noOfEquipment)
      {
        if (availableEquipment.ElementAt(foundEquipmentIndex).getName() ==  name)
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

    public int findEquipmentIndex(string name,int locationIndex)
    {
      return locationList.ElementAt(locationIndex).findEquipmentIndex(name);
    }

    public List<Location> GetLocations()
    {
      return locationList;
    }

    public int getNoOfLocations()
    {
      return noOfLocations;
    }

    public string getName()
    {
      return this.locationName;
    }

    public List<Equipment> GetEquipment()
    {
      return this.availableEquipment;
    }

    public List<Equipment> GetEquipment(int index)
    {
      return locationList.ElementAt(index).GetEquipment();
    }

    public int getNoOfEquipmentAtLocationIndex(int indexOfLocation)
    {
      return locationList.ElementAt(indexOfLocation).noOfEquipment;
    }

    public bool checkIfMovable(string equipmentName)
    {
      int foundEquipmentIndex = findEquipmentIndex(equipmentName);
      return availableEquipment.ElementAt(foundEquipmentIndex).movable;
    }
    public bool checkIfMovable(string equipmentName,int index)
    {
      return locationList.ElementAt(index).checkIfMovable(equipmentName);
    }

  }
}