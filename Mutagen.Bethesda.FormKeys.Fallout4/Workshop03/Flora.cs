// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Workshop03
{
    public static partial class Flora
    {
        private static FormLink<IFloraGetter> Construct(uint id) => new FormLink<IFloraGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IFloraGetter> DLC06PipBoyCrate => Construct(0x4bd2);
    }
}
