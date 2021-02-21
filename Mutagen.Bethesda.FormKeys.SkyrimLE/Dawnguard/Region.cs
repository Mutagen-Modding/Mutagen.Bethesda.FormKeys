using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Region
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IRegionGetter> Construct(uint id) => new FormLink<IRegionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IRegionGetter> AudioExtFalmerValleyBossChapel => Construct(0x14c60);
            public static FormLink<IRegionGetter> MeganSoulCairn02 => Construct(0x13ece);
            public static FormLink<IRegionGetter> Region340 => Construct(0x139b4);
            public static FormLink<IRegionGetter> DLC01VampCastleStorm => Construct(0x12dad);
            public static FormLink<IRegionGetter> AudioExtFallForestDLC1FortDawnguard => Construct(0xd95e);
            public static FormLink<IRegionGetter> Region337 => Construct(0xc746);
            public static FormLink<IRegionGetter> Region336 => Construct(0xc652);
            public static FormLink<IRegionGetter> DLC1SoulCairnLODRegion => Construct(0xc639);
            public static FormLink<IRegionGetter> DLC01WeatherFVBoss => Construct(0x29e5);
            public static FormLink<IRegionGetter> DLC01WeatherCanyon => Construct(0x1a880);
            public static FormLink<IRegionGetter> DLC01Weather03 => Construct(0x19219);
            public static FormLink<IRegionGetter> DLC01Weather02 => Construct(0x19218);
            public static FormLink<IRegionGetter> DLC01WeatherIce => Construct(0x191d3);
            public static FormLink<IRegionGetter> DLC01WeatherPlayground => Construct(0x191d2);
            public static FormLink<IRegionGetter> DLC1FalmerValleyBorder => Construct(0x18c4e);
            public static FormLink<IRegionGetter> AudioIntDarkfallWorld01 => Construct(0x14c2f);
            public static FormLink<IRegionGetter> DLC1SoulCairnNavmesh => Construct(0x12858);
            public static FormLink<IRegionGetter> MeganSoulCairn01 => Construct(0xc7d6);
            public static FormLink<IRegionGetter> DLC1NavmeshGen => Construct(0xc3e6);
            public static FormLink<IRegionGetter> AudioExtFalmerValleyWorld => Construct(0xa262);
            public static FormLink<IRegionGetter> Navmesh => Construct(0x9168);
            public static FormLink<IRegionGetter> AudioExtSoulCairn => Construct(0x7013);
            public static FormLink<IRegionGetter> AudioIntDarkDungeonCave01 => Construct(0x6b0e);
            public static FormLink<IRegionGetter> DLC1BorderRegionSkyrim => Construct(0x6a3b);
            public static FormLink<IRegionGetter> DLC01WeatherGrove => Construct(0x5099);
        }
    }
}
