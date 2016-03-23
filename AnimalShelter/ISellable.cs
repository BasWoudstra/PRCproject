using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    interface ISellable
    {
        decimal Price { get; set; }

        public abstract void CalcPrice();
    }
}
