using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Dragonborn
    {
        public static class Worldspace
        {
            private readonly static ModKey ModKey = ModKey.FromNameAndExtension("Dragonborn.esm");
            private static FormLink<IWorldspaceGetter> Construct(uint id) => new FormLink<IWorldspaceGetter>(ModKey.MakeFormKey(id));
            public static FormLink<IWorldspaceGetter> DLC2SolstheimWorld => Construct(0x800);
            public static FormLink<IWorldspaceGetter> DLC2ApocryphaWorld => Construct(0x1c0b2);
        }
    }
}
