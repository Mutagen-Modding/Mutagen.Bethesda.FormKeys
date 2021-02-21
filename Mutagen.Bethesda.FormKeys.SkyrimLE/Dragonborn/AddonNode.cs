using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE
{
    public static partial class Dragonborn
    {
        public static class AddonNode
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IAddonNodeGetter> Construct(uint id) => new FormLink<IAddonNodeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAddonNodeGetter> AshMps => Construct(0x27bf8);
        }
    }
}
