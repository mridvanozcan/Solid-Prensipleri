using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    public class Human : IHuman, Code, Sleep , Eat
    {

        public void code()
        {
            throw new NotImplementedException();
        }

        public void Omni()
        {
            throw new NotImplementedException();
        }

        public void sleep()
        {
            throw new NotImplementedException();
        }

        public void walk()
        {
            throw new NotImplementedException();
        }
    }
}
