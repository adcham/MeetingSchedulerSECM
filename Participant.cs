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
  public partial class Participant : Form
  {
    List<User> listOfAllUsersInSystem = User.getUserLists();
    User currentUser;
    Meeting currentMeeting;
    bool currentUserImportant;
    Location baseLocation = new Location();

    public Participant()
    {
      InitializeComponent();
      populateUserList();
    }

    private void populateUserList()
    {
      foreach (User u in listOfAllUsersInSystem)
      {
        selectUserDropdown.Items.Add(u);
      }
    }

    private void selectUserDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      currentUser = (User)selectUserDropdown.SelectedItem;
      clearAllCurrentlySelectedMeetingInformation();
      populatePreferenceAndExclusionSets();
      populateMeetingDropdown();
    }

    private void populatePreferenceAndExclusionSets()
    {
      populateCheckedListBoxForSet(currentUser.preferenceSet, preferenceSetCheckedListBox);
      populateCheckedListBoxForSet(currentUser.exclusionSet, exclusionSetCheckedListBox);
    }

    private void populateCheckedListBoxForSet(bool[] set, CheckedListBox clb)
    {
      clb.Items.Clear();
      int counter = 0;
      foreach (bool isSelected in set)
      {
        string slotLabel = "Slot " + (counter + 1);
        clb.Items.Add(slotLabel, isSelected);
        counter++;
      }
    }

    private void populateMeetingDropdown()
    {
      selectMeetingDropdown.Items.Clear();

      foreach (Meeting m in currentUser.getMeetings())
      {
        selectMeetingDropdown.Items.Add(m);
      }
    }

    public void clearAllCurrentlySelectedMeetingInformation()
    {
      selectMeetingDropdown.Items.Clear();
      selectMeetingDropdown.Text = "";

      currentMeetingParticipantListbox.Items.Clear();

      currentMeetingEquipmentListbox.Items.Clear();

      currentMeetingSuggestEquipmentDropdown.Items.Clear();
      currentMeetingSuggestEquipmentDropdown.Text = "";

      importantParticipantSelectNewLocationToSuggestDropdown.Items.Clear();
      importantParticipantSelectNewLocationToSuggestDropdown.Text = "";

      importantParticipantSuggestedMeetingLocationsListbox.Items.Clear();

      confirmAttendanceCheckbox.Checked = false;
    }

    private void selectMeetingDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      currentMeeting = (Meeting)selectMeetingDropdown.SelectedItem;
      detectAndSetImportance();
      populateMeetingControls();
    }
    private void detectAndSetImportance()
    {
      foreach (Meeting.participant p in currentMeeting.getParticipantList())
      {
        if (p.getUser() == currentUser)
          currentUserImportant = p.getImportance();
      }

      if (!currentUserImportant)
      {
        //make important user controls readonly and set panelBG to grey
        importantUserControlPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
        setImportantParticipantMeetingControlsUsable(false);
      }
      else
      {
        //make important user controls usable and set panelBG to blue
        importantUserControlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
        setImportantParticipantMeetingControlsUsable(true);
      }
    }
    private void populateMeetingControls()
    {

      //-----regular participant features-----//
      //update participant list
      updateParticipantList();
      //update requested equipment list
      updateRequestedEquipmentList();
      //update add equipment dropdown
      updateRequestEquipmentDropdown();
      //update labels for timeslot and location
      updateTimeSlotAndLocationLabels();
      //update attendance
      updateAttendingCheckBox();

      //-----important participant features-----//
      //update suggest location list
      updateSuggestedLocationsListbox();
      //populate suggest location downdown
      updateSuggestedLocationsDropdown();

    }

    private void updateAttendingCheckBox()
    {
      confirmAttendanceCheckbox.Checked = currentMeeting.getAttendance(currentUser.getName());
    }

    private void setImportantParticipantMeetingControlsUsable(bool usable)
    {
      if (usable)
      {
        importantParticipantAddSuggestedLocationBtn.Show();
        importantParticipantSelectNewLocationToSuggestDropdown.Show();
        importantParticipantSelectLocationLbl.Text = "Select new location to suggest";
      }
      else
      {
        importantParticipantAddSuggestedLocationBtn.Hide();
        importantParticipantSelectNewLocationToSuggestDropdown.Hide();
        importantParticipantSelectLocationLbl.Text = "Only important participants may suggest locations.";
      }


    }

    private void updateParticipantList()
    {
      currentMeetingParticipantListbox.Items.Clear();

      foreach (Meeting.participant p in currentMeeting.getParticipantList())
        currentMeetingParticipantListbox.Items.Add(p);
    }

    private void updateRequestedEquipmentList()
    {
      currentMeetingEquipmentListbox.Items.Clear();

      foreach (Equipment e in currentMeeting.getRequestedEquipment())
        currentMeetingEquipmentListbox.Items.Add(e);
    }

    private void updateRequestEquipmentDropdown()
    {
      currentMeetingSuggestEquipmentDropdown.Items.Clear();
      currentMeetingSuggestEquipmentDropdown.Text = "";

      foreach (Equipment e in Equipment.getListOfAllEquipment())
      {
        bool equipmentAlreadySuggested = currentMeetingEquipmentListbox.Items.Contains(e);

        if (!equipmentAlreadySuggested)
          currentMeetingSuggestEquipmentDropdown.Items.Add(e);
      }

    }

    private void updateTimeSlotAndLocationLabels()
    {
      int currentMeetingIndex = currentMeeting.getMeetingLocation();
      string currentLocationName = currentMeeting.getLocationName();

      currentMeetingLocationLbl.Text = currentLocationName;
      currentMeetingTimeSlotLbl.Text = "Slot " + currentMeetingIndex;
    }
    private void updateSuggestedLocationsListbox()
    {
      importantParticipantSuggestedMeetingLocationsListbox.Items.Clear();

      foreach (Location l in currentMeeting.getSuggestedLocations())
        importantParticipantSuggestedMeetingLocationsListbox.Items.Add(l);
    }

    private void updateSuggestedLocationsDropdown()
    {
      importantParticipantSelectNewLocationToSuggestDropdown.Items.Clear();
      importantParticipantSelectNewLocationToSuggestDropdown.Text = "";

      foreach (Location l in baseLocation.GetLocationsWithoutStorage())
      {
        bool meetingAlreadySuggested = importantParticipantSuggestedMeetingLocationsListbox.Items.Contains(l);
        if (!meetingAlreadySuggested)
          importantParticipantSelectNewLocationToSuggestDropdown.Items.Add(l);
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      //check value of checkbox and set it according to the change
      if (currentMeeting != null) {
        if (confirmAttendanceCheckbox.Checked == true)
        {
          currentMeeting.changeAttendance(currentUser.getName(), true);
        }
        else
        {
          currentMeeting.changeAttendance(currentUser.getName(), false);
        }
      }

    }

    private void backToMainMenuButton_Click(object sender, EventArgs e)
    {
      MainMenu newForm = new MainMenu();
      this.Hide();
      newForm.ShowDialog();
    }

    private void savePrefenceAndExclusionsButton_Click(object sender, EventArgs e)
    {
      bool[] newPreferenceSet = new bool[6];
      bool[] newExclusionSet = new bool[6];

      // -1 value represents a false boolean
      int[] checkedPreferenceIndicies = { -1, -1, -1, -1, -1, -1 };
      int[] checkedExclusionIndicies = { -1, -1, -1, -1, -1, -1 };
      preferenceSetCheckedListBox.CheckedIndices.CopyTo(checkedPreferenceIndicies, 0);
      preferenceSetCheckedListBox.CheckedIndices.CopyTo(checkedExclusionIndicies, 0);

      foreach (int i in checkedPreferenceIndicies)
      {
        if (i >= 0)
          newPreferenceSet[i] = true;
      }

      foreach (int i in checkedExclusionIndicies)
      {
        if (i >= 0)
          newExclusionSet[i] = true;
      }

      bool anyDuplicates = false;
      for (int i = 0; i < 6; i++)
      {
        if (newPreferenceSet[i] == newExclusionSet[i])
          anyDuplicates = true;
      }

      if (anyDuplicates)
        MessageBox.Show("Please make sure you have not prefered and excluded the same time slot.");
      else
      {
        currentUser.exclusionSet = newExclusionSet;
        currentUser.preferenceSet = newExclusionSet;
        MessageBox.Show("Changes to your exclusion and preference sets have been saved.");
      }

    }

    private void importantParticipantAddSuggestedLocationBtn_Click(object sender, EventArgs e)
    {
      if (importantParticipantSelectNewLocationToSuggestDropdown.SelectedItem != null)
      {
        currentMeeting.addSuggestedLocation((Location)importantParticipantSelectNewLocationToSuggestDropdown.SelectedItem);
        updateSuggestedLocationsListbox();
        updateSuggestedLocationsDropdown();
      }
      else
      {
        MessageBox.Show("Please select a location to suggest");
      }
    }

    private void currentMeetingRequestEquipmentBtn_Click(object sender, EventArgs e)
    {
      if (currentMeetingSuggestEquipmentDropdown.SelectedItem != null)
      {
        currentMeeting.requestEquipment((Equipment)currentMeetingSuggestEquipmentDropdown.SelectedItem);
        updateRequestedEquipmentList();
        updateRequestEquipmentDropdown();
      }
      else
      {
        MessageBox.Show("Please select a piece of equipment to request");
      }
    }

    private void currentMeetingBackOutOfMeetingBtn_Click(object sender, EventArgs e)
    {
      if (currentUserImportant)
      {
        MessageBox.Show("The meeting initiator, Mehmet, has been notified that you would like to back out of the meeting.");
      }
      else
      {
        string currentUserName = currentUser.getName();

        currentMeeting.removeParticipant(currentUserName);

        MessageBox.Show("You have been removed from the meeting");

        clearAllCurrentlySelectedMeetingInformation();
        populatePreferenceAndExclusionSets();
      }
    }

    private void preferenceSetCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
    }
    private void Participant_Load(object sender, EventArgs e)
    {

    }
    private void label1_Click(object sender, EventArgs e)
    {

    }
    private void label2_Click(object sender, EventArgs e)
    {

    }
    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }
    private void label4_Click(object sender, EventArgs e)
    {

    }
    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void label14_Click(object sender, EventArgs e)
    {

    }
  }

}
