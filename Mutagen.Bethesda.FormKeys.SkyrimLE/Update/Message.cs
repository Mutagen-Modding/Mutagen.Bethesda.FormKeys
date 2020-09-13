namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Message
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            public static FormKey HelpLegendary => ModKey.MakeFormKey(0x9d7);
            public static FormKey HelpKinectShouts => ModKey.MakeFormKey(0x94c);
            public static FormKey HelpKinect => ModKey.MakeFormKey(0x94b);
        }
    }
}
