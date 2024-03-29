// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimLE;

public static partial class HearthFires
{
    public static partial class AnimatedObject
    {
        private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAnimatedObjectGetter> AnimObjectDoll => Construct(0x16a4f);
        public static FormLink<IAnimatedObjectGetter> AnimObjectWoodScrap => Construct(0x14352);
        public static FormLink<IAnimatedObjectGetter> AnimObjectDrawBlade => Construct(0xa256);
        public static FormLink<IAnimatedObjectGetter> AnimObjectBreadPeel => Construct(0x2843);
        public static FormLink<IAnimatedObjectGetter> AnimObjectDumplingRight => Construct(0x2842);
        public static FormLink<IAnimatedObjectGetter> AnimObjectDumplingLeft => Construct(0x2841);
    }
}
