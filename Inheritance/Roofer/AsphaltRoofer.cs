using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Roofer
{
    internal class AsphaltRoofer : RooferBase
    {
        public override void ApplyShingles()
        {
            Console.WriteLine("New asphalt shingles nailed to roof.");
        }

        public override void TearOff()
        {
            Console.WriteLine("Asphalt shingles torn off and put in dumpster.");
        }
    }
}
