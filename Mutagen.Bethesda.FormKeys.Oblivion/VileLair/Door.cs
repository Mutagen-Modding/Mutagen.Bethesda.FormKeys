using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Door
        {
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> LairVileSurfaceDoor => Construct(0x9716);
            public static FormLink<IDoorGetter> DunCellDoorWide => Construct(0x134e);
            public static FormLink<IDoorGetter> LairVileMinionExitLadder => Construct(0x9715);
        }
    }
}
