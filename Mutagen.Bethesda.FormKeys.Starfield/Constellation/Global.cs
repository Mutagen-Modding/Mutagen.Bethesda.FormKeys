// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Starfield;

public static partial class Constellation
{
    public static partial class Global
    {
        private static FormLink<IGlobalGetter> Construct(uint id) => new FormLink<IGlobalGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IGlobalGetter> ConstellationDLC => Construct(0x1);
        public static FormLink<IGlobalGetter> ConstellationTestGlobal => Construct(0x41);
    }
}
