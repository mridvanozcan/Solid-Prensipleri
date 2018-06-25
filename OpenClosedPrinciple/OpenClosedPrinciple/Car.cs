using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class Car
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int ModelCode { get; set; }

        public Car(string brandName, string modelName, int modelCode)
        {
            BrandName = brandName;
            ModelName = modelName;
            ModelCode = modelCode;
        }
    }
}
