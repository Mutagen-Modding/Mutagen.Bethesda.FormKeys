using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class AddonNode
        {
            private static FormLink<IAddonNodeGetter> Construct(uint id) => new FormLink<IAddonNodeGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IAddonNodeGetter> AshMps => Construct(0x27bf8);
        }
    }
}
