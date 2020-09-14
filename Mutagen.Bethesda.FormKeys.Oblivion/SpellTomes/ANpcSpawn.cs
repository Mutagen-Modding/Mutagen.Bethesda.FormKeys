namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class ANpcSpawn
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCSpellTomes.esp");
            public static FormKey DLCTomeConjurer => ModKey.MakeFormKey(0x40ee);
        }
    }
}
