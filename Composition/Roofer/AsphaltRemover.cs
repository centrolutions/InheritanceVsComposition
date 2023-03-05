using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Roofer
{
    internal class AsphaltRemover : ITearOffRoof
    {
        public void TearOff()
        {
            Console.WriteLine("Asphalt shingles torn off and put in dumpster.");
        }
    }
}
