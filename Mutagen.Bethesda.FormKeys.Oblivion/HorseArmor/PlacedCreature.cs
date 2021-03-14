using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class HorseArmor
    {
        public static class PlacedCreature
        {
            private static FormLink<IPlacedCreatureGetter> Construct(uint id) => new FormLink<IPlacedCreatureGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenPaintWeynonRef => Construct(0x2123);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenWhiteAnvilRef => Construct(0x2121);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenShadowmereRef => Construct(0x2122);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenPaintLeyawiinRef => Construct(0x2124);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenPaintBrumaRef => Construct(0x2125);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenOldNagRef => Construct(0x34cd);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenChestnutChorrolRef => Construct(0x2126);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenBlackCheydinhalRef => Construct(0x2127);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenBaySkingradRef => Construct(0x2128);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredElvenBayBravilRef => Construct(0x2129);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelWhiteAnvilRef => Construct(0x1c26);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelShadowmereRef => Construct(0x1c25);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelPaintWeynonRef => Construct(0x1c24);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelPaintLeyawiinRef => Construct(0x1c23);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelPaintBrumaRef => Construct(0x1c22);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelOldNagRef => Construct(0x34cb);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelChestnutChorrolRef => Construct(0x1c21);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelBlackCheydinhalRef => Construct(0x1c27);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelBaySkingradRef => Construct(0x1c1f);
            public static FormLink<IPlacedCreatureGetter> HorsePCArmoredSteelBayBravilRef => Construct(0x1c20);
            public static FormLink<IPlacedCreatureGetter> DLCHorseArmorWhiteHorse => Construct(0xcf2);
        }
    }
}
