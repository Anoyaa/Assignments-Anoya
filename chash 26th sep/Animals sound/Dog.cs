using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog:Animal
    {
        public string Name { get; set; }
       

        public Dog(string name):base(name)
        {
            Name = name;
        }
        public override string Sound()
        {
            return Name +" sounds barks";
        }
    }
}