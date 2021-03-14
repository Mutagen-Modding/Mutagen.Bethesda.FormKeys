using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Light
        {
            private static FormLink<ILightGetter> Construct(uint id) => new FormLink<ILightGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILightGetter> LairVileCustomSithisFaceLight => Construct(0x26c0);
            public static FormLink<ILightGetter> LairVileSithisDaylight => Construct(0x26c1);
            public static FormLink<ILightGetter> LairVileCustomFireLight128 => Construct(0x169c);
            public static FormLink<ILightGetter> LairVileCustomFireLight320 => Construct(0x169e);
            public static FormLink<ILightGetter> LairVileCustomSithisFontLight => Construct(0x3190);
            public static FormLink<ILightGetter> LairVileCustomLightRed256 => Construct(0x1693);
            public static FormLink<ILightGetter> LairVileCustomLamp320 => Construct(0x1694);
            public static FormLink<ILightGetter> LairVilePaleTorch => Construct(0x3791);
            public static FormLink<ILightGetter> LairVileCustomSconce188 => Construct(0x1695);
            public static FormLink<ILightGetter> LairVileCustomSithisHeartLight => Construct(0x26be);
        }
    }
}
