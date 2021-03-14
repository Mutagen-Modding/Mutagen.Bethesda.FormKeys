using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class EncounterZone
        {
            private static FormLink<IEncounterZoneGetter> Construct(uint id) => new FormLink<IEncounterZoneGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEncounterZoneGetter> DLC2ThirskExteriorZone => Construct(0x1e284);
            public static FormLink<IEncounterZoneGetter> DLC2ThirskInteriorZone => Construct(0x1e11d);
            public static FormLink<IEncounterZoneGetter> DLC2RRTempleTombZone => Construct(0x3cfcb);
            public static FormLink<IEncounterZoneGetter> DLC2HoldingCellBardZone => Construct(0x3a4a2);
            public static FormLink<IEncounterZoneGetter> DLC2ColdcinderCaveZone => Construct(0x3a42e);
            public static FormLink<IEncounterZoneGetter> DLC2BloodskalBarrowBanditZone => Construct(0x3a080);
            public static FormLink<IEncounterZoneGetter> DLC2HeadwatersOfHarstradZone => Construct(0x39f99);
            public static FormLink<IEncounterZoneGetter> DLC2RamshackleTradingPostZone => Construct(0x34ee7);
            public static FormLink<IEncounterZoneGetter> DLC2BrokenTuskMineZone => Construct(0x33953);
            public static FormLink<IEncounterZoneGetter> DLC2BristlebackCaveZone => Construct(0x32893);
            public static FormLink<IEncounterZoneGetter> DLC2DamphallMineZone => Construct(0x296db);
            public static FormLink<IEncounterZoneGetter> DLC2SnowcladRuinsZone => Construct(0x247c7);
            public static FormLink<IEncounterZoneGetter> DLC2DremoraShopZone => Construct(0x1ff29);
            public static FormLink<IEncounterZoneGetter> DLC2Book07DungeonZone => Construct(0x1ee19);
            public static FormLink<IEncounterZoneGetter> DLC2Book06DungeonZone => Construct(0x1ee18);
            public static FormLink<IEncounterZoneGetter> DLC2Book05DungeonZone => Construct(0x1ee17);
            public static FormLink<IEncounterZoneGetter> DLC2Book04DungeonZone => Construct(0x1ee16);
            public static FormLink<IEncounterZoneGetter> DLC2TelMithrynZone => Construct(0x1d751);
            public static FormLink<IEncounterZoneGetter> DLC2SaeringsWatchZone => Construct(0x19d2a);
            public static FormLink<IEncounterZoneGetter> DLC2HighpointTowerZone => Construct(0x184fd);
            public static FormLink<IEncounterZoneGetter> DLC2HrothmundsBarrowZone => Construct(0x17bae);
            public static FormLink<IEncounterZoneGetter> DLC2StoneWindZone => Construct(0x142e1);
            public static FormLink<IEncounterZoneGetter> DLC2StoneWaterZone => Construct(0x142e0);
            public static FormLink<IEncounterZoneGetter> DLC2StoneSunZone => Construct(0x142dd);
            public static FormLink<IEncounterZoneGetter> DLC2MoesringPassZone => Construct(0x142db);
            public static FormLink<IEncounterZoneGetter> DLC2POI13Zone => Construct(0x142d9);
            public static FormLink<IEncounterZoneGetter> DLC2FrostmoonCragZone => Construct(0x142d8);
            public static FormLink<IEncounterZoneGetter> DLC2BujoldsRetreatZone => Construct(0x142d7);
            public static FormLink<IEncounterZoneGetter> DLC2POI10Zone => Construct(0x142d6);
            public static FormLink<IEncounterZoneGetter> DLC2NorthshoreLandingZone => Construct(0x142d4);
            public static FormLink<IEncounterZoneGetter> DLC2AshfallowZone => Construct(0x142d2);
            public static FormLink<IEncounterZoneGetter> DLC2GlacialCaveZone => Construct(0x142d1);
            public static FormLink<IEncounterZoneGetter> DLC2HrodulfsHouseZone => Construct(0x142d0);
            public static FormLink<IEncounterZoneGetter> DLC2HaknirsShoalZone => Construct(0x142cf);
            public static FormLink<IEncounterZoneGetter> DLC2AbandonedLodgeZone => Construct(0x142cd);
            public static FormLink<IEncounterZoneGetter> DLC2WhiteRidgeBarrowZone => Construct(0x142bf);
            public static FormLink<IEncounterZoneGetter> DLC2KolbjornBarrowZone => Construct(0x142be);
            public static FormLink<IEncounterZoneGetter> DLC2VahloksTombZone => Construct(0x142bd);
            public static FormLink<IEncounterZoneGetter> DLC2TempleOfMiraakZone => Construct(0x142b7);
            public static FormLink<IEncounterZoneGetter> DLC2NchardakZone => Construct(0x142b5);
            public static FormLink<IEncounterZoneGetter> DLC2Book01DungeonZone => Construct(0x142b3);
            public static FormLink<IEncounterZoneGetter> DLC2Book03DungeonZone => Construct(0x142b2);
            public static FormLink<IEncounterZoneGetter> DLC2Book02DungeonZone => Construct(0x142b1);
            public static FormLink<IEncounterZoneGetter> DLC2MiscBookLevel1Zone => Construct(0x142ad);
            public static FormLink<IEncounterZoneGetter> DLC2HorkerIslandZone => Construct(0x142ab);
            public static FormLink<IEncounterZoneGetter> DLC2GyldenhulBarrowZone => Construct(0x142a9);
            public static FormLink<IEncounterZoneGetter> DLC2FrosselZone => Construct(0x142a7);
            public static FormLink<IEncounterZoneGetter> DLC2StoneEarthZone => Construct(0x142a5);
            public static FormLink<IEncounterZoneGetter> DLC2KagrumezZone => Construct(0x142a3);
            public static FormLink<IEncounterZoneGetter> DLC2FahlbtharzZone => Construct(0x142a1);
            public static FormLink<IEncounterZoneGetter> DLC2CastleKarstaagRuinsZone => Construct(0x1429f);
            public static FormLink<IEncounterZoneGetter> DLC2BrodirGroveZone => Construct(0x1429d);
            public static FormLink<IEncounterZoneGetter> DLC2RavenRockMineZone => Construct(0x1429b);
            public static FormLink<IEncounterZoneGetter> DLC2BenkongerikeZone => Construct(0x14299);
            public static FormLink<IEncounterZoneGetter> DLC2StoneBeastZone => Construct(0x14297);
            public static FormLink<IEncounterZoneGetter> DLC2AltarofThrondZone => Construct(0x14295);
            public static FormLink<IEncounterZoneGetter> DLC2FortFrostmothZone => Construct(0x14292);
        }
    }
}
