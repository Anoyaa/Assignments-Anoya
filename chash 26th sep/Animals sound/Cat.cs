using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat:Animal
    {
        public string Name { get; set; }
        public Cat(string name):base(name) 
        {
          Name = name;
        }
        public override string Sound() 
        {
            return Name + " sounds meow";

        }
    }
}
