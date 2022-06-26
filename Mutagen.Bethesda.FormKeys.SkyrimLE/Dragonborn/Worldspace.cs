// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dragonborn
{
    public static class Worldspace
    {
        private static FormLink<IWorldspaceGetter> Construct(uint id) => new FormLink<IWorldspaceGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IWorldspaceGetter> DLC2SolstheimWorld => Construct(0x800);
        public static FormLink<IWorldspaceGetter> DLC2ApocryphaWorld => Construct(0x1c0b2);
    }
}
