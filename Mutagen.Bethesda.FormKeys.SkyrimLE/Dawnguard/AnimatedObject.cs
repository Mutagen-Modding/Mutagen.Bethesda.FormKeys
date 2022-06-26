// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class Dawnguard
{
    public static class AnimatedObject
    {
        private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAnimatedObjectGetter> AnimObjectWoodScrap => Construct(0x13795);
        public static FormLink<IAnimatedObjectGetter> AnimObjectDrawBlade => Construct(0x13794);
        public static FormLink<IAnimatedObjectGetter> AnimObjectVampireMeat => Construct(0x11e1e);
        public static FormLink<IAnimatedObjectGetter> AnimObjectSilverPitcher => Construct(0xa255);
    }
}
