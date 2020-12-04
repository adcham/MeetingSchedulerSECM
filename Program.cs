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
      testUser1.addExclusionSlot(4);
      testUser1.addExclusionSlot(5);
      testUser1.addExclusionSlot(6);

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
      Meeting testMeeting = new Meeting(currentUser);

      testMeeting.addParticipant(testUser1, false);
      testMeeting.addParticipant(testUser2, true);
      testMeeting.addParticipant(testUser3, false);

      testMeeting.changeImportance("Maxwel", false);
      testMeeting.removeParticipant("Adam");

      Equipment testEquipment = new Equipment("Projector",  true);
      Equipment testEquipment2 = new Equipment("Whiteboard", true);
      Equipment testEquipment3 = new Equipment("Laptops", true);

      Location testLocation = new Location("Room 1", "Sheffield Road");
      testLocation.addEquipmentToLocation(testEquipment);
      testLocation.addEquipmentToLocation(testEquipment2);
      testLocation.addEquipmentToLocation(testEquipment3);

      Location testLocation2 = new Location("Room 5", "Somewhere in Chesterfield");
      testLocation2.addEquipmentToLocation(testEquipment);
      testLocation2.addEquipmentToLocation(testEquipment2);
      testLocation2.addEquipmentToLocation(testEquipment3);

      // logic for running the main menu
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainMenu());
    }
  }
}
