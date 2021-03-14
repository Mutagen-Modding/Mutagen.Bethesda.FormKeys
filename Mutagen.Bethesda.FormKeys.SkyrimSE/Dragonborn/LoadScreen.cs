using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class LoadScreen
        {
            private static FormLink<ILoadScreenGetter> Construct(uint id) => new FormLink<ILoadScreenGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILoadScreenGetter> DLC2Solstheim5 => Construct(0x3b04f);
            public static FormLink<ILoadScreenGetter> DLC2RavenRock3 => Construct(0x3abca);
            public static FormLink<ILoadScreenGetter> DLC2RavenRock2 => Construct(0x3abc9);
            public static FormLink<ILoadScreenGetter> DLC2RavenRock1 => Construct(0x3abc8);
            public static FormLink<ILoadScreenGetter> DLC2DragonRiding1 => Construct(0x3a63a);
            public static FormLink<ILoadScreenGetter> DLC2ArmorChitin => Construct(0x3a639);
            public static FormLink<ILoadScreenGetter> DLC2CreatureNetch => Construct(0x3a638);
            public static FormLink<ILoadScreenGetter> DLC2CreatureRieklings3 => Construct(0x3a637);
            public static FormLink<ILoadScreenGetter> DLC2Thirsk1 => Construct(0x3a636);
            public static FormLink<ILoadScreenGetter> DLC2CreatureRieklings2 => Construct(0x3a635);
            public static FormLink<ILoadScreenGetter> DLC2Solstheim4 => Construct(0x3a634);
            public static FormLink<ILoadScreenGetter> DLC2TelMithryn1 => Construct(0x3a633);
            public static FormLink<ILoadScreenGetter> DLC2StalhrimSmithing => Construct(0x3a632);
            public static FormLink<ILoadScreenGetter> DLC2MQLore1 => Construct(0x3a631);
            public static FormLink<ILoadScreenGetter> DLC2Solstheim3 => Construct(0x3a630);
            public static FormLink<ILoadScreenGetter> DLC2Solstheim2 => Construct(0x3a62f);
            public static FormLink<ILoadScreenGetter> DLC2Solstheim1 => Construct(0x3a62e);
            public static FormLink<ILoadScreenGetter> DLC2Skaal1 => Construct(0x3a62d);
            public static FormLink<ILoadScreenGetter> DLC2SolstheimIntro => Construct(0x3a62c);
            public static FormLink<ILoadScreenGetter> DLC2SacredStoneTip => Construct(0x3a327);
            public static FormLink<ILoadScreenGetter> DLC2CreatureDwarvenBallista => Construct(0x36a69);
            public static FormLink<ILoadScreenGetter> DLC2Apocrypha02 => Construct(0x32401);
            public static FormLink<ILoadScreenGetter> DLC2Apocrypha => Construct(0x32400);
            public static FormLink<ILoadScreenGetter> DLC2CreatureSeeker => Construct(0x26733);
            public static FormLink<ILoadScreenGetter> DLC2CreatureRieklings => Construct(0x26731);
            public static FormLink<ILoadScreenGetter> DLC2CreatureLurker => Construct(0x26730);
            public static FormLink<ILoadScreenGetter> DLC2CreatureAshSpawn => Construct(0x2672f);
            public static FormLink<ILoadScreenGetter> DLC2ArmorBonemold => Construct(0x2672d);
            public static FormLink<ILoadScreenGetter> DLC2StalhrimEnchantingLoadScreen => Construct(0x2672c);
            public static FormLink<ILoadScreenGetter> DLC2SkillSmithing => Construct(0x2672b);
        }
    }
}
