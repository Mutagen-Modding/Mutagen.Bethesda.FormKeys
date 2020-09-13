namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class TalkingActivator
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            public static FormKey DLC2DamphallTalkingActivator => ModKey.MakeFormKey(0x37542);
            public static FormKey DLC2MQ05HermaeusMora => ModKey.MakeFormKey(0x1c0ab);
        }
    }
}
