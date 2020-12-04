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
  }
}
