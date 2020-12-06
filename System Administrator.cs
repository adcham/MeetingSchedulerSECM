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
    Location baseLocation = new Location("Base");
    public System_Administrator()
    {
      InitializeComponent();
      updateList();
    }

    public void updateList()
    {
      locationListbox.Items.Clear();
      List<Location> menuLocations = baseLocation.GetLocations();
      for (int i = 0; i < baseLocation.getNoOfLocations(); i++)
      {
        locationListbox.Items.Add(menuLocations.ElementAt(i).getName());
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Location newLocation = new Location(addLocationNameTextbox.Text, addLocationAddressTextbox.Text);
      addLocationNameTextbox.Text = "";
      addLocationAddressTextbox.Text = "";
      updateList();
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      locationListbox.MultiColumn = true;
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

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      baseLocation.deleteLocation(locationListbox.GetItemText(locationListbox.SelectedItem));
      updateList();
    }
  }
}
