using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Region
        {
            private static FormLink<IRegionGetter> Construct(uint id) => new FormLink<IRegionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRegionGetter> DLCFrostCragRegion => Construct(0x14e9f);
        }
    }
}
