using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class MehrunesRazor
    {
        public static class Potion
        {
            private static FormLink<IPotionGetter> Construct(uint id) => new FormLink<IPotionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPotionGetter> DL9TrichoBezoarPotion => Construct(0x1493);
            public static FormLink<IPotionGetter> DL9FortifBlade => Construct(0x5654);
        }
    }
}
