using System;
using System.Collections.Generic;
using System.Text;
using Hotel_Reservation_System.Guest;

namespace Hotel_Reservation_System.Room
{

    public class Room
    {
        // Room R1 = new Room(1, Single, 500);
        public Room(int Number, RoomType Type, double NighlyRate )
        {
            // Expected Edit: Avoid Number Repetition.
            this.Number = Number;
            this.Type = Type; 
            this.NighlyRate = NighlyRate;
            this.UnderMaintenance = false;
            this.IsReserved = false;
        }

        
        public int Number { get; }
        public RoomType Type { get; }
        public double NighlyRate { get; private set; }
        public Boolean UnderMaintenance { get; private set; }
        public Boolean IsReserved { get; set; }


        public void StartMaintenance()
        {
            if (UnderMaintenance)
                Console.WriteLine("Room is in Maintenance Already.");
            else if (IsReserved)
                Console.WriteLine("Room is Reserved now.");
            else
                UnderMaintenance = true;
        }

        public void EndMaintenance()
        {
            if (!UnderMaintenance)
                Console.WriteLine("Room Not In Maintenance.");
            else
                UnderMaintenance = false;
        }

        public void AdjustPrice(Room room, double NewNighlyRate)
        {
            if (NewNighlyRate < 0)
                throw new Exception("NighlyRate Must be greater than 0");

            room.NighlyRate = NewNighlyRate;
        }

    }
}
