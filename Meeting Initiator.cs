﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
  public partial class Meeting_Initiator : Form
  {
    Location baseLocation = new Location();
    Meeting baseMeeting = new Meeting();
    User baseParticipant = new User();

    //users to ADD to a meeting
    List<User> usersToAddToNewMeeting = new List<User>();

    public Meeting_Initiator()
    {
      InitializeComponent();

      newMeetingLocationDropdown.Items.Clear();
      List<Location> menuLocations = baseLocation.GetLocations();
      for (int i = 0; i < baseLocation.getNoOfLocations(); i++)
      {
        if (!(menuLocations.ElementAt(i).getName() == "Storage"))
          newMeetingLocationDropdown.Items.Add(menuLocations.ElementAt(i).getName());
      }

      updateEditMeetingDropdown();
    }

    private void Meeting_Initiator_Load(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label11_Click(object sender, EventArgs e)
    {

    }

    private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      string currentlySelectedLocation = newMeetingLocationDropdown.Text;
      int indexOfLocation = baseLocation.findLocationIndex(currentlySelectedLocation) - 1;
      int currentTimeSlot = (int)Char.GetNumericValue(newMeetingTimeslotDropdown.Text[5]) - 1;
      string meetingName = newMeetingMeetingName.Text;
      Meeting newMeeting = new Meeting(meetingName, usersToAddToNewMeeting, currentTimeSlot, indexOfLocation);
      clearNewMeetingFormData();
      updateEditMeetingDropdown();
    }

    private void clearNewMeetingFormData()
    {
      newMeetingMeetingName.Text = "";
      newMeetingLocationDropdown.Text = "";
      newMeetingTimeslotDropdown.Text = "";
      newMeetingChooseParticipantName.Text = "";
      newMeetingChooseParticipantName.Items.Clear();
      newMeetingParticipantList.Items.Clear();
    }

    private void updateEditMeetingDropdown()
    {
      editMeetingListChooseMeetingDropdown.Items.Clear();

      List<Meeting[]> listOfMeetings = baseMeeting.getMeetingList();
      foreach (Meeting[] a in listOfMeetings)
      {
        for (int i = 0; i < baseMeeting.getNoOfTimeSlots(); i++)
        {
          if (a[i] != null)
          {
            editMeetingListChooseMeetingDropdown.Items.Add(a[i]);
          }
        }
      }

    }

    private void button9_Click(object sender, EventArgs e)
    {

    }

    private void backToMainMenuButton_Click(object sender, EventArgs e)
    {
      MainMenu newForm = new MainMenu();
      this.Hide();
      newForm.ShowDialog();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void newMeetingLocationDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      newMeetingTimeslotDropdown.Items.Clear();
      newMeetingTimeslotDropdown.Text = "";
      string currentlySelectedLocation = newMeetingLocationDropdown.Text;
      int indexOfLocation = baseLocation.findLocationIndex(currentlySelectedLocation);
      Meeting[] meetingSlots = baseLocation.getTimeSlotsForThisLocation(indexOfLocation);
      for (int slot = 0; slot < 6; slot++)
      {
        if (meetingSlots[slot] == null)
          newMeetingTimeslotDropdown.Items.Add("Slot " + (slot + 1));
      }
    }

    private void newMeetingTimeslotDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      usersToAddToNewMeeting.Clear();
      newMeetingParticipantList.Items.Clear();
      newMeetingChooseParticipantName.Items.Clear();
      List<User> potentialParticipantList = baseParticipant.getUserList();
      int potentialParticipantListLength = baseParticipant.getNoOfUsers();
      int currentTimeSlot = (int)Char.GetNumericValue(newMeetingTimeslotDropdown.Text[5]);

      for (int i = 0; i < potentialParticipantListLength; i++)
      {
        User currentParticipant = potentialParticipantList.ElementAt(i);
        bool currentParticipantHasNotExcluded = !(currentParticipant.getExclusionSlot(currentTimeSlot));
        if (currentParticipantHasNotExcluded)
          newMeetingChooseParticipantName.Items.Add(currentParticipant.getName());
      }

      if (newMeetingLocationDropdown.Text == "")
        MessageBox.Show("Select a location first");
    }

    private void newMeetingChooseParticipantName_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void addNewParticipant_Click(object sender, EventArgs e)
    {
      string participantToAddName = newMeetingChooseParticipantName.Text;
      User newMeetingUser = baseParticipant.getUserByName(participantToAddName);
      usersToAddToNewMeeting.Add(newMeetingUser);
      newMeetingParticipantList.Items.Add(newMeetingUser.getName());

      updatePotentialParticipantDropdown();

    }

    private void removeSelectedParticipantFromNewMeetingBtn_Click(object sender, EventArgs e)
    {
      int tempUserIndex = findSelectedParticipantObjectIndex(usersToAddToNewMeeting, newMeetingParticipantList);
      usersToAddToNewMeeting.RemoveAt(tempUserIndex);
      updatePotentialParticipantDropdown();
      newMeetingParticipantList.Items.RemoveAt(tempUserIndex);
    }

    private void newMeetingParticipantList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void updatePotentialParticipantDropdown()
    {
      newMeetingChooseParticipantName.Text = "";
      newMeetingChooseParticipantName.Items.Clear();
      List<User> potentialParticipantList = baseParticipant.getUserList();

      foreach (User u in potentialParticipantList)
      {
        if (!usersToAddToNewMeeting.Contains(u))
          newMeetingChooseParticipantName.Items.Add(u.getName());
      }
    }

    private int findSelectedParticipantObjectIndex(List<User> userList, ListBox listBoxOfParticipants)
    {
      string userToFindIndexFor = listBoxOfParticipants.GetItemText(listBoxOfParticipants.SelectedItem);

      int counter = 0;
      bool found = false;
      while (!found && counter < userList.Count)
      {
        if (userList.ElementAt(counter).getName() == userToFindIndexFor)
        {
          found = true;
        }
        else
        {
          counter++;
        }
      }

      return counter;
    }

    private void editMeetingListChooseMeetingDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      updateEditMeetingParticipantLists(currentlySelectedMeeting);
      updateEditMeetingLocation(currentlySelectedMeeting);
      updateEditMeetingTimeSlot(currentlySelectedMeeting);
      updateEditMeetingAddNewParticipantDropdown(currentlySelectedMeeting);
    }

    private void updateEditMeetingParticipantLists(Meeting meeting)
    {
      editMeetingImportantParticipantList.Items.Clear();
      editMeetingParticipantList.Items.Clear();

      foreach (Meeting.participant p in meeting.getParticipantList())
      {
        if (p.getImportance())
        {
          editMeetingImportantParticipantList.Items.Add(p);
        }
        else
        {
          editMeetingParticipantList.Items.Add(p);
        }
      }

    }

    private void updateEditMeetingTimeSlot(Meeting meeting)
    {
      int timeSlot = meeting.getTimeSlot();
      int locationID = meeting.getMeetingLocation();

      currentTimeSlotLabel.Text = "Slot " + timeSlot.ToString();
      //logic to add each availble meeting location for the time slot
      List<Meeting[]> meetingList = baseMeeting.getMeetingList();

      for (int i = 0; i < meeting.getNoOfTimeSlots(); i++)
      {
        if (meetingList.ElementAt(locationID)[i] == null)
          editMeetingChangeTimeSlotDropdown.Items.Add("Slot " + (i + 1).ToString());
      }

    }

    private void updateEditMeetingLocation(Meeting meeting)
    {
      int timeSlot = meeting.getTimeSlot();
      List<Location> menuLocations = baseLocation.GetLocations();
      int Location = meeting.getMeetingLocation() + 1;
      List<Meeting[]> meetingList = baseMeeting.getMeetingList();

      currentLocationLabel.Text = menuLocations.ElementAt(Location).getName();

      for (int i = 1; i < baseLocation.getNoOfLocations() - 1; i++)
      {
        if (meetingList.ElementAt(i)[timeSlot] == null)
          editMeetingChangeLocationDropdown.Items.Add(menuLocations.ElementAt(i).getName());
      }
      //adding current location to dropdown
      updateEditMeetingAddNewParticipantDropdown(meeting);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      // remove selected participant
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      List<Meeting.participant> currentMeetingParticipants = currentlySelectedMeeting.getParticipantList();
      Meeting.participant tempParticipant = (Meeting.participant)editMeetingParticipantList.SelectedItem;
      int i = 0;
      bool deleted = false;
      int timeSlot = (int)Char.GetNumericValue(currentTimeSlotLabel.Text[5]) - 1;

      while (i < currentMeetingParticipants.Count() && !deleted)
      {
        if (tempParticipant.p.getName() == currentMeetingParticipants.ElementAt(i).p.getName())
        {
          currentMeetingParticipants.ElementAt(i).p.removeExclusionSlot(timeSlot);
          currentMeetingParticipants.RemoveAt(i);
          deleted = true;
        }
        else
        {
          i++;
        }
      }

      updateEditMeetingParticipantLists(currentlySelectedMeeting);

      updateEditMeetingAddNewParticipantDropdown(currentlySelectedMeeting);
      //update dropdown of new participant
    }

    private void editMeetingParticipantList_SelectedIndexChanged(object sender, EventArgs e)
    {
      editMeetingImportantParticipantList.SelectedIndex = -1;
    }

    private void editMeetingImportantParticipantList_SelectedIndexChanged(object sender, EventArgs e)
    {
      editMeetingParticipantList.SelectedIndex = -1;
    }

    private void editMeetingAddParticipantDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void updateEditMeetingAddNewParticipantDropdown(Meeting meeting)
    {
      //get list of all users
      //filter out any already in participant lists
      //filter out any that have current timeslot as exclusion
      //add remaining users to the dropdown list
      editMeetingAddParticipantDropdown.Items.Clear();
      int timeSlot = -1;

      if (editMeetingChangeTimeSlotDropdown.Text == "")
      {
        timeSlot = meeting.getTimeSlot();
      }
      else
      {
        timeSlot = (int)Char.GetNumericValue(editMeetingChangeTimeSlotDropdown.Text[5]);
      }

      List<User> listOfAllUsers = baseParticipant.getUserList();

      foreach (User u in listOfAllUsers)
      {
        if (!u.getExclusionSlot(timeSlot))
        {
          bool participantIsNotAlreadyInMeeting = !(meeting.getParticipantList().Contains(new Meeting.participant(u, false)) || meeting.getParticipantList().Contains(new Meeting.participant(u, true)));
          if (participantIsNotAlreadyInMeeting)
            editMeetingAddParticipantDropdown.Items.Add(u);
        }
      }

    }

    private void editMeetingChangeTimeSlotDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      updateEditMeetingAddNewParticipantDropdown(currentlySelectedMeeting);
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      //make selected important participant unimportant
      changeEditMeetingSelectedUserImportance(false, editMeetingImportantParticipantList);
    }

    private void button8_Click(object sender, EventArgs e)
    {
      changeEditMeetingSelectedUserImportance(true, editMeetingParticipantList);

    }

    private void changeEditMeetingSelectedUserImportance(bool importance, ListBox participantList)
    {
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      List<Meeting.participant> currentMeetingParticipants = currentlySelectedMeeting.getParticipantList();
      int participantIndex = currentlySelectedMeeting.findParticipantIndex(participantList.SelectedItem.ToString());
      User tempuser = currentMeetingParticipants.ElementAt(participantIndex).p;
      currentMeetingParticipants.RemoveAt(participantIndex);
      currentlySelectedMeeting.addParticipant(tempuser, importance);

      updateEditMeetingParticipantLists(currentlySelectedMeeting);
    }

    private void button11_Click(object sender, EventArgs e)
    {
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      List<Meeting[]> listOfMeetings = baseMeeting.getMeetingList();

      string message = "Are you sure you want to delete meeting?";
      string title = "Delete Meeting";
      MessageBoxButtons buttons = MessageBoxButtons.YesNo;
      DialogResult result = MessageBox.Show(message, title, buttons);
      if (result == DialogResult.Yes)
      {
        int timeslot = currentlySelectedMeeting.getTimeSlot() - 1;
        int location = currentlySelectedMeeting.getMeetingLocation();
        resetExclusionSlotsBeforeDeleteMeeting(currentlySelectedMeeting, timeslot);
        Meeting.deleteMeeting(timeslot, location);


        editMeetingAddParticipantDropdown.Text = "";
        editMeetingChangeLocationDropdown.Text = "";
        editMeetingImportantParticipantList.Text = "";
        editMeetingListChooseMeetingDropdown.Text = "";
        currentLocationLabel.Text = "";
        currentTimeSlotLabel.Text = "";

        editMeetingImportantParticipantList.Items.Clear();
        editMeetingParticipantList.Items.Clear();

        updateEditMeetingDropdown();
      }
    }

    private void resetExclusionSlotsBeforeDeleteMeeting(Meeting meeting, int timeSlot)
    {
      List<Meeting.participant> participants = meeting.getParticipantList();
      for (int i = 0; i < participants.Count; i++)
      {
        participants.ElementAt(i).p.removeExclusionSlot(timeSlot);
      }
    }

    private void editMeetingAddNewParticipantButton_Click(object sender, EventArgs e)
    {
      //add participant
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      User currentUser = (User)editMeetingAddParticipantDropdown.SelectedItem;
      int timeSlot = (int)Char.GetNumericValue(currentTimeSlotLabel.Text[5]);
      currentlySelectedMeeting.addParticipant(currentUser, false);
      currentUser.addExclusionSlot(timeSlot);
      //need to add this time slot to the (User)editMeetingAddParticipantDropdown exlcusion set

      editMeetingAddParticipantDropdown.Text = "";
      updateEditMeetingParticipantLists(currentlySelectedMeeting);
      updateEditMeetingAddNewParticipantDropdown(currentlySelectedMeeting);

    }

    private void button5_Click(object sender, EventArgs e)
    {

      Meeting tempMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      int oldLocation = tempMeeting.getMeetingLocation();
      int oldTimeSlot = tempMeeting.getTimeSlot();
      string curSelectedLocation = editMeetingChangeLocationDropdown.SelectedItem.ToString();
      int newLocation = 0;
      int newTimeSlot = 0;

      if (editMeetingChangeTimeSlotDropdown.Text == "") { newTimeSlot = oldTimeSlot; }
      else { newTimeSlot = (int)Char.GetNumericValue(editMeetingChangeTimeSlotDropdown.Text[5])-1; }

      if (curSelectedLocation == "") { newLocation = oldLocation; }
      else { newLocation = baseLocation.getLocationIndexByString(curSelectedLocation); }


      if (newLocation != tempMeeting.getMeetingLocation())
        tempMeeting.changeLocation(newLocation);

      if(newTimeSlot != tempMeeting.getTimeSlot())
        tempMeeting.changeTimeSlot(newTimeSlot, oldTimeSlot);

      List<Meeting[]> listOfMeetings = baseMeeting.getMeetingList();
      Meeting.deleteMeeting(oldTimeSlot-1, oldLocation);
      listOfMeetings.ElementAt(newLocation)[newTimeSlot]  =  tempMeeting;

      editMeetingChangeLocationDropdown.Text = "";
      editMeetingAddParticipantDropdown.Text = "";
      editMeetingChangeTimeSlotDropdown.Text = "";

      List<Location> menuLocations = baseLocation.GetLocations();
      int Location = tempMeeting.getMeetingLocation() + 1;
      currentLocationLabel.Text = menuLocations.ElementAt(Location).getName();

      int timeSlot = tempMeeting.getTimeSlot();
      currentTimeSlotLabel.Text = "Slot " + timeSlot.ToString();

    }
  }
}
