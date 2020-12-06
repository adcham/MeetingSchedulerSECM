using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
  class Equipment
  {
    //static private List<Equipment> equipmentList = new List<Equipment>();

    private string name;
    public bool movable;

    public Equipment(string eName)
    {
      this.name = eName;
      this.movable = false;
    //  equipmentList.Add(this);
    }
    public Equipment(string eName, bool mov)
    {
      this.name = eName;
      this.movable = mov;
     // equipmentList.Add(this);
    }

    public string getName()
    {
      return this.name;
    }

    /*
    public void deleteEquipment(string eName)
    {
      int foundEquipmentIndex = findEquipment(eName);
      if (foundEquipmentIndex != -1)
      {
        equipmentList.RemoveAt(foundEquipmentIndex);
      }
      else
      {
        //code to say user was not found and therefore not removed.
      }
    }

    public int findEquipment(string eName)
    {
      int foundEquipmentIndex = 0;
      bool found = false;
      while (!found && foundEquipmentIndex < equipmentList.Count() - 1)
      {
        if (equipmentList.ElementAt(foundEquipmentIndex).name.Equals(eName))
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
    */

  }
}