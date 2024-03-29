// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class MovableStatic
    {
        private static FormLink<IMovableStaticGetter> Construct(uint id) => new FormLink<IMovableStaticGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IMovableStaticGetter> DLC06SkeletonClothedVaultsuit88 => Construct(0x53dc);
    }
}
