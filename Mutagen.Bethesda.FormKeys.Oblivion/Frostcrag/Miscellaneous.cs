// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Frostcrag
{
    public static class Miscellaneous
    {
        private static FormLink<IMiscellaneousGetter> Construct(uint id) => new FormLink<IMiscellaneousGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMiscellaneousGetter> FrostcragMagetallowCandle => Construct(0xd44);
    }
}
