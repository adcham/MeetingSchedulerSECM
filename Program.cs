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
      //various methods used for random data creation automation

      //Number Randomizer
      Random _random = new Random();
      int RandomNumber(int min,int max)
      {
        return _random.Next(min, max);
      }

      void setPreferenceSlots(User userName)
      {
        for (int i = 0; i < 3; i++)
        {
          int j = RandomNumber(1, 3);
          userName.addPreferenceSlot(j);
        }
      }
      void setExclusionSlots(User userName)
      {
        for (int i = 0; i < 3; i++)
        {
          int j = RandomNumber(4, 6);
          userName.addExclusionSlot(j);
        }
      }
      /*
      void randomEquipmentAssigner(Location locationName,Equipment equipmentName)
      {
          locationName.addEquipmentToLocation(equipmentName);
      }
      */
      //random prefabricated data, not how the system stores data but rather made here to allow for experimentation and testing

      //3 main System Admin, Meeting Initiator and Equipment Keeper Users
      User sysAdmin = new User("Mazen", User.EmployeeType.systemAdmin);
      User meetingInitiator = new User("Mehmet", User.EmployeeType.meetingInitiator);
      User equipmentKeeper = new User("Maxwel", User.EmployeeType.equipmentKeeper);

      //A list of multiple participants
      User[] testParticipantArray = new User[6];
      //A list of assorted participant names
      String[] participantNames = {  "Mike",  "Adam",  "Ross",  "Sarah",  "Peter",  "Dale"  };

      //creating the users using their names, populating their exclusion and preference slots randomly yet not allowing them to intersect
      for (int userNumber = 0; userNumber < 6; userNumber++)
      {
        testParticipantArray[userNumber] = new User(participantNames[userNumber], User.EmployeeType.participant);
        setPreferenceSlots(testParticipantArray[userNumber]);
        setExclusionSlots(testParticipantArray[userNumber]);
      }

      //setting up the various locations including Storage (not accessible for meetings) and other possible meeting locations
      Location equipmentStorageLocation = new Location("Storage");
      Location[] locations = { new Location("Room 1"), new Location("Room 2"), new Location("Room 3"), new Location("Room 4"), new Location("Room 5")};


      //creating various equipment which can be included in any location and allow for easier manipulation
      Equipment[] randomEquipment = { new Equipment("Overhead Projector", true), new Equipment("Whiteboard", true), new Equipment("Laptop", true) , new Equipment("Desktop Computer", false),
      new Equipment("Telephone", false),new Equipment("Printer", false),new Equipment("3D Printer", false),new Equipment("Speakers", true)};

      for(int storageEquipment =0; storageEquipment <randomEquipment.Length; storageEquipment++) {
        equipmentStorageLocation.addEquipmentToLocation(randomEquipment[storageEquipment]);
      }
      //Adding Equipment to various rooms
      // Adding Overhead Projector, Whiteboard and Desktop Computer to Room 1
      locations[0].addEquipmentToLocation(randomEquipment[0]);
      locations[0].addEquipmentToLocation(randomEquipment[1]);
      locations[0].addEquipmentToLocation(randomEquipment[3]);

      //Adding Telephone, Printer and 3D Printer to Room 2
      locations[1].addEquipmentToLocation(randomEquipment[4]);
      locations[1].addEquipmentToLocation(randomEquipment[5]);
      locations[1].addEquipmentToLocation(randomEquipment[6]);

      //Adding Overhead Perojector,Desktop Computer and Speakers to Room 3
      locations[2].addEquipmentToLocation(randomEquipment[7]);
      locations[2].addEquipmentToLocation(randomEquipment[3]);
      locations[2].addEquipmentToLocation(randomEquipment[0]);

      //Adding Telephone, Desktop Computer and Whiteboard to Room 4
      locations[3].addEquipmentToLocation(randomEquipment[4]);
      locations[3].addEquipmentToLocation(randomEquipment[3]);
      locations[3].addEquipmentToLocation(randomEquipment[1]);

      //Adding Laptop, Whiteboard and Telephone to Room 5
      locations[4].addEquipmentToLocation(randomEquipment[2]);
      locations[4].addEquipmentToLocation(randomEquipment[1]);
      locations[4].addEquipmentToLocation(randomEquipment[4]);



      /* was randomly assigning equipment, better to keep it stable
      for  (int roomNumber  =  0; roomNumber  <  5; roomNumber++)
      {
        for (int i = 0; i < 3; i++)
        {
          int randomEquipmentNumber = RandomNumber(0, 7);
          randomEquipmentAssigner(locations[roomNumber], randomEquipment[randomEquipmentNumber]);
        }
      }
      */

      //A list of various meetings
      Meeting[] variousMeetings=new Meeting[4];
      //By default all meetings, at the moment, will set any added users to non-important and their confirmation of attendance to false
      //Administration Meeting at TimeSlot 1 and Location 2 (Room 2) & Administration User List
      // Room 4 is a suggested location and Overhead Projector,Telephone is requested equipment
      List<User> adminUsers = new List<User>();
      adminUsers.Add(sysAdmin);
      adminUsers.Add(meetingInitiator);
      adminUsers.Add(equipmentKeeper);
      variousMeetings[0] = new Meeting("Administration Meeting",adminUsers , 0, 1);
      variousMeetings[0].changeImportance("Mazen",true);
      variousMeetings[0].changeImportance("Mehmet", true);
      variousMeetings[0].changeAttendance("Mazen",  true);
      variousMeetings[0].changeAttendance("Mehmet", true);
      variousMeetings[0].addSuggestedLocation(locations[3]);
      variousMeetings[0].requestEquipment(randomEquipment[0]);
      variousMeetings[0].requestEquipment(randomEquipment[4]);


      //RandomMeeting1 with participants Mike, Adam(Important), Ross(Confirmed Attendance), Sarah (Confirmed Attendance) at TimeSlot 1 and Location 1 (Room 1)
      // Rooms 3,4 and 5 all added as suggested locations and Whiteboard, Speakers are requested equipment
      List<User> randomUsers1 = new List<User>();
      randomUsers1.Add(testParticipantArray[0]);
      randomUsers1.Add(testParticipantArray[1]);
      randomUsers1.Add(testParticipantArray[2]);
      randomUsers1.Add(testParticipantArray[3]);
      variousMeetings[1] = new Meeting("Meeting 1", randomUsers1, 0, 0);
      variousMeetings[1].changeImportance(testParticipantArray[1].getName(), true);
      variousMeetings[1].changeAttendance(testParticipantArray[3].getName(), true);
      variousMeetings[1].changeAttendance(testParticipantArray[4].getName(),true);
      variousMeetings[1].addSuggestedLocation(locations[2]);
      variousMeetings[1].addSuggestedLocation(locations[3]);
      variousMeetings[1].addSuggestedLocation(locations[4]);
      variousMeetings[1].requestEquipment(randomEquipment[1]);
      variousMeetings[1].requestEquipment(randomEquipment[7]);


      //RandomMeeting2 with participants Sarah(Important, Confirmed Attendance), Peter(Confirmed Attendance), Dale at TimeSlot 2 and Location 2 (Room 2)
      //Rooms 1 and 4 added as suggested locations and Laptop, Printer are requested equipment
      List<User> randomUsers2 = new List<User>();
      randomUsers2.Add(testParticipantArray[3]);
      randomUsers2.Add(testParticipantArray[4]);
      randomUsers2.Add(testParticipantArray[5]);
      variousMeetings[2] = new Meeting("Meeting 2", randomUsers1, 1, 1);
      variousMeetings[2].changeImportance(testParticipantArray[3].getName(), true);
      variousMeetings[2].changeAttendance(testParticipantArray[3].getName(), true);
      variousMeetings[2].changeAttendance(testParticipantArray[4].getName(), true);
      variousMeetings[2].addSuggestedLocation(locations[0]);
      variousMeetings[2].addSuggestedLocation(locations[3]);
      variousMeetings[2].requestEquipment(randomEquipment[2]);
      variousMeetings[2].requestEquipment(randomEquipment[5]);


      //RandomMeeting3 with participants Mike,Adam(Important,Cofirmed Attendance), Peter(Confirmed Attendance) at TimeSlot 3 and Location 5 (Room 5)
      // Rooms 2 and 4  added as suggested locations and Whiteboard,Telephone are requested equipment
      List<User> randomUsers3 = new List<User>();
      randomUsers3.Add(testParticipantArray[0]);
      randomUsers3.Add(testParticipantArray[1]);
      randomUsers3.Add(testParticipantArray[4]);
      variousMeetings[3] = new Meeting("Meeting 3", randomUsers1, 2, 4);
      variousMeetings[3].changeImportance(testParticipantArray[1].getName(), true);
      variousMeetings[3].changeAttendance(testParticipantArray[1].getName(), true);
      variousMeetings[3].changeAttendance(testParticipantArray[4].getName(), true);
      variousMeetings[3].addSuggestedLocation(locations[3]);
      variousMeetings[3].addSuggestedLocation(locations[1]);
      variousMeetings[3].requestEquipment(randomEquipment[1]);
      variousMeetings[3].requestEquipment(randomEquipment[4]);

  





      // logic for running the main menu
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainMenu());

    }
  }
}
