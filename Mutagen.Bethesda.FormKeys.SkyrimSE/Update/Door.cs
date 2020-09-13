namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Door
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey SDoorManholeCoverInvisible => ModKey.MakeFormKey(0x308b);
            public static FormKey ccEEJSSE003_RiftenRWDoorLoad01 => ModKey.MakeFormKey(0x2fca);
            public static FormKey ccEEJSSE003_RiftenRWDoorJail01 => ModKey.MakeFormKey(0x2fc8);
            public static FormKey ccBGSSSE043_FarmBTrapdoor01 => ModKey.MakeFormKey(0x2fc6);
            public static FormKey ccBGSSSE043_FarmBTrapdoor02 => ModKey.MakeFormKey(0x2fc5);
            public static FormKey CreationClubPlaceHolderDoor => ModKey.MakeFormKey(0x2f3b);
        }
    }
}
