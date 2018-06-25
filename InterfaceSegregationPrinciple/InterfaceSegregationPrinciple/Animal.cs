using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    class Animal : Sleep, Eat, IAnimal
    {
        public void bark()
        {
            throw new NotImplementedException();
        }

        public void Omni()
        {
            throw new NotImplementedException();
        }

        public void overRun()
        {
            throw new NotImplementedException();
        }

        public void sleep()
        {
            throw new NotImplementedException();
        }
    }
}
