namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Region
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey DLCFrostCragRegion => ModKey.MakeFormKey(0x14e9f);
        }
    }
}
