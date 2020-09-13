namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Update
    {
        public static class Message
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey PetFramework_PetMaxReachedMessage => ModKey.MakeFormKey(0x2f2b);
            public static FormKey PetFramework_PetDismissMessage => ModKey.MakeFormKey(0x2f26);
            public static FormKey HelpMods => ModKey.MakeFormKey(0x2ecb);
            public static FormKey HelpLegendary => ModKey.MakeFormKey(0x9d7);
            public static FormKey HelpKinectShouts => ModKey.MakeFormKey(0x94c);
            public static FormKey HelpKinect => ModKey.MakeFormKey(0x94b);
        }
    }
}
