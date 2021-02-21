using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            private static FormLink<IAItemGetter> Construct(uint id) => new FormLink<IAItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAItemGetter> FrostcragLibraryAreaReceipt => Construct(0xd5e);
            public static FormLink<IAItemGetter> FrostcragApparatusReceipt => Construct(0xd5f);
            public static FormLink<IAItemGetter> FrostcragSpireMemoirs => Construct(0xd56);
            public static FormLink<IAItemGetter> FrostcragSpireDeed => Construct(0xd52);
            public static FormLink<IAItemGetter> FrostcragBedroomAreaReceipt => Construct(0xd5a);
            public static FormLink<IAItemGetter> FrostcragVaultAreaReceipt => Construct(0xd5d);
            public static FormLink<IAItemGetter> FrostcragRing => Construct(0x5e36);
            public static FormLink<IAItemGetter> FortRuins1YellowCommonWhite512 => Construct(0x2b1e);
            public static FormLink<IAItemGetter> FrostCragIceCave900 => Construct(0x8c07);
            public static FormLink<IAItemGetter> ObvRedBright400FrostCrag => Construct(0x8531);
            public static FormLink<IAItemGetter> FCWarm512 => Construct(0x2147);
            public static FormLink<IAItemGetter> FCWarm750 => Construct(0x6c23);
            public static FormLink<IAItemGetter> FrostcragMagetallowCandle => Construct(0xd44);
            public static FormLink<IAItemGetter> FrostcragSpireKey => Construct(0xd50);
            public static FormLink<IAItemGetter> DaedricLavaWhiskey01 => Construct(0x8c37);
        }
    }
}
