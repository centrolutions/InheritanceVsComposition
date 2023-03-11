
using Composition.Roofer;
using Composition.Roofer.Appliers;
using Composition.Roofer.Removers;

IRoofApplier applier = new AsphaltApplier();
IRoofRemover remover = new AsphaltRemover();
var roofer = new Roofer(remover, applier);

roofer.Setup();
roofer.TearOff();
roofer.ApplyShingles();
roofer.Cleanup();