namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Race
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ccBGSSSE036_BoneWolfCompanionRace => ModKey.MakeFormKey(0x2f93);
            public static FormKey ccBGSSSE035_NixHoundCompanionRace => ModKey.MakeFormKey(0x2f74);
        }
    }
}
