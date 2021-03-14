using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Potion
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IPotionGetter> Construct(uint id) => new FormLink<IPotionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPotionGetter> DaedricLavaWhiskey01 => Construct(0x8c37);
        }
    }
}
