// Autogenerated by https://github.com/Mutagen-Modding/Mutagen.Bethesda.FormKeys

using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.Fallout4;

public static partial class Coast
{
    public static class AnimatedObject
    {
        private static FormLink<IAnimatedObjectGetter> Construct(uint id) => new FormLink<IAnimatedObjectGetter>(ModKey.MakeFormKey(id));
        public static FormLink<IAnimatedObjectGetter> FogCrawlerAttack2AnimObject => Construct(0x4dc03);
        public static FormLink<IAnimatedObjectGetter> FogCrawlerAttack3AnimObject => Construct(0x4dc02);
        public static FormLink<IAnimatedObjectGetter> AnimObjectFishFarm_Basket => Construct(0x23b31);
        public static FormLink<IAnimatedObjectGetter> AnimObjectFish => Construct(0xc6aa);
    }
}
