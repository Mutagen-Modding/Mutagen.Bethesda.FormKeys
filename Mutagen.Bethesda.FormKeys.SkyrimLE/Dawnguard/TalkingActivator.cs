using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dawnguard
    {
        public static class TalkingActivator
        {
            private static FormLink<ITalkingActivatorGetter> Construct(uint id) => new FormLink<ITalkingActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITalkingActivatorGetter> DLC01VampireThrallFeedTA02 => Construct(0x11dfc);
            public static FormLink<ITalkingActivatorGetter> DLC01VampireThrallFeedTA01 => Construct(0x11dfb);
            public static FormLink<ITalkingActivatorGetter> DLC1LD_KatriaTalkingActivator => Construct(0xcfae);
        }
    }
}
