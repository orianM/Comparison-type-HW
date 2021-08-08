using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_Type_HW
{
    class Pointers
    {
        public int x { get; set; }
        public int y { get; set; }

        public override bool Equals(object myInstance)
        {
            if (myInstance is Pointers)
            {
                Pointers pointersInstance = myInstance as Pointers;
                if (pointersInstance.x == this.x)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
