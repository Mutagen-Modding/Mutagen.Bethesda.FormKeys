using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class TalkingActivator
        {
            private static FormLink<ITalkingActivatorGetter> Construct(uint id) => new FormLink<ITalkingActivatorGetter>(ModKey.MakeFormKey(id));
            public static FormLink<ITalkingActivatorGetter> DLC2DamphallTalkingActivator => Construct(0x37542);
            public static FormLink<ITalkingActivatorGetter> DLC2MQ05HermaeusMora => Construct(0x1c0ab);
        }
    }
}
