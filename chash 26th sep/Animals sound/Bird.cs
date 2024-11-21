using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bird:Animal
    {
        public string Name { get; set; }    
        public Bird(string name):base(name) 
        {
           Name = name;
        }
        public override string Sound()
        {
            return Name+ " sound chirps";
        }
    }
}
