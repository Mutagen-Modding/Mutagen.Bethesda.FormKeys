using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class MusicTrack
        {
            private static FormLink<IMusicTrackGetter> Construct(uint id) => new FormLink<IMusicTrackGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMusicTrackGetter> ccMUSDungeonOblivion05 => Construct(0x3052);
            public static FormLink<IMusicTrackGetter> ccMUSDungeonOblivion04 => Construct(0x3051);
            public static FormLink<IMusicTrackGetter> ccMUSDungeonOblivion03 => Construct(0x3050);
            public static FormLink<IMusicTrackGetter> ccMUSDungeonOblivion02 => Construct(0x304f);
            public static FormLink<IMusicTrackGetter> ccMUSDungeonOblivion01 => Construct(0x304e);
            public static FormLink<IMusicTrackGetter> MUSCombatBossUmbra01 => Construct(0x301d);
        }
    }
}
