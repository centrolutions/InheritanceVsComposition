namespace Composition.Roofer
{
    internal class AsphaltApplier : IApplyShingles
    {
        public void ApplyShingles()
        {
            Console.WriteLine("New asphalt shingles nailed to roof.");
        }
    }
}
