namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class TalkingActivator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dawnguard.esm");
            public static FormKey DLC01VampireThrallFeedTA02 => ModKey.MakeFormKey(0x11dfc);
            public static FormKey DLC01VampireThrallFeedTA01 => ModKey.MakeFormKey(0x11dfb);
            public static FormKey DLC1LD_KatriaTalkingActivator => ModKey.MakeFormKey(0xcfae);
        }
    }
}
