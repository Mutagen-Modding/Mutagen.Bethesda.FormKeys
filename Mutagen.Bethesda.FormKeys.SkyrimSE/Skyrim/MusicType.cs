using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class MusicType
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IMusicTypeGetter> Construct(uint id) => new FormLink<IMusicTypeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMusicTypeGetter> MUSExploreSovngardeChantExterior => Construct(0xf74);
            public static FormLink<IMusicTypeGetter> MUSSpecialWordOfPower => Construct(0x17415);
            public static FormLink<IMusicTypeGetter> MUSDiscoveryHighHrothgar => Construct(0x17411);
            public static FormLink<IMusicTypeGetter> MUSSovngardeHallofValor => Construct(0x1714b);
            public static FormLink<IMusicTypeGetter> MUSExploreSovngardeChant => Construct(0x1714a);
            public static FormLink<IMusicTypeGetter> MUSSpecialHallofValor => Construct(0x17036);
            public static FormLink<IMusicTypeGetter> MUSTavernB => Construct(0x17035);
            public static FormLink<IMusicTypeGetter> MUSAlduinDeath => Construct(0x10fe85);
            public static FormLink<IMusicTypeGetter> MUSOdahviingRiding => Construct(0x10fe84);
            public static FormLink<IMusicTypeGetter> MUSDungeonCleared => Construct(0x10963f);
            public static FormLink<IMusicTypeGetter> MUSCombatBossChargen => Construct(0x1094aa);
            public static FormLink<IMusicTypeGetter> MUSDungeonChargen => Construct(0x1094a9);
            public static FormLink<IMusicTypeGetter> MUSTavernSILENCE => Construct(0x10486d);
            public static FormLink<IMusicTypeGetter> MUSSpecialElderScrollSquence => Construct(0x10486c);
            public static FormLink<IMusicTypeGetter> MUSSpecialCart => Construct(0xfed06);
            public static FormLink<IMusicTypeGetter> MUSE3DemoDungeon => Construct(0xea472);
            public static FormLink<IMusicTypeGetter> MUSE3DemoExplore => Construct(0xea470);
            public static FormLink<IMusicTypeGetter> MUSCombatBoss => Construct(0xd777a);
            public static FormLink<IMusicTypeGetter> MUSExploreMarsh => Construct(0xc76d3);
            public static FormLink<IMusicTypeGetter> MUSExploreCoast => Construct(0xc76d2);
            public static FormLink<IMusicTypeGetter> MUSSpecialIntro => Construct(0x8dc7c);
            public static FormLink<IMusicTypeGetter> MUSExploreMountain => Construct(0xb9dce);
            public static FormLink<IMusicTypeGetter> MUSExploreSovngarde => Construct(0xb9dcc);
            public static FormLink<IMusicTypeGetter> MUSExploreTundra => Construct(0xb9dcb);
            public static FormLink<IMusicTypeGetter> MUSExploreReach => Construct(0xb9dc9);
            public static FormLink<IMusicTypeGetter> MUSDiscoveryGeneric => Construct(0xac13d);
            public static FormLink<IMusicTypeGetter> MUSDiscoveryCity => Construct(0xabda5);
            public static FormLink<IMusicTypeGetter> MUSDiscoveryDungeon => Construct(0xabda4);
            public static FormLink<IMusicTypeGetter> MUSDiscoveryTown => Construct(0xabda3);
            public static FormLink<IMusicTypeGetter> MUSStinger => Construct(0x950d0);
            public static FormLink<IMusicTypeGetter> MUSDungeonCave => Construct(0x94bdd);
            public static FormLink<IMusicTypeGetter> MUSCombatCivilWar => Construct(0x8cda3);
            public static FormLink<IMusicTypeGetter> MUSExploreTestb => Construct(0x89a9c);
            public static FormLink<IMusicTypeGetter> MUSExploreSnow => Construct(0x8690f);
            public static FormLink<IMusicTypeGetter> MUSReward => Construct(0x7f810);
            public static FormLink<IMusicTypeGetter> MUSSkillsMenu => Construct(0x64453);
            public static FormLink<IMusicTypeGetter> MUSDungeonFort => Construct(0x5615b);
            public static FormLink<IMusicTypeGetter> MUSExploreForestPine => Construct(0x6d546);
            public static FormLink<IMusicTypeGetter> MUSExploreForestFall => Construct(0x6d544);
            public static FormLink<IMusicTypeGetter> MUSCastle => Construct(0x6d542);
            public static FormLink<IMusicTypeGetter> MUSTavern => Construct(0x622ab);
            public static FormLink<IMusicTypeGetter> MUSReveal => Construct(0x5221e);
            public static FormLink<IMusicTypeGetter> MUSDungeonIce => Construct(0x5228a);
            public static FormLink<IMusicTypeGetter> MUSDread => Construct(0x4da92);
            public static FormLink<IMusicTypeGetter> MUSSpecialSuccess => Construct(0x3b565);
            public static FormLink<IMusicTypeGetter> MUSCombat => Construct(0x3418e);
            public static FormLink<IMusicTypeGetter> __NONE => Construct(0x1ba72);
            public static FormLink<IMusicTypeGetter> MUSDungeon => Construct(0x2d4c2);
            public static FormLink<IMusicTypeGetter> MUSTownTest => Construct(0x2c3ca);
            public static FormLink<IMusicTypeGetter> MUSSpecialDeath => Construct(0x13686);
        }
    }
}
