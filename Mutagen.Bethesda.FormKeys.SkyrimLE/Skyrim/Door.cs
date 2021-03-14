using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class Door
        {
            private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDoorGetter> dunTwilightSepulcherDoor => Construct(0x10fcd9);
            public static FormLink<IDoorGetter> SHouseDoor01MinUse => Construct(0x10f10d);
            public static FormLink<IDoorGetter> WinterholdLDoorMinUse => Construct(0x10e866);
            public static FormLink<IDoorGetter> WinterholdTrapdoor01 => Construct(0x10de06);
            public static FormLink<IDoorGetter> ImpWoodDoorCaveLoad01 => Construct(0x10c62a);
            public static FormLink<IDoorGetter> WRStableGate01Anim => Construct(0x10c00e);
            public static FormLink<IDoorGetter> MetalCageDoor01NoName => Construct(0x10aa96);
            public static FormLink<IDoorGetter> HHDoor02MinUse => Construct(0x10aa4d);
            public static FormLink<IDoorGetter> WinterholdGate01 => Construct(0x1092a9);
            public static FormLink<IDoorGetter> WRDragonSideDoor01 => Construct(0x108e8a);
            public static FormLink<IDoorGetter> WinterholdLDoor02 => Construct(0x107f04);
            public static FormLink<IDoorGetter> WinterholdAnimDoor01 => Construct(0x107eff);
            public static FormLink<IDoorGetter> WinterholdLDoor01 => Construct(0x107efe);
            public static FormLink<IDoorGetter> DweDoorLarge01LoadMinUse => Construct(0x10009e);
            public static FormLink<IDoorGetter> NorLabyrinthianMazePanel01 => Construct(0xfe6b0);
            public static FormLink<IDoorGetter> ImpJailDoor02NoSearch => Construct(0xfe52f);
            public static FormLink<IDoorGetter> ImpJailDoor01NoSearch => Construct(0xfe52e);
            public static FormLink<IDoorGetter> WRShackDoorMinUse01 => Construct(0xfe471);
            public static FormLink<IDoorGetter> TG07SpecialDisplayCaseLgAngled01 => Construct(0xf84a6);
            public static FormLink<IDoorGetter> MetalCageLongGate01Snow => Construct(0xf5bde);
            public static FormLink<IDoorGetter> RifRmSmBaseWallGrate01Act => Construct(0xe8218);
            public static FormLink<IDoorGetter> NorDoorSmLoad01MinUse => Construct(0xf1c16);
            public static FormLink<IDoorGetter> DBSanc_FusedDoor => Construct(0xf0647);
            public static FormLink<IDoorGetter> ImpDoorSingleLoad01MinUse => Construct(0xef53a);
            public static FormLink<IDoorGetter> dunSolitudeJailSecretExit02 => Construct(0xef539);
            public static FormLink<IDoorGetter> dunSolitudeJailSecretExit01 => Construct(0xef538);
            public static FormLink<IDoorGetter> DragonBridgeKitchenDoor01 => Construct(0xedf17);
            public static FormLink<IDoorGetter> SLGDoor01 => Construct(0xecf90);
            public static FormLink<IDoorGetter> DwePtnDoor01NoName => Construct(0xecce8);
            public static FormLink<IDoorGetter> WHIntWoodBackSecDoor01 => Construct(0xecce2);
            public static FormLink<IDoorGetter> FarmhouseJailDoor01 => Construct(0xec563);
            public static FormLink<IDoorGetter> TGSecretDoor01 => Construct(0xeb832);
            public static FormLink<IDoorGetter> NorLargeDoorMinUse => Construct(0xeafbb);
            public static FormLink<IDoorGetter> FarmBTrapdoor02 => Construct(0xe9e08);
            public static FormLink<IDoorGetter> FarmBTrapdoor01 => Construct(0xe9e07);
            public static FormLink<IDoorGetter> SSingleDoorIntJail01R => Construct(0xdd4d2);
            public static FormLink<IDoorGetter> RiftenKeepDoor01 => Construct(0xd8713);
            public static FormLink<IDoorGetter> MS11SecretCabinetDoor01 => Construct(0xd57ec);
            public static FormLink<IDoorGetter> FarmhouseAnimDoor02 => Construct(0xc78a6);
            public static FormLink<IDoorGetter> FarmhouseAnimDoor01 => Construct(0xc78a3);
            public static FormLink<IDoorGetter> RiftenRWArmoryDoor02 => Construct(0xc19c2);
            public static FormLink<IDoorGetter> RifRmSmBaseWallSecretDoor02 => Construct(0xc19c1);
            public static FormLink<IDoorGetter> FarmhouseDoorMinimalUse01 => Construct(0xbecdd);
            public static FormLink<IDoorGetter> NorLabyrinthianLoadDoor01 => Construct(0xb5cb1);
            public static FormLink<IDoorGetter> TrapTriggerHinge => Construct(0xae4e0);
            public static FormLink<IDoorGetter> NorShaftTrapDoor01 => Construct(0xa343f);
            public static FormLink<IDoorGetter> RTIronGate02 => Construct(0x99367);
            public static FormLink<IDoorGetter> MQDelphineSecretDoor => Construct(0x99066);
            public static FormLink<IDoorGetter> ShipKatariahAnchorWoodhole02MinUse => Construct(0x976ff);
            public static FormLink<IDoorGetter> RTIronGate01 => Construct(0x94101);
            public static FormLink<IDoorGetter> RiftenDoorLoad01MinUseDoor => Construct(0x94025);
            public static FormLink<IDoorGetter> RiftenRWDoorLoad01MinUse => Construct(0x94024);
            public static FormLink<IDoorGetter> WHIntmetalarchdoor => Construct(0x93a7c);
            public static FormLink<IDoorGetter> WHIntDoor01 => Construct(0x93a78);
            public static FormLink<IDoorGetter> ImpJailDoor02 => Construct(0x163f0);
            public static FormLink<IDoorGetter> WRDragonDoor01MinUse => Construct(0x8648c);
            public static FormLink<IDoorGetter> RTMainGate01MinUse => Construct(0x713de);
            public static FormLink<IDoorGetter> MarkarthWarrensGarveyDoor => Construct(0x65767);
            public static FormLink<IDoorGetter> MarkarthWarrensCosnachDoor => Construct(0x6575f);
            public static FormLink<IDoorGetter> MarkarthWarrensElyrsDoor => Construct(0x6573b);
            public static FormLink<IDoorGetter> MarkarthWarrensDegaineDoor => Construct(0x6573a);
            public static FormLink<IDoorGetter> MarkarthWarrensWeylinDoor => Construct(0x65739);
            public static FormLink<IDoorGetter> MarkarthWarrensOmluagDoor => Construct(0x65738);
            public static FormLink<IDoorGetter> WHArenaDoor => Construct(0x5437b);
            public static FormLink<IDoorGetter> MrkMarketStallDoor => Construct(0x4739d);
            public static FormLink<IDoorGetter> SSingleDoorInt01Load => Construct(0x36170);
            public static FormLink<IDoorGetter> SHouseIntDoor02Load => Construct(0x36165);
            public static FormLink<IDoorGetter> AutoLoadDoorHiddenMinUse01 => Construct(0x351eb);
            public static FormLink<IDoorGetter> ShipKatariahAnchorWoodhole02 => Construct(0xe74fb);
            public static FormLink<IDoorGetter> ShipKatariahDoorLoad01 => Construct(0xe74f6);
            public static FormLink<IDoorGetter> ShipKatariahDoor02 => Construct(0xe74f5);
            public static FormLink<IDoorGetter> HelgenGate01 => Construct(0xe41da);
            public static FormLink<IDoorGetter> SJailDoor02Load => Construct(0xe3e3f);
            public static FormLink<IDoorGetter> dunDeadMensRespiteHoSDoor => Construct(0xe3c4e);
            public static FormLink<IDoorGetter> NorMS06WolfDoor => Construct(0xe0dde);
            public static FormLink<IDoorGetter> RiftenRWDoorJailLoad01 => Construct(0xd71f4);
            public static FormLink<IDoorGetter> DweFacadeLiftLeverLoadUp01_MinUse => Construct(0xd3972);
            public static FormLink<IDoorGetter> WHgrayquarterdoor01 => Construct(0xd18ab);
            public static FormLink<IDoorGetter> DunFrostflowCellarDoor => Construct(0xd08bf);
            public static FormLink<IDoorGetter> SHouseIntDoor02 => Construct(0xcee68);
            public static FormLink<IDoorGetter> SDoorJail02 => Construct(0xce7e3);
            public static FormLink<IDoorGetter> MetalCageLongGate01 => Construct(0xce0ab);
            public static FormLink<IDoorGetter> DweFacadeLiftLeverLoadDown01_MinUse => Construct(0xcd6bf);
            public static FormLink<IDoorGetter> RTMarketStallDoor01 => Construct(0xcc526);
            public static FormLink<IDoorGetter> SSingleDoorInt01L => Construct(0xcc16a);
            public static FormLink<IDoorGetter> SDoubleDoorInt01 => Construct(0xcc164);
            public static FormLink<IDoorGetter> SSingleDoorInt01R => Construct(0xcc163);
            public static FormLink<IDoorGetter> NorWoodDoorLoad01MinUse => Construct(0xc76df);
            public static FormLink<IDoorGetter> ShrineMehrunesDoor01 => Construct(0xc5a1a);
            public static FormLink<IDoorGetter> MS12ForsakenCaveDoorSmLoad01 => Construct(0xc58a4);
            public static FormLink<IDoorGetter> DisplayCaseSmFlat01 => Construct(0xc5894);
            public static FormLink<IDoorGetter> DisplayCaseSmAngled01 => Construct(0xc5893);
            public static FormLink<IDoorGetter> DisplayCaseLgFlat01 => Construct(0xc5892);
            public static FormLink<IDoorGetter> DisplayCaseLgAngled01 => Construct(0xc5891);
            public static FormLink<IDoorGetter> DBKatariahChainStatic => Construct(0xc3e3b);
            public static FormLink<IDoorGetter> ShipDoor01Load => Construct(0xc227b);
            public static FormLink<IDoorGetter> WHcastledoorentrance => Construct(0xc0e2a);
            public static FormLink<IDoorGetter> WHmetalarchdoor => Construct(0xc0e0b);
            public static FormLink<IDoorGetter> RiftenHonorhalIMinUseDoor => Construct(0xc0623);
            public static FormLink<IDoorGetter> RifRmSmSecretCabinetPanel01 => Construct(0xc0306);
            public static FormLink<IDoorGetter> RifRmSmSecretCabinetDoor01 => Construct(0xc0305);
            public static FormLink<IDoorGetter> ImpJailDoor01MinUse => Construct(0xc0088);
            public static FormLink<IDoorGetter> ImpDoorSingle01MinUse => Construct(0xc006f);
            public static FormLink<IDoorGetter> AutoLoadDoorMinUse01 => Construct(0x180d8);
            public static FormLink<IDoorGetter> RiftenRWDoorLoad01hiddenMinUse => Construct(0x52a92);
            public static FormLink<IDoorGetter> RiftenRWHallLadderDoor01MinUse => Construct(0x2d2ff);
            public static FormLink<IDoorGetter> FalmerBigFenceGate01 => Construct(0x99d48);
            public static FormLink<IDoorGetter> CaveDoorLoad01 => Construct(0x99d2e);
            public static FormLink<IDoorGetter> ShipKatariahTrapdoor01 => Construct(0x98584);
            public static FormLink<IDoorGetter> ShipKatariahDoor01 => Construct(0x98582);
            public static FormLink<IDoorGetter> ShipKatariahTrapdoorLadder02 => Construct(0x98581);
            public static FormLink<IDoorGetter> ShipKatariahTrapdoorLadder01 => Construct(0x98580);
            public static FormLink<IDoorGetter> SDoorFrontGate => Construct(0x97be6);
            public static FormLink<IDoorGetter> DBSecretPassageHole => Construct(0x84b2e);
            public static FormLink<IDoorGetter> DBSecretPassageStainGlassDoor => Construct(0x84b2b);
            public static FormLink<IDoorGetter> CWSecretImpDoorSingleLoad01 => Construct(0x54d0b);
            public static FormLink<IDoorGetter> MineSecretDoor01 => Construct(0x3e469);
            public static FormLink<IDoorGetter> dunda14PortalDoor01 => Construct(0x3dc41);
            public static FormLink<IDoorGetter> TrapdoorLadder01HiddenMinUse => Construct(0x2fbad);
            public static FormLink<IDoorGetter> OrcDoorLoad01 => Construct(0x27fe8);
            public static FormLink<IDoorGetter> OrcDoor01 => Construct(0x27fe7);
            public static FormLink<IDoorGetter> SHouseIntDoor01 => Construct(0x1e4e3);
            public static FormLink<IDoorGetter> NMCoffin01 => Construct(0x1c599);
            public static FormLink<IDoorGetter> HHSprintGate01 => Construct(0xbec6f);
            public static FormLink<IDoorGetter> SOVDoorShortL => Construct(0xbd060);
            public static FormLink<IDoorGetter> SOVDoorTallL => Construct(0xbd05f);
            public static FormLink<IDoorGetter> SOVDoorTallR => Construct(0xbd05e);
            public static FormLink<IDoorGetter> SOVDoorShortR => Construct(0xbd05d);
            public static FormLink<IDoorGetter> RTStableDoor01 => Construct(0xbb7b8);
            public static FormLink<IDoorGetter> TG03MeaderyMinUseDoor => Construct(0xb9772);
            public static FormLink<IDoorGetter> NorDoorSmLoad02MinUse => Construct(0xb7d9f);
            public static FormLink<IDoorGetter> RifRmSmBaseWallSecretDoor01 => Construct(0xab46b);
            public static FormLink<IDoorGetter> RifRmSmBaseWallGrate01 => Construct(0xab469);
            public static FormLink<IDoorGetter> RiftenRWDoorJail01PRISONER => Construct(0xaa78a);
            public static FormLink<IDoorGetter> WRJailDoor01PRISONER => Construct(0xaa789);
            public static FormLink<IDoorGetter> ImpJailDoor01PRISONER => Construct(0xaa785);
            public static FormLink<IDoorGetter> MetalCageDoor01 => Construct(0xaa043);
            public static FormLink<IDoorGetter> WRFenceStrGate01Door01 => Construct(0xa88da);
            public static FormLink<IDoorGetter> HHDoor02 => Construct(0xa85eb);
            public static FormLink<IDoorGetter> HHDoor01 => Construct(0xa85ea);
            public static FormLink<IDoorGetter> WRJailDoor01 => Construct(0xa7613);
            public static FormLink<IDoorGetter> WRPrisonCellFloorGrate01Door => Construct(0xa760e);
            public static FormLink<IDoorGetter> RiftenDoor02 => Construct(0xa56ff);
            public static FormLink<IDoorGetter> ShipTrapdoor01MinUse => Construct(0xa38d3);
            public static FormLink<IDoorGetter> WHDoorFrontGate => Construct(0x9f27c);
            public static FormLink<IDoorGetter> NorDoorSmLoad02HiddenMinUse => Construct(0x988df);
            public static FormLink<IDoorGetter> NorBridgeCageExSm01NoName => Construct(0x94a5c);
            public static FormLink<IDoorGetter> WRDoorDA08 => Construct(0x94195);
            public static FormLink<IDoorGetter> WRDoor02Load => Construct(0x94193);
            public static FormLink<IDoorGetter> WRDoor02 => Construct(0x94192);
            public static FormLink<IDoorGetter> WRDoor03Load => Construct(0x94191);
            public static FormLink<IDoorGetter> WRDoor03 => Construct(0x9418f);
            public static FormLink<IDoorGetter> RTMainGate01 => Construct(0x8a1f9);
            public static FormLink<IDoorGetter> ImpJailDoorNoName => Construct(0x6ae73);
            public static FormLink<IDoorGetter> WRCastleDoor01 => Construct(0x60d85);
            public static FormLink<IDoorGetter> DBKatariahChainActivator => Construct(0x5a281);
            public static FormLink<IDoorGetter> WRDoorMainGate01 => Construct(0x50973);
            public static FormLink<IDoorGetter> SPatioGate01 => Construct(0x7df47);
            public static FormLink<IDoorGetter> ImpDoorExtHoleDoorLoadMinUse01 => Construct(0x7c914);
            public static FormLink<IDoorGetter> WRSkyForge01Door01 => Construct(0x7ba48);
            public static FormLink<IDoorGetter> WRUnderforgedoor01 => Construct(0x7ba1b);
            public static FormLink<IDoorGetter> SSecretJaildoor01 => Construct(0x663b1);
            public static FormLink<IDoorGetter> SDoorJail01 => Construct(0x5e91d);
            public static FormLink<IDoorGetter> SMdDoorHoleCei01 => Construct(0x56f21);
            public static FormLink<IDoorGetter> ImpJailDoor01 => Construct(0x40bb2);
            public static FormLink<IDoorGetter> StockadeGate01Light_SN => Construct(0x2a289);
            public static FormLink<IDoorGetter> RiftenRWDoorJail01 => Construct(0x74daf);
            public static FormLink<IDoorGetter> RiftenRWArmoryDoorLock01 => Construct(0x73021);
            public static FormLink<IDoorGetter> RiftenRWArmoryDoor01 => Construct(0x73020);
            public static FormLink<IDoorGetter> ImperialWallShackle01 => Construct(0x6f791);
            public static FormLink<IDoorGetter> CaveGSecretDoor01 => Construct(0x6f703);
            public static FormLink<IDoorGetter> RiftenRWDoorLoad01 => Construct(0x6f267);
            public static FormLink<IDoorGetter> SkyHavenDoor01 => Construct(0x6da86);
            public static FormLink<IDoorGetter> SkyHavenHeadDoor01 => Construct(0x6aef1);
            public static FormLink<IDoorGetter> NorShaftTrapDoorSmallerTriggered => Construct(0x68931);
            public static FormLink<IDoorGetter> NorShaftTrapDoorTriggered => Construct(0x68930);
            public static FormLink<IDoorGetter> DweDoorLarge01Load => Construct(0x6597b);
            public static FormLink<IDoorGetter> DweDoorSmall01Load => Construct(0x64092);
            public static FormLink<IDoorGetter> DweDoorSmall01 => Construct(0x64091);
            public static FormLink<IDoorGetter> DweDoorLarge01 => Construct(0x64090);
            public static FormLink<IDoorGetter> DweFacadeLiftLeverLoadDown01 => Construct(0x36adb);
            public static FormLink<IDoorGetter> DweFacadeLiftLeverLoadUp01 => Construct(0x61517);
            public static FormLink<IDoorGetter> ShipTrapdoor01MinUseHidden => Construct(0x61435);
            public static FormLink<IDoorGetter> SHouseDoor03 => Construct(0x5d7ea);
            public static FormLink<IDoorGetter> ImpWellDoor => Construct(0x5cbbc);
            public static FormLink<IDoorGetter> ImpWallcage01 => Construct(0x52e9d);
            public static FormLink<IDoorGetter> ImpStableGate01 => Construct(0x5ad57);
            public static FormLink<IDoorGetter> TrapdoorLadder01 => Construct(0x5ad3c);
            public static FormLink<IDoorGetter> TrapdoorLadder02 => Construct(0x5ad3b);
            public static FormLink<IDoorGetter> ImpSewerHole01 => Construct(0x5ad39);
            public static FormLink<IDoorGetter> DwePtnDoor01 => Construct(0x59d60);
            public static FormLink<IDoorGetter> TG05LockedDoor01 => Construct(0x59a97);
            public static FormLink<IDoorGetter> ImpDoorExtSingleSmallLoad01 => Construct(0x4e33d);
            public static FormLink<IDoorGetter> ImpDoorExtHoleDoor01 => Construct(0x4e300);
            public static FormLink<IDoorGetter> ImpDoorExtHoleDoorLoad01 => Construct(0x4e2c2);
            public static FormLink<IDoorGetter> ImpDoorExtSingleSmall01 => Construct(0x4dfd9);
            public static FormLink<IDoorGetter> ShipTrapdoor01 => Construct(0x2834e);
            public static FormLink<IDoorGetter> ShipDoor01 => Construct(0x25ff7);
            public static FormLink<IDoorGetter> TG04TEMPDoorSolitudeEETCConnection => Construct(0x50374);
            public static FormLink<IDoorGetter> RiftenDoorLoad01 => Construct(0x4d6ed);
            public static FormLink<IDoorGetter> DBBlackDoorBase => Construct(0x4d6c3);
            public static FormLink<IDoorGetter> RiftenRWPortholeDoor01MinUse => Construct(0x4d233);
            public static FormLink<IDoorGetter> RiftenRWDoor01 => Construct(0x4c5c4);
            public static FormLink<IDoorGetter> RiftenRWDoorSpecial01 => Construct(0x4c5c1);
            public static FormLink<IDoorGetter> MineDoor01LoadBare => Construct(0x4b484);
            public static FormLink<IDoorGetter> MineDoor01Load => Construct(0x37cfe);
            public static FormLink<IDoorGetter> RiftenRWThievesGuildDoor01 => Construct(0x349ae);
            public static FormLink<IDoorGetter> StockadeGate01 => Construct(0x1ae14);
            public static FormLink<IDoorGetter> RiftenRWPortholeDoor01 => Construct(0x49b02);
            public static FormLink<IDoorGetter> RiftenRWRoomLadder01 => Construct(0x48e6c);
            public static FormLink<IDoorGetter> RiftenRWHallLadderDoor01 => Construct(0x48b39);
            public static FormLink<IDoorGetter> SHouseDoor02 => Construct(0x453d8);
            public static FormLink<IDoorGetter> ImpDoorDoubleLoad01 => Construct(0x439c4);
            public static FormLink<IDoorGetter> ImpDoorDouble01 => Construct(0x439c2);
            public static FormLink<IDoorGetter> ImpDoorSingleLoad01 => Construct(0x4203a);
            public static FormLink<IDoorGetter> ImpDoorSingle01 => Construct(0x42035);
            public static FormLink<IDoorGetter> NorDoorMediumLoad01 => Construct(0x3c30a);
            public static FormLink<IDoorGetter> NorDoorMedium01 => Construct(0x3c308);
            public static FormLink<IDoorGetter> AutoLoadDoor01 => Construct(0x31897);
            public static FormLink<IDoorGetter> NorDoorSm02Flipped => Construct(0x31895);
            public static FormLink<IDoorGetter> dunUstenPuzGate01x => Construct(0x3b2e0);
            public static FormLink<IDoorGetter> WHDoor01 => Construct(0x37e41);
            public static FormLink<IDoorGetter> SHouseDoor01 => Construct(0x368ce);
            public static FormLink<IDoorGetter> RFTrapDoor => Construct(0x3473b);
            public static FormLink<IDoorGetter> NorBridgeCageExSm01 => Construct(0x34451);
            public static FormLink<IDoorGetter> WinterholdCollegeHallDoor => Construct(0x327c9);
            public static FormLink<IDoorGetter> NorLargeDoor => Construct(0x2e4c3);
            public static FormLink<IDoorGetter> WRShackDoor01 => Construct(0x24e26);
            public static FormLink<IDoorGetter> MrkDoor01 => Construct(0x1bffc);
            public static FormLink<IDoorGetter> MrkDoor02 => Construct(0x1bffb);
            public static FormLink<IDoorGetter> NorShaftTrapDoorSmaller => Construct(0x1bc2a);
            public static FormLink<IDoorGetter> NorShaftTrapDoor => Construct(0x2c947);
            public static FormLink<IDoorGetter> NorWoodDoorLoad01 => Construct(0x2c157);
            public static FormLink<IDoorGetter> NorWoodDoor01 => Construct(0x2c155);
            public static FormLink<IDoorGetter> NorDoorSmLoad02 => Construct(0x2abac);
            public static FormLink<IDoorGetter> NorDoorSmLoad01 => Construct(0x2abab);
            public static FormLink<IDoorGetter> FarmhouseLDoor01 => Construct(0x29cb0);
            public static FormLink<IDoorGetter> WRDragonDoor01 => Construct(0x252c7);
            public static FormLink<IDoorGetter> DBBlackDoor => Construct(0x22f44);
            public static FormLink<IDoorGetter> MS08AlikrBaseDoor => Construct(0x215ff);
            public static FormLink<IDoorGetter> NorDoorSm02 => Construct(0x1ebee);
            public static FormLink<IDoorGetter> NorDoorSm01 => Construct(0x1ebed);
            public static FormLink<IDoorGetter> FarmhouseDoor01 => Construct(0x12eb1);
            public static FormLink<IDoorGetter> PrisonMarker => Construct(0x4);
        }
    }
}
