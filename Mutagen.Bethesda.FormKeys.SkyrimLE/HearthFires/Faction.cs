using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class Faction
        {
            private static FormLink<IFactionGetter> Construct(uint id) => new FormLink<IFactionGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFactionGetter> BYOHHouseBanditAttackFriendFaction => Construct(0x8c9);
            public static FormLink<IFactionGetter> BYOHCarriageDriverFaction => Construct(0x7890);
            public static FormLink<IFactionGetter> BYOHHousecarlPaleCrimeFaction => Construct(0x5213);
            public static FormLink<IFactionGetter> BYOHHousecarlHjaalmarchCrimeFaction => Construct(0x5212);
            public static FormLink<IFactionGetter> BYOHHousecarlFalkreathCrimeFaction => Construct(0x5211);
            public static FormLink<IFactionGetter> BYOHServicesWindhelmSofie => Construct(0x403a);
            public static FormLink<IFactionGetter> BYOHRelationshipPotentialPetFaction => Construct(0x192d6);
            public static FormLink<IFactionGetter> BYOHHouseBardFaction => Construct(0x18de1);
            public static FormLink<IFactionGetter> BYOHHousePaleServicesSpouseSpells => Construct(0x18481);
            public static FormLink<IFactionGetter> BYOHHousePaleServicesSpouseMiscVendor => Construct(0x18480);
            public static FormLink<IFactionGetter> BYOHHousePaleServicesSpouseInnkeeper => Construct(0x1847f);
            public static FormLink<IFactionGetter> BYOHHousePaleServicesSpouseBlacksmith => Construct(0x1847e);
            public static FormLink<IFactionGetter> BYOHHousePaleServicesSpouseApothecary => Construct(0x1847d);
            public static FormLink<IFactionGetter> BYOHHouseHjaalmarchServicesSpouseSpells => Construct(0x1847c);
            public static FormLink<IFactionGetter> BYOHHouseHjaalmarchServicesSpouseMiscVendor => Construct(0x1847b);
            public static FormLink<IFactionGetter> BYOHHouseHjaalmarchServicesSpouseInnkeeper => Construct(0x1847a);
            public static FormLink<IFactionGetter> BYOHHouseHjaalmarchServicesSpouseBlacksmith => Construct(0x18479);
            public static FormLink<IFactionGetter> BYOHHouseHjaalmarchServicesSpouseApothecary => Construct(0x18478);
            public static FormLink<IFactionGetter> BYOHHouseFalkreathServicesSpouseSpells => Construct(0x18477);
            public static FormLink<IFactionGetter> BYOHHouseFalkreathServicesSpouseMiscVendor => Construct(0x18476);
            public static FormLink<IFactionGetter> BYOHHouseFalkreathServicesSpouseInnkeeper => Construct(0x18475);
            public static FormLink<IFactionGetter> BYOHHouseFalkreathServicesSpouseApothecary => Construct(0x18474);
            public static FormLink<IFactionGetter> BYOHHouseFalkreathServicesSpouseBlacksmith => Construct(0x18473);
            public static FormLink<IFactionGetter> BYOHRelationshipAdoptionChildOwnedFaction => Construct(0x183a8);
            public static FormLink<IFactionGetter> BYOHLumberVendorFaction => Construct(0x9ba5);
            public static FormLink<IFactionGetter> BYOHHousecarlFaction => Construct(0x8460);
            public static FormLink<IFactionGetter> BYOHRelationshipAdoptionFaction => Construct(0x42b0);
            public static FormLink<IFactionGetter> BYOHRelationshipAdoptableFaction => Construct(0x4290);
            public static FormLink<IFactionGetter> BYOHUrchin_SofieJobFaction => Construct(0x4033);
            public static FormLink<IFactionGetter> BYOHUrchin_AlesanJobFaction => Construct(0x3f62);
            public static FormLink<IFactionGetter> BYOHDisallowGamesFaction => Construct(0x3f61);
            public static FormLink<IFactionGetter> BYOHUrchin_LuciaJobFaction => Construct(0x3f5d);
            public static FormLink<IFactionGetter> BYOHUrchin_BlaiseJobFaction => Construct(0x3f55);
            public static FormLink<IFactionGetter> BYOHHouse2Faction => Construct(0x375f);
            public static FormLink<IFactionGetter> BYOHHouse3Faction => Construct(0x375e);
            public static FormLink<IFactionGetter> BYOHHouseStewardNoForcegreet => Construct(0x3178);
            public static FormLink<IFactionGetter> BYOHHouse1Faction => Construct(0x3131);
            public static FormLink<IFactionGetter> BYOHHouseStewardFaction => Construct(0x308e);
        }
    }
}
