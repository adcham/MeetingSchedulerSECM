﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingScheduler
{
  class Meeting
  {
   static private int noOfParticipants;
   public struct participant
    {
      public User p;
      public bool important;

      public participant(User user, bool important)
      {
        p = user;
        this.important = important;
      }
    }

    private List<participant> participants;
    User meetingInitiator;

    public Meeting(User initiator)
    {
      meetingInitiator = initiator;
      noOfParticipants = 0;
      participants = new List<participant>();
    }

    public void addParticipant(User participant, bool important)
    {
      participant tempParticipant = new participant(participant, important);
      participants.Add(tempParticipant);
      noOfParticipants++;
    }
    public void removeParticipant(string name) {
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
    public void changeImportance(string name, bool importance) {
      int foundParticipantIndex = findParticipantIndex(name);
      if (foundParticipantIndex != -1)
      {
        addParticipant(participants[foundParticipantIndex].p,  importance);
        participants.RemoveAt(foundParticipantIndex);
      }

    }
    public int findParticipantIndex(string name)
    {
      int foundIndex = 0;
      bool found = false;
      while (!found && foundIndex < noOfParticipants - 1)       
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
        foundIndex  =  -1;
      }
      return foundIndex;
    }

  }
}