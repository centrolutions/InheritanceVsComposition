namespace Composition.Roofer.Removers
{
    internal class RemoverDecorator : IRoofRemover
    {
        readonly List<IRoofRemover> _Removers;

        public RemoverDecorator(params IRoofRemover[] remover)
        {
            _Removers = new List<IRoofRemover>();
            _Removers.AddRange(remover);
        }

        public void TearOff()
        {
            foreach (var remover in _Removers)
            {
                remover.TearOff();
            }
        }
    }
}
