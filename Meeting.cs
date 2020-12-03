using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
  class Meeting
  {
    private List<User> participants;
    private char startSlot;
    private char endSlot;

    public Meeting(char startSlot, char endSlot)
    {
      this.startSlot = startSlot;
      this.endSlot = endSlot;
      participants = new List<User>;
    }
  }
}