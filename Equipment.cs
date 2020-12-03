using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
  class Equipment
  {
    static private List<Equipment> equipmentList = new List<Equipment>;
    private string name;
    private bool movable;
    private bool temporary;

    public Equipment(string eName)
    {
      this.name = eName;
      this.movable = false;
      this.temporary = false;
      equipmentList.Add(this);
    }
    public Equipment(string eName, bool mov, bool temp)
    {
      this.name = eName;
      this.movable = mov;
      this.temporary = temp;
      equipmentList.Add(this);
    }


  }
}