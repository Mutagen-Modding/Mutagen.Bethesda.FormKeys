namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey LairVileSurfaceDoor => ModKey.MakeFormKey(0x9716);
            public static FormKey DunCellDoorWide => ModKey.MakeFormKey(0x134e);
            public static FormKey LairVileMinionExitLadder => ModKey.MakeFormKey(0x9715);
        }
    }
}
