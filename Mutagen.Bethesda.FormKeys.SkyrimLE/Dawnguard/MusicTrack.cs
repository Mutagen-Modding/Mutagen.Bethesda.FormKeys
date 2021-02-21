using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class MusicTrack
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            private static FormLink<IMusicTrackGetter> Construct(uint id) => new FormLink<IMusicTrackGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMusicTrackGetter> MUSCombatBossDLC1_03 => Construct(0x126a3);
            public static FormLink<IMusicTrackGetter> MUSCombatBossDLC1_02 => Construct(0x126a2);
            public static FormLink<IMusicTrackGetter> MUSCombatBossDLC1_01 => Construct(0x126a1);
            public static FormLink<IMusicTrackGetter> MUSExploreDLCFalmerValley01 => Construct(0xef95);
            public static FormLink<IMusicTrackGetter> MUSExploreDLCSoulCairn01 => Construct(0xef6d);
            public static FormLink<IMusicTrackGetter> MUSDungeonDLCVampireCastle02 => Construct(0xeeb8);
            public static FormLink<IMusicTrackGetter> MUSDungeonDLCVampireCastle01 => Construct(0xeeb7);
            public static FormLink<IMusicTrackGetter> MUSExploreTundraNightPaletteECLIPSE01 => Construct(0x19bb9);
            public static FormLink<IMusicTrackGetter> MUSExploreSnowNightPaletteECLIPSE01 => Construct(0x19bb8);
            public static FormLink<IMusicTrackGetter> MUSExploreReachNightPaletteECLIPSE01 => Construct(0x19bb7);
            public static FormLink<IMusicTrackGetter> MUSExploreMountainNightPaletteECLIPSE01 => Construct(0x19bb6);
            public static FormLink<IMusicTrackGetter> MUSEclipse01 => Construct(0x19bb4);
            public static FormLink<IMusicTrackGetter> MUSExploreForestNightPaletteECLIPSE01 => Construct(0x19bb3);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPalette => Construct(0x7b9a);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPaletteB03 => Construct(0x7b99);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPaletteB02 => Construct(0x7b98);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPaletteB01 => Construct(0x7b97);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPaletteA05 => Construct(0x7b96);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPaletteA04 => Construct(0x7b95);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPaletteA03 => Construct(0x7b94);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPaletteA02 => Construct(0x7b93);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnPaletteA01 => Construct(0x7b92);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnBPalette => Construct(0x7015);
            public static FormLink<IMusicTrackGetter> MUSExploreSoulCairnAPalette => Construct(0x7014);
        }
    }
}
