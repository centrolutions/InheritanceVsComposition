
using Composition.Roofer;
using Composition.Roofer.Appliers;
using Composition.Roofer.Removers;

//var applier = new AsphaltApplier();
//var remover = new AsphaltRemover();

//remove and apply wood shingles
//var applier = new WoodApplier();
//var remover = new WoodRemover();

//remove wood and apply asphalt
var applier = new AsphaltApplier();
var remover = new WoodRemover();

var roofer = new Roofer(remover, applier);

roofer.Setup();
roofer.TearOff();
roofer.ApplyShingles();
roofer.Cleanup();