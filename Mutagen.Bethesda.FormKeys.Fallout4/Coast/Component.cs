// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static class Component
    {
        private static FormLink<IComponentGetter> Construct(uint id) => new FormLink<IComponentGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IComponentGetter> DLC03VRComponent02 => Construct(0x35c3);
        public static FormLink<IComponentGetter> DLC03VRComponent01 => Construct(0x35c2);
    }
}
