using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Knights
    {
        public static class IdleAnimation
        {
            private static FormLink<IIdleAnimationGetter> Construct(uint id) => new FormLink<IIdleAnimationGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IIdleAnimationGetter> NDAnims => Construct(0x2d43);
            public static FormLink<IIdleAnimationGetter> ND10FINCheer03 => Construct(0x2d44);
            public static FormLink<IIdleAnimationGetter> ND10FINCheer02 => Construct(0x2d45);
            public static FormLink<IIdleAnimationGetter> ND10FINCheer01 => Construct(0x2d46);
            public static FormLink<IIdleAnimationGetter> ND10FinThredretAnnounce => Construct(0x2d47);
            public static FormLink<IIdleAnimationGetter> ND05ThedretExhausted => Construct(0x2d48);
            public static FormLink<IIdleAnimationGetter> ND09ProphetPreach => Construct(0x2d49);
            public static FormLink<IIdleAnimationGetter> ND02Anims => Construct(0x2d4a);
            public static FormLink<IIdleAnimationGetter> ND02SirAmielWatchFight => Construct(0x2d4b);
            public static FormLink<IIdleAnimationGetter> SirCaiusDefeatedAnim => Construct(0x2d4c);
            public static FormLink<IIdleAnimationGetter> SirAmielDefeatedAnim => Construct(0x2d4d);
            public static FormLink<IIdleAnimationGetter> SirCasimirDefeatedAnim => Construct(0x2d4e);
            public static FormLink<IIdleAnimationGetter> SirGregoryDefeatedAnim => Construct(0x2d4f);
            public static FormLink<IIdleAnimationGetter> SirHenrikDefeatedAnim => Construct(0x2d50);
            public static FormLink<IIdleAnimationGetter> SirJuncanDefeatedAnim => Construct(0x2d51);
            public static FormLink<IIdleAnimationGetter> SirRalvasDefeatedAnim => Construct(0x2d52);
            public static FormLink<IIdleAnimationGetter> SirTorolfDefeatedAnim => Construct(0x2d53);
            public static FormLink<IIdleAnimationGetter> ND10FInGhostIdle => Construct(0x2d54);
            public static FormLink<IIdleAnimationGetter> NDLathonFindSirRodericsBody => Construct(0x2d55);
            public static FormLink<IIdleAnimationGetter> ND10FinKnightsListen => Construct(0x2d56);
            public static FormLink<IIdleAnimationGetter> NDWayshrinePray => Construct(0x2d57);
            public static FormLink<IIdleAnimationGetter> NDProphetPreachIdle1 => Construct(0x2d58);
            public static FormLink<IIdleAnimationGetter> NDProphetPreachIdle2 => Construct(0x2d59);
            public static FormLink<IIdleAnimationGetter> NDProphetPreachIdle3 => Construct(0x2d5a);
            public static FormLink<IIdleAnimationGetter> ND09ProphetPray => Construct(0x2d5b);
            public static FormLink<IIdleAnimationGetter> ND03BearIdle1 => Construct(0x2d5c);
        }
    }
}
