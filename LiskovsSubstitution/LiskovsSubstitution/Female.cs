using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovsSubstitution
{
    class Female : Show
    {

        public override string ShowAnimal(Animal animal)
        {
            MaleFeCheck check = new MaleFeCheck();
            if (!check.check(animal))
            {
                return animal.ToString() + " Ve Hanim Kizimizda Burada ayyyy kzum benim! ^^ <3 ";
            }

            return "Kardesim bu hayvanin Disi olduguna eminmisin bana pek oyle gelmedide?";
        }
    }
}
