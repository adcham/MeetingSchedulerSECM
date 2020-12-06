
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
  public partial class Equipment_Keeper : Form
  {
    Location baseLocation = new Location();
    public Equipment_Keeper()
    {
      InitializeComponent();
      updateList(addEquipmentLocationDropdown);
      updateList(moveEquipmentLocationDropdown);
      updateList(removeEquipmentLocationDropdown);
      updateList(selectLocationBox);

    }

    public void updateList(ComboBox comboBoxName)
    {
      List<Location> menuLocations = baseLocation.GetLocations();
      for (int i = 0; i < baseLocation.getNoOfLocations(); i++)
      {
        comboBoxName.Items.Add(menuLocations.ElementAt(i).getName());
      }
    }

    private void backToMainMenuButton_Click(object sender, EventArgs e)
    {
      MainMenu newForm = new MainMenu();
      this.Hide();
      newForm.ShowDialog();
    }

    private void backToMainMenuButton_Click_1(object sender, EventArgs e)
    {
      MainMenu newForm = new MainMenu();
      this.Hide();
      newForm.ShowDialog();
    }

    private void equipmentList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      //remove button
      string location = removeEquipmentLocationDropdown.Text;
      string equipmentToRemove = removeEquipmentDropdown.Text;
      int indexOfLocation = baseLocation.findLocationIndex(location);
      baseLocation.removeEquipmentFromLocation(equipmentToRemove, indexOfLocation);
      removeEquipmentDropdown.Text = "";
      updateEquipmentList(removeEquipmentLocationDropdown, removeEquipmentDropdown);

      bool ifAddedToCurrentlySelectedLocation = selectLocationBox.GetItemText(selectLocationBox.SelectedItem) == location;
      if (ifAddedToCurrentlySelectedLocation)
      {
        updateEquipmentList();
      }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void Equipment_Keeper_Load(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {

    }

    private void selectLocationBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      updateEquipmentList();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string currentlySelectedLocation = addEquipmentLocationDropdown.GetItemText(addEquipmentLocationDropdown.SelectedItem);
      int indexOfLocation = baseLocation.findLocationIndex(currentlySelectedLocation);
      bool movable = moveableCheckBox.Checked;
      string equipmentName = addEquipmentNameTextbox.Text;
      Equipment newEquipment = new Equipment(equipmentName, movable);
      baseLocation.addEquipmentToLocation(newEquipment, indexOfLocation);

      bool ifAddedToCurrentlySelectedLocation = selectLocationBox.GetItemText(selectLocationBox.SelectedItem) == currentlySelectedLocation;
      if (ifAddedToCurrentlySelectedLocation)
      {
        updateEquipmentList();
      }

      addEquipmentNameTextbox.Text = "";
      moveableCheckBox.Checked = false;
    }

    public void updateEquipmentList()
    {
      equipmentList.Items.Clear();
      string currentlySelectedLocation = selectLocationBox.GetItemText(selectLocationBox.SelectedItem);
      int indexOfLocation = baseLocation.findLocationIndex(currentlySelectedLocation);
      List<Equipment> equipmentForLocation = baseLocation.GetEquipment(indexOfLocation);
      for (int i = 0; i < baseLocation.getNoOfEquipmentAtLocationIndex(indexOfLocation); i++)
      {
        equipmentList.Items.Add(equipmentForLocation.ElementAt(i).getName());
      }
    }
    public void updateEquipmentList(ComboBox locationDropdown, ComboBox equipmentDropdown)
    {
      equipmentDropdown.Items.Clear();
      string currentlySelectedLocation = locationDropdown.GetItemText(locationDropdown.SelectedItem);
      int indexOfLocation = baseLocation.findLocationIndex(currentlySelectedLocation);
      List<Equipment> equipmentForLocation = baseLocation.GetEquipment(indexOfLocation);
      for (int i = 0; i < baseLocation.getNoOfEquipmentAtLocationIndex(indexOfLocation); i++)
      {
        equipmentDropdown.Items.Add(equipmentForLocation.ElementAt(i).getName());
      }
    }

    private void removeEquipmentLocationDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      updateEquipmentList(removeEquipmentLocationDropdown, removeEquipmentDropdown);
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
      moveEquipmentNewLocationDropdown.Items.Clear();
      List<Location> menuLocations = baseLocation.GetLocations();
      for (int i = 0; i < baseLocation.getNoOfLocations(); i++)
      {
        if (!(menuLocations.ElementAt(i).getName() == moveEquipmentLocationDropdown.Text))
          moveEquipmentNewLocationDropdown.Items.Add(menuLocations.ElementAt(i).getName());
      }
    }

    private void moveEquipmentLocationDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      moveEquipmentNewLocationDropdown.Text = "";
      moveEquipmentNameTextbox.Text = "";

      updateEquipmentList(moveEquipmentLocationDropdown, moveEquipmentNameTextbox);
      //update moveEquipmentLocationDropdown
      //update moveEquipmentNameTextbox
      moveEquipmentNewLocationDropdown.Items.Clear();
      List<Location> menuLocations = baseLocation.GetLocations();
      for (int i = 0; i < baseLocation.getNoOfLocations(); i++)
      {
        if (!(menuLocations.ElementAt(i).getName() == moveEquipmentLocationDropdown.Text))
          moveEquipmentNewLocationDropdown.Items.Add(menuLocations.ElementAt(i).getName());
      }
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      // move equipment button logic
      // first check if its movable
      // if not, message box an error

      string currentLocation = moveEquipmentLocationDropdown.Text;
      string equipmentToMove = moveEquipmentNameTextbox.Text;
      string newLocation = moveEquipmentNewLocationDropdown.Text;
      int currentLocationIndex = baseLocation.findLocationIndex(currentLocation);
      int newLocationIndex = baseLocation.findLocationIndex(newLocation);
      bool moveable = baseLocation.checkIfMovable(equipmentToMove, currentLocationIndex);

      if (moveable)
      {
        //add to new newLocation equipment list
        //delete from currentLocation equipment list
        List<Equipment> equipmentForLocation = baseLocation.GetEquipment(currentLocationIndex);
        baseLocation.addEquipmentToLocation(equipmentForLocation.ElementAt(baseLocation.findEquipmentIndex(equipmentToMove, currentLocationIndex)), newLocationIndex);
        baseLocation.removeEquipmentFromLocation(equipmentToMove, currentLocationIndex);

        bool ifChangingEquipmentAtCurrentlySelectedLocation = ((selectLocationBox.GetItemText(selectLocationBox.SelectedItem) == currentLocation) || (selectLocationBox.GetItemText(selectLocationBox.SelectedItem) == newLocation));
        if (ifChangingEquipmentAtCurrentlySelectedLocation)
        {
          updateEquipmentList();
        }

        moveEquipmentNameTextbox.Text = "";
        moveEquipmentNewLocationDropdown.Text = "";


      }
      else
      {
        MessageBox.Show("Sorry, this piece of equipment is not movable between locations.", "Equipment Error");
      }


    }
  }
}
