// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Fallout4
{
    public static class Tree
    {
        private static FormLink<ITreeGetter> Construct(uint id) => new FormLink<ITreeGetter>(ModKey.MakeFormKey(id));
        public static FormLink<ITreeGetter> TestCloth02 => Construct(0x4d13);
    }
}