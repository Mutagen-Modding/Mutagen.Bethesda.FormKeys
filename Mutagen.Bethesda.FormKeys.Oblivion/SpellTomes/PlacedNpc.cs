namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class PlacedNpc
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCSpellTomes.esp");
            public static FormKey DLCTomeConjurerREF => ModKey.MakeFormKey(0x45d6);
        }
    }
}
