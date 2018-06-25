using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovsSubstitution
{
    class Male : Show
    {
        public override string ShowAnimal(Animal animal)
        {
            MaleFeCheck check = new MaleFeCheck();
            if (check.check(animal))
            {
                return animal.ToString()+" Adam bu Adam ADAM! ^^/*\\^^";
            }
            return "Kardesim bu hayvanin Erkek olduguna eminmisin bana pek oyle gelmedide?";
        }
    }
}
