using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.Lambda_Expressions
{
    internal class Backpack
    {
        private string _Color { get; set; }

        private string _Brand { get; set; }
        private string _Cloth { get; set; }
        private double _Weight { get; set; }
        private double _Capacity { get; set; }
        private double _currentVolume = 0;
        private List<string> items = new List<string>();

        public delegate void ItemEventHandler(string item);
        public delegate void CharacteristicsChangedHandler(string message);

        public event ItemEventHandler ItemAdded;
        public event ItemEventHandler ItemRemoved;
        public event CharacteristicsChangedHandler CharacteristicsChanged;

        public Backpack(string color, string brand, string cloth, double weight, double capacity, double currentVolume)
        {
            _Color = color;
            _Brand = brand;
            _Cloth = cloth;
            _Weight = weight;
            _Capacity = capacity;
            _currentVolume = currentVolume;
        }

        public void AddItem(string item, double itemVolume)
        {
            if (_currentVolume + itemVolume > _Capacity)
            {
                Console.WriteLine("Cannot add item: Exceeds backpack capacity!");
                return;
            }

            items.Add(item);
            _currentVolume += itemVolume;
            if (ItemAdded != null)
                ItemAdded(item);
        }

        public void RemoveItem(string item, double itemVolume)
        {
            if (items.Remove(item))
            {
                _currentVolume -= itemVolume;
                if (ItemRemoved != null)
                    ItemRemoved(item);
            }
        }

        public void ChangeCharacteristics(string color, string brand, string cloth, double weight, double capacity)
        {
            _Color = color;
            _Brand = brand;
            _Cloth = cloth;
            _Weight = weight;
            _Capacity = capacity;
            if (CharacteristicsChanged != null)
            {
                CharacteristicsChanged("Backpack characteristics updated.");
            }
        }
    }
}
