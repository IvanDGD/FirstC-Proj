using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace FirstC_Proj
{
    internal class Vessel
    {

        private double _volume;
        private string _material;
        private double _currentLevel;
        private bool _isFull;


        public Vessel(double volume)
        {
            _volume = volume;
            _material = "Unknown";
            _currentLevel = 0;
            _isFull = false;
        }

        public Vessel(double volume, string material)
        {
            _volume = volume;
            _material = material;
            _currentLevel = 0;
            _isFull = false;
        }

        public Vessel(double volume, string material, bool isFull)
        {
            _volume = volume;
            _material = material;
            _isFull = isFull;
            _currentLevel = isFull ? _volume : 0;
        }

        public void Fill(double amount)
        {
            if (_currentLevel + amount > _volume)
            {
                Console.WriteLine("Vessel is full");
                _currentLevel = _volume;
                _isFull = true;
            }
            else
            {
                _currentLevel += amount;
                Console.WriteLine($"Current level: {_currentLevel}");
                if (_currentLevel == _volume)
                {
                    _isFull = true;
                    Console.WriteLine("Vessel full filling.");
                }
            }
        }

        public void Empty(double amount)
        {
            if (_currentLevel - amount < 0)
            {
                Console.WriteLine("Vessel is full");
                _currentLevel = 0;
                _isFull = false;
            }
            else
            {
                _currentLevel -= amount;
                Console.WriteLine($"Current level: {_currentLevel}");
                if (_currentLevel == 0)
                {
                    _isFull = false;
                    Console.WriteLine("Vessel full empty.");
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Info about vessel:");
            Console.WriteLine($"Volume: {_volume}");
            Console.WriteLine($"Material: {_material}");
            Console.WriteLine($"Current level: {_currentLevel}");
            Console.WriteLine($"Mill: {(_isFull ? "Full" : "Empty")}");
        }

    }
}
