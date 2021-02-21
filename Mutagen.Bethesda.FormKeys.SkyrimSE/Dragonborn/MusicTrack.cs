using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class MusicTrack
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IMusicTrackGetter> Construct(uint id) => new FormLink<IMusicTrackGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim11 => Construct(0x3d553);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim10 => Construct(0x3d552);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim09 => Construct(0x3d551);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim08 => Construct(0x3d4a2);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim07 => Construct(0x3a73f);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim06 => Construct(0x3a73e);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim05 => Construct(0x3a73d);
            public static FormLink<IMusicTrackGetter> MUSDLC2BoatArrival01 => Construct(0x3a4d8);
            public static FormLink<IMusicTrackGetter> DLC2MUSCombatBoss03 => Construct(0x39ba4);
            public static FormLink<IMusicTrackGetter> DLC2MUSCombatBoss02 => Construct(0x39ba3);
            public static FormLink<IMusicTrackGetter> DLC2MUSCombatBoss01 => Construct(0x39ba2);
            public static FormLink<IMusicTrackGetter> DLC2MUSDungeonApocrypha02 => Construct(0x34280);
            public static FormLink<IMusicTrackGetter> DLC2MUSDungeonApocrypha01 => Construct(0x3427f);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim04 => Construct(0x3391c);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim02 => Construct(0x3391b);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim03 => Construct(0x3391a);
            public static FormLink<IMusicTrackGetter> DLC2MUSExploreSolstheim01 => Construct(0x33919);
            public static FormLink<IMusicTrackGetter> MUSExploreMorningDUPLICATE002 => Construct(0x33918);
            public static FormLink<IMusicTrackGetter> DLC2dunKarstaagMUSCombatBoss03 => Construct(0x2823e);
            public static FormLink<IMusicTrackGetter> DLC2dunKarstaagMUSCombatBoss01 => Construct(0x2823d);
            public static FormLink<IMusicTrackGetter> DLC2dunKarstaagMUSCombatBoss02 => Construct(0x2823c);
        }
    }
}
