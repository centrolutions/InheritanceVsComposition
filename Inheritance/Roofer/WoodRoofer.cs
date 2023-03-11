namespace Inheritance.Roofer
{
    internal class WoodRoofer : RooferBase
    {
        public override void ApplyShingles()
        {
            Console.WriteLine("New wood shingles nailed to roof.");
        }

        public override void TearOff()
        {
            Console.WriteLine("Wood shingles torn off and put in dumpster.");
        }
    }
}
