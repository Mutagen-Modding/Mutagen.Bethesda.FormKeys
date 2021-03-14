using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Region
        {
            private static FormLink<IRegionGetter> Construct(uint id) => new FormLink<IRegionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRegionGetter> AudioExtApocryphaGeneral => Construct(0x39e2f);
            public static FormLink<IRegionGetter> AudioIntTelMithrynWet => Construct(0x3974f);
            public static FormLink<IRegionGetter> WeatherSkaalVillage01 => Construct(0x37562);
            public static FormLink<IRegionGetter> WeatherRavenRock01 => Construct(0x374bc);
            public static FormLink<IRegionGetter> Region332 => Construct(0x3414d);
            public static FormLink<IRegionGetter> Region331 => Construct(0x2b048);
            public static FormLink<IRegionGetter> WeatherDLC2SolstheimSnowHeavy => Construct(0x2adc6);
            public static FormLink<IRegionGetter> WeatherDLC2SolstheimMtns => Construct(0x2a201);
            public static FormLink<IRegionGetter> WeatherDLC2SolstheimSnow => Construct(0x29f3b);
            public static FormLink<IRegionGetter> DLC2SolstheimBorderRegion => Construct(0x28649);
            public static FormLink<IRegionGetter> Region326 => Construct(0x24fd3);
            public static FormLink<IRegionGetter> Region325 => Construct(0x24fd2);
            public static FormLink<IRegionGetter> WeatherVolcanicAsh02 => Construct(0x1ef70);
            public static FormLink<IRegionGetter> Region322 => Construct(0x1e7d8);
            public static FormLink<IRegionGetter> DLC2ApocryphaBorderRegion => Construct(0x1c49a);
            public static FormLink<IRegionGetter> DLC2NavmeshRegion => Construct(0x1b9a9);
            public static FormLink<IRegionGetter> AudioExtDLC2Ashlands => Construct(0x195c3);
            public static FormLink<IRegionGetter> WeatherVolcanicAsh01 => Construct(0x18681);
        }
    }
}
