using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovsSubstitution
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string MF { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "Age: " + Age + "Gender: " + MF;
        }
    }
}
