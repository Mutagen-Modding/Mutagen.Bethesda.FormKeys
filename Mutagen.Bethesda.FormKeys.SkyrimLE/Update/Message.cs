using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Update
    {
        public static class Message
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Update.esm");
            private static FormLink<IMessageGetter> Construct(uint id) => new FormLink<IMessageGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IMessageGetter> HelpLegendary => Construct(0x9d7);
            public static FormLink<IMessageGetter> HelpKinectShouts => Construct(0x94c);
            public static FormLink<IMessageGetter> HelpKinect => Construct(0x94b);
        }
    }
}
