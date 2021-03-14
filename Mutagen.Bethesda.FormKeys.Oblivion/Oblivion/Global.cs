using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Oblivion
    {
        public static class Global
        {
            private static FormLink<IGlobalGetter> Construct(uint id) => new FormLink<IGlobalGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IGlobalGetter> SEKnightSpawnTime => Construct(0x8d9da);
            public static FormLink<IGlobalGetter> SESwordDuskfangEquip => Construct(0x7d7ef);
            public static FormLink<IGlobalGetter> SESwordDawnfangEquip => Construct(0x7d7ee);
            public static FormLink<IGlobalGetter> SESwordDuskfangKills => Construct(0x7d434);
            public static FormLink<IGlobalGetter> SESwordDawnfangKills => Construct(0x7d433);
            public static FormLink<IGlobalGetter> SE07GreenmoteFlag => Construct(0x6a7e7);
            public static FormLink<IGlobalGetter> SE07GreenmoteEffect => Construct(0x55fe9);
            public static FormLink<IGlobalGetter> SEGatekeeperDebugNoLeash => Construct(0x5572d);
            public static FormLink<IGlobalGetter> SECrimeGold => Construct(0x459cb);
            public static FormLink<IGlobalGetter> SE09CagedVictims => Construct(0x44c3b);
            public static FormLink<IGlobalGetter> SE30PiecesMaceAxe => Construct(0x1f3ea);
            public static FormLink<IGlobalGetter> SEFringeOrdered => Construct(0x1b037);
            public static FormLink<IGlobalGetter> SEObeliskMaxHearts => Construct(0x1a802);
            public static FormLink<IGlobalGetter> SEGatekeeperLeashTimer => Construct(0x19d50);
            public static FormLink<IGlobalGetter> SEGatekeeperPerimeterLength => Construct(0x19d4f);
            public static FormLink<IGlobalGetter> SE30PiecesSword => Construct(0x16c89);
            public static FormLink<IGlobalGetter> SE30PiecesHammerClaymore => Construct(0x16c88);
            public static FormLink<IGlobalGetter> SE30PiecesBow => Construct(0x16c87);
            public static FormLink<IGlobalGetter> SE30PiecesArrows => Construct(0x16c86);
            public static FormLink<IGlobalGetter> SE30PiecesShield => Construct(0x16bf6);
            public static FormLink<IGlobalGetter> SE30PiecesHelmet => Construct(0x16bf5);
            public static FormLink<IGlobalGetter> SE30PiecesGreaves => Construct(0x16bf4);
            public static FormLink<IGlobalGetter> SE30PiecesGauntlets => Construct(0x16bf3);
            public static FormLink<IGlobalGetter> SE30PiecesCuirass => Construct(0x16bf2);
            public static FormLink<IGlobalGetter> SE30PiecesBoots => Construct(0x16bf1);
            public static FormLink<IGlobalGetter> SEKnightRespawnDelay => Construct(0x13548);
            public static FormLink<IGlobalGetter> SEOrderPriestResurrectTimer => Construct(0x134d2);
            public static FormLink<IGlobalGetter> SEKnightRespawn => Construct(0x134d1);
            public static FormLink<IGlobalGetter> HasGrace => Construct(0x14d24);
            public static FormLink<IGlobalGetter> UmbacanoCount => Construct(0xc509b);
            public static FormLink<IGlobalGetter> HighwaymanGotMoney => Construct(0xc506f);
            public static FormLink<IGlobalGetter> MQEndDayWeek => Construct(0xaf06d);
            public static FormLink<IGlobalGetter> FameJulianos => Construct(0x177212);
            public static FormLink<IGlobalGetter> FameKynareth => Construct(0x177211);
            public static FormLink<IGlobalGetter> FameZenithar => Construct(0x177210);
            public static FormLink<IGlobalGetter> FameTiberSeptim => Construct(0x17720f);
            public static FormLink<IGlobalGetter> FameAkatosh => Construct(0x17720e);
            public static FormLink<IGlobalGetter> FameDibella => Construct(0x17720d);
            public static FormLink<IGlobalGetter> FameArkay => Construct(0x17720c);
            public static FormLink<IGlobalGetter> FameStendarr => Construct(0x17720b);
            public static FormLink<IGlobalGetter> FameMara => Construct(0x177200);
            public static FormLink<IGlobalGetter> RentNewlandsLodge => Construct(0xbb9d8);
            public static FormLink<IGlobalGetter> RentRoxeyInn => Construct(0xbb9d7);
            public static FormLink<IGlobalGetter> RentImperialBridge => Construct(0xbb9d6);
            public static FormLink<IGlobalGetter> RentFaregyl => Construct(0xbb9d4);
            public static FormLink<IGlobalGetter> RentBrinaCross => Construct(0xbb9d2);
            public static FormLink<IGlobalGetter> RentWawnetInn => Construct(0xbb9ce);
            public static FormLink<IGlobalGetter> RentGottshawInn => Construct(0xb985d);
            public static FormLink<IGlobalGetter> RentICBloatedFloat => Construct(0xb985b);
            public static FormLink<IGlobalGetter> RentICAllSaintsInn => Construct(0xb9859);
            public static FormLink<IGlobalGetter> RentICTiberSeptimHotel => Construct(0xb9857);
            public static FormLink<IGlobalGetter> RentICLuthorBroad => Construct(0xb9855);
            public static FormLink<IGlobalGetter> RentICKingandQueen => Construct(0xb9853);
            public static FormLink<IGlobalGetter> RentICMerchantsInn => Construct(0xb9851);
            public static FormLink<IGlobalGetter> RentLeyawiinThreeSisters => Construct(0xb6c26);
            public static FormLink<IGlobalGetter> RentLeyawiinFiveClaws => Construct(0xb6c25);
            public static FormLink<IGlobalGetter> RentCheydinhalBridgeInn => Construct(0xb6c21);
            public static FormLink<IGlobalGetter> RentCheydinhalNewlandsLodge => Construct(0xb6c20);
            public static FormLink<IGlobalGetter> RentBrumaJerallView => Construct(0xb129c);
            public static FormLink<IGlobalGetter> RentBrumaOlavs => Construct(0xb129b);
            public static FormLink<IGlobalGetter> RentBravilSilverhome => Construct(0xb1259);
            public static FormLink<IGlobalGetter> RentBravilLonelySuitor => Construct(0xb1257);
            public static FormLink<IGlobalGetter> RentAnvilCountsArms => Construct(0xb1251);
            public static FormLink<IGlobalGetter> RentBorderWatchInn => Construct(0xb1247);
            public static FormLink<IGlobalGetter> RentDrunkenDragon => Construct(0x27dee);
            public static FormLink<IGlobalGetter> RentIllOmen => Construct(0x279f1);
            public static FormLink<IGlobalGetter> MS22DealGold => Construct(0xa495f);
            public static FormLink<IGlobalGetter> MS22RewardGold => Construct(0xa495e);
            public static FormLink<IGlobalGetter> RentHackdirtMoslinsInn => Construct(0x9ea92);
            public static FormLink<IGlobalGetter> TGPayoffCrimeGold => Construct(0x982e5);
            public static FormLink<IGlobalGetter> RentAnvilFlowingBowl => Construct(0x98126);
            public static FormLink<IGlobalGetter> MQ05RavenPace => Construct(0x976fe);
            public static FormLink<IGlobalGetter> CrimeForceJail => Construct(0x4cad5);
            public static FormLink<IGlobalGetter> RentSkingradWestWealdInn => Construct(0x3b357);
            public static FormLink<IGlobalGetter> RentSkingradTwoSistersLodge => Construct(0x3b354);
            public static FormLink<IGlobalGetter> RentChorrolGreyMare => Construct(0x3ab5b);
            public static FormLink<IGlobalGetter> RentChorrolOakandCrosier => Construct(0x3ab55);
            public static FormLink<IGlobalGetter> OblivionCrisis => Construct(0x32d45);
            public static FormLink<IGlobalGetter> TGPriceSteal => Construct(0x1e85f);
            public static FormLink<IGlobalGetter> TGPriceAttack => Construct(0x1e85e);
            public static FormLink<IGlobalGetter> KvatchDestroyed => Construct(0x1e6a4);
            public static FormLink<IGlobalGetter> TGPricePerKill => Construct(0x1cf20);
            public static FormLink<IGlobalGetter> MS05InProgress => Construct(0x2cf32);
            public static FormLink<IGlobalGetter> EmfridBittneld => Construct(0x2a38e);
            public static FormLink<IGlobalGetter> PCVampire => Construct(0x24161);
            public static FormLink<IGlobalGetter> MS38LastContact => Construct(0x223e3);
            public static FormLink<IGlobalGetter> Fame => Construct(0x223c5);
            public static FormLink<IGlobalGetter> Sleep => Construct(0x223b1);
            public static FormLink<IGlobalGetter> GameYear => Construct(0x35);
            public static FormLink<IGlobalGetter> GameMonth => Construct(0x36);
            public static FormLink<IGlobalGetter> GameDay => Construct(0x37);
            public static FormLink<IGlobalGetter> GameHour => Construct(0x38);
            public static FormLink<IGlobalGetter> GameDaysPassed => Construct(0x39);
            public static FormLink<IGlobalGetter> TimeScale => Construct(0x3a);
        }
    }
}
