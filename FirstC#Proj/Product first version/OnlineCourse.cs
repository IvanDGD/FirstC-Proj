using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class OnlineCourse : Course
    {
        public string Platform { get; set; }

        public OnlineCourse(string name, int duration, string platform)
            : base(name, duration)
        {
            Platform = platform;
        }
        
        public override string ToString()
        {
            return $"Online Course: {Name}, Duration: {Duration} hours, Platform: {Platform}";
        }
    }
}
