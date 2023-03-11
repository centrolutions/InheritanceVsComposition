using Composition.Roofer.Appliers;
using Composition.Roofer.Removers;

namespace Composition.Roofer
{
    internal class Roofer
    {
        private readonly IRoofRemover _Remover;
        private readonly IRoofApplier _Applier;

        public Roofer(IRoofRemover remover, IRoofApplier applier)
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
