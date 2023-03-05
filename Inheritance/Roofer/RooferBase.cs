using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Roofer
{
    internal abstract class RooferBase
    {
        public virtual void Setup()
        {
            Console.WriteLine("Ladders and safety equipment are set up.");
        }
        public abstract void TearOff();
        public abstract void ApplyShingles();
        public virtual void Cleanup()
        {
            Console.WriteLine("Safety equipment and ladders taken down and put on truck.");
        }
    }
}
