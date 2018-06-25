using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class GermanBradsCheckers : BrandModelChecker
    {
        public override bool brandCheck(int mCode)
        {
            if (mCode < 30)
            {
                return true;
            }
            return false;
        }
    }
}
