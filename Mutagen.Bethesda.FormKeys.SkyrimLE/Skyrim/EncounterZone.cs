using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Skyrim
    {
        public static class EncounterZone
        {
            private static FormLink<IEncounterZoneGetter> Construct(uint id) => new FormLink<IEncounterZoneGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IEncounterZoneGetter> TowerOfMzarkZone => Construct(0x10f67d);
            public static FormLink<IEncounterZoneGetter> WinterholdCollegeMiddenZone => Construct(0x10d415);
            public static FormLink<IEncounterZoneGetter> MarkarthAbandonedHouseZone => Construct(0x10d0c3);
            public static FormLink<IEncounterZoneGetter> StendarrsBeaconZone => Construct(0x108a5b);
            public static FormLink<IEncounterZoneGetter> NorthwindMineZone => Construct(0xfdbe0);
            public static FormLink<IEncounterZoneGetter> BonechillPassageZone => Construct(0xfda47);
            public static FormLink<IEncounterZoneGetter> ArcwindPointZone => Construct(0xfd686);
            public static FormLink<IEncounterZoneGetter> HelgenZone => Construct(0xf94a6);
            public static FormLink<IEncounterZoneGetter> NoResetZone => Construct(0xf90b1);
            public static FormLink<IEncounterZoneGetter> MeekosShackZone => Construct(0xf6f14);
            public static FormLink<IEncounterZoneGetter> ShrineofBoethiahZone => Construct(0xf5ba8);
            public static FormLink<IEncounterZoneGetter> ShrineofPeryiteZone => Construct(0xf5ba6);
            public static FormLink<IEncounterZoneGetter> AngisCampZone => Construct(0xf5ba3);
            public static FormLink<IEncounterZoneGetter> BoulderfallCaveZone => Construct(0xf52db);
            public static FormLink<IEncounterZoneGetter> HuntersRestZone => Construct(0xf52b1);
            public static FormLink<IEncounterZoneGetter> RefugeesRestZone => Construct(0xef573);
            public static FormLink<IEncounterZoneGetter> JourneymansNookZone => Construct(0xef54b);
            public static FormLink<IEncounterZoneGetter> IronbackHideoutZone => Construct(0xef545);
            public static FormLink<IEncounterZoneGetter> PinefrostTowerZone => Construct(0xef0bd);
            public static FormLink<IEncounterZoneGetter> SkytempleRuinsZone => Construct(0xef0b1);
            public static FormLink<IEncounterZoneGetter> WidowsWatchRuinsZone => Construct(0xef0aa);
            public static FormLink<IEncounterZoneGetter> HamvirsRestZone => Construct(0xef0a3);
            public static FormLink<IEncounterZoneGetter> BrokenLimbCampZone => Construct(0xecf89);
            public static FormLink<IEncounterZoneGetter> MarasEyePondZone => Construct(0xecf54);
            public static FormLink<IEncounterZoneGetter> RiversideShackZone => Construct(0xecf4e);
            public static FormLink<IEncounterZoneGetter> AbandonedPrisonZone => Construct(0xecf4b);
            public static FormLink<IEncounterZoneGetter> ValkyggZone => Construct(0xeaa61);
            public static FormLink<IEncounterZoneGetter> WarehouseZone => Construct(0xe9da8);
            public static FormLink<IEncounterZoneGetter> AnisesCabinZone => Construct(0xd9546);
            public static FormLink<IEncounterZoneGetter> EmbershardMineZone => Construct(0xd9545);
            public static FormLink<IEncounterZoneGetter> HalloftheVigilantZone => Construct(0xc3442);
            public static FormLink<IEncounterZoneGetter> YorgrimOverlookZone => Construct(0xc3429);
            public static FormLink<IEncounterZoneGetter> WaywardPassZone => Construct(0xc2efd);
            public static FormLink<IEncounterZoneGetter> SnowpointBeaconZone => Construct(0xc2ef9);
            public static FormLink<IEncounterZoneGetter> KjenstagRuinsZone => Construct(0xc2ef2);
            public static FormLink<IEncounterZoneGetter> WindwardRuinsZone => Construct(0xc2eee);
            public static FormLink<IEncounterZoneGetter> TraitorsPostZone => Construct(0xc2ee8);
            public static FormLink<IEncounterZoneGetter> WeynonStonesZone => Construct(0xbc0ad);
            public static FormLink<IEncounterZoneGetter> ColdRockPassZone => Construct(0xbc0a4);
            public static FormLink<IEncounterZoneGetter> FourSkullLookoutZone => Construct(0xb23ad);
            public static FormLink<IEncounterZoneGetter> ReachwindEyrieZone => Construct(0xb23a6);
            public static FormLink<IEncounterZoneGetter> CradleStoneTowerZone => Construct(0xb23a0);
            public static FormLink<IEncounterZoneGetter> DragonBridgeOverlookZone => Construct(0xb2396);
            public static FormLink<IEncounterZoneGetter> DeepFolkCrossingZone => Construct(0xb2392);
            public static FormLink<IEncounterZoneGetter> CliffsideRetreatZone => Construct(0xb238e);
            public static FormLink<IEncounterZoneGetter> E3DemoBleakFallsBarrowZone => Construct(0x998bf);
            public static FormLink<IEncounterZoneGetter> RaldbtharZone => Construct(0x90575);
            public static FormLink<IEncounterZoneGetter> StonyCreekCaveZone => Construct(0x80f29);
            public static FormLink<IEncounterZoneGetter> SteamcragCampZone => Construct(0x79fa0);
            public static FormLink<IEncounterZoneGetter> MarkarthWizardsQuarters02Zone => Construct(0x5cf97);
            public static FormLink<IEncounterZoneGetter> MarkarthWizardsQuartersZone => Construct(0x5cf96);
            public static FormLink<IEncounterZoneGetter> KagrenzelZone => Construct(0x233f2);
            public static FormLink<IEncounterZoneGetter> DrelasCottageZone => Construct(0xe66ac);
            public static FormLink<IEncounterZoneGetter> CrabbersShantyZone => Construct(0xe66aa);
            public static FormLink<IEncounterZoneGetter> LundsHutZone => Construct(0xe66a6);
            public static FormLink<IEncounterZoneGetter> GjukarsMonumentZone => Construct(0xe66a2);
            public static FormLink<IEncounterZoneGetter> WhitewatchTowerZone => Construct(0xe66a1);
            public static FormLink<IEncounterZoneGetter> DoomstoneAtronachZone => Construct(0xd568a);
            public static FormLink<IEncounterZoneGetter> DoomstoneLadyZone => Construct(0xd5689);
            public static FormLink<IEncounterZoneGetter> DoomstoneLordZone => Construct(0xd5688);
            public static FormLink<IEncounterZoneGetter> DoomstoneLoverZone => Construct(0xd5687);
            public static FormLink<IEncounterZoneGetter> DoomstoneMageZone => Construct(0xd5686);
            public static FormLink<IEncounterZoneGetter> DoomstoneRitualZone => Construct(0xd5685);
            public static FormLink<IEncounterZoneGetter> DoomstoneSerpentZone => Construct(0xd5684);
            public static FormLink<IEncounterZoneGetter> DoomstoneShadowZone => Construct(0xd5683);
            public static FormLink<IEncounterZoneGetter> DoomstoneSteedZone => Construct(0xd5682);
            public static FormLink<IEncounterZoneGetter> DoomstoneTowerZone => Construct(0xd5681);
            public static FormLink<IEncounterZoneGetter> DoomstoneWarriorZone => Construct(0xd5680);
            public static FormLink<IEncounterZoneGetter> DoomstoneApprenticeZone => Construct(0xd5674);
            public static FormLink<IEncounterZoneGetter> DoomstoneThiefZone => Construct(0xd5672);
            public static FormLink<IEncounterZoneGetter> BthalftZone => Construct(0xd5670);
            public static FormLink<IEncounterZoneGetter> AlchemistsShackZone => Construct(0xd566e);
            public static FormLink<IEncounterZoneGetter> LostProspectMineZone => Construct(0xd566c);
            public static FormLink<IEncounterZoneGetter> ShorsWatchtowerZone => Construct(0xd566a);
            public static FormLink<IEncounterZoneGetter> RkundZone => Construct(0xd5668);
            public static FormLink<IEncounterZoneGetter> RiftWatchtowerZone => Construct(0xd5666);
            public static FormLink<IEncounterZoneGetter> FrokisShackZone => Construct(0xd5664);
            public static FormLink<IEncounterZoneGetter> SeptimusSignusOutpostZone => Construct(0xd440e);
            public static FormLink<IEncounterZoneGetter> GiantsGroveZone => Construct(0xc33ae);
            public static FormLink<IEncounterZoneGetter> RebelsCairnZone => Construct(0xa828a);
            public static FormLink<IEncounterZoneGetter> OrotheimZone => Construct(0xa8286);
            public static FormLink<IEncounterZoneGetter> ShriekwindBastionZone => Construct(0xa0e3c);
            public static FormLink<IEncounterZoneGetter> SunderstoneGorgeZone => Construct(0x61ada);
            public static FormLink<IEncounterZoneGetter> IronbindBarrowZone => Construct(0x22f07);
            public static FormLink<IEncounterZoneGetter> BloodletThroneZone => Construct(0x16f87);
            public static FormLink<IEncounterZoneGetter> SkyboundWatchZone => Construct(0x4b677);
            public static FormLink<IEncounterZoneGetter> FalkreathWatchtowerZone => Construct(0x478dd);
            public static FormLink<IEncounterZoneGetter> PeaksShadeTowerZone => Construct(0x47884);
            public static FormLink<IEncounterZoneGetter> RoadsideRuinsZone => Construct(0x4787f);
            public static FormLink<IEncounterZoneGetter> BannermistZone => Construct(0x4786a);
            public static FormLink<IEncounterZoneGetter> KnifepointRidgeZone => Construct(0x8e1b8);
            public static FormLink<IEncounterZoneGetter> ThalmorEmbassyZone => Construct(0x27f6f);
            public static FormLink<IEncounterZoneGetter> KatariahZone => Construct(0xbbb46);
            public static FormLink<IEncounterZoneGetter> GuldunRockZone => Construct(0xb8aa2);
            public static FormLink<IEncounterZoneGetter> NarzulburZone => Construct(0xa385a);
            public static FormLink<IEncounterZoneGetter> BilegulchMineZone => Construct(0xa3859);
            public static FormLink<IEncounterZoneGetter> LargashburZone => Construct(0xa3858);
            public static FormLink<IEncounterZoneGetter> CrackedTuskKeepZone => Construct(0xa3857);
            public static FormLink<IEncounterZoneGetter> DushnikhYalZone => Construct(0xa3856);
            public static FormLink<IEncounterZoneGetter> BlizzardRestZone => Construct(0xa3855);
            public static FormLink<IEncounterZoneGetter> RiftenRatwayZone => Construct(0x9fbb9);
            public static FormLink<IEncounterZoneGetter> DawnstarSanctuaryZone => Construct(0x919a0);
            public static FormLink<IEncounterZoneGetter> DaintySloadZone => Construct(0x7b919);
            public static FormLink<IEncounterZoneGetter> MorKhazgurZone => Construct(0x6e2f1);
            public static FormLink<IEncounterZoneGetter> ShroudHearthBarrowZone => Construct(0x6ccc7);
            public static FormLink<IEncounterZoneGetter> BronzeWaterCaveZone => Construct(0x46bbc);
            public static FormLink<IEncounterZoneGetter> SkybornAltarZone => Construct(0x30ab1);
            public static FormLink<IEncounterZoneGetter> EastEmpireWarehouseZone => Construct(0x5fba6);
            public static FormLink<IEncounterZoneGetter> BrinewaterGrottoZone => Construct(0x5f429);
            public static FormLink<IEncounterZoneGetter> HaemarsShameZone => Construct(0x52541);
            public static FormLink<IEncounterZoneGetter> NightingaleHallZone => Construct(0x47d27);
            public static FormLink<IEncounterZoneGetter> KarthspireRedoubtZone => Construct(0x3ec94);
            public static FormLink<IEncounterZoneGetter> FallowstoneCaveZone => Construct(0x3ec93);
            public static FormLink<IEncounterZoneGetter> SouthfringeSanctumZone => Construct(0x3ec92);
            public static FormLink<IEncounterZoneGetter> YsgramorsTombZone => Construct(0x3ec91);
            public static FormLink<IEncounterZoneGetter> YngvildZone => Construct(0x3ec90);
            public static FormLink<IEncounterZoneGetter> YngolBarrowZone => Construct(0x3ec8f);
            public static FormLink<IEncounterZoneGetter> WolfskullCaveZone => Construct(0x3ec8e);
            public static FormLink<IEncounterZoneGetter> WitchmistGroveZone => Construct(0x3ec8d);
            public static FormLink<IEncounterZoneGetter> WhiteRiverWatchZone => Construct(0x3ec8b);
            public static FormLink<IEncounterZoneGetter> WhistlingMineZone => Construct(0x3ec8a);
            public static FormLink<IEncounterZoneGetter> SerpentsBluffRedoubtZone => Construct(0x3ec89);
            public static FormLink<IEncounterZoneGetter> VolunruudZone => Construct(0x3ec88);
            public static FormLink<IEncounterZoneGetter> VolskyggeZone => Construct(0x3ec87);
            public static FormLink<IEncounterZoneGetter> ValthumeZone => Construct(0x3ec86);
            public static FormLink<IEncounterZoneGetter> ValtheimKeepZone => Construct(0x3ec85);
            public static FormLink<IEncounterZoneGetter> UtteringHillsCampZone => Construct(0x3ec84);
            public static FormLink<IEncounterZoneGetter> UstengravZone => Construct(0x3ec83);
            public static FormLink<IEncounterZoneGetter> TumbleArchPassZone => Construct(0x3ec82);
            public static FormLink<IEncounterZoneGetter> TrevasWatchZone => Construct(0x3ec81);
            public static FormLink<IEncounterZoneGetter> TolvaldsCaveZone => Construct(0x3ec80);
            public static FormLink<IEncounterZoneGetter> ThroatoftheWorldZone => Construct(0x3ec7f);
            public static FormLink<IEncounterZoneGetter> TalkingStoneCampZone => Construct(0x3ec7e);
            public static FormLink<IEncounterZoneGetter> NightcallerTempleZone => Construct(0x3ec7d);
            public static FormLink<IEncounterZoneGetter> FrostmereCryptZone => Construct(0x3ec7c);
            public static FormLink<IEncounterZoneGetter> StonehillBluffZone => Construct(0x3ec7b);
            public static FormLink<IEncounterZoneGetter> StillbornCaveZone => Construct(0x3ec7a);
            public static FormLink<IEncounterZoneGetter> SteepfallBurrowZone => Construct(0x3ec79);
            public static FormLink<IEncounterZoneGetter> SovngardeZone => Construct(0x3ec76);
            public static FormLink<IEncounterZoneGetter> SoljundsSinkholeZone => Construct(0x3ec75);
            public static FormLink<IEncounterZoneGetter> SnowVeilSanctumZone => Construct(0x3ec74);
            public static FormLink<IEncounterZoneGetter> SnaplegCaveZone => Construct(0x3ec73);
            public static FormLink<IEncounterZoneGetter> SleepingTreeCampZone => Construct(0x3ec72);
            public static FormLink<IEncounterZoneGetter> SkuldafnZone => Construct(0x3ec71);
            public static FormLink<IEncounterZoneGetter> SilverdriftLairZone => Construct(0x3ec70);
            public static FormLink<IEncounterZoneGetter> SilentMoonsCampZone => Construct(0x3ec6f);
            public static FormLink<IEncounterZoneGetter> SightlessPitZone => Construct(0x3ec6e);
            public static FormLink<IEncounterZoneGetter> ShroudedGroveZone => Construct(0x3ec6d);
            public static FormLink<IEncounterZoneGetter> OrphansTearZone => Construct(0x3ec6c);
            public static FormLink<IEncounterZoneGetter> WinterWarZone => Construct(0x3ec6b);
            public static FormLink<IEncounterZoneGetter> PrideofTelVosZone => Construct(0x3ec6a);
            public static FormLink<IEncounterZoneGetter> PilgrimsTrenchZone => Construct(0x3ec69);
            public static FormLink<IEncounterZoneGetter> HelasFollyZone => Construct(0x3ec68);
            public static FormLink<IEncounterZoneGetter> BrinehammerZone => Construct(0x3ec67);
            public static FormLink<IEncounterZoneGetter> IcerunnerZone => Construct(0x3ec66);
            public static FormLink<IEncounterZoneGetter> ShimmermistCaveZone => Construct(0x3ec65);
            public static FormLink<IEncounterZoneGetter> ShadowgreenCavernZone => Construct(0x3ec64);
            public static FormLink<IEncounterZoneGetter> RobbersGorgeZone => Construct(0x3ec63);
            public static FormLink<IEncounterZoneGetter> SecundasShelfZone => Construct(0x3ec62);
            public static FormLink<IEncounterZoneGetter> SaarthalZone => Construct(0x3ec61);
            public static FormLink<IEncounterZoneGetter> RiverwatchZone => Construct(0x3ec5f);
            public static FormLink<IEncounterZoneGetter> RimerockBurrowZone => Construct(0x3ec5e);
            public static FormLink<IEncounterZoneGetter> RedRoadPassZone => Construct(0x3ec5d);
            public static FormLink<IEncounterZoneGetter> RedoransRetreatZone => Construct(0x3ec5c);
            public static FormLink<IEncounterZoneGetter> ReachwaterRockZone => Construct(0x3ec5b);
            public static FormLink<IEncounterZoneGetter> ReachcliffCaveZone => Construct(0x3ec5a);
            public static FormLink<IEncounterZoneGetter> RavenscarHollowZone => Construct(0x3ec59);
            public static FormLink<IEncounterZoneGetter> RannveigsFastZone => Construct(0x3ec58);
            public static FormLink<IEncounterZoneGetter> RagnvaldZone => Construct(0x3ec57);
            public static FormLink<IEncounterZoneGetter> PurewaterRunZone => Construct(0x3ec55);
            public static FormLink<IEncounterZoneGetter> PotemasCatacombsZone => Construct(0x3ec54);
            public static FormLink<IEncounterZoneGetter> PinewatchZone => Construct(0x3ec52);
            public static FormLink<IEncounterZoneGetter> PinepeakCavernZone => Construct(0x3ec51);
            public static FormLink<IEncounterZoneGetter> PinemoonCaveZone => Construct(0x3ec50);
            public static FormLink<IEncounterZoneGetter> NorthwatchKeepZone => Construct(0x3ec4f);
            public static FormLink<IEncounterZoneGetter> NilheimZone => Construct(0x3ec4e);
            public static FormLink<IEncounterZoneGetter> NchuandZelZone => Construct(0x3ec4d);
            public static FormLink<IEncounterZoneGetter> MzulftZone => Construct(0x3ec4c);
            public static FormLink<IEncounterZoneGetter> MountAnthorZone => Construct(0x3ec4b);
            public static FormLink<IEncounterZoneGetter> MossMotherCavernZone => Construct(0x3ec4a);
            public static FormLink<IEncounterZoneGetter> MzinchaleftZone => Construct(0x3ec49);
            public static FormLink<IEncounterZoneGetter> MorvunskarZone => Construct(0x3ec48);
            public static FormLink<IEncounterZoneGetter> MistwatchZone => Construct(0x3ec47);
            public static FormLink<IEncounterZoneGetter> LostValleyRedoubtZone => Construct(0x3ec46);
            public static FormLink<IEncounterZoneGetter> LostKnifeHideoutZone => Construct(0x3ec45);
            public static FormLink<IEncounterZoneGetter> LostEchoCaveZone => Construct(0x3ec44);
            public static FormLink<IEncounterZoneGetter> LabyrinthianZone => Construct(0x3ec42);
            public static FormLink<IEncounterZoneGetter> LiarsRetreatZone => Construct(0x3ec41);
            public static FormLink<IEncounterZoneGetter> KorvanjundZone => Construct(0x3ec40);
            public static FormLink<IEncounterZoneGetter> KilkreathRuinsZone => Construct(0x3ec3f);
            public static FormLink<IEncounterZoneGetter> IrkngthandZone => Construct(0x3ec3e);
            public static FormLink<IEncounterZoneGetter> GreenspringHollowZone => Construct(0x3ec3d);
            public static FormLink<IEncounterZoneGetter> IlinaltasDeepZone => Construct(0x3ec3c);
            public static FormLink<IEncounterZoneGetter> HonningbrewMeaderyZone => Construct(0x3ec3b);
            public static FormLink<IEncounterZoneGetter> HoneystrandCaveZone => Construct(0x3ec39);
            public static FormLink<IEncounterZoneGetter> HobsFallCaveZone => Construct(0x3ec38);
            public static FormLink<IEncounterZoneGetter> BrittleshinPassZone => Construct(0x3ec37);
            public static FormLink<IEncounterZoneGetter> HillgrundsTombZone => Construct(0x3ec36);
            public static FormLink<IEncounterZoneGetter> HighHrothgarZone => Construct(0x3ec35);
            public static FormLink<IEncounterZoneGetter> HighGateRuinsZone => Construct(0x3ec34);
            public static FormLink<IEncounterZoneGetter> HarmugstahlZone => Construct(0x3ec33);
            public static FormLink<IEncounterZoneGetter> HaltedStreamCampZone => Construct(0x3ec32);
            public static FormLink<IEncounterZoneGetter> HalldirsCairnZone => Construct(0x3ec31);
            public static FormLink<IEncounterZoneGetter> HagsEndZone => Construct(0x3ec30);
            public static FormLink<IEncounterZoneGetter> HagRockRedoubtZone => Construct(0x3ec2f);
            public static FormLink<IEncounterZoneGetter> GoldunRockZone => Construct(0x3ec2e);
            public static FormLink<IEncounterZoneGetter> GreywaterGrottoZone => Construct(0x3ec2d);
            public static FormLink<IEncounterZoneGetter> GraywinterWatchZone => Construct(0x3ec2c);
            public static FormLink<IEncounterZoneGetter> GoldenglowFarmZone => Construct(0x3ec2b);
            public static FormLink<IEncounterZoneGetter> GloomreachZone => Construct(0x3ec2a);
            public static FormLink<IEncounterZoneGetter> GloomboundMineZone => Construct(0x3ec29);
            public static FormLink<IEncounterZoneGetter> GlenmorilCovenZone => Construct(0x3ec28);
            public static FormLink<IEncounterZoneGetter> MovarthsLairZone => Construct(0x3ec27);
            public static FormLink<IEncounterZoneGetter> GeirmundsHallZone => Construct(0x3ec26);
            public static FormLink<IEncounterZoneGetter> GallowsRockZone => Construct(0x3ec25);
            public static FormLink<IEncounterZoneGetter> FrostflowLighthouseZone => Construct(0x3ec24);
            public static FormLink<IEncounterZoneGetter> FortSungardZone => Construct(0x3ec23);
            public static FormLink<IEncounterZoneGetter> FortSnowhawkZone => Construct(0x3ec22);
            public static FormLink<IEncounterZoneGetter> FortNeugradZone => Construct(0x3ec21);
            public static FormLink<IEncounterZoneGetter> FortKastavZone => Construct(0x3ec20);
            public static FormLink<IEncounterZoneGetter> FortHraggstadZone => Construct(0x3ec1f);
            public static FormLink<IEncounterZoneGetter> FortGreenwallZone => Construct(0x3ec1e);
            public static FormLink<IEncounterZoneGetter> FortFellhammerZone => Construct(0x3ec1d);
            public static FormLink<IEncounterZoneGetter> FortDunstadZone => Construct(0x3ec1c);
            public static FormLink<IEncounterZoneGetter> FortGreymoorZone => Construct(0x3ec1b);
            public static FormLink<IEncounterZoneGetter> FortAmolZone => Construct(0x3ec1a);
            public static FormLink<IEncounterZoneGetter> ForsakenCaveZone => Construct(0x3ec19);
            public static FormLink<IEncounterZoneGetter> ForelhostZone => Construct(0x3ec18);
            public static FormLink<IEncounterZoneGetter> FolgunthurZone => Construct(0x3ec17);
            public static FormLink<IEncounterZoneGetter> RockjointIslandZone => Construct(0x3ec16);
            public static FormLink<IEncounterZoneGetter> FellglowKeepZone => Construct(0x3ec15);
            public static FormLink<IEncounterZoneGetter> FaldarsToothZone => Construct(0x3ec14);
            public static FormLink<IEncounterZoneGetter> EvergreenGroveZone => Construct(0x3ec13);
            public static FormLink<IEncounterZoneGetter> EldergleamSanctuaryZone => Construct(0x3ec12);
            public static FormLink<IEncounterZoneGetter> DustmansCairnZone => Construct(0x3ec11);
            public static FormLink<IEncounterZoneGetter> DuskglowCreviceZone => Construct(0x3ec10);
            public static FormLink<IEncounterZoneGetter> DruadachRedoubtZone => Construct(0x3ec0f);
            public static FormLink<IEncounterZoneGetter> RedEagleRedoubtZone => Construct(0x3ec0e);
            public static FormLink<IEncounterZoneGetter> DriftshadeSanctuaryZone => Construct(0x3ec0d);
            public static FormLink<IEncounterZoneGetter> DeepwoodRedoubtZone => Construct(0x3ec0c);
            public static FormLink<IEncounterZoneGetter> DeadMensRespiteZone => Construct(0x3ec0b);
            public static FormLink<IEncounterZoneGetter> DeadCroneRockZone => Construct(0x3ec0a);
            public static FormLink<IEncounterZoneGetter> DarkwaterCavernZone => Construct(0x3ec09);
            public static FormLink<IEncounterZoneGetter> DarkshadeCopseZone => Construct(0x3ec08);
            public static FormLink<IEncounterZoneGetter> DarklightTowerZone => Construct(0x3ec07);
            public static FormLink<IEncounterZoneGetter> DarkBrotherhoodSancZone => Construct(0x3ec06);
            public static FormLink<IEncounterZoneGetter> CrystaldriftCaveZone => Construct(0x3ec05);
            public static FormLink<IEncounterZoneGetter> CronvangrHallZone => Construct(0x3ec04);
            public static FormLink<IEncounterZoneGetter> CragwallowSlopeZone => Construct(0x3ec03);
            public static FormLink<IEncounterZoneGetter> CragslaneCavernZone => Construct(0x3ec02);
            public static FormLink<IEncounterZoneGetter> CradlecrushRockZone => Construct(0x3ec01);
            public static FormLink<IEncounterZoneGetter> ClearspringTarnZone => Construct(0x3ec00);
            public static FormLink<IEncounterZoneGetter> ClearpinePondZone => Construct(0x3ebff);
            public static FormLink<IEncounterZoneGetter> CidhnaMineZone => Construct(0x3ebfd);
            public static FormLink<IEncounterZoneGetter> BrokenOarGrottoZone => Construct(0x3ebfc);
            public static FormLink<IEncounterZoneGetter> ChillwindDepthsZone => Construct(0x3ebfb);
            public static FormLink<IEncounterZoneGetter> BthardamzZone => Construct(0x3ebfa);
            public static FormLink<IEncounterZoneGetter> BrucasLeapRedoubtZone => Construct(0x3ebf9);
            public static FormLink<IEncounterZoneGetter> BroodCavernZone => Construct(0x3ebf8);
            public static FormLink<IEncounterZoneGetter> BrokenTowerRedoubtZone => Construct(0x3ebf7);
            public static FormLink<IEncounterZoneGetter> BrokenHelmHollowZone => Construct(0x3ebf6);
            public static FormLink<IEncounterZoneGetter> BrokenFangCaveZone => Construct(0x3ebf5);
            public static FormLink<IEncounterZoneGetter> BluePalaceWingZone => Construct(0x3ebf4);
            public static FormLink<IEncounterZoneGetter> TwilightSepulcherZone => Construct(0x3ebf3);
            public static FormLink<IEncounterZoneGetter> BloatedMansGrottoZone => Construct(0x3ebf2);
            public static FormLink<IEncounterZoneGetter> BlindCliffCaveZone => Construct(0x3ebf1);
            public static FormLink<IEncounterZoneGetter> BleakwindBluffZone => Construct(0x3ebf0);
            public static FormLink<IEncounterZoneGetter> BleakwindBasinZone => Construct(0x3ebef);
            public static FormLink<IEncounterZoneGetter> BleakcoastCaveZone => Construct(0x3ebee);
            public static FormLink<IEncounterZoneGetter> BlackreachZone => Construct(0x3ebed);
            public static FormLink<IEncounterZoneGetter> AzurasStarZone => Construct(0x3ebec);
            public static FormLink<IEncounterZoneGetter> AvanchnzelZone => Construct(0x3ebeb);
            public static FormLink<IEncounterZoneGetter> AutumnshadeClearingZone => Construct(0x3ebea);
            public static FormLink<IEncounterZoneGetter> AnsilvundZone => Construct(0x3ebe9);
            public static FormLink<IEncounterZoneGetter> AngarvundeZone => Construct(0x3ebe8);
            public static FormLink<IEncounterZoneGetter> SwindlersDenZone => Construct(0x3ebe7);
            public static FormLink<IEncounterZoneGetter> AlftandZone => Construct(0x3ebe6);
            public static FormLink<IEncounterZoneGetter> BleakFallsBarrowZone => Construct(0x38ab1);
            public static FormLink<IEncounterZoneGetter> RiverwoodZone => Construct(0x18a45);
            public static FormLink<IEncounterZoneGetter> NoZoneZone => Construct(0x1e);
        }
    }
}
