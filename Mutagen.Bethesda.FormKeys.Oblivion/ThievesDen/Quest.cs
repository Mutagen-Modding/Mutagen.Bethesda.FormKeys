namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class ThievesDen
    {
        public static class Quest
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCThievesDen.esp");
            public static FormKey DLC06ThievesDen => ModKey.MakeFormKey(0x3e84);
        }
    }
}
