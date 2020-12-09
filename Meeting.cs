using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
  class Meeting
  {
    Location baseLocation = new Location();

    public static List<Meeting[]> listOfMeetings = new List<Meeting[]>();
    public const int NOOFTIMESLOTS = 6;

    private int noOfParticipants;

    public string meetingName;
    public int meetingLocation;
    public int timeSlot;
    private List<Equipment> requestedEquipment;
    private List<Location> suggestedLocations;

    public struct participant
    {
      public User p;
      public bool important;
      public bool confirmedAttendance;

      public participant(User user, bool important)
      {
        p = user;
        this.important = important;
        confirmedAttendance = false;
      }
      public participant(User user, bool important,bool attendance)
      {
        p = user;
        this.important = important;
        confirmedAttendance = attendance;
      }

      public void confirmAttendance()
      {
        this.confirmedAttendance  =  true;
      }
      public void unConfirmAttendance()
      {
        this.confirmedAttendance = false;
      }
      public bool getAttendance()
      {
                return confirmedAttendance;
      }
      public bool getImportance()
      {
        return this.important;
      }

      public override string ToString()
      {
        return this.p.getName();
      }

      public void setUnimportant()
      {
        Debug.WriteLine("Setting participant important to" + false);
        this.important = false;
      }

      public User getUser()
      {
        return this.p;
      }
    }

    public void changeAttendance(string name,bool value)
    {
      int foundParticipantIndex = findParticipantIndex(name);
      if (foundParticipantIndex != -1)
      {
        addParticipant(participants[foundParticipantIndex].p, participants[foundParticipantIndex].important, value) ;
        participants.RemoveAt(foundParticipantIndex);
      }
    }
    public bool getAttendance(string name)
    {
      int foundParticipantIndex = findParticipantIndex(name);
      if (foundParticipantIndex != -1)
      {
        return participants[foundParticipantIndex].confirmedAttendance;
      }
      return false;
    }

    private List<participant> participants;
    private string meetingInitiator;

    public Meeting()
    {

    }

    public Meeting(string mName, List<User> users, int timeSlot, int location)
    {
      meetingInitiator = "Mehmet";
      this.meetingName = mName;
      noOfParticipants = users.Count;
      participants = new List<participant>();
      requestedEquipment = new List<Equipment>();
      suggestedLocations = new List<Location>();
      this.meetingLocation = location;
      this.timeSlot = timeSlot;

      foreach (User u in users)
      {
        participants.Add(new participant(u, false));
        u.addExclusionSlot(timeSlot + 1);
                u.addMeeting(this);
      }

      listOfMeetings.ElementAt(location)[timeSlot] = this;
    }
    ~Meeting() { }
    public void addSuggestedLocation(Location suggestLocation)
    {
      suggestedLocations.Add(suggestLocation);
    }

    public List<Location> getSuggestedLocations()
    {
      return this.suggestedLocations;
    }
    public void removeSuggestedLocation(Location locationToBeRemoved)
    {
      suggestedLocations.Remove(locationToBeRemoved);
    }

    public void requestEquipment(Equipment e)
    {
      requestedEquipment.Add(e);
    }

    public void removeRequestedEquipment(Equipment equipmentToBeRemoved)
    {
      requestedEquipment.Remove(equipmentToBeRemoved);
    }

    public List<Equipment> getRequestedEquipment()
    {
      return requestedEquipment;
    }

    public string getMissingEquipmentToString()
    {
      StringBuilder missingEquipmentList = new StringBuilder();
      List<Equipment> listOfEquipmentAtCurrentLocation = baseLocation.GetEquipment(meetingLocation+1);
      bool firstitem = true;

      foreach (Equipment e in requestedEquipment)
      {
        bool found = false;
        int counter = 0;
        while (!found && counter < listOfEquipmentAtCurrentLocation.Count)
        {
          bool equipmentExists = listOfEquipmentAtCurrentLocation.ElementAt(counter).getName() == e.getName();
          if (equipmentExists)
          {
            found = true;
          }
          else
          {
            counter++;
          }
        }
        if (!found)
        {
          if (firstitem)
          {
            missingEquipmentList.Append(e.getName());
            firstitem = false;
          }
          else
            missingEquipmentList.Append(", " + e.getName());
        }
      }

      return missingEquipmentList.ToString();
    }
    public static void deleteMeeting(int timeslot,int location)
    {
      Meeting[] tempMeetingArray  =  new Meeting[NOOFTIMESLOTS];
      for (int i = 0; i < NOOFTIMESLOTS; i++)
      {
        if (i != timeslot)
        {
          tempMeetingArray[i]  =  listOfMeetings.ElementAt(location)[i];
        }
      }
      List<Meeting.participant> participantList = listOfMeetings.ElementAt(location)[timeslot].getParticipantList();
      for (int j = 0; j < participantList.Count; j++)
      {
        participantList.ElementAt(j).p.removeMeeting(listOfMeetings.ElementAt(location)[timeslot]);
        participantList.ElementAt(j).p.removeExclusionSlot(timeslot);
      }
      listOfMeetings.RemoveAt(location);
      listOfMeetings.Insert(location, tempMeetingArray);
      



      //Meeting tempMeeting = listOfMeetings.ElementAt(location)[timeslot];
      //tempMeeting = null;
    }

    public String getLocationName()
    {
      return Location.getName(meetingLocation);
    }

    public void addParticipant(User participant, bool important)
    {
      participant tempParticipant = new participant(participant, important);
      participants.Add(tempParticipant);
      noOfParticipants++;
    }
    public void addParticipant(User participant, bool important,bool attendance)
    {
      participant tempParticipant = new participant(participant, important,attendance);
      participants.Add(tempParticipant);
      noOfParticipants++;
    }
    public void removeParticipant(string name)
    {
      int foundParticipantIndex = findParticipantIndex(name);
      int currentTimeSlot = this.getTimeSlot()-1;

      if (foundParticipantIndex != -1)
      {
        participants.ElementAt(foundParticipantIndex).p.removeMeeting(this);
        //removing the exclusion slot
        participants.ElementAt(foundParticipantIndex).p.removeExclusionSlot(currentTimeSlot);
        
        //removing the participant from the participants
        participants.RemoveAt(foundParticipantIndex);
      }
      else
      {
        
      }
    }
    public void changeImportance(string name, bool importance)
    {
      int foundParticipantIndex = findParticipantIndex(name);
      if (foundParticipantIndex != -1)
      {
        addParticipant(participants[foundParticipantIndex].p, importance);
        participants.RemoveAt(foundParticipantIndex);
      }

    }
    
    public int findParticipantIndex(string name)
    {
      int foundIndex = 0;
      bool found = false;
      while (!found && foundIndex < participants.Count)
      {
        if (participants.ElementAt(foundIndex).p.getName().Equals(name))
        {
          found = true;
        }
        else
        {
          foundIndex++;
        }
      }
      if (!found)
      {
        foundIndex = -1;
      }
      return foundIndex;
    }


    public List<Meeting[]> getMeetingList()
    {
      return listOfMeetings;
    }

    public int getNoOfTimeSlots()
    {
      return NOOFTIMESLOTS;
    }

    public override string ToString()
    {
      return this.meetingName;
    }

    public List<participant> getParticipantList()
    {
      return participants;
    }

    public int getTimeSlot()
    {
      return this.timeSlot + 1;
    }
    public int getMeetingLocation()
    {
      return meetingLocation;
    }

    public void changeLocation(int location)
    {
      this.meetingLocation  =  location;
    }

    public void changeTimeSlot(int timeSlot, int oldTimeSlot)
    {
      this.timeSlot = timeSlot;

      foreach(participant pToChangeExclusionsFor in this.participants)
      {
        pToChangeExclusionsFor.p.removeExclusionSlot(oldTimeSlot);
        pToChangeExclusionsFor.p.addExclusionSlot(timeSlot+1);
      }

    }

  }
}