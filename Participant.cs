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
      populateMeetingDropdown();
    }
 
    private void populateMeetingDropdown()
    {
      foreach (Meeting m in currentUser.getMeetings())
      {
        selectUserDropdown.Items.Add(m);
      }
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
    }
    private void populateMeetingControls()
    {
      if(currentUserImportant)
        setImportantParticipantMeetingControlsUsable();

      //-----regular participant features-----//
      //update participant list
      updateParticipantList();
      //update requested equipment list
      updateRequestedEquipmentList();
      //update add equipment dropdown

      //update labels for timeslot and location

      //-----important participant features-----//
      //update suggest location list
      //populate suggest location downdown
    }

    void setImportantParticipantMeetingControlsUsable()
    {

    }

    void updateParticipantList()
    {
      currentMeetingParticipantListbox.Items.Clear();

      foreach (Meeting.participant p in currentMeeting.getParticipantList())
        currentMeetingParticipantListbox.Items.Add(p);
    }

    void updateRequestedEquipmentList()
    {
      currentMeetingEquipmentListbox.Items.Clear();

      foreach (Equipment e in currentMeeting.getRequestedEquipment())
        currentMeetingParticipantListbox.Items.Add(e);
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
    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void backToMainMenuButton_Click(object sender, EventArgs e)
    {
      MainMenu newForm = new MainMenu();
      this.Hide();
      newForm.ShowDialog();
    }


  }
}
