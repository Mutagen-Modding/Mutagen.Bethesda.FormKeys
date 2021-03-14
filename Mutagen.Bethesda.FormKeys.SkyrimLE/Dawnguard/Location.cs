using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class Location
        {
            private static FormLink<ILocationGetter> Construct(uint id) => new FormLink<ILocationGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ILocationGetter> DLC1FalmerValleyTempleLocation => Construct(0x1379f);
            public static FormLink<ILocationGetter> DLC1HunterHQLocationInterior => Construct(0x128fe);
            public static FormLink<ILocationGetter> DLC1IcewaterJettyLocation => Construct(0x12409);
            public static FormLink<ILocationGetter> DLC1MolderingRuinsLocation => Construct(0x3cfd);
            public static FormLink<ILocationGetter> DLC1DeadDropFallsLocation => Construct(0x19c8e);
            public static FormLink<ILocationGetter> DLC1zFalmerValley03Location => Construct(0x162b4);
            public static FormLink<ILocationGetter> DLC1zFalmerValley02Location => Construct(0x162b2);
            public static FormLink<ILocationGetter> DLC1zFalmerValley01Location => Construct(0x162b0);
            public static FormLink<ILocationGetter> DLC1GlacialCreviceLocation => Construct(0x162af);
            public static FormLink<ILocationGetter> DLC1DarkfallPassageLocation => Construct(0x162ac);
            public static FormLink<ILocationGetter> DLC1FalmerValleyLocation => Construct(0xa87c);
            public static FormLink<ILocationGetter> DLC1DarkfallCaveLocation => Construct(0xa87a);
            public static FormLink<ILocationGetter> DLC1RuunvaldLocation => Construct(0x7b21);
            public static FormLink<ILocationGetter> DLC1BthalftAetheriumForgeLocation => Construct(0x5826);
            public static FormLink<ILocationGetter> DLC1DimhollowCryptLocation => Construct(0x4ee8);
            public static FormLink<ILocationGetter> DLC1RedwaterDenLocation => Construct(0x4d6f);
            public static FormLink<ILocationGetter> DLC1HunterRadiantDungeonLocation => Construct(0x4d6e);
            public static FormLink<ILocationGetter> DLC1ArkngthamzLocation => Construct(0x4d6d);
            public static FormLink<ILocationGetter> DLC1VampireCastleLocation => Construct(0x4c20);
            public static FormLink<ILocationGetter> DLC1HunterHQLocation => Construct(0x4c1f);
            public static FormLink<ILocationGetter> DLC1SoulCairnLocation => Construct(0x3b8f);
            public static FormLink<ILocationGetter> DLC1_AncestorsGladeLocation => Construct(0x3583);
            public static FormLink<ILocationGetter> DLC1ForebearsHoldhoutLocation => Construct(0x357f);
            public static FormLink<ILocationGetter> DLC1VampireCastleDungeonLocation => Construct(0x357e);
            public static FormLink<ILocationGetter> DLC1VampireCastleGuildhallLocation => Construct(0x357d);
        }
    }
}
