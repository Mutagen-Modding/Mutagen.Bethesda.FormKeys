using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Scroll
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Skyrim.esm");
            private static FormLink<IScrollGetter> Construct(uint id) => new FormLink<IScrollGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IScrollGetter> MGR21ScrollMagicka => Construct(0x1076ec);
            public static FormLink<IScrollGetter> MGR21ScrollConjuration => Construct(0x1076eb);
            public static FormLink<IScrollGetter> MGR21ScrollRestoration => Construct(0x1076ea);
            public static FormLink<IScrollGetter> MGR21ScrollAlteration => Construct(0x1076e9);
            public static FormLink<IScrollGetter> MGR21ScrollIllusion => Construct(0x1076e8);
            public static FormLink<IScrollGetter> MGR21ScrollDestruction => Construct(0x1076e7);
            public static FormLink<IScrollGetter> TGDetectLifeScroll => Construct(0x1019ae);
            public static FormLink<IScrollGetter> DragonhideScroll => Construct(0xe0cd6);
            public static FormLink<IScrollGetter> GuardianCircleScroll => Construct(0xe0cd5);
            public static FormLink<IScrollGetter> BaneOfTheUndeadScroll => Construct(0x218f2);
            public static FormLink<IScrollGetter> MassParalysisScroll => Construct(0x21876);
            public static FormLink<IScrollGetter> CureWoundsScroll => Construct(0xb64b3);
            public static FormLink<IScrollGetter> TurnGreaterUndeadScroll => Construct(0xa44c6);
            public static FormLink<IScrollGetter> RepelUndeadScroll => Construct(0xa44c5);
            public static FormLink<IScrollGetter> GrandHealingScroll => Construct(0xa44c4);
            public static FormLink<IScrollGetter> CircleOfProtectionScroll => Construct(0xa44c3);
            public static FormLink<IScrollGetter> RepelLesserUndeadScroll => Construct(0xa44c2);
            public static FormLink<IScrollGetter> HealOtherScroll => Construct(0xa44c1);
            public static FormLink<IScrollGetter> TurnLesserUndeadScroll => Construct(0xa44bf);
            public static FormLink<IScrollGetter> CallToArmsScroll => Construct(0xa44be);
            public static FormLink<IScrollGetter> HysteriaScroll => Construct(0xa44bd);
            public static FormLink<IScrollGetter> HarmonyScroll => Construct(0xa44bc);
            public static FormLink<IScrollGetter> MayhemScroll => Construct(0xa44bb);
            public static FormLink<IScrollGetter> RoutScroll => Construct(0xa44ba);
            public static FormLink<IScrollGetter> PacifyScroll => Construct(0xa44b9);
            public static FormLink<IScrollGetter> InvisibilityScroll => Construct(0xa44b7);
            public static FormLink<IScrollGetter> FrenzyScroll => Construct(0xa44b6);
            public static FormLink<IScrollGetter> RallyScroll => Construct(0xa44b5);
            public static FormLink<IScrollGetter> BlizzardScroll => Construct(0xa44b2);
            public static FormLink<IScrollGetter> FireStormScroll => Construct(0xa44b1);
            public static FormLink<IScrollGetter> ChainLightningScroll => Construct(0xa44b0);
            public static FormLink<IScrollGetter> IceStormScroll => Construct(0xa44af);
            public static FormLink<IScrollGetter> FireballScroll => Construct(0xa44ae);
            public static FormLink<IScrollGetter> LightningCloakScroll => Construct(0xa44ad);
            public static FormLink<IScrollGetter> FrostCloakScroll => Construct(0xa44ac);
            public static FormLink<IScrollGetter> FlameCloakScroll => Construct(0xa44ab);
            public static FormLink<IScrollGetter> StormThrallScroll => Construct(0xa44aa);
            public static FormLink<IScrollGetter> FrostThrallScroll => Construct(0xa44a9);
            public static FormLink<IScrollGetter> FlameThrallScroll => Construct(0xa44a8);
            public static FormLink<IScrollGetter> DeadThrallScroll => Construct(0xa44a7);
            public static FormLink<IScrollGetter> ExpelDaedraScroll => Construct(0xa44a6);
            public static FormLink<IScrollGetter> DreadZombieScroll => Construct(0xa44a5);
            public static FormLink<IScrollGetter> CommandDaedraScroll => Construct(0xa44a4);
            public static FormLink<IScrollGetter> RevenantScroll => Construct(0xa44a3);
            public static FormLink<IScrollGetter> ConjureStormAtronachScroll => Construct(0xa44a1);
            public static FormLink<IScrollGetter> ConjureFrostAtronachScroll => Construct(0xa44a0);
            public static FormLink<IScrollGetter> BanishDaedraScroll => Construct(0xa449f);
            public static FormLink<IScrollGetter> EbonyFleshScroll => Construct(0xa449e);
            public static FormLink<IScrollGetter> ParalyzeScroll => Construct(0xa449d);
            public static FormLink<IScrollGetter> WaterBreathingScroll => Construct(0xa449c);
            public static FormLink<IScrollGetter> IronFleshScroll => Construct(0xa449b);
            public static FormLink<IScrollGetter> MGRJzargo1Scroll => Construct(0x967e3);
            public static FormLink<IScrollGetter> TurnUndeadScroll => Construct(0x965b0);
            public static FormLink<IScrollGetter> FastHealingScroll => Construct(0x965af);
            public static FormLink<IScrollGetter> FearScroll => Construct(0x965ae);
            public static FormLink<IScrollGetter> CalmScroll => Construct(0x965ad);
            public static FormLink<IScrollGetter> MuffleScroll => Construct(0x965ab);
            public static FormLink<IScrollGetter> ShockRuneScroll => Construct(0x965aa);
            public static FormLink<IScrollGetter> FrostRuneScroll => Construct(0x965a9);
            public static FormLink<IScrollGetter> FireRuneScroll => Construct(0x965a8);
            public static FormLink<IScrollGetter> SoulTrapScroll => Construct(0x965a7);
            public static FormLink<IScrollGetter> ConjureFlameAtronachScroll => Construct(0x965a5);
            public static FormLink<IScrollGetter> ReanimateCorpseScroll => Construct(0x965a4);
            public static FormLink<IScrollGetter> StonefleshScroll => Construct(0x965a3);
            public static FormLink<IScrollGetter> MagelightScroll => Construct(0x965a2);
            public static FormLink<IScrollGetter> FuryScroll => Construct(0x965a1);
            public static FormLink<IScrollGetter> CourageScroll => Construct(0x965a0);
            public static FormLink<IScrollGetter> ConjureFamiliarScroll => Construct(0x9659f);
            public static FormLink<IScrollGetter> RaiseZombieScroll => Construct(0x9659e);
            public static FormLink<IScrollGetter> OakfleshScroll => Construct(0x9659c);
            public static FormLink<IScrollGetter> CandlelightScroll => Construct(0x9659b);
            public static FormLink<IScrollGetter> LightningBoltScroll => Construct(0x9659a);
            public static FormLink<IScrollGetter> IceSpikeScroll => Construct(0x96599);
            public static FormLink<IScrollGetter> FireboltScroll => Construct(0x96598);
        }
    }
}
