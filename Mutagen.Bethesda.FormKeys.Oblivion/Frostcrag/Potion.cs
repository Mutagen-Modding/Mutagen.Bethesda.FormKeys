using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Potion
        {
            private static FormLink<IPotionGetter> Construct(uint id) => new FormLink<IPotionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPotionGetter> DaedricLavaWhiskey01 => Construct(0x8c37);
        }
    }
}
