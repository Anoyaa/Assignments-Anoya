using System;

namespace Animals2
{
    public class Dogs2:Animals2
    {
        
        public override string sound 
        { get { return "barks"; }
          set { sound = value; }    
        }

        public override string name 
        { 
          get { return "Dog";}
            set {name = value; }  
        }
        //public dogs2(string name)
        //{
        //    n = name; 
        //}

        public override void MakeSound()
        {
            Console.WriteLine($"{name} makes {sound} sound");
        }

    }
}
