namespace Composition.Roofer.Appliers
{
    internal class AsphaltApplier : IRoofApplier
    {
        public void ApplyShingles()
        {
            Console.WriteLine("New asphalt shingles nailed to roof.");
        }
    }
}
