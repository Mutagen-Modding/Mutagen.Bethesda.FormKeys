using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Skyrim
    {
        public static class Key
        {
            private static FormLink<IKeyGetter> Construct(uint id) => new FormLink<IKeyGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IKeyGetter> RiftenConfiscatedGoodsChestKey => Construct(0x10e7e6);
            public static FormLink<IKeyGetter> MzinchaleftKey01 => Construct(0x10beff);
            public static FormLink<IKeyGetter> MorthalGuardhouseKey => Construct(0x108ba5);
            public static FormLink<IKeyGetter> MorthalFalionsHouseKeyCOPY0000 => Construct(0x108ba4);
            public static FormLink<IKeyGetter> DA07ShrineKey => Construct(0x107d97);
            public static FormLink<IKeyGetter> IvarsteadKlimmeksHouseKey => Construct(0x106e24);
            public static FormLink<IKeyGetter> IvarsteadFellstarFarmKey => Construct(0x106e23);
            public static FormLink<IKeyGetter> ShorsStoneOdfelsHouseKey => Construct(0x106e22);
            public static FormLink<IKeyGetter> ShorsStoneFilnjarsHouseKey => Construct(0x106e21);
            public static FormLink<IKeyGetter> MorthalJailKey => Construct(0x10480c);
            public static FormLink<IKeyGetter> TGTQ02RedWaveSafeKey => Construct(0x102eba);
            public static FormLink<IKeyGetter> CidhnaMineJailKey => Construct(0x100fa6);
            public static FormLink<IKeyGetter> TG04EECKey => Construct(0x10080e);
            public static FormLink<IKeyGetter> RiftenEvidenceChestKey => Construct(0xff787);
            public static FormLink<IKeyGetter> PelagiusFarmKey => Construct(0xfe2b3);
            public static FormLink<IKeyGetter> ChillfurrowFarmKey => Construct(0xfe2b2);
            public static FormLink<IKeyGetter> BattleBornFarmKey => Construct(0xfe2b1);
            public static FormLink<IKeyGetter> RiftenStablesKey => Construct(0xfdec1);
            public static FormLink<IKeyGetter> RiftenSnowShodHouseKey => Construct(0xfdec0);
            public static FormLink<IKeyGetter> RiftenFisheryKey => Construct(0xfdebf);
            public static FormLink<IKeyGetter> RiftenScorchedHammerKey => Construct(0xfdebe);
            public static FormLink<IKeyGetter> RiftenMariseAravelsHouseKey => Construct(0xfdebd);
            public static FormLink<IKeyGetter> RiftenRomlynsHouseKey => Construct(0xfdebc);
            public static FormLink<IKeyGetter> RiftenValindorsHouseKey => Construct(0xfdebb);
            public static FormLink<IKeyGetter> RiftenElgrimsElixirsKey => Construct(0xfdeba);
            public static FormLink<IKeyGetter> RiftenBlackBriarMeaderyKey => Construct(0xfdeb9);
            public static FormLink<IKeyGetter> RiftenBlackBriarManorKeySpecial => Construct(0xfdeb8);
            public static FormLink<IKeyGetter> RiftenBlackBriarManorKey => Construct(0xfdeb7);
            public static FormLink<IKeyGetter> RiftenBolliHouseKey => Construct(0xfdeb6);
            public static FormLink<IKeyGetter> RiftenAerinsHouseKey => Construct(0xfdeb5);
            public static FormLink<IKeyGetter> RiftenHaelgasBunkhouseKey => Construct(0xfdeb4);
            public static FormLink<IKeyGetter> RiftenPawnedPrawnKey => Construct(0xfdeb3);
            public static FormLink<IKeyGetter> RiftenBeeandBarbKey => Construct(0xfdeb2);
            public static FormLink<IKeyGetter> WindhelmJailKey => Construct(0xfb90d);
            public static FormLink<IKeyGetter> FalkreathJailKey => Construct(0xfb90c);
            public static FormLink<IKeyGetter> dunMiddenInvestigatorKey => Construct(0xf9924);
            public static FormLink<IKeyGetter> TGTributeChestKey => Construct(0xf84cb);
            public static FormLink<IKeyGetter> TG07MercerDisplayCaseKey => Construct(0xf84a5);
            public static FormLink<IKeyGetter> dunTrevasWatchPrisonKey => Construct(0xf669b);
            public static FormLink<IKeyGetter> dunTreasMapDBKey => Construct(0xf4a1a);
            public static FormLink<IKeyGetter> DragonBridgeLumberCampKey => Construct(0xf49be);
            public static FormLink<IKeyGetter> dunRaldbtharKey => Construct(0xf232e);
            public static FormLink<IKeyGetter> ShorsStoneSylgjaKey => Construct(0xf18f9);
            public static FormLink<IKeyGetter> RiftenRomlynKey => Construct(0xf18f7);
            public static FormLink<IKeyGetter> MixwaterMillGilfreKey => Construct(0xf18ec);
            public static FormLink<IKeyGetter> dunBilegulchKey01 => Construct(0xef02f);
            public static FormLink<IKeyGetter> DB08BalagogTrapDoorKey => Construct(0xed02d);
            public static FormLink<IKeyGetter> HagRockRedoubtJailKey => Construct(0xe9918);
            public static FormLink<IKeyGetter> dunAbandonedPrisonKey => Construct(0xe94d4);
            public static FormLink<IKeyGetter> WindhelmBrunwulfsHouseKey => Construct(0xdd744);
            public static FormLink<IKeyGetter> dunFortSnowhawkRitualRoomKey => Construct(0xd8996);
            public static FormLink<IKeyGetter> TGTQ04NiranyesSafeKey => Construct(0xd7772);
            public static FormLink<IKeyGetter> FortNeugradLibraryKey => Construct(0xcc59c);
            public static FormLink<IKeyGetter> CollegeArchMageKey => Construct(0xc5140);
            public static FormLink<IKeyGetter> DawnstarWindpeakKey => Construct(0xbecde);
            public static FormLink<IKeyGetter> KolskeggrPavosHouseKey => Construct(0xbecd8);
            public static FormLink<IKeyGetter> MarkarthWarrensDegaineKey => Construct(0xbec39);
            public static FormLink<IKeyGetter> MarkarthStableHouseKey => Construct(0xbeb82);
            public static FormLink<IKeyGetter> MarkarthTempleDibellaKey => Construct(0xbd79c);
            public static FormLink<IKeyGetter> RiftenMadesiDisplayKey => Construct(0xb8f43);
            public static FormLink<IKeyGetter> RiftenMadesiStallKey => Construct(0xb8f42);
            public static FormLink<IKeyGetter> RiftenGrelkaStallKey => Construct(0xb8f35);
            public static FormLink<IKeyGetter> MS03BlackBriarLodgeStashKey => Construct(0xb862f);
            public static FormLink<IKeyGetter> MorthalJorgenLamiKey => Construct(0xb858a);
            public static FormLink<IKeyGetter> MQDelphineSecretDoorKey => Construct(0x990df);
            public static FormLink<IKeyGetter> MarkarthExcavationSiteKey => Construct(0x537f8);
            public static FormLink<IKeyGetter> MS03BlackBriarLodgeKey => Construct(0x2c474);
            public static FormLink<IKeyGetter> FFRiften20SarthisKey => Construct(0x85d57);
            public static FormLink<IKeyGetter> RiftenWarehouseKey => Construct(0x85d45);
            public static FormLink<IKeyGetter> MarkarthWarrensGarveyKey => Construct(0x65780);
            public static FormLink<IKeyGetter> DaintySloadFootlockerKey => Construct(0x5b614);
            public static FormLink<IKeyGetter> MarkarthJewelryCaseKey => Construct(0x4700d);
            public static FormLink<IKeyGetter> DA13OrchendorKey => Construct(0x3e141);
            public static FormLink<IKeyGetter> FFRiften04ChestKey => Construct(0x3c590);
            public static FormLink<IKeyGetter> FFRiften02ChestKey => Construct(0x3c514);
            public static FormLink<IKeyGetter> FFRiften08StrongboxKey => Construct(0xe82c3);
            public static FormLink<IKeyGetter> TG02GoldenglowSafeKey => Construct(0xe6dfe);
            public static FormLink<IKeyGetter> WindhelmCalixtosKey => Construct(0xe6c64);
            public static FormLink<IKeyGetter> RiftenNorthGateKey => Construct(0xe6705);
            public static FormLink<IKeyGetter> MQ201InterrogationExitKey => Construct(0xe3f98);
            public static FormLink<IKeyGetter> MS02MadanachKey => Construct(0xe17a8);
            public static FormLink<IKeyGetter> TGTQ02SabineKey => Construct(0xdc175);
            public static FormLink<IKeyGetter> dunPOITundraWerewolfKey => Construct(0xdb0e2);
            public static FormLink<IKeyGetter> WhiterunMainGateKey => Construct(0xd8f0c);
            public static FormLink<IKeyGetter> dunCragslaneKey02 => Construct(0xd81f9);
            public static FormLink<IKeyGetter> MS01WeylinKey => Construct(0xd66f9);
            public static FormLink<IKeyGetter> dunCragslaneKey01 => Construct(0xd509b);
            public static FormLink<IKeyGetter> MS01MargretKey => Construct(0xd3e6a);
            public static FormLink<IKeyGetter> dunHaltedStreamCampKey => Construct(0xd2947);
            public static FormLink<IKeyGetter> dunAlftandExitKey => Construct(0xd1843);
            public static FormLink<IKeyGetter> dunNorthwatchKey01 => Construct(0xca5eb);
            public static FormLink<IKeyGetter> DA16NightcallerKey => Construct(0xc6321);
            public static FormLink<IKeyGetter> dunKatariahKeyDoesntExist => Construct(0xc62a1);
            public static FormLink<IKeyGetter> SolitudeWinkingSkeeverKey => Construct(0xc1405);
            public static FormLink<IKeyGetter> SolitudeVittoriaVicisHouseKey => Construct(0xc1402);
            public static FormLink<IKeyGetter> SolitudeTempleoftheDivinesKey => Construct(0xc13ff);
            public static FormLink<IKeyGetter> SolitudeStyrrsHouseKey => Construct(0xc13fc);
            public static FormLink<IKeyGetter> SolitudeStablesKey => Construct(0xc13f9);
            public static FormLink<IKeyGetter> SolitudeSawmillKey => Construct(0xc13f6);
            public static FormLink<IKeyGetter> SolitudeRadiantRaimentsKey => Construct(0xc13f3);
            public static FormLink<IKeyGetter> SolitudeLighthouseKey => Construct(0xc13f0);
            public static FormLink<IKeyGetter> SolitudeJusticiarsHeadquartersKey => Construct(0xc13ed);
            public static FormLink<IKeyGetter> SolitudeJalasHouseKey => Construct(0xc13ea);
            public static FormLink<IKeyGetter> SolitudeFletcherKey => Construct(0xc13e7);
            public static FormLink<IKeyGetter> SolitudeEvetteSansHouseKey => Construct(0xc13e4);
            public static FormLink<IKeyGetter> SolitudeErikursHouseKey => Construct(0xc13e1);
            public static FormLink<IKeyGetter> SolitudeCemetaryKey => Construct(0xc13de);
            public static FormLink<IKeyGetter> SolitudeCastleDourTowerKey => Construct(0xc13db);
            public static FormLink<IKeyGetter> SolitudeCastleDourKey => Construct(0xc13d8);
            public static FormLink<IKeyGetter> SolitudeBrylingsHouseKey => Construct(0xc13d5);
            public static FormLink<IKeyGetter> SolitudeBluePalaceKey => Construct(0xc13d2);
            public static FormLink<IKeyGetter> SolitudeBlacksmithKey => Construct(0xc13cf);
            public static FormLink<IKeyGetter> SolitudeBitsAndPiecesKey => Construct(0xc13cc);
            public static FormLink<IKeyGetter> SolitudeBardsCollegeKey => Construct(0xc13c9);
            public static FormLink<IKeyGetter> SolitudeAngelinesAromaticsKey => Construct(0xc13c6);
            public static FormLink<IKeyGetter> SolitudeAddvarsHouseKey => Construct(0xc13c3);
            public static FormLink<IKeyGetter> HalfMoonMillKey => Construct(0xc13c0);
            public static FormLink<IKeyGetter> FalkreathLodsHouseKey => Construct(0xc13aa);
            public static FormLink<IKeyGetter> FalkreathJarlsLonghouseKey => Construct(0xc13a9);
            public static FormLink<IKeyGetter> FalkreathHosueofArkayKey => Construct(0xc13a8);
            public static FormLink<IKeyGetter> FalkreathGrayPineGoodsKey => Construct(0xc13a7);
            public static FormLink<IKeyGetter> FalkreathGraveConcoctionsKey => Construct(0xc13a6);
            public static FormLink<IKeyGetter> FalkreathDengeirsHallKey => Construct(0xc13a5);
            public static FormLink<IKeyGetter> FalkreathDeadMansDrinkKey => Construct(0xc139e);
            public static FormLink<IKeyGetter> FalkreathCorpselightFarmKey => Construct(0xc1395);
            public static FormLink<IKeyGetter> DunFaldarsToothCageKey => Construct(0xc007b);
            public static FormLink<IKeyGetter> BrandyMugFarmKey => Construct(0x9c876);
            public static FormLink<IKeyGetter> HlaaluFarmKey => Construct(0x9c875);
            public static FormLink<IKeyGetter> HollyfrostFarmKey => Construct(0x9c874);
            public static FormLink<IKeyGetter> WindhelmWhitePhialKey => Construct(0x9c872);
            public static FormLink<IKeyGetter> WindhelmStablesKey => Construct(0x9c870);
            public static FormLink<IKeyGetter> WindhelmSadrisShopKey => Construct(0x9c86f);
            public static FormLink<IKeyGetter> WindhelmNiranyesHouseKey => Construct(0x9c86e);
            public static FormLink<IKeyGetter> WindhelmClanShatterShieldHouseKey => Construct(0x9c86c);
            public static FormLink<IKeyGetter> WindhelmClanCruelSeaHouseKey => Construct(0x9c86a);
            public static FormLink<IKeyGetter> WindhelmClanShatterShieldOfficeKey => Construct(0x9c867);
            public static FormLink<IKeyGetter> WindhelmBlacksmithKey => Construct(0x9c865);
            public static FormLink<IKeyGetter> WindhelmBelynHlaaluHouseKey => Construct(0x9c864);
            public static FormLink<IKeyGetter> WindhelmAtheronResidenceKey => Construct(0x9c7da);
            public static FormLink<IKeyGetter> WindhelmArgonianAssemblageKey => Construct(0x9c79b);
            public static FormLink<IKeyGetter> WindhelmAretinoResidenceKey => Construct(0x9c795);
            public static FormLink<IKeyGetter> DarkwaterCrossingVernersHouseKey => Construct(0x9c6fd);
            public static FormLink<IKeyGetter> DarkwaterCrossingCrossinghouseKey => Construct(0x9c6d7);
            public static FormLink<IKeyGetter> TG02GoldenglowBasementKey => Construct(0x61aed);
            public static FormLink<IKeyGetter> dunBloodletThroneCageKey => Construct(0x5e4a8);
            public static FormLink<IKeyGetter> dunYngvildKey => Construct(0x835ca);
            public static FormLink<IKeyGetter> TG07MercerHouseKey => Construct(0x72b05);
            public static FormLink<IKeyGetter> TG03MeaderyKey03 => Construct(0x5cdc6);
            public static FormLink<IKeyGetter> TG03MeaderyKey02 => Construct(0x5cdbc);
            public static FormLink<IKeyGetter> RoriksteadFreeformMralkisChestKey => Construct(0x4ec50);
            public static FormLink<IKeyGetter> RiftenKeeravasKey => Construct(0x4e0b7);
            public static FormLink<IKeyGetter> DB02CaptiveShackleKey => Construct(0x2e3f9);
            public static FormLink<IKeyGetter> DB02AbandonedShackKey => Construct(0x2e3f8);
            public static FormLink<IKeyGetter> dunFortKastavKey => Construct(0xbed2d);
            public static FormLink<IKeyGetter> DunHillgrundsTombChestKey => Construct(0xbc6fe);
            public static FormLink<IKeyGetter> dunKatariahKey => Construct(0xbbb7f);
            public static FormLink<IKeyGetter> MQ101PrisonKey => Construct(0xb965d);
            public static FormLink<IKeyGetter> DragonBridgeLylvieveHouseKey => Construct(0xb8764);
            public static FormLink<IKeyGetter> DragonBridgeHorgeirsHouseKey => Construct(0xb8761);
            public static FormLink<IKeyGetter> DunIrkngthandKey02 => Construct(0xb7cbc);
            public static FormLink<IKeyGetter> DunIrkngthandKey01 => Construct(0xb7c00);
            public static FormLink<IKeyGetter> dunEmbershardKey => Construct(0xb6fe5);
            public static FormLink<IKeyGetter> TG02GoldenglowGateKey => Construct(0xb6439);
            public static FormLink<IKeyGetter> MQ101KeepDoorKey => Construct(0xb5178);
            public static FormLink<IKeyGetter> SolitudeBluePalaceServantsKey => Construct(0xb48fe);
            public static FormLink<IKeyGetter> dunFolgunthurKey => Construct(0xab6fe);
            public static FormLink<IKeyGetter> DunHillgrundsTombKey02 => Construct(0xa9f21);
            public static FormLink<IKeyGetter> SolitudeHouseKey => Construct(0xa7b37);
            public static FormLink<IKeyGetter> RiftenHoneysideKey => Construct(0xa7b36);
            public static FormLink<IKeyGetter> dunDeadCroneRockKey => Construct(0xa0d46);
            public static FormLink<IKeyGetter> BarleyDarkFarmHouseKey => Construct(0xa035e);
            public static FormLink<IKeyGetter> dunRedEagleKey => Construct(0x9fd51);
            public static FormLink<IKeyGetter> StonehillsArgisHouseKey => Construct(0x9e2a6);
            public static FormLink<IKeyGetter> StonehillsAleucsHouseKey => Construct(0x9e2a5);
            public static FormLink<IKeyGetter> StonehillsLonghouseKey => Construct(0x9e2a4);
            public static FormLink<IKeyGetter> StonehillsGestursHouseKey => Construct(0x9e2a3);
            public static FormLink<IKeyGetter> StonehillsSorlisHouseKey => Construct(0x9e2a2);
            public static FormLink<IKeyGetter> MorthalThaumaturgistsHutKey => Construct(0x9e29a);
            public static FormLink<IKeyGetter> MorthalThonnirsHouseKey => Construct(0x9e299);
            public static FormLink<IKeyGetter> MorthalFalionsHouseKey => Construct(0x9e298);
            public static FormLink<IKeyGetter> WinterholdRanmirsHouseKey => Construct(0x9e28f);
            public static FormLink<IKeyGetter> WinterholdKraldarsHouseKey => Construct(0x9e28e);
            public static FormLink<IKeyGetter> RoriksteadCowflopFarmKey => Construct(0x9e134);
            public static FormLink<IKeyGetter> RoriksteadLemkilsHouseKey => Construct(0x9e133);
            public static FormLink<IKeyGetter> RoriksteadRoriksManorKey => Construct(0x9e131);
            public static FormLink<IKeyGetter> DawnstarFrukisHouseKey => Construct(0x9da42);
            public static FormLink<IKeyGetter> DawnstarJailKey => Construct(0x9da41);
            public static FormLink<IKeyGetter> DawnstarRustleifsHouseKey => Construct(0x9da39);
            public static FormLink<IKeyGetter> DawnstarLeigelfsKey => Construct(0x9da38);
            public static FormLink<IKeyGetter> DawnstarIrgnirsKey => Construct(0x9da37);
            public static FormLink<IKeyGetter> DawnstarBrinasKey => Construct(0x9da32);
            public static FormLink<IKeyGetter> DawnstarMortarAndPestleKey => Construct(0x9da31);
            public static FormLink<IKeyGetter> DawnstarBeitildsHouseKey => Construct(0x9da2d);
            public static FormLink<IKeyGetter> dunHagsEndKey => Construct(0x9d392);
            public static FormLink<IKeyGetter> dunDustmansCairnKey => Construct(0x9aeff);
            public static FormLink<IKeyGetter> KatlasFarmKey => Construct(0x98b7d);
            public static FormLink<IKeyGetter> SolitudeSawmillHjorunnRoomKey => Construct(0x98b7c);
            public static FormLink<IKeyGetter> SolitudeSawmillKharagRoomKey => Construct(0x98b7b);
            public static FormLink<IKeyGetter> IrontreeMillHouseKey => Construct(0x98b7a);
            public static FormLink<IKeyGetter> WhiterunSeverioPelagiasHouseKey => Construct(0x96573);
            public static FormLink<IKeyGetter> DA07SilussHouseKey => Construct(0x960f0);
            public static FormLink<IKeyGetter> MarkarthMuseumKey => Construct(0x94392);
            public static FormLink<IKeyGetter> MarkarthVlindrelHallKey => Construct(0x94391);
            public static FormLink<IKeyGetter> DunAnsilvundKey02 => Construct(0x93bf4);
            public static FormLink<IKeyGetter> WhiterunWintersandManorKey => Construct(0x93b14);
            public static FormLink<IKeyGetter> WhiterunYsoldasHouseKey => Construct(0x93b13);
            public static FormLink<IKeyGetter> WhiterunWarmaidensKey => Construct(0x93b12);
            public static FormLink<IKeyGetter> WhiterunUthgerdsHouseKey => Construct(0x93b11);
            public static FormLink<IKeyGetter> WhiterunUlfbethsKey => Construct(0x93b10);
            public static FormLink<IKeyGetter> WhiterunStablesKey => Construct(0x93b0f);
            public static FormLink<IKeyGetter> WhiterunOlavasKey => Construct(0x93b0e);
            public static FormLink<IKeyGetter> WhiterunMaidenLoomManorKey => Construct(0x93b0d);
            public static FormLink<IKeyGetter> WhiterunHouseBattleBornKey => Construct(0x93b0c);
            public static FormLink<IKeyGetter> WhiterunHouseGrayManeKey => Construct(0x93b0b);
            public static FormLink<IKeyGetter> WhiterunHeimskrsHouseKey => Construct(0x93b0a);
            public static FormLink<IKeyGetter> WhiterunCarlottaValentiasKey => Construct(0x93b09);
            public static FormLink<IKeyGetter> WhiterunBreezehomeKey => Construct(0x93b08);
            public static FormLink<IKeyGetter> WhiterunBelethorsGoodsKey => Construct(0x93b07);
            public static FormLink<IKeyGetter> WhiterunAmrensHouseKey => Construct(0x93b06);
            public static FormLink<IKeyGetter> WhiterunArcadiasCauldronKey => Construct(0x93b05);
            public static FormLink<IKeyGetter> dunFortSnowhawkJailKey => Construct(0x91f0e);
            public static FormLink<IKeyGetter> dunMistwatchKey => Construct(0x918c6);
            public static FormLink<IKeyGetter> dunHarmugstahlKey => Construct(0x8e5d1);
            public static FormLink<IKeyGetter> FortNeugradJailKey => Construct(0x8b232);
            public static FormLink<IKeyGetter> MarkarthHalloftheDeadKey => Construct(0x7d94c);
            public static FormLink<IKeyGetter> dunAngarvundeKey => Construct(0x8715f);
            public static FormLink<IKeyGetter> BrokenTowerRedoubtPrisonerKey => Construct(0x8683b);
            public static FormLink<IKeyGetter> dunSolitudeJailKey => Construct(0x7e019);
            public static FormLink<IKeyGetter> FortSungardJailKey => Construct(0x798c1);
            public static FormLink<IKeyGetter> dunRobbersGorgeCoveKey => Construct(0x78dc2);
            public static FormLink<IKeyGetter> dunPinewatchTreasKey => Construct(0x786ba);
            public static FormLink<IKeyGetter> MzulftKeyTelekinesisPuzzle => Construct(0x401f4);
            public static FormLink<IKeyGetter> dunDarklightTowerClosetKey => Construct(0x2e104);
            public static FormLink<IKeyGetter> WhiterunJorrvaskrCeremonyRoomKey => Construct(0x734c5);
            public static FormLink<IKeyGetter> dunFellglowCallersKey => Construct(0x71c08);
            public static FormLink<IKeyGetter> dunFellglowFrontKey => Construct(0x71c07);
            public static FormLink<IKeyGetter> MorthalAlvasHouseKey => Construct(0x70e80);
            public static FormLink<IKeyGetter> dunShroudHearthKey => Construct(0x6f88c);
            public static FormLink<IKeyGetter> AvanchnzelKey01 => Construct(0x6d0ad);
            public static FormLink<IKeyGetter> MS06PotemaCatacombsKey => Construct(0x6b705);
            public static FormLink<IKeyGetter> OldHroldanInnKey => Construct(0x695c7);
            public static FormLink<IKeyGetter> GularzKhazgurKeepKey => Construct(0x6649a);
            public static FormLink<IKeyGetter> CrackedTuskKeepVaultKey => Construct(0x66485);
            public static FormLink<IKeyGetter> MarkarthDibellaInnerSanctumKey => Construct(0x656ee);
            public static FormLink<IKeyGetter> MarkarthKeepKey => Construct(0x656ec);
            public static FormLink<IKeyGetter> MarkarthOverseersHouseKey => Construct(0x656e8);
            public static FormLink<IKeyGetter> MarkarthWarrensCosnachRoomKey => Construct(0x656e5);
            public static FormLink<IKeyGetter> MarkarthWarrensEltrysRoomKey => Construct(0x656e3);
            public static FormLink<IKeyGetter> MarkarthWarrensOmluagRoomKey => Construct(0x656e1);
            public static FormLink<IKeyGetter> MarkarthHagsCureKey => Construct(0x65678);
            public static FormLink<IKeyGetter> MarkarthNeposHouseKey => Construct(0x65676);
            public static FormLink<IKeyGetter> MarkarthOgmundsHouseKey => Construct(0x65674);
            public static FormLink<IKeyGetter> MarkarthAbandonedHouseKey => Construct(0x65673);
            public static FormLink<IKeyGetter> MarkarthEndonsHouseKey => Construct(0x65672);
            public static FormLink<IKeyGetter> MarkarthSilverBloodInnKey => Construct(0x65670);
            public static FormLink<IKeyGetter> MarkarthArnleifandSonsKey => Construct(0x6566e);
            public static FormLink<IKeyGetter> MarkarthTreasuryHouseKey => Construct(0x6566c);
            public static FormLink<IKeyGetter> DushnikhYalBurguksLonghouseKey => Construct(0x6566a);
            public static FormLink<IKeyGetter> MorKhazgurLaraksLonghouseKey => Construct(0x65669);
            public static FormLink<IKeyGetter> LeftHandDaighreKey => Construct(0x65667);
            public static FormLink<IKeyGetter> LeftHandMinersBarracksKey => Construct(0x65665);
            public static FormLink<IKeyGetter> LeftHandMineSkaggisHouseKey => Construct(0x65663);
            public static FormLink<IKeyGetter> SalviusFarmhouseKey => Construct(0x65661);
            public static FormLink<IKeyGetter> KarthwastenMinersBarracksKey => Construct(0x65660);
            public static FormLink<IKeyGetter> KarthwastenEnmonsHouseKey => Construct(0x6565e);
            public static FormLink<IKeyGetter> KarthwastenHallKey => Construct(0x6565c);
            public static FormLink<IKeyGetter> KolskeggrMinePavosHouseKey => Construct(0x6565b);
            public static FormLink<IKeyGetter> SoljundsSinkholeMinerHouseKey => Construct(0x6565a);
            public static FormLink<IKeyGetter> HeljarchenTraillusHouseKey => Construct(0x65659);
            public static FormLink<IKeyGetter> HeljarchenNightgateInnKey => Construct(0x65658);
            public static FormLink<IKeyGetter> HeljarchenJensFarmHouseKey => Construct(0x65656);
            public static FormLink<IKeyGetter> HeljarchenHeigenFarmHouseKey => Construct(0x65655);
            public static FormLink<IKeyGetter> HeljarchenFathendasHouseKey => Construct(0x65653);
            public static FormLink<IKeyGetter> LoreiusFarmhouseKey => Construct(0x65651);
            public static FormLink<IKeyGetter> AngasMillCommonHouseKey => Construct(0x65650);
            public static FormLink<IKeyGetter> AngasMillAeriHouseKey => Construct(0x6564e);
            public static FormLink<IKeyGetter> dunPotemaSewerKey => Construct(0x648b6);
            public static FormLink<IKeyGetter> MS01OmluagKey => Construct(0x63b5d);
            public static FormLink<IKeyGetter> dunDeadMensTreasuryKey => Construct(0x62893);
            public static FormLink<IKeyGetter> DA10BasementKey => Construct(0x2bae2);
            public static FormLink<IKeyGetter> dunRiftenJailKey => Construct(0x612b8);
            public static FormLink<IKeyGetter> MzulftKeyStart => Construct(0x5dcb9);
            public static FormLink<IKeyGetter> WhiterunJailKey => Construct(0x5aec4);
            public static FormLink<IKeyGetter> MzulftKey01 => Construct(0x57b66);
            public static FormLink<IKeyGetter> WindhelmViolaGiordanosKey => Construct(0x56b90);
            public static FormLink<IKeyGetter> WindhelmEastEmpireCompanyKey => Construct(0x56af7);
            public static FormLink<IKeyGetter> MarkarthLaboratoryKey => Construct(0x55901);
            public static FormLink<IKeyGetter> JaphetsFollyKey01 => Construct(0x2e5fb);
            public static FormLink<IKeyGetter> MS02BorkulKey => Construct(0x1ab5d);
            public static FormLink<IKeyGetter> dunRannCageKey => Construct(0x51988);
            public static FormLink<IKeyGetter> karthspireRedoubtJailKey => Construct(0x506d2);
            public static FormLink<IKeyGetter> TG04BrinewaterGrottoKey => Construct(0x50341);
            public static FormLink<IKeyGetter> dunValthumeSecPassageKey => Construct(0x4d6e2);
            public static FormLink<IKeyGetter> DunSyncopeSancKey => Construct(0x4c475);
            public static FormLink<IKeyGetter> dunValthumeTrapKey => Construct(0x4b6d2);
            public static FormLink<IKeyGetter> dunDarklightTowerKey => Construct(0x41965);
            public static FormLink<IKeyGetter> DA08WhisperingDoorKey => Construct(0x28d8b);
            public static FormLink<IKeyGetter> MS09NorthwatchKeepKey => Construct(0x27f7a);
            public static FormLink<IKeyGetter> DunFrostflowRoofKey => Construct(0x48141);
            public static FormLink<IKeyGetter> DunFrostflowAbyssKey => Construct(0x4811d);
            public static FormLink<IKeyGetter> dunPinewatchKey => Construct(0x44e78);
            public static FormLink<IKeyGetter> FortFellhammerMinesKey => Construct(0x446d8);
            public static FormLink<IKeyGetter> DunFaldarsToothKey => Construct(0x43a71);
            public static FormLink<IKeyGetter> dunGeirmundsHallKey => Construct(0x3e694);
            public static FormLink<IKeyGetter> DunAnsilvundKey => Construct(0x3e4f2);
            public static FormLink<IKeyGetter> dunRavenscarKey => Construct(0x3d26b);
            public static FormLink<IKeyGetter> dunBrokenOarShipKey => Construct(0x38ce2);
            public static FormLink<IKeyGetter> sightlessPitShamanKey => Construct(0x3718e);
            public static FormLink<IKeyGetter> dunDeepwoodRedoubtKey => Construct(0x28440);
            public static FormLink<IKeyGetter> CWFortBlackmoorPrisonKey => Construct(0x16ff1);
            public static FormLink<IKeyGetter> MS06PotemaThrallKey => Construct(0x1f147);
            public static FormLink<IKeyGetter> DunLiarsRetreatKey => Construct(0x1e30d);
            public static FormLink<IKeyGetter> DarkwaterKey => Construct(0x3bb13);
            public static FormLink<IKeyGetter> dunHalldirsKey => Construct(0x3ad48);
            public static FormLink<IKeyGetter> DunForelhostEntranceKey => Construct(0x3a694);
            public static FormLink<IKeyGetter> DunForelhostBossKey => Construct(0x3a691);
            public static FormLink<IKeyGetter> MQ201InterrogationChamberKey => Construct(0x39f29);
            public static FormLink<IKeyGetter> RiverwoodFaendalsHouseKey => Construct(0x36a42);
            public static FormLink<IKeyGetter> RiverwoodSvensHouseKey => Construct(0x36a41);
            public static FormLink<IKeyGetter> RiverwoodGerdursHouseKey => Construct(0x36a40);
            public static FormLink<IKeyGetter> RiverwoodTraderKey => Construct(0x36a3f);
            public static FormLink<IKeyGetter> RiverwoodSleepingGiantInnKey => Construct(0x36a3e);
            public static FormLink<IKeyGetter> RiverwoodAlvorHouseKey => Construct(0x36a3d);
            public static FormLink<IKeyGetter> LostKnifeCageKey => Construct(0x34c91);
            public static FormLink<IKeyGetter> dunMistwatchJailKey => Construct(0x30b37);
            public static FormLink<IKeyGetter> LabyrinthianCryptKey => Construct(0x22896);
            public static FormLink<IKeyGetter> DunHillgrundsTombKey => Construct(0x19cff);
            public static FormLink<IKeyGetter> TG03MeaderyKey => Construct(0x2baa7);
            public static FormLink<IKeyGetter> DA15PelagiusKey => Construct(0x2ac70);
            public static FormLink<IKeyGetter> DA07JorgensKey => Construct(0x26bc8);
            public static FormLink<IKeyGetter> DunForelhostWaterKey => Construct(0x241b4);
            public static FormLink<IKeyGetter> MS07Key => Construct(0x23a70);
            public static FormLink<IKeyGetter> MS11HjerimKey => Construct(0x21679);
            public static FormLink<IKeyGetter> SR01Key => Construct(0x1c250);
        }
    }
}
