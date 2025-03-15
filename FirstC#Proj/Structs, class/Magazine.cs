using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Magazine
    {

        private string _magazineName;
        private string _yearOfCreation;
        private string _magazineDescription;
        private string _contactPhoneNumber;
        private string _contactEmail;

        public Magazine() { }

        public Magazine(string magazineName, string yearOfCreation, string magazineDescription, string contactPhoneNumber, string contactEmail)
        {
            _magazineName = magazineName;
            _yearOfCreation = yearOfCreation;
            _magazineDescription = magazineDescription;
            _contactPhoneNumber = contactPhoneNumber;
            _contactEmail = contactEmail;
        }

        public void InputData()
        {
            Console.Write("Enter magazine name: ");
            _magazineName = Console.ReadLine();

            Console.Write("Enter year of creation: ");
            _yearOfCreation = Console.ReadLine();

            Console.Write("Enter description magazine: ");
            _magazineDescription = Console.ReadLine();

            Console.Write("Phone number: ");
            _contactPhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            _contactEmail = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nInfo about magazine:");
            Console.WriteLine($"Magazine name: {_magazineName}");
            Console.WriteLine($"Year of creation magazine: {_yearOfCreation}");
            Console.WriteLine($"Description: {_magazineDescription}");
            Console.WriteLine($"Phone number: {_contactPhoneNumber}");
            Console.WriteLine($"Email: {_contactEmail}");
        }

        public string MagazineName
        {
            get { return _magazineName; }
            set { _magazineName = value; }
        }

        public string YearOfCreation
        {
            get { return _yearOfCreation; }
            set { _yearOfCreation = value; }
        }

        public string MagazineDescription
        {
            get { return _magazineDescription; }
            set { _magazineDescription = value; }
        }

        public string PhoneNumber
        {
            get { return _contactPhoneNumber; }
            set { _contactPhoneNumber = value; }
        }

        public string Email
        {
            get { return _contactEmail; }
            set { _contactEmail = value; }
        }

    }
}
