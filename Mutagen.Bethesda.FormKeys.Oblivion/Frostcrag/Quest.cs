namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class Frostcrag
    {
        public static class Quest
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCFrostcrag.esp");
            public static FormKey DLCFrostcragSpire => ModKey.MakeFormKey(0xd53);
        }
    }
}
