using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class HearthFires
    {
        public static class DialogResponses
        {
            private static FormLink<IDialogResponsesGetter> Construct(uint id) => new FormLink<IDialogResponsesGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogResponsesGetter> RelationshipMarriageFIN_MoveNord => Construct(0x2f4c);
            public static FormLink<IDialogResponsesGetter> RelationshipMarriageFIN_MoveOrc => Construct(0x2f4d);
            public static FormLink<IDialogResponsesGetter> RelationshipMarriageFIN_MoveNeutral => Construct(0x2f47);
            public static FormLink<IDialogResponsesGetter> RelationshipMarriageFIN_MoveArgonian => Construct(0x2f4e);
            public static FormLink<IDialogResponsesGetter> RelationshipMarriageFIN_MoveDrunk => Construct(0x2f4f);
            public static FormLink<IDialogResponsesGetter> RelationshipMarriageFIN_MoveArrogant => Construct(0x2f50);
            public static FormLink<IDialogResponsesGetter> RelationshipMarriageFIN_MoveRough => Construct(0x2f51);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBanditAttack2NoMoney => Construct(0x88c);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBanditAttackSpouseRescue => Construct(0x973);
            public static FormLink<IDialogResponsesGetter> BYOHHouseSkeeverInfestationSpouseHello => Construct(0x897);
            public static FormLink<IDialogResponsesGetter> BYOHHousePaleAvailableForPurchase => Construct(0xc37);
            public static FormLink<IDialogResponsesGetter> BYOHHouseHjaalmarchLandAvailable => Construct(0xc51);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_YesMom => Construct(0x3ed2);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_ThanksMom => Construct(0x3ed3);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_YesDad => Construct(0x3ed4);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_Greet2 => Construct(0x3ecb);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_Greet3 => Construct(0x3ecc);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_Greet4 => Construct(0x3ecd);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_Moving_Boy => Construct(0x3ece);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_MovingGirl => Construct(0x3ecf);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_NameCallingIntro1 => Construct(0x192ca);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_NameCallingIntro2 => Construct(0x192cb);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_NameCallingIntro3 => Construct(0x192cc);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_NameCallingIntro4 => Construct(0x192cd);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_StopTeasing => Construct(0x3ed1);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_ThanksDad => Construct(0x3ed5);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_OrdersStayOut => Construct(0x3ed6);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_OrdersNotDark => Construct(0x3ed7);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_OrdersRefuse => Construct(0x3ed8);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_OrdersYea => Construct(0x3ed9);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PickGame => Construct(0x3eda);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PickGameSure => Construct(0x3edb);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_ThanksSmall => Construct(0x3edc);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_ThanksMed => Construct(0x3edd);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_ThanksWow => Construct(0x3ede);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_GamesDarkOut => Construct(0x3edf);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG1 => Construct(0x3e7d);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG10 => Construct(0x3e86);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG9 => Construct(0x3e85);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG8 => Construct(0x3e84);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG7 => Construct(0x3e83);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG6 => Construct(0x3e82);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG5 => Construct(0x3e81);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG4 => Construct(0x3e80);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG3 => Construct(0x3e7f);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_FG2 => Construct(0x3e7e);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PlayerGivesGift01 => Construct(0x7b66);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PlayerGivesGift02 => Construct(0x7b67);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PlayerGivesGift03 => Construct(0x7b68);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PlayerGivesGift04 => Construct(0x7b69);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PlayerGivesGift05 => Construct(0x7b6a);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PlayerGivesGift06 => Construct(0x7b6b);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_PlayerGivesGift07 => Construct(0x7b6c);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_GiftThanks => Construct(0x7b6d);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_NoGift1 => Construct(0x7b6e);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_ArrogantSolitude => Construct(0x891c);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_ArrogantWindhelm => Construct(0x891d);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_ArrogantMarkarth => Construct(0x891e);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_ArrogantRiften => Construct(0x891f);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_ArrogantWhiterun => Construct(0x8920);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_ArrogantBYOH => Construct(0x8921);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NeutralSolitude => Construct(0x8922);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NeutralWindhelm => Construct(0x8923);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NeutralMarkarth => Construct(0x8924);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NeutralRiften => Construct(0x8925);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NeutralWhiterun => Construct(0x8926);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NeutralBYOH => Construct(0x8927);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NordSolitude => Construct(0x8928);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NordWindhelm => Construct(0x8929);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NordMarkarth => Construct(0x892a);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NordRiften => Construct(0x892b);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NordWhiterun => Construct(0x892c);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_NordBYOH => Construct(0x892d);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_OrcSolitude => Construct(0x892e);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_OrcWindhelm => Construct(0x892f);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_OrcMarkarth => Construct(0x8930);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_OrcRiften => Construct(0x8931);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_OrcWhiterun => Construct(0x8932);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_HowreKids_OrcBYOH => Construct(0x8933);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_KeepPet3 => Construct(0x13ee5);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_KeepPet4 => Construct(0x13ee6);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_KeepPet2 => Construct(0x13ee7);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_KeepPet1 => Construct(0x13ee8);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoption_Greet1 => Construct(0x3eca);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Intro_GirlBoth => Construct(0x3e43);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Intro_GirlMotherOnly => Construct(0x3e44);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Intro_GirlFatherOnly => Construct(0x3e45);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Intro_BoyBoth => Construct(0x3e46);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Intro_BoyFatherOnly => Construct(0x3e47);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Intro_BoyMotherOnly => Construct(0x3e48);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_AdoptHaveHouse => Construct(0x3e49);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_AskConfirm => Construct(0x3e4a);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_RejectedGirl => Construct(0x3e4b);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_RejectedBoy => Construct(0x3e4c);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Adopt_MomDaughter => Construct(0x3e4d);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Adopt_DadDaughter => Construct(0x3e4e);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Adopt_MomSon => Construct(0x997);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptable_Adopt_DadSon => Construct(0x998);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptableOrphanage_OccupationOdd => Construct(0x3e19);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptableOrphanage_OccupationReject => Construct(0x3e1a);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptableOrphanage_MmHmm => Construct(0x3e1b);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptableOrphanage_VeryWell => Construct(0x3e1c);
            public static FormLink<IDialogResponsesGetter> RelationshipAdoptableOrphanage_NoHome => Construct(0x3e1d);
            public static FormLink<IDialogResponsesGetter> BYOHRelationshipAdoptableUrchins_SofieReject => Construct(0x3dbd);
            public static FormLink<IDialogResponsesGetter> BYOHRelationshipAdoptableUrchins_SofieBuy => Construct(0x3dbe);
            public static FormLink<IDialogResponsesGetter> BYOHRelationshipAdoptableUrchins_SofieParents => Construct(0x3dbf);
            public static FormLink<IDialogResponsesGetter> BYOHRelationshipAdoptableUrchins_BlaiseStory => Construct(0x3dc0);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardAccept => Construct(0x7023);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardSeeToItAtOnce => Construct(0x7024);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardPutSuppliesInChest => Construct(0xcd2e);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardWhereToBuySuppliesFalkreath => Construct(0xcd2f);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardWhereToBuySuppliesHjaalmarch => Construct(0xcd30);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardWhereToBuySuppliesPale => Construct(0xcd31);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardPurchaseCow => Construct(0x7025);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBardOfCourseMale => Construct(0x18dd0);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBardOfCourseFemale => Construct(0x18dd1);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBardRehireBlocking => Construct(0x195c2);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardFurnishingsBuy => Construct(0xb0b1);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardFurnishingsNoGold => Construct(0xb0b2);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardPurchaseHorseNeedStable => Construct(0xf9a6);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardPurchaseCowNeedPen => Construct(0xf9a5);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardHireCarriage => Construct(0x7026);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardHireBard => Construct(0x18dcf);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardPurchaseHorse => Construct(0x7a8b);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardUpgrade => Construct(0x823c);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardBuyMaterialsShared => Construct(0x94f9);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardIsThereAnythingElse => Construct(0x94fa);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardVeryGoodSir => Construct(0x94fb);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardVeryGoodMaam => Construct(0x94fc);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardShortOfGold => Construct(0x94fd);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBuyLumberIntro => Construct(0x9b81);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBuyLumberNoMoney => Construct(0x9b82);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBuyLumberBuy => Construct(0x9b83);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBuyLumberNeverMind => Construct(0x9b84);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBuyLumberSureThingFriend => Construct(0x9b85);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBuyLumberSureThingDeliver => Construct(0x9b86);
            public static FormLink<IDialogResponsesGetter> BYOHHouseBuyLumberNotFriend => Construct(0x9b87);
            public static FormLink<IDialogResponsesGetter> BYOHHouseStewardFurnishingsIntro => Construct(0xb0b0);
        }
    }
}
