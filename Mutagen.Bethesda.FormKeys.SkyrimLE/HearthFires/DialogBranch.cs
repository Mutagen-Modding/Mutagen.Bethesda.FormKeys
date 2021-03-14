using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class HearthFires
    {
        public static class DialogBranch
        {
            private static FormLink<IDialogBranchGetter> Construct(uint id) => new FormLink<IDialogBranchGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogBranchGetter> BYOHHouseBanditAttack2Bandit => Construct(0x8b2);
            public static FormLink<IDialogBranchGetter> BYOHHouseBanditAttack2Spouse => Construct(0x8b1);
            public static FormLink<IDialogBranchGetter> BYOHHouseBardIntro => Construct(0x19637);
            public static FormLink<IDialogBranchGetter> BYOHHouseBardRehire => Construct(0x1962f);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_RehirePetsTopic => Construct(0x192d5);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGNameCallingBranch => Construct(0x192d1);
            public static FormLink<IDialogBranchGetter> BYOHHouseBardSwitchInstrumentBranch => Construct(0x18de5);
            public static FormLink<IDialogBranchGetter> BYOHHouseBardDismiss => Construct(0x18de4);
            public static FormLink<IDialogBranchGetter> BYOHHouseBardBranch => Construct(0x18de3);
            public static FormLink<IDialogBranchGetter> BYOHHousePalePurchase => Construct(0x17719);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGChestIntroBranch => Construct(0x14124);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGInitialBranch => Construct(0x13f01);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGCritterBranch => Construct(0x13f00);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_NeverSpeakToYouAgainBranch => Construct(0x13eff);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGPetBranch => Construct(0x13efe);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGPetBailout => Construct(0x13efd);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGChestBranch => Construct(0x13efc);
            public static FormLink<IDialogBranchGetter> BYOHHouseSkeeverInfestationBranch => Construct(0x10a4d);
            public static FormLink<IDialogBranchGetter> BYOHHouseStewardWhereToBuySupplies => Construct(0xcd5b);
            public static FormLink<IDialogBranchGetter> BYOHHouseHjaalmarchPurchase => Construct(0xbe43);
            public static FormLink<IDialogBranchGetter> BYOHHouseStewardFurnishBranch => Construct(0xb0bb);
            public static FormLink<IDialogBranchGetter> BYOHHouseStewardBuyMaterials => Construct(0x9568);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptionCWSiegeHandler_ChildBranch => Construct(0x8935);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_AskSpouseReKids => Construct(0x8789);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGSuggestGame => Construct(0x7f40);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGAskForGift => Construct(0x7b78);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_OrderBedPostMidnight => Construct(0x7b77);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_GiveGiftBranch => Construct(0x7b76);
            public static FormLink<IDialogBranchGetter> BYOHHouseCarriageBranch => Construct(0x788f);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGGiveGiftBranch => Construct(0x2f58);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_FGAllowanceBranch => Construct(0x2f57);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_MovingBranch => Construct(0x42ae);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_OrderOutside => Construct(0x42a5);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_GameRequest => Construct(0x42a1);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_ForcegreetsBranch => Construct(0x4297);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptable_IntroduceAdoptability => Construct(0x428e);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptable_OfferAdoption => Construct(0x428d);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_JustAdoptedBranch => Construct(0x428b);
            public static FormLink<IDialogBranchGetter> RelationshipAdoptableOrphanage_OrphanIntros => Construct(0x4285);
            public static FormLink<IDialogBranchGetter> RelationshipAdoptableOrphanage_MatronBranch => Construct(0x4283);
            public static FormLink<IDialogBranchGetter> RelationshipAdoptableOrphanage_RetryFail => Construct(0x4282);
            public static FormLink<IDialogBranchGetter> RelationshipAdoptableOrphanage_RetrySucceed => Construct(0x4281);
            public static FormLink<IDialogBranchGetter> RelationshipAdoptableOrphanage_Succeed100 => Construct(0x4280);
            public static FormLink<IDialogBranchGetter> RelationshipAdoptableOrphanage_Succeed255 => Construct(0x427f);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptable_TellMeAbout => Construct(0x4275);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableBlocking => Construct(0x4103);
            public static FormLink<IDialogBranchGetter> RelationshipAdoptableOrphanage_Succeed200 => Construct(0x4101);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableUrchins_SofieOfferServices => Construct(0x4032);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableUrchins_SofieForcegreet => Construct(0x4028);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableUrchins_SofieAskStory => Construct(0x4027);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableUrchins_AlesanWhoAreYou => Construct(0x401d);
            public static FormLink<IDialogBranchGetter> RelationshipMarriageCeremonyPostLoveInterestBlockingWithAdoption => Construct(0x3f71);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableUrchins_AlesanWhatDoYouDo => Construct(0x3f63);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableUrchins_LuciaName => Construct(0x3f5c);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableUrchins_BlaiseHello => Construct(0x3f42);
            public static FormLink<IDialogBranchGetter> BYOHRelationshipAdoptableUrchins_SorryForWhat => Construct(0x3f41);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_OrderHome => Construct(0x3f3e);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_OrderBedPreMidnight => Construct(0x3f3d);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_OrderChoresTopic => Construct(0x3f3c);
            public static FormLink<IDialogBranchGetter> RelationshipAdoption_OrderWhining => Construct(0x3f3b);
            public static FormLink<IDialogBranchGetter> WIChangeLocation08ForceGreetAdoption => Construct(0x3f0b);
            public static FormLink<IDialogBranchGetter> BYOHHouseStewardUpgradeBranch => Construct(0x3134);
            public static FormLink<IDialogBranchGetter> BYOHHouseHireSteward => Construct(0x3130);
            public static FormLink<IDialogBranchGetter> BYOHHouseStewardOfferBranch => Construct(0x3091);
            public static FormLink<IDialogBranchGetter> BYOHHouseFalkreathPurchase => Construct(0x307a);
            public static FormLink<IDialogBranchGetter> BYOHHouseBuildingBuyLumber => Construct(0x3077);
        }
    }
}
