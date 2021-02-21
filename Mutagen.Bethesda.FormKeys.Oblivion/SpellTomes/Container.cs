using Mutagen.Bethesda.Oblivion;

namespace Mutagen.Bethesda.FormKeys.Oblivion
{
    public static partial class SpellTomes
    {
        public static class Container
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("DLCSpellTomes.esp");
            private static FormLink<IContainerGetter> Construct(uint id) => new FormLink<IContainerGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IContainerGetter> TestQASpellTomes => Construct(0x4fa3);
        }
    }
}
