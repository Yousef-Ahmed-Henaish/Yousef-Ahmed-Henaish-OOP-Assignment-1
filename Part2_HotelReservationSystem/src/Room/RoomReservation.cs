using System;
using System.Collections.Generic;
using System.Text;
using Hotel_Reservation_System.Guest;

namespace Hotel_Reservation_System.Room
{
    public class RoomReservation
    {
        public static int AllReservations { get; private set; } = 0;
        public RoomReservation( Guest.Guest NewGuest, Room NewRoom, int DaysNumber)
        {
            if (!RoomIsAvaliable(NewRoom))
                Console.WriteLine("Room Is Not Avaliable.");

            else
            {
                ID = ++AllReservations;
                ReservedRoom = NewRoom;
                CheckInDate = DateTime.Now;
                CheckOutDate = CheckInDate.AddDays(DaysNumber) ;
                Guest = NewGuest;
                Status = ReservationStatus.Pending;
            }
        }

        //Unique
        public int ID { get; set; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public Room? ReservedRoom { get; private set; }
        public Guest.Guest Guest { get; private set; }
        public ReservationStatus Status { get; private set; }

        public static Boolean RoomIsAvaliable(Room NewRoom)
        {
            if (! (NewRoom.IsReserved || NewRoom.UnderMaintenance) )
                return (true);
            else
                return (false);
        }

        public void CheckIn()
        {
            Status = ReservationStatus.CheckedIn;
        }

        public void CheckOut()
        {
            Status = ReservationStatus.CheckedOut;
        }

        public void CancelReservation()
        {
            Status = ReservationStatus.Cancelled;
        }

    }
}
