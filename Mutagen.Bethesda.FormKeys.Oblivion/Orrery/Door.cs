// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Oblivion;

public static partial class Orrery
{
    public static class Door
    {
        private static FormLink<IDoorGetter> Construct(uint id) => new FormLink<IDoorGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IDoorGetter> ArchitectureOrreryDoor => Construct(0x11eb5a);
    }
}
