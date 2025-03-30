using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FirstC_Proj.File_System
{
    internal class Validator
    {
        public static bool ValidateWithRegex(string input, string pattern, string errorMessage)
        {
            if (!Regex.IsMatch(input, pattern))
            {
                Console.WriteLine(errorMessage);
                return false;
            }
            return true;
        }

        public static bool ValidateNick(string nick)
        {
            return ValidateWithRegex(nick, "^[a-zA-Z0-9_]{3,16}$", "Nick must be 3-16 characters long.");
        }

        public static bool ValidateEmail(string email)
        {
            return ValidateWithRegex(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", "Invalid email format.");
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            return ValidateWithRegex(phoneNumber, @"^\+\d{1,3}[0-9]{9}$", "Phone number must start with '+' followed by 10-12 digits.");
        }

        public static bool ValidateRestaurantName(string name)
        {
            return ValidateWithRegex(name, @"^[a-zA-Z0-9\s-]+$", "Restaurant name can contain only letters, digits and spaces.");
        }

        public static bool ValidateRestaurantAddress(string address)
        {
            return ValidateWithRegex(address, @"^[a-zA-Z0-9\s,.-]+$", "Restaurant address can contain only letters, digits and spaces.");
        }

        public static bool ValidateKitchenName(string kitchen)
        {
            return ValidateWithRegex(kitchen, @"^[a-zA-Z]+$", "Kitchen name should contain only letters.");
        }

        public static bool ValidateRestaurantMark(string mark)
        {
            return ValidateWithRegex(mark, "^(1[0-2]|[1-9])$", "Restaurant mark should be a number from 1 to 12.");
        }

        public static bool ValidateUserResponse(string response)
        {
            return ValidateWithRegex(response, @"^[a-zA-Z0-9!)(,._!\"";:&?*%~`<>/+=-\s]{1,256}$", "Usser response should be between 1 and 256 characters long.");
        }
    }
}
