using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webService.App_Code
{
    public class PhoneContact
    {
        private bool validPhoneNumber(string phoneNumber)
        {
            int phoneNumberLength = phoneNumber.Length;
            int i = 0;

            // check if the phone number is in valid length
            if (phoneNumberLength != 10)
            {
                return false;
            }

            // check if all characters are numbers
            for (i = 0; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public string email { set; get; }

        public string phoneNumber
        {
            set
            {
                phoneNumber = "Unvalid phone number";
                if (validPhoneNumber(value))
                {
                    phoneNumber = value;
                }
            }
            get
            {
                return phoneNumber;
            }
        }
        public string name { get; set; }
    }
}