using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class PlacedNpc
        {
            private static FormLink<IPlacedNpcGetter> Construct(uint id) => new FormLink<IPlacedNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedNpcGetter> LairVileMinionREF => Construct(0xe1c);
            public static FormLink<IPlacedNpcGetter> LairVilePrisonerREF => Construct(0x1410);
            public static FormLink<IPlacedNpcGetter> RowleyEardwulfRef => Construct(0x3288);
        }
    }
}
