
using Composition.Roofer;

IApplyShingles applier = new AsphaltApplier();
ITearOffRoof remover = new AsphaltRemover();
var roofer = new Roofer(remover, applier);

roofer.Setup();
roofer.TearOff();
roofer.ApplyShingles();
roofer.Cleanup();