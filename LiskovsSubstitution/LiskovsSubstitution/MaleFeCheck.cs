using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovsSubstitution
{
    public class MaleFeCheck
    {
        public bool check(Animal animal)
        {
            if (!String.Equals(animal.MF,"F"))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
