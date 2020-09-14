namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Enchantment
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey FrostcragEnAppRingEnch => ModKey.MakeFormKey(0x5e37);
        }
    }
}
