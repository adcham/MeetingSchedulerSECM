using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
      //update editMeetingChangeLocationDropdown
      //update editMeetingChangeTimeSlotDropdown
    }

    private void updateEditMeetingParticipantLists(Meeting meeting)
    {
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
  }
}
