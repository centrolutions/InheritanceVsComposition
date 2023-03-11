namespace Composition.Roofer.Removers
{
    internal class AsphaltRemover : IRoofRemover
    {
        public void TearOff()
        {
            Console.WriteLine("Asphalt shingles torn off and put in dumpster.");
        }
    }
}
