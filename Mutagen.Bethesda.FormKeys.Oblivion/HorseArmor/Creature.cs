using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class Creature
        {
            private static FormLink<ICreatureGetter> Construct(uint id) => new FormLink<ICreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelWhiteAnvil => Construct(0xcea);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelPaintWeynon => Construct(0xceb);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelBaySkingrad => Construct(0x1bae);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelPaintLeyawiin => Construct(0x1baf);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenBayBravil => Construct(0x210f);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenBaySkingrad => Construct(0x2110);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenBlackCheydinhal => Construct(0x2111);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenlChestnutChorrol => Construct(0x2112);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenPaintBruma => Construct(0x2113);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenPaintLeyawiin => Construct(0x2114);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenPaintWeynon => Construct(0x2115);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenShadowmere => Construct(0x2116);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenWhiteAnvil => Construct(0x2117);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelBayBravil => Construct(0xce5);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelOldNag => Construct(0x34ca);
            public static FormLink<ICreatureGetter> HorsePCArmoredElvenOldNag => Construct(0x34cc);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelShadowmere => Construct(0xce6);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelBlackCheydinhal => Construct(0xce7);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelChestnutChorrol => Construct(0xce8);
            public static FormLink<ICreatureGetter> HorsePCArmoredSteelPaintBruma => Construct(0xce9);
        }
    }
}