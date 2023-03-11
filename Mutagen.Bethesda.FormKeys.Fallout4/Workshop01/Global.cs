// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop01
{
    public static class Global
    {
        private static FormLink<IGlobalGetter> Construct(uint id) => new FormLink<IGlobalGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IGlobalGetter> DLCworkshop01Loaded => Construct(0x800);
    }
}