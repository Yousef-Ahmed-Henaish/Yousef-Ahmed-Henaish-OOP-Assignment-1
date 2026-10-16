using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Reservation_System.Room
{
    public class RoomManagement
    {
        private readonly static List<Room> AllRooms = new List<Room>();


        public static void AddRoom(Room NewRoom)
        {
            AllRooms.Add(NewRoom);
        }

        public static void RemoveRoom(Room NewRoom)
        {
            AllRooms.Remove(NewRoom);
        }


        public double CalculateTotalPrice(Room room, int NumberOfNights)
        {
            if (NumberOfNights <= 0)
                throw new Exception("Invalid Nights Number.");

            return NumberOfNights * room.NighlyRate;
        }
    }
}
