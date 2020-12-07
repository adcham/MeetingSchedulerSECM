using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MeetingScheduler
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

      Meeting[,] MeetingSlots = new Meeting[6, 4];

      User testSysAdmin = new User("Mazen Omar", User.EmployeeType.systemAdmin);
      User currentUser = testSysAdmin;

      //adding some test users
      User testUser1 = new User("Mazen", User.EmployeeType.participant);
      User testUser2 = new User("Maxwel", User.EmployeeType.participant);
      User testUser3 = new User("Adam", User.EmployeeType.participant);

      testUser1.addPreferenceSlot(1);
      testUser1.addPreferenceSlot(2);
      testUser1.addPreferenceSlot(3);
      testUser1.addExclusionSlot(3);
      testUser1.addExclusionSlot(4);
      testUser1.addExclusionSlot(5);

      testUser2.addPreferenceSlot(1);
      testUser2.addPreferenceSlot(2);
      testUser2.addPreferenceSlot(3);
      testUser2.addExclusionSlot(4);
      testUser2.addExclusionSlot(5);
      testUser2.addExclusionSlot(6);

      testUser3.addPreferenceSlot(1);
      testUser3.addPreferenceSlot(2);
      testUser3.addPreferenceSlot(3);
      testUser3.addExclusionSlot(4);
      testUser3.addExclusionSlot(5);
      testUser3.addExclusionSlot(6);

      //adding test meeting


      Equipment testEquipment = new Equipment("Projector", false);
      Equipment testEquipment2 = new Equipment("Whiteboard", true);
      Equipment testEquipment3 = new Equipment("Laptops", true);
      Equipment testEquipment4 = new Equipment("unique equipment", true);
      Equipment testEquipment5 = new Equipment("Projector", false);

      Location equipmentStorageLocation = new Location("Storage");
      Equipment storageEquipment1 = new Equipment("Stored Equipment A", true);
      Equipment storageEquipment2 = new Equipment("Stored Equipment B", true);
      Equipment storageEquipment3 = new Equipment("Stored Equipment C", true);
      Equipment storageEquipment4 = new Equipment("Stored Equipment D", true);
      Equipment storageEquipment5 = new Equipment("Stored Equipment E", true);
      Equipment storageEquipment6 = new Equipment("Stored Equipment F", true);
      Equipment storageEquipment7 = new Equipment("Stored Equipment G", true);
      Equipment storageEquipment8 = new Equipment("Stored Equipment H", true);
      equipmentStorageLocation.addEquipmentToLocation(storageEquipment1);
      equipmentStorageLocation.addEquipmentToLocation(storageEquipment2);
      equipmentStorageLocation.addEquipmentToLocation(storageEquipment3);
      equipmentStorageLocation.addEquipmentToLocation(storageEquipment4);
      equipmentStorageLocation.addEquipmentToLocation(storageEquipment5);
      equipmentStorageLocation.addEquipmentToLocation(storageEquipment6);
      equipmentStorageLocation.addEquipmentToLocation(storageEquipment7);
      equipmentStorageLocation.addEquipmentToLocation(storageEquipment8);

      Location testLocation = new Location("Room 1");
      testLocation.addEquipmentToLocation(testEquipment);
      testLocation.addEquipmentToLocation(testEquipment2);
      testLocation.addEquipmentToLocation(testEquipment3);
      testLocation.addEquipmentToLocation(testEquipment4);
      testLocation.addEquipmentToLocation(testEquipment5);

      Location testLocation2 = new Location("Room 5");
      testLocation2.addEquipmentToLocation(testEquipment);
      testLocation2.addEquipmentToLocation(testEquipment3);

      List<User> potentialParticipantsForTestMeeting = new List<User>();
      potentialParticipantsForTestMeeting.Add(testUser1);
      potentialParticipantsForTestMeeting.Add(testUser2);
      potentialParticipantsForTestMeeting.Add(testUser3);
      //add meeting to test
      Meeting testMeeting = new Meeting("testMeeting", potentialParticipantsForTestMeeting, 0, 1);
      testMeeting.changeImportance("Adam", true);





      // logic for running the main menu
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainMenu());

    }
  }
}
