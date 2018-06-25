using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class BrandModelChecker
    {
        public virtual bool brandCheck(int mCode)
        {
            if (mCode >50)
            {
                return false;
            }
            return true;
        }
    }
}
