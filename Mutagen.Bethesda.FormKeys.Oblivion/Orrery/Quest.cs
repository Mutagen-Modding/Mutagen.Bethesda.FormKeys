namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Orrery
    {
        public static class Quest
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCOrrery.esp");
            public static FormKey DLCOrrery => ModKey.MakeFormKey(0x11b9fb);
        }
    }
}
