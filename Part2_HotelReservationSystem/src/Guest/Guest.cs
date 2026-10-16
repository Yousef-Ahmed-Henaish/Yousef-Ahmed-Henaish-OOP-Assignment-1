using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Hotel_Reservation_System.Helpers;
using Hotel_Reservation_System.Room;

namespace Hotel_Reservation_System.Guest
{
    public class Guest
    {
        public Guest(string FullName, string PhoneNumber)
        {
            Validation.CheckGuestData(FullName, PhoneNumber);

            this.ID = ++GuestsNumber;
            this.FullName = FullName;
            this.PhoneNumber = PhoneNumber;
        }


        // Edit: Move this field to Manager Class
        private static int GuestsNumber;
        public int ID { get; }
        string? FullName { get; }
        string? PhoneNumber { get; }



        // Change type
        void GetAllGuestsReservations()
        {

        }
    }
}
