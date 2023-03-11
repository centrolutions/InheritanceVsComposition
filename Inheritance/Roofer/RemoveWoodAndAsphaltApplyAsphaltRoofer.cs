using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Roofer
{
    internal class RemoveWoodAndAsphaltApplyAsphaltRoofer : AsphaltRoofer
    {
        public override void TearOff()
        {
            Console.WriteLine("Wood shingles torn off and put in dumpster.");
            base.TearOff();
        }
    }
}
