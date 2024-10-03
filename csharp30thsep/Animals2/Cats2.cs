using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Animals2
{
    public  class Cats2:Animals2
    {
        string n;
        public override string sound
        {
            get { return "meow"; }
            set { sound = value; }
        }
        public override string name
        { get { return "cat"; }
            set { name = value; }
        }

        //public Cats2(string name)
        //{
        //    n = name;
        //}

        public override void MakeSound()
        {
            Console.WriteLine($"{name} makes {sound} sound");
          
        }
    }
}
