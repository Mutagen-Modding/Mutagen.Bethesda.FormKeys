namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class AIPackage
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCSpellTomes.esp");
            public static FormKey DLCSpellTomesFindPlayer => ModKey.MakeFormKey(0x45d5);
        }
    }
}
