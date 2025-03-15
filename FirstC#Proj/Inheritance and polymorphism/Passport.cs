using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Passport
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public string PassportNumber { get; set; }
        public string DateOfBirth { get; set; }

        public Passport(string firstName, string lastName, string nationality, string passportNumber, string dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            PassportNumber = passportNumber;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName}");
            sb.AppendLine($"Nationality: {Nationality}");
            sb.AppendLine($"Passport Number: {PassportNumber}");
            sb.AppendLine($"Date of Birth: {DateOfBirth:dd.MM.yyyy}");
            return sb.ToString();
        }
    }
}
