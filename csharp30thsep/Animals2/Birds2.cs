using System;

namespace Animals2
{
    public class Birds2:Animals2
    {
        public override string sound
        {  
            get { return "chirps"; }
            set { sound = value; }
        }

        public override string name
        {
            get { return "bird"; }
            set { name = value; }
        }
        //public Birds2(string name)
        //{
        //    n = name;
        //}

        public override void MakeSound()
        {
            Console.WriteLine( $"{name} makes {sound} sound");
        }
    }
}
