namespace Composition.Roofer.Removers
{
    internal class WoodRemover : IRoofRemover
    {
        public void TearOff()
        {
            Console.WriteLine("Wood shingles torn off and put in dumpster.");
        }
    }
}
