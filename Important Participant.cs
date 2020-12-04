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
  public partial class Important_Participant : Form
  {
    public Important_Participant()
    {
      InitializeComponent();
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
