using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Roofer
{
    internal class Roofer
    {
        private readonly ITearOffRoof _Remover;
        private readonly IApplyShingles _Applier;

        public Roofer(ITearOffRoof remover, IApplyShingles applier)
        {
            _Remover = remover;
            _Applier = applier;
        }

        public void Setup()
        {
            Console.WriteLine("Ladders and safety equipment are set up.");
        }

        public void TearOff()
        {
            _Remover.TearOff();
        }

        public void ApplyShingles()
        {
            _Applier.ApplyShingles();
        }

        public void Cleanup()
        {
            Console.WriteLine("Safety equipment and ladders taken down and put on truck.");
        }
    }
}
