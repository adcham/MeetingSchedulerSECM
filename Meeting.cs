﻿using System;
using System.Collections.Generic;
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

    static private int noOfParticipants;

    public string meetingName;
    public int meetingLocation;
    public int timeSlot;

    public struct participant
    {
      public User p;
      public bool important;

      public participant(User user, bool important)
      {
        p = user;
        this.important = important;
      }

      public bool getImportance()
      {
        return this.important;
      }

      public override string ToString()
      {
        return this.p.getName();
      }
    }

    private List<participant> participants;
    private string meetingInitiator;

    public Meeting()
    {
      /*  List<Location> temp = baseLocation.GetLocationsWithoutStorage();
        for (int i = 0; i < temp.Count; i++)
        {
          listOfMeetings.Add(new Meeting[NOOFTIMESLOTS]);
        }
      */

    }

    public Meeting(string mName, List<User> users, int timeSlot, int location)
    {
      meetingInitiator = "Mehmet";
      this.meetingName = mName;
      noOfParticipants = users.Count;
      participants = new List<participant>();
      this.meetingLocation = location;
      this.timeSlot = timeSlot;

      foreach (User u in users)
      {
        participants.Add(new participant(u, false));
        u.addExclusionSlot(timeSlot + 1);
      }

      listOfMeetings.ElementAt(location)[timeSlot] = this;
    }

    public void addParticipant(User participant, bool important)
    {
      participant tempParticipant = new participant(participant, important);
      participants.Add(tempParticipant);
      noOfParticipants++;
    }
    public void removeParticipant(string name)
    {
      int foundParticipantIndex = findParticipantIndex(name);
      if (foundParticipantIndex != -1)
      {
        participants.RemoveAt(foundParticipantIndex);
      }
      else
      {
        //code to say user was not found and therefore not removed.
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
      while (!found && foundIndex < noOfParticipants)
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
  }
}