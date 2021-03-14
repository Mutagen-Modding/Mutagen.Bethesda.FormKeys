using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Light
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILightGetter> FortRuins1YellowCommonWhite512 => Construct(0x2b1e);
            public static FormLink<ILightGetter> FrostCragIceCave900 => Construct(0x8c07);
            public static FormLink<ILightGetter> ObvRedBright400FrostCrag => Construct(0x8531);
            public static FormLink<ILightGetter> FCWarm512 => Construct(0x2147);
            public static FormLink<ILightGetter> FCWarm750 => Construct(0x6c23);
        }
    }
}
