using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj
{
    internal class Builder : Human
    {
        private string _post;

        public Builder(string post, int age, string name) : base(age, name)
        {
            base.Name = name;
            base.Age = age;
            _post = post;
        }

        public string Post
        {
            get { return _post; }
            set { _post = value; }
        }

        public void DoWork()
        {
            Console.WriteLine($"Builder: {Name} is building");
        }

    }
}
