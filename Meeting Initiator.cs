using System;
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
      Meeting[] meetingSlots = baseLocation.getTimeSlotsForThisLocation(indexOfLocation);
      meetingSlots[currentTimeSlot]  =  newMeeting;
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
      List<Meeting[]> listofMeetings = baseMeeting.getMeetingList();
      Meeting[] meetingSlots = baseLocation.getTimeSlotsForThisLocation(indexOfLocation);

      for (int slot = 0; slot < 6; slot++)
      {
        if (meetingSlots[slot] == null && listofMeetings.ElementAt(indexOfLocation-1)[slot]==null)
        {
          newMeetingTimeslotDropdown.Items.Add("Slot " + (slot + 1));
        }
      }
    }

    private void newMeetingTimeslotDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      updateEditMeetingParticipantsAndConflicts(true);

      if (newMeetingLocationDropdown.Text == " ")
        MessageBox.Show("Select a location first");
    }

    private void updateEditMeetingParticipantsAndConflicts(bool newMeeting)
    {
      usersToAddToNewMeeting.Clear();
      newMeetingParticipantList.Items.Clear();
      newMeetingChooseParticipantName.Items.Clear();

      List<User> potentialParticipantList = baseParticipant.getUserList();
      int potentialParticipantListLength = baseParticipant.getNoOfUsers();
      int currentTimeSlot;
      int counterOfParticipantsInString = 0;
      StringBuilder stringOfUnavailiableParticipants = new StringBuilder();
      bool editTimeSlotChanged =  false;
      if (newMeeting)
      {
        currentTimeSlot = (int)Char.GetNumericValue(newMeetingTimeslotDropdown.Text[5]);
        for (int i = 0; i < potentialParticipantListLength; i++)
        {
          User currentParticipant = potentialParticipantList.ElementAt(i);
          bool currentParticipantHasNotExcluded = !(currentParticipant.getExclusionSlot(currentTimeSlot));
          if (currentParticipantHasNotExcluded)
          {
            newMeetingChooseParticipantName.Items.Add(currentParticipant.getName());
          }
          else
          {
            if (counterOfParticipantsInString == 0)
            {
              stringOfUnavailiableParticipants.Append(currentParticipant.getName());
              counterOfParticipantsInString++;
            }
            else
            {
              stringOfUnavailiableParticipants.Append(", " + currentParticipant.getName());
              counterOfParticipantsInString++;
            }

          }
        }
      }
      else
      {
        if (editMeetingChangeTimeSlotDropdown.Text == "")
        {
          currentTimeSlot = (int)Char.GetNumericValue(currentTimeSlotLabel.Text[5]);
        }
        else
        {
          currentTimeSlot = (int)Char.GetNumericValue(editMeetingChangeTimeSlotDropdown.Text[5]);
          editTimeSlotChanged = true;
        }
        //similar logic but we check for participants already in the meeting and omit them
        Meeting currentMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
        for (int i = 0; i < potentialParticipantListLength; i++)
        {
          User currentParticipant = potentialParticipantList.ElementAt(i);
          if (!editTimeSlotChanged)
          {
            bool currentParticipantHasExcluded = (currentParticipant.getExclusionSlot(currentTimeSlot));
            bool currentParticipantHasExcludedOrInCurrentMeeting = currentParticipantHasExcluded
               && !((currentMeeting.getParticipantList().Contains(new Meeting.participant(currentParticipant, true)))
               || (currentMeeting.getParticipantList().Contains(new Meeting.participant(currentParticipant, false))));

            if (currentParticipantHasExcludedOrInCurrentMeeting)
            {
              if (counterOfParticipantsInString == 0)
              {
                stringOfUnavailiableParticipants.Append(currentParticipant.getName());
                counterOfParticipantsInString++;
              }
              else
              {
                stringOfUnavailiableParticipants.Append(", " + currentParticipant.getName());
                counterOfParticipantsInString++;
              }
            }
          }
          else
          {
            bool currentParticipantHasExcluded = currentParticipant.getExclusionSlot(currentTimeSlot);
            if (currentParticipantHasExcluded)
            {
              if (counterOfParticipantsInString == 0)
              {
                stringOfUnavailiableParticipants.Append(currentParticipant.getName());
                counterOfParticipantsInString++;
              }
              else
              {
                stringOfUnavailiableParticipants.Append(", " + currentParticipant.getName());
                counterOfParticipantsInString++;
              }
            }

          }
          
        }
      }

      if (counterOfParticipantsInString > 1)
      {
        stringOfUnavailiableParticipants.Append(" are");
      }
      else if (counterOfParticipantsInString == 0)
      {
        stringOfUnavailiableParticipants.Clear();
      }
      else
      {
        stringOfUnavailiableParticipants.Append(" is");
      }


      updateNewMeetingParticipantConflicts(stringOfUnavailiableParticipants.ToString(), newMeeting,currentTimeSlot);
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

      /*foreach (User u in potentialParticipantList)
      {
        if (!usersToAddToNewMeeting.Contains(u))
          newMeetingChooseParticipantName.Items.Add(u.getName());
      }*/


      int currentTimeSlot = (int)Char.GetNumericValue(newMeetingTimeslotDropdown.Text[5]);
      for (int i = 0; i < potentialParticipantList.Count; i++)
      {
        User currentParticipant = potentialParticipantList.ElementAt(i);
        bool currentParticipantHasNotExcluded = !(currentParticipant.getExclusionSlot(currentTimeSlot));
        bool userIsCurrentInNewMeetingParticipantList = newMeetingParticipantList.Items.Contains(currentParticipant.getName());
        if (currentParticipantHasNotExcluded && !userIsCurrentInNewMeetingParticipantList)
        {
          newMeetingChooseParticipantName.Items.Add(currentParticipant.getName());
        }

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
      editMeetingReset(currentlySelectedMeeting);
      
    }

    private void editMeetingReset(Meeting currentlySelectedMeeting)
    {
      updateEditMeetingParticipantLists(currentlySelectedMeeting);
      updateEditMeetingLocation(currentlySelectedMeeting);
      updateEditMeetingTimeSlot(currentlySelectedMeeting);
      updateEditMeetingAddNewParticipantDropdown(currentlySelectedMeeting);
      updateCurrentLocationEquipment();
      updateMeetingRequestedEquipment();
      updateMissingEquipmentPanel();
      updateEditMeetingParticipantsAndConflicts(false);
    }

    private void updateMissingEquipmentPanel()
    {
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      string missingEquipmentString = currentlySelectedMeeting.getMissingEquipmentToString();

      bool missingEquipmentStringEmpty = (missingEquipmentString == null | missingEquipmentString.Equals(""));

      if (missingEquipmentStringEmpty)
      {
        requestedEquipmentConflictDataGroupboxLabel.ForeColor = System.Drawing.Color.DarkGreen;
        requestedEquipmentConflictDataGroupboxLabel.Text = "No equipment conflicts";
        equipmentNotAtCurrentLocationLbl.ForeColor = System.Drawing.Color.Black;
        equipmentNotAtCurrentLocationLbl.Text = "All requested equipment is availiable at the current meeting location.";
      }
      else
      {
        requestedEquipmentConflictDataGroupboxLabel.ForeColor = System.Drawing.Color.DarkRed;
        requestedEquipmentConflictDataGroupboxLabel.Text = "Equipment conflicts found";
        equipmentNotAtCurrentLocationLbl.ForeColor = System.Drawing.Color.Black;
        equipmentNotAtCurrentLocationLbl.Text = missingEquipmentString + " not availiable at the current meeting location.";
      }
    }

    private void updateEditMeetingParticipantLists(Meeting meeting)
    {
      editMeetingImportantParticipantList.Items.Clear();
      editMeetingParticipantList.Items.Clear();
      editImportantMeetingParticipantAttendingListbox.Items.Clear();
      editMeetingParticipantAttendingListbox.Items.Clear();

      String Attendance;
      foreach (Meeting.participant p in meeting.getParticipantList())
      {
        if (p.getAttendance())
        {
          Attendance = "✔";
        }
        else
        {
          Attendance = "❌";
        }
        if (p.getImportance())
        {
          editMeetingImportantParticipantList.Items.Add(p);
          editImportantMeetingParticipantAttendingListbox.Items.Add(Attendance);
        }
        else
        {
          editMeetingParticipantList.Items.Add(p);
          editMeetingParticipantAttendingListbox.Items.Add(Attendance);
        }
      }

    }

    private void updateEditMeetingTimeSlot(Meeting meeting)
    {
      editMeetingChangeTimeSlotDropdown.Items.Clear();

      int timeSlot = meeting.getTimeSlot();
      int locationID = meeting.getMeetingLocation();

      currentTimeSlotLabel.Text = "Slot " + timeSlot.ToString();
      List<Meeting[]> meetingList = baseMeeting.getMeetingList();

      for (int i = 0; i < meeting.getNoOfTimeSlots(); i++)
      {
        if (meetingList.ElementAt(locationID)[i] == null)
          editMeetingChangeTimeSlotDropdown.Items.Add("Slot " + (i + 1).ToString());
      }

    }

    private void updateEditMeetingLocation(Meeting meeting)
    {
      editMeetingChangeLocationDropdown.Items.Clear();
      int timeSlot = meeting.getTimeSlot() - 1;
      List<Location> potentialLocations = baseLocation.GetLocationsWithoutStorage();
      int Location = meeting.getMeetingLocation();
      List<Meeting[]> meetingList = baseMeeting.getMeetingList();

      currentLocationLabel.Text = potentialLocations.ElementAt(Location).getName();

      for (int i = 0; i < potentialLocations.Count; i++)
      {
        if (meetingList.ElementAt(i)[timeSlot] == null)
          editMeetingChangeLocationDropdown.Items.Add(potentialLocations.ElementAt(i).getName());
      }

      updateEditMeetingAddNewParticipantDropdown(meeting);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      // remove selected participant
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      List<Meeting.participant> currentMeetingParticipants = currentlySelectedMeeting.getParticipantList();

      String tempParticipantName = editMeetingParticipantList.Text.ToString();
      String tempImportantParticipantName = editMeetingImportantParticipantList.Text.ToString();



      //Meeting.participant tempImportantParticipant = (Meeting.participant)editMeetingImportantParticipantList.SelectedItem;
      bool selectedParticipantIsImportant = (tempParticipantName.Equals("") && tempImportantParticipantName != null);
      if (selectedParticipantIsImportant)
      {
        MessageBox.Show("Please select a non-important participant to remove.");
      }
      else
      {

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
        updateEditMeetingParticipantsAndConflicts(false);
      }

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
      updateEditMeetingParticipantsAndConflicts(false);
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
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
        Meeting.deleteMeeting(timeslot, location);


        editMeetingAddParticipantDropdown.Text = "";
        editMeetingChangeLocationDropdown.Text = "";
        editMeetingImportantParticipantList.Text = "";
        editMeetingListChooseMeetingDropdown.Text = "";
        currentLocationLabel.Text = "";
        currentTimeSlotLabel.Text = "";

        editImportantMeetingParticipantAttendingListbox.Items.Clear();
        editMeetingParticipantAttendingListbox.Items.Clear();
        editMeetingImportantParticipantList.Items.Clear();
        editMeetingParticipantList.Items.Clear();
        editMeetingCurrentRequestedEquipment.Items.Clear();
        editMeetingCurrentLocationEquipment.Items.Clear();
        equipmentNotAtCurrentLocationLbl.Text = "";

        updateEditMeetingDropdown();
      }
    }
    /*
    private void resetExclusionSlotsBeforeDeleteMeeting(Meeting meeting, int timeSlot)
    {
      List<Meeting.participant> participants = meeting.getParticipantList();
      for (int i = 0; i < participants.Count; i++)
      {
        participants.ElementAt(i).p.removeExclusionSlot(timeSlot);
        participants.ElementAt(j).p.removeMeeting(meeting);
      }
    }
    */

    private void editMeetingAddNewParticipantButton_Click(object sender, EventArgs e)
    {
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      User currentUser = (User)editMeetingAddParticipantDropdown.SelectedItem;
      int timeSlot = (int)Char.GetNumericValue(currentTimeSlotLabel.Text[5]);
      currentlySelectedMeeting.addParticipant(currentUser, false);
      currentUser.addExclusionSlot(timeSlot + 1);
      editMeetingAddParticipantDropdown.Text = "";
      updateEditMeetingParticipantLists(currentlySelectedMeeting);
      updateEditMeetingAddNewParticipantDropdown(currentlySelectedMeeting);
      updateEditMeetingParticipantsAndConflicts(false);
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Meeting tempMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      int oldLocation = tempMeeting.getMeetingLocation();
      int oldTimeSlot = tempMeeting.getTimeSlot() - 1;
      string curSelectedLocation = "";
      if (editMeetingChangeLocationDropdown.SelectedItem != null)
      {
        curSelectedLocation = editMeetingChangeLocationDropdown.SelectedItem.ToString();
      }
      int newLocation = 0;
      int newTimeSlot = 0;

      if (editMeetingChangeTimeSlotDropdown.Text == "") { newTimeSlot = oldTimeSlot; }
      else { newTimeSlot = (int)Char.GetNumericValue(editMeetingChangeTimeSlotDropdown.Text[5]) - 1; }

      if (curSelectedLocation == "") { newLocation = oldLocation; }
      else { newLocation = baseLocation.getLocationIndexByString(curSelectedLocation) - 1; }

      if (newLocation != tempMeeting.getMeetingLocation())
        tempMeeting.changeLocation(newLocation);

      if (newTimeSlot != oldTimeSlot)
        tempMeeting.changeTimeSlot(newTimeSlot, oldTimeSlot);

      List<Meeting[]> listOfMeetings = baseMeeting.getMeetingList();
      List<Meeting.participant> listofParticipants = tempMeeting.getParticipantList();
      for (int j = 0; j < listofParticipants.Count; j++)
      {
        listofParticipants.ElementAt(j).p.addMeeting(tempMeeting);
        listofParticipants.ElementAt(j).p.addExclusionSlot(newTimeSlot + 1);

      }

      Meeting.deleteMeeting(oldTimeSlot, oldLocation);

      listOfMeetings.ElementAt(newLocation)[newTimeSlot] = tempMeeting;



      editMeetingChangeLocationDropdown.Text = "";
      editMeetingAddParticipantDropdown.Text = "";
      editMeetingChangeTimeSlotDropdown.Text = "";

      List<Location> potentialLocations = baseLocation.GetLocationsWithoutStorage();
      int locationIndex = tempMeeting.getMeetingLocation();
      List<Location> locationList = baseLocation.GetLocationsWithoutStorage();
      currentLocationLabel.Text = potentialLocations.ElementAt(locationIndex).getName();

      int timeSlot = tempMeeting.getTimeSlot();
      currentTimeSlotLabel.Text = "Slot " + timeSlot.ToString();

      updateMissingEquipmentPanel();
      updateCurrentLocationEquipment();
      updateEditMeetingLocation(tempMeeting);
      //update the list of potential meeting slots
      Meeting currentlySelectedMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      editMeetingReset(currentlySelectedMeeting);
    }


    private void editMeetingCurrentRequestedEquipment_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void editMeetingChangeLocationDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      updateCurrentLocationEquipment();
    }

    private void updateCurrentLocationEquipment()
    {
      editMeetingCurrentLocationEquipment.Items.Clear();

      Meeting tempMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      int meetingLocationIndex = tempMeeting.getMeetingLocation();

      List<Location> tempLocList = baseLocation.GetLocationsWithoutStorage();
      List<Equipment> equipmentToDisplay = tempLocList.ElementAt(meetingLocationIndex).GetEquipment();

      foreach (Equipment e in equipmentToDisplay)
      {
        editMeetingCurrentLocationEquipment.Items.Add(e);
      }
    }

    private void updateMeetingRequestedEquipment()
    {
      editMeetingCurrentRequestedEquipment.Items.Clear();
      Meeting tempMeeting = (Meeting)editMeetingListChooseMeetingDropdown.SelectedItem;
      foreach (Equipment e in tempMeeting.getRequestedEquipment())
      {
        editMeetingCurrentRequestedEquipment.Items.Add(e);
      }
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void updateNewMeetingParticipantConflicts(string conflicts, bool newMeeting,int timeSlot)
    {
      GroupBox groupBoxToEdit;
      Label labelToEdit;
      if (newMeeting)
      {
        groupBoxToEdit = createNewMeetingParticipantConflictsgroupBox;
        labelToEdit = participantConflictsToDisplayLbl;
      }
      else
      {
        groupBoxToEdit = editMeetingParticipantConflictsGroupbox;
        labelToEdit = editMeetingParticipantConflictsToDisplay;
      }

      bool anyParticipantConflicts = (conflicts == null | conflicts.Equals(""));

      if (anyParticipantConflicts)
      {
        groupBoxToEdit.ForeColor = System.Drawing.Color.DarkGreen;
        groupBoxToEdit.Text = "No participant conflicts";
        labelToEdit.ForeColor = System.Drawing.Color.Black;
        labelToEdit.Text = "All potential participants are availiable at meeting time slot "+timeSlot;
      }
      else
      {
        groupBoxToEdit.ForeColor = System.Drawing.Color.DarkRed;
        groupBoxToEdit.Text = "Participant conflicts found";
        labelToEdit.ForeColor = System.Drawing.Color.Black;
        labelToEdit.Text = conflicts + " not availiable at meeting time slot "+timeSlot;
      }
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
