using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class FormList
        {
            private static FormLink<IFormListGetter> Construct(uint id) => new FormLink<IFormListGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IFormListGetter> BYOHHouse3RoomsStartedFlags => Construct(0xc02);
            public static FormLink<IFormListGetter> BYOHHouse2RoomsStartedFlags => Construct(0xc01);
            public static FormLink<IFormListGetter> BYOHHouse1RoomsStartedFlags => Construct(0xbd7);
            public static FormLink<IFormListGetter> BYOHHouseBuildingExtraList => Construct(0x96b);
            public static FormLink<IFormListGetter> BYOHHouseFishList6 => Construct(0x8f8);
            public static FormLink<IFormListGetter> BYOHHouseFishList5 => Construct(0x8f7);
            public static FormLink<IFormListGetter> BYOHHouseFishList4 => Construct(0x8f6);
            public static FormLink<IFormListGetter> BYOHHouseFishList3 => Construct(0x8f5);
            public static FormLink<IFormListGetter> BYOHHouseFishList2 => Construct(0x8f4);
            public static FormLink<IFormListGetter> BYOHHouseFishList1 => Construct(0x8f3);
            public static FormLink<IFormListGetter> BYOHHouseFishContainerList => Construct(0x8ef);
            public static FormLink<IFormListGetter> BYOHHouseBanditAttack2CombatList => Construct(0x8ab);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoption_PetDogsList => Construct(0x192d7);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoption_PetAllowedRacesList => Construct(0x192d2);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoption_NameCallingWinnersList => Construct(0x18c72);
            public static FormLink<IFormListGetter> VoicesMarriageAdoptionRough => Construct(0x17fde);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoption_CrittersFemale => Construct(0x13816);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoption_CrittersMale => Construct(0x13815);
            public static FormLink<IFormListGetter> BYOHHouse3RoomsDoneFlags => Construct(0x10c05);
            public static FormLink<IFormListGetter> BYOHHouseBuildingAdditionLayoutTOKENList => Construct(0xf9bc);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom01RemodelList => Construct(0xcd5c);
            public static FormLink<IFormListGetter> BYOHHouseRoomCostList => Construct(0xb0fd);
            public static FormLink<IFormListGetter> BYOHHouse2RoomsDoneFlags => Construct(0xb0fc);
            public static FormLink<IFormListGetter> BYOHHouse1RoomsDoneFlags => Construct(0xb0d2);
            public static FormLink<IFormListGetter> BYOHHouseBuildingTrophyPlaceList => Construct(0xa339);
            public static FormLink<IFormListGetter> BYOHHouseBuildingTrophyMasterList => Construct(0xa31d);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoomWorkbenches => Construct(0xa319);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_Junk => Construct(0x9ee8);
            public static FormLink<IFormListGetter> flPlanterPlantableItem => Construct(0x8247);
            public static FormLink<IFormListGetter> flPlanterPlantedFlora => Construct(0x8246);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionPlayerGiftChildFemale => Construct(0x7b75);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionPlayerGiftChildMale => Construct(0x7b74);
            public static FormLink<IFormListGetter> BYOHHouseBuildingExteriorMasterList => Construct(0x71db);
            public static FormLink<IFormListGetter> BYOHVoicesNonUnique => Construct(0x5e57);
            public static FormLink<IFormListGetter> VoicesMarriageAdoptionOrc => Construct(0x4d8e);
            public static FormLink<IFormListGetter> VoicesMarriageAdoptionNord => Construct(0x4d8d);
            public static FormLink<IFormListGetter> VoicesMarriageAdoptionNeutral => Construct(0x4d8c);
            public static FormLink<IFormListGetter> VoicesMarriageAdoptionArrogant => Construct(0x4d8b);
            public static FormLink<IFormListGetter> VoicesMarriageAdoptionAll => Construct(0x4d8a);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom12MasterList => Construct(0x3af8);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom11MasterList => Construct(0x3af7);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom10MasterList => Construct(0x3af6);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom09MasterList => Construct(0x3af5);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom08MasterList => Construct(0x3af4);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom07MasterList => Construct(0x3af3);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom06MasterList => Construct(0x3af2);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom05MasterList => Construct(0x3af1);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom04MasterList => Construct(0x3af0);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom03MasterList => Construct(0x3aef);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_1000 => Construct(0x2f61);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_0500 => Construct(0x2f60);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_0250 => Construct(0x2f5f);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_0100 => Construct(0x2f5e);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_0050 => Construct(0x2f5d);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_0000 => Construct(0x2f5c);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_0025 => Construct(0x2f5b);
            public static FormLink<IFormListGetter> BYOHRelationshipAdoptionGifts_Poor => Construct(0x2f5a);
            public static FormLink<IFormListGetter> BYOHVoicesAdoptedChildren => Construct(0x42a7);
            public static FormLink<IFormListGetter> BYOHUrchin_SofieVendorList => Construct(0x4037);
            public static FormLink<IFormListGetter> BYOHHouseBuildingAdditionLayoutList => Construct(0x320b);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom01BMasterList => Construct(0x312f);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom01ARemoveList => Construct(0x30fa);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom02MasterList => Construct(0x30eb);
            public static FormLink<IFormListGetter> BYOHHouseBuildingRoom01AMasterList => Construct(0x30ea);
            public static FormLink<IFormListGetter> BYOHHouseBuildingMasterList => Construct(0x305f);
        }
    }
}
