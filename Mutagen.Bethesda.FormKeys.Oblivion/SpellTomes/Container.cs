namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCSpellTomes.esp");
            public static FormKey TestQASpellTomes => ModKey.MakeFormKey(0x4fa3);
        }
    }
}
