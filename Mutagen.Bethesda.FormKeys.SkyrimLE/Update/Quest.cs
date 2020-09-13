namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Quest
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey Patch1_9_UpdateQuest => ModKey.MakeFormKey(0x9a3);
            public static FormKey Patch1_6_UpdateQuest => ModKey.MakeFormKey(0x97f);
            public static FormKey Patch1_5_UpdateQuest => ModKey.MakeFormKey(0x83f);
            public static FormKey Patch1_4_UpdateQuest => ModKey.MakeFormKey(0x803);
        }
    }
}
