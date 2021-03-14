using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class Key
        {
            private static FormLink<IKeyGetter> Construct(uint id) => new FormLink<IKeyGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IKeyGetter> DLC2TelMithrynStaffEnchanterKey => Construct(0x3d23f);
            public static FormLink<IKeyGetter> DLC2PlayerHouseKey => Construct(0x3bd09);
            public static FormLink<IKeyGetter> DLC2RRJailKey => Construct(0x34f97);
            public static FormLink<IKeyGetter> DLC2TelMithrynStewardsKey => Construct(0x336a0);
            public static FormLink<IKeyGetter> DLC2TelMithrynKitchenKeyNEW => Construct(0x3369f);
            public static FormLink<IKeyGetter> DLC2TelMithrynApothelcaryKeyNEW => Construct(0x3369e);
            public static FormLink<IKeyGetter> DLC2TGGloverKey => Construct(0x2ad3d);
            public static FormLink<IKeyGetter> DLC2ExpSpiderCageKey => Construct(0x297da);
            public static FormLink<IKeyGetter> DLC2RR02BossChestKey => Construct(0x292a8);
            public static FormLink<IKeyGetter> DLC2TempleOfMiraak02Key => Construct(0x28930);
            public static FormLink<IKeyGetter> DLC2SV02AbandonedLodgeKey => Construct(0x27e00);
            public static FormLink<IKeyGetter> WhiterunJailKeyDUPLICATE002 => Construct(0x27664);
            public static FormLink<IKeyGetter> DLC2NB01BossJailKey => Construct(0x27663);
            public static FormLink<IKeyGetter> DLC2RRF05StrongboxKey => Construct(0x24fa7);
            public static FormLink<IKeyGetter> DLC2RRTempleTombKey => Construct(0x24e02);
            public static FormLink<IKeyGetter> DLC2dunCastleKarstaagKey => Construct(0x2481a);
            public static FormLink<IKeyGetter> DLC2RR03GateKey => Construct(0x20a43);
            public static FormLink<IKeyGetter> DLC2dunFortFrostmothExitKey => Construct(0x1f4b4);
            public static FormLink<IKeyGetter> DLC2RR02SeverinSafeKey => Construct(0x1f31e);
            public static FormLink<IKeyGetter> DLC2TelMithrynKitchenKey => Construct(0x1bd06);
            public static FormLink<IKeyGetter> DLC2TelMithrynApothecaryKey => Construct(0x1bd05);
            public static FormLink<IKeyGetter> DLC2dunBenkongerikeKey01 => Construct(0x1a971);
            public static FormLink<IKeyGetter> DLC2SVGreathallKey => Construct(0x18fc7);
            public static FormLink<IKeyGetter> DLC2SVEdlasHouseKey => Construct(0x18fbb);
            public static FormLink<IKeyGetter> DLC2SVBaldorIronShapersHouseKey => Construct(0x18fb7);
            public static FormLink<IKeyGetter> DLC2SVWulfWildbloodsHouseKey => Construct(0x18fb0);
            public static FormLink<IKeyGetter> DLC2SVMorwensHouseKey => Construct(0x18fad);
            public static FormLink<IKeyGetter> DLC2SVDeorWoodcuttersHouseKey => Construct(0x18fa4);
            public static FormLink<IKeyGetter> DLC2SVOslafsHouseKey => Construct(0x18f9f);
            public static FormLink<IKeyGetter> DLC2dunGyldenhulBarrowKey => Construct(0x18d1c);
            public static FormLink<IKeyGetter> DLC2RRIenthFarmKey => Construct(0x18457);
            public static FormLink<IKeyGetter> DLC2RRSeverinManorKey => Construct(0x18456);
            public static FormLink<IKeyGetter> DLC2RRCaerelliusHouseKey => Construct(0x18455);
            public static FormLink<IKeyGetter> DLC2RRGloverHouseKey => Construct(0x18454);
            public static FormLink<IKeyGetter> DLC2RRAlorHouseKey => Construct(0x18453);
            public static FormLink<IKeyGetter> DLC2RRNetchKey => Construct(0x18452);
            public static FormLink<IKeyGetter> DLC2RRTempleKey => Construct(0x18451);
            public static FormLink<IKeyGetter> DLC2RRMorvaynManorKey => Construct(0x18450);
        }
    }
}
