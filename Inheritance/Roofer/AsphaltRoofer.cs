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
