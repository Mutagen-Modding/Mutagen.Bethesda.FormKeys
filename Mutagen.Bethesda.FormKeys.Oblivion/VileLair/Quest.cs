namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class VileLair
    {
        public static class Quest
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCVileLair.esp");
            public static FormKey DLCDeepscorn => ModKey.MakeFormKey(0x41c4);
        }
    }
}
