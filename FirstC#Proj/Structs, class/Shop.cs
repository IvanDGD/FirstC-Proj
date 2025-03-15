using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Shop
    {

        private string _shopName;
        private string _adress;
        private string _shopDescription;
        private string _contactPhoneNumber;
        private string _contactEmail;

        public Shop() { }

        public Shop(string shopName, string adress, string shopDescription, string contactPhoneNumber, string contactEmail)
        {
            _shopName = shopName;
            _adress = adress;
            _shopDescription = shopDescription;
            _contactPhoneNumber = contactPhoneNumber;
            _contactEmail = contactEmail;
        }

        public void InputData()
        {
            Console.Write("Enter shop name: ");
            _shopName = Console.ReadLine();

            Console.Write("Enter shop adress: ");
            _adress = Console.ReadLine();

            Console.Write("Enter shop desctiption: ");
            _shopDescription = Console.ReadLine();

            Console.Write("Phone number: ");
            _contactPhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            _contactEmail = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nInfo about shop:");
            Console.WriteLine($"Shop name: {_shopName}");
            Console.WriteLine($"Shop adress: {_adress}");
            Console.WriteLine($"Description: {_shopDescription}");
            Console.WriteLine($"Phone number: {_contactPhoneNumber}");
            Console.WriteLine($"Email: {_contactEmail}");
        }

        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public string ShopDescription
        {
            get { return _shopDescription; }
            set { _shopDescription = value; }
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
