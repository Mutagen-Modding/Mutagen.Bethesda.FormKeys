using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Quest
        {
            private static FormLink<IQuestGetter> Construct(uint id) => new FormLink<IQuestGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IQuestGetter> PetFramework_ParentQuest => Construct(0x2f1c);
            public static FormLink<IQuestGetter> Patch1_9_UpdateQuest => Construct(0x9a3);
            public static FormLink<IQuestGetter> Patch1_6_UpdateQuest => Construct(0x97f);
            public static FormLink<IQuestGetter> Patch1_5_UpdateQuest => Construct(0x83f);
            public static FormLink<IQuestGetter> Patch1_4_UpdateQuest => Construct(0x803);
        }
    }
}
