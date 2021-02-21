using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCHorseArmor.esp");
            private static FormLink<IANpcSpawnGetter> Construct(uint id) => new FormLink<IANpcSpawnGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelWhiteAnvil => Construct(0xcea);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelPaintWeynon => Construct(0xceb);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelBaySkingrad => Construct(0x1bae);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelPaintLeyawiin => Construct(0x1baf);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenBayBravil => Construct(0x210f);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenBaySkingrad => Construct(0x2110);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenBlackCheydinhal => Construct(0x2111);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenlChestnutChorrol => Construct(0x2112);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenPaintBruma => Construct(0x2113);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenPaintLeyawiin => Construct(0x2114);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenPaintWeynon => Construct(0x2115);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenShadowmere => Construct(0x2116);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenWhiteAnvil => Construct(0x2117);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelBayBravil => Construct(0xce5);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelOldNag => Construct(0x34ca);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredElvenOldNag => Construct(0x34cc);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelShadowmere => Construct(0xce6);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelBlackCheydinhal => Construct(0xce7);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelChestnutChorrol => Construct(0xce8);
            public static FormLink<IANpcSpawnGetter> HorsePCArmoredSteelPaintBruma => Construct(0xce9);
        }
    }
}
