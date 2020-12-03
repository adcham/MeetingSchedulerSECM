using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MeetingScheduler
{
  class User
  {
    private static int noOfUsers = 0;
    private int userID;
    private String name;
    public enum EmployeeType { systemAdmin = 0, equipmentKeeper = 1, meetingInitiator = 2, participant = 3 }
    private EmployeeType EmpType;
    private List<Meeting> meetingList;
    private List<int> exclusionSet;
    private List<int> preferenceSet;

    //default user constructor
    public User(string newName, EmployeeType empType)
    {
      userID = noOfUsers++;
      this.name = newName;
      EmpType = empType;

      meetingList = new List<Meeting>();
      exclusionSet = new List<int>();
      preferenceSet = new List<int>();
    }
    public void addPreferenceSlot(int slot)
    {
      this.preferenceSet.Add(slot);
    }

    public void addExclusionSlot(int slot)
    {
      this.exclusionSet.Add(slot);
    }

    public void addMeeting(Meeting newMeeting)
    {
      this.meetingList.Add(newMeeting);

      //add meeting to exlusion set (need to add correct logic here)
      //this.exclustionSet.Add(newMeeting.slot);
    }

    public string getName()
    {
      return this.name;
    }

  }
}