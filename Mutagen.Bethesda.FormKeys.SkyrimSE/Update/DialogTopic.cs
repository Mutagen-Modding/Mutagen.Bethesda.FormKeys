using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class DialogTopic
        {
            private static FormLink<IDialogTopicGetter> Construct(uint id) => new FormLink<IDialogTopicGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IDialogTopicGetter> PetFramework_BranchWaitResumeTopic => Construct(0x2eea);
            public static FormLink<IDialogTopicGetter> PetFramework_BranchHomeCurrLocTopic => Construct(0x2eeb);
            public static FormLink<IDialogTopicGetter> PetFramework_InventoryTopic => Construct(0x2eec);
            public static FormLink<IDialogTopicGetter> PetFramework_BranchWaitTopic => Construct(0x2eed);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetHjerim => Construct(0x2eee);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetWindstad => Construct(0x2eef);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetVilendral => Construct(0x2ef0);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetDLC2Severin => Construct(0x2ef1);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetProudspire => Construct(0x2ef2);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetLakeview => Construct(0x2ef3);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetHoneyside => Construct(0x2ef4);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetHeljarchen => Construct(0x2ef5);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetBreezhome => Construct(0x2ef6);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetFalkreath => Construct(0x2ef7);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetDawnstar => Construct(0x2ef8);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetMarkarth => Construct(0x2ef9);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetWinterhold => Construct(0x2efa);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetSolitude => Construct(0x2efb);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetRiften => Construct(0x2efc);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetWindhelm => Construct(0x2efd);
            public static FormLink<IDialogTopicGetter> PetFramework_SendPetWhiterun => Construct(0x2efe);
            public static FormLink<IDialogTopicGetter> PetFramework_BranchDismiss_HomeTopic => Construct(0x2eff);
            public static FormLink<IDialogTopicGetter> PetFramework_BranchDismiss_HoldTopic => Construct(0x2f00);
            public static FormLink<IDialogTopicGetter> PetFramework_BranchRecruitTopic => Construct(0x2f01);
        }
    }
}
