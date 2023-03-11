
using Inheritance.Roofer;

//var roofer = new AsphaltRoofer();

//remove and apply wood shingles
//var roofer = new WoodRoofer();

//remove wood and apply asphalt shingles
//var roofer = new RemoveWoodApplyAsphaltRoofer();

//remove two different layers and apply asphalt
var roofer = new RemoveWoodAndAsphaltApplyAsphaltRoofer();

roofer.Setup();
roofer.TearOff();
roofer.ApplyShingles();
roofer.Cleanup();
