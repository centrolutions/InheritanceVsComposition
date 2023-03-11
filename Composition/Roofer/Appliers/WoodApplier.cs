namespace Composition.Roofer.Appliers
{
    internal class WoodApplier : IRoofApplier
    {
        public void ApplyShingles()
        {
            Console.WriteLine("New wood shingles nailed to roof.");
        }
    }
}
