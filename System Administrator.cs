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
  public partial class System_Administrator : Form
  {
    public System_Administrator()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      listBox1.MultiColumn = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      MainMenu newForm = new MainMenu();
      this.Hide();
      newForm.ShowDialog();
    }

    private void System_Administrator_Load(object sender, EventArgs e)
    {

    }
  }
}
