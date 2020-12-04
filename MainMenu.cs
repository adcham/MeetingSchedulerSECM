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
  public partial class MainMenu : Form
  {
    public MainMenu()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        System_Administrator newForm = new System_Administrator();
        this.Hide();
        newForm.ShowDialog();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.Application.Exit();
     }

    private void MainMenu_Load(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      Equipment_Keeper newForm = new Equipment_Keeper();
      this.Hide();
      newForm.ShowDialog();
    }

    private void goToMeetingInitiatorView_Click(object sender, EventArgs e)
    {
      Meeting_Initiator newForm = new Meeting_Initiator();
      this.Hide();
      newForm.ShowDialog();
    }

    private void goToParticipantView_Click(object sender, EventArgs e)
    {
      Participant newForm = new Participant();
      this.Hide();
      newForm.ShowDialog();
    }

    private void goToImportantParticipantView_Click(object sender, EventArgs e)
    {
      Important_Participant newForm = new Important_Participant();
      this.Hide();
      newForm.ShowDialog();
    }
  }
}
