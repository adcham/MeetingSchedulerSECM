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
    private static List<User> userList = new List<User>();
    private int userID;
    private String name;
    public enum EmployeeType { systemAdmin = 0, equipmentKeeper = 1, meetingInitiator = 2, participant = 3 }
    private EmployeeType EmpType;
    private List<Meeting> meetingList;
    public bool[] exclusionSet;
    public bool[] preferenceSet;

    //default user constructor
    public User(string newName, EmployeeType empType)
    {
      userID = noOfUsers++;
      this.name = newName;
      EmpType = empType;

      meetingList = new List<Meeting>();
      exclusionSet = new bool[6];
      preferenceSet = new bool[6];
      userList.Add(this);
    }
    
    public User()
    {
      meetingList = new List<Meeting>();
      exclusionSet = new bool[6];
      preferenceSet = new bool[6];
    }

    public void addPreferenceSlot(int slot)
    {
      this.preferenceSet[slot-1]=true;
    }

    public bool getPreferenceSlot(int slot)
    {
      return preferenceSet[slot - 1];
    }

    public void addExclusionSlot(int slot)
    {
      this.exclusionSet[slot-1]=true;
    }

    public bool getExclusionSlot (int slot)
    {
      return exclusionSet[slot-1];
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

    public List<User> getUserList()
    {
      return userList;
    }

    public int getNoOfUsers()
    {
      return noOfUsers;
    }

    public User getUserByName(string name)
    {
      return userList.ElementAt(findUserIndex(name));
    }

    public int findUserIndex(string name)
    {
      int foundUserIndex = 0;
      bool found = false;
      while (!found && foundUserIndex < noOfUsers)
      {
        if (userList.ElementAt(foundUserIndex).getName() == name)
        {
          found = true;
        }
        else
        {
          foundUserIndex++;
        }
      }
      if (!found)
      {
        foundUserIndex = -1;
      }
      return foundUserIndex;

    }
  }
}