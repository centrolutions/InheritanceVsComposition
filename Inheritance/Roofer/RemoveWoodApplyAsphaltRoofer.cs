namespace Inheritance.Roofer
{
    internal class RemoveWoodApplyAsphaltRoofer : WoodRoofer
    {
        public override void ApplyShingles()
        {
            Console.WriteLine("New asphalt shingles nailed to roof.");
        }
    }
}
