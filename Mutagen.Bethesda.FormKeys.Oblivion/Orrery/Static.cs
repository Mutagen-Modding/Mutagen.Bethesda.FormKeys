// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Orrery
{
    public static partial class Static
    {
        private static FormLink<IStaticGetter> Construct(uint id) => new FormLink<IStaticGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IStaticGetter> ArchitectureOrreryDoorFrame => Construct(0x11eb57);
    }
}
