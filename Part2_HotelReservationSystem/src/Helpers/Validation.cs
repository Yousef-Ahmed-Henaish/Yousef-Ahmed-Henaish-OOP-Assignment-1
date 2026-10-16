using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Reservation_System.Helpers
{
    public class Validation
    {

        // Validation on Register
        public static void CheckGuestData(string FullName, string PhoneNumber)
        {
            Boolean isNameInvalid = string.IsNullOrWhiteSpace(FullName);
            Boolean isNumberInvalid = string.IsNullOrWhiteSpace(PhoneNumber);

            if (isNameInvalid && isNumberInvalid)
            {
                throw new ArgumentNullException("Wrong Full Name and Phone Number.");
            }

            if (isNameInvalid)
            {
                throw new ArgumentNullException("Wrong Full Name");
            }

            if (isNumberInvalid)
            {
                throw new ArgumentNullException("Wrong Phone Number");
            }
        }





    }
}
