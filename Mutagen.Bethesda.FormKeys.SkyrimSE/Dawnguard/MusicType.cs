using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dawnguard
    {
        public static class MusicType
        {
            private static FormLink<IMusicTypeGetter> Construct(uint id) => new FormLink<IMusicTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMusicTypeGetter> MUSCombatBossDLC1 => Construct(0x126a0);
            public static FormLink<IMusicTypeGetter> MUSExploreDLCFalmerValley => Construct(0xef94);
            public static FormLink<IMusicTypeGetter> MUSDungeonDLCVampireCastle => Construct(0xeeb9);
            public static FormLink<IMusicTypeGetter> MUSEclipse => Construct(0x19bb5);
            public static FormLink<IMusicTypeGetter> MUSExploreDLCSoulCairn => Construct(0x7012);
        }
    }
}
