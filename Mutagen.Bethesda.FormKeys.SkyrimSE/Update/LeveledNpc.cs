namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class LeveledNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey ccBGSSSE003_LCharUndeadList => ModKey.MakeFormKey(0x3024);
        }
    }
}
