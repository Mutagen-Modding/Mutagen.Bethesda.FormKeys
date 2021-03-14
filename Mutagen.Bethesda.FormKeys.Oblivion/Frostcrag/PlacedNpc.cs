using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class PlacedNpc
        {
            private static FormLink<IPlacedNpcGetter> Construct(uint id) => new FormLink<IPlacedNpcGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedNpcGetter> AurelinwaeRef => Construct(0x124a);
        }
    }
}
