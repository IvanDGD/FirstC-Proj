using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Website
    {

        private string _websiteName;
        private string _path;
        private string _websiteDescription;
        private string _IPAdress;

        public Website() { }

        public Website(string websiteName, string path, string websiteDescription, string IP)
        {
            _websiteName = websiteName;
            _path = path;
            _websiteDescription = websiteDescription;
            _IPAdress = IP;
        }

        public void InputData()
        {
            Console.Write("Enter web-site name: ");
            _websiteName = Console.ReadLine();

            Console.Write("Enter path: ");
            _path = Console.ReadLine();

            Console.Write("Enter description web-site: ");
            _websiteDescription = Console.ReadLine();

            Console.Write("Enter IP adress: ");
            _IPAdress = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("\nInfo about site:");
            Console.WriteLine($"Web-Site name: {_websiteName}");
            Console.WriteLine($"Path: {_path}");
            Console.WriteLine($"Description: {_websiteDescription}");
            Console.WriteLine($"IP адресс: {_IPAdress}");
        }

        public string WebsiteName
        {
            get { return _websiteName; }
            set { _websiteName = value; }
        }

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public string WebsiteDescription
        {
            get { return _websiteDescription; }
            set { _websiteDescription = value; }
        }

        public string InternetProtocol
        {
            get { return _IPAdress; }
            set { _IPAdress = value; }
        }

    }
}
