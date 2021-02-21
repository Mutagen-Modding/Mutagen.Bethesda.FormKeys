using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class AItem
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            private static FormLink<IAItemGetter> Construct(uint id) => new FormLink<IAItemGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAItemGetter> LairVileCrimsonScarRaiment05 => Construct(0xbe66);
            public static FormLink<IAItemGetter> LairVileCrimsonScarRaiment10 => Construct(0xbe67);
            public static FormLink<IAItemGetter> LairVileCrimsonScarRaiment15 => Construct(0xbe68);
            public static FormLink<IAItemGetter> LairVileCrimsonScarRaiment25 => Construct(0xbe6a);
            public static FormLink<IAItemGetter> LairVileCrimsonScarRaiment20 => Construct(0xc35e);
            public static FormLink<IAItemGetter> LairVileCrimsonScarRaiment01 => Construct(0xbe65);
            public static FormLink<IAItemGetter> DeepscornCellReceipt => Construct(0x46b3);
            public static FormLink<IAItemGetter> DeepscornVenomgrowthReceipt => Construct(0x4b9c);
            public static FormLink<IAItemGetter> LairVileVampireManifesto => Construct(0x5093);
            public static FormLink<IAItemGetter> LairVileOpusculusLamae => Construct(0x5095);
            public static FormLink<IAItemGetter> DeepscornHollowJournal => Construct(0x46ac);
            public static FormLink<IAItemGetter> DeepscornBedroomReceipt => Construct(0x46ae);
            public static FormLink<IAItemGetter> DeepscornDiningReceipt => Construct(0x46af);
            public static FormLink<IAItemGetter> DeepscornStudyReceipt => Construct(0x46b0);
            public static FormLink<IAItemGetter> DeepscornStorageReceipt => Construct(0x46b1);
            public static FormLink<IAItemGetter> DeepscornHollowNote => Construct(0xdc0a);
            public static FormLink<IAItemGetter> DeepscornMinionReceipt => Construct(0x46b2);
            public static FormLink<IAItemGetter> LairVileManacles => Construct(0x31aa);
            public static FormLink<IAItemGetter> LairVileSalts => Construct(0x1372);
            public static FormLink<IAItemGetter> LairVileChokeberry => Construct(0x9bfe);
            public static FormLink<IAItemGetter> LairVileCustomSithisFaceLight => Construct(0x26c0);
            public static FormLink<IAItemGetter> LairVileSithisDaylight => Construct(0x26c1);
            public static FormLink<IAItemGetter> LairVileCustomFireLight128 => Construct(0x169c);
            public static FormLink<IAItemGetter> LairVileCustomFireLight320 => Construct(0x169e);
            public static FormLink<IAItemGetter> LairVileCustomSithisFontLight => Construct(0x3190);
            public static FormLink<IAItemGetter> LairVileCustomLightRed256 => Construct(0x1693);
            public static FormLink<IAItemGetter> LairVileCustomLamp320 => Construct(0x1694);
            public static FormLink<IAItemGetter> LairVilePaleTorch => Construct(0x3791);
            public static FormLink<IAItemGetter> LairVileCustomSconce188 => Construct(0x1695);
            public static FormLink<IAItemGetter> LairVileCustomSithisHeartLight => Construct(0x26be);
            public static FormLink<IAItemGetter> IchorofSithis => Construct(0x4b9b);
            public static FormLink<IAItemGetter> LairVileEviscerator05 => Construct(0xb97e);
            public static FormLink<IAItemGetter> LairVileEviscerator20 => Construct(0x60bb);
            public static FormLink<IAItemGetter> LairVileEviscerator25 => Construct(0x60bc);
            public static FormLink<IAItemGetter> LairVileEviscerator30 => Construct(0x60bd);
            public static FormLink<IAItemGetter> LairVileEviscerator01 => Construct(0x60b6);
            public static FormLink<IAItemGetter> LairVileEviscerator10 => Construct(0x60b9);
            public static FormLink<IAItemGetter> LairVileEviscerator15 => Construct(0x60ba);
            public static FormLink<IAItemGetter> LairVileCellKey => Construct(0x1380);
            public static FormLink<IAItemGetter> DeepscornHollowKey => Construct(0x46ad);
            public static FormLink<IAItemGetter> LairVileRaimentLvl100 => Construct(0xc35d);
            public static FormLink<IAItemGetter> LairVileRewardsGoldLeveledList => Construct(0x7e63);
            public static FormLink<IAItemGetter> LairVileModifiedLL2LootJewelryMagic100 => Construct(0x14ce3);
            public static FormLink<IAItemGetter> LairVileEvisceratorLvl100 => Construct(0x60c2);
        }
    }
}
