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
      //implement populating participant list
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

    }
  }
}
